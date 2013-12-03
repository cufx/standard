using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom;
using System.IO;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;
using Newtonsoft.Json;
using FizzWare.NBuilder;
using System.Collections;
using Newtonsoft.Json.Converters;

namespace CUFX.Generator
{
	public class JsonGenerator
	{
		public static bool GenerateJsonFromCs(string sourceCsFile, string jsonFile)
		{
			CSharpCodeProvider provider = new CSharpCodeProvider();

			// Build the parameters for source compilation.
			CompilerParameters cp = new CompilerParameters();

			// Add an assembly reference.
			cp.ReferencedAssemblies.Add("System.dll");
			cp.ReferencedAssemblies.Add("System.Xml.dll");

			// Generate an executable instead of 
			// a class library.
			cp.GenerateExecutable = false;
            
			// Set the assembly file name to generate.
			//cp.OutputAssembly = dllFile;

			// Save the assembly as a physical file.
			cp.GenerateInMemory = false;

			// Invoke compilation.
			CompilerResults cr = provider.CompileAssemblyFromFile(cp, sourceCsFile);
             
			Assembly assembly = cr.CompiledAssembly;

			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter outJsonFile = new StreamWriter(jsonFile))
			{
				foreach (Type type in assembly.GetTypes())
				{
					try
					{
						if (type.IsAbstract)
						{
							Type subclass = GetFirstSubclass(type, assembly);

                            // Cannot build JSON objects for Abstract classes that have no concrete subclasses
							if (subclass == null)
							{
								Console.WriteLine("Could not create abstract type [{0}]", type.FullName);
								continue;
							}

                            // Builds the JSON version of the CS Object (or null if unable to build object)
							var subClassObj = BuildSingleObject(assembly, subclass.FullName);

                            // Append the JSON object to the .json file
							if (subClassObj != null)
							{
								string jsonText = JsonConvert.SerializeObject(subClassObj, Newtonsoft.Json.Formatting.Indented, new IsoDateTimeConverter());
								outJsonFile.WriteLine("\n" + type.FullName);
								outJsonFile.Write(jsonText);
							}
						}
						else
                        {
                            // Builds the JSON version of the CS Object (or null if unable to build object)
							var obj = BuildSingleObject(assembly, type.FullName);
                            
                            // Append the JSON object to the .json file
							if (obj != null)
							{
								string jsonText = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented, new IsoDateTimeConverter());
								outJsonFile.WriteLine("\n" + type.FullName);
								outJsonFile.Write(jsonText);
							}
						}
					}
					catch (Exception ex)
					{
						Console.WriteLine("Could not create object: [{0}] Message: [{1}]", type.FullName, ex.Message);
					}
				}
			}

			if (cr.Errors.Count > 0)
			{
				// Display compilation errors.
				Console.WriteLine("Errors building {0} into {1}",
					 sourceCsFile, cr.PathToAssembly);
				foreach (CompilerError ce in cr.Errors)
				{
					Console.WriteLine("  {0}", ce.ToString());
					Console.WriteLine();
				}
			}

			// Return the results of compilation. 
			if (cr.Errors.Count > 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public static Type GetFirstSubclass(Type abstractBaseClass, Assembly assembly)
		{
			Type[] types = assembly.GetTypes();

			foreach (Type type in types)
			{

				 if (type.IsSubclassOf(abstractBaseClass))
					return type;
			}

			Console.WriteLine("No derived classes found for abstract base class [{0}]", abstractBaseClass.FullName);
			return null;
		}

        // Builds each object within the file. Returns null if the object can't/shouldn't be built
        // such as in the case when an Abstract object has no subclasses and therefore nothing to build.
		public static object BuildSingleObject(Assembly assembly, string type)
		{
			Assembly systemAssembly = Assembly.Load("mscorlib");

			var entityType = assembly.GetType(type);

			if (entityType == null)
			{
				// System type?
				entityType = systemAssembly.GetType(type);
			}

			if (entityType == null)
			{
				Console.WriteLine("Could not find type for: " + type);
				return null;
			}
      
            // Can't create JSON object for Abstract object with no concrete subclasses
            if (entityType != null && entityType.IsAbstract)
			{
				Console.WriteLine("Ignoring abstract type: " + type+". No concrete objects to build.");
                return null;
			}
            
			var builderClassType = typeof(Builder<>);

			Type[] args = { entityType };

			var genericBuilderType = builderClassType.MakeGenericType(args);

			var builder = Activator.CreateInstance(genericBuilderType);

			var createNewMethodInfo = builder.GetType().GetMethod("CreateNew");

			var objectBuilder = createNewMethodInfo.Invoke(builder, null);

			var buildMethodInfo = objectBuilder.GetType().GetMethod("Build");

			var result = buildMethodInfo.Invoke(objectBuilder, null);
			
			foreach (PropertyInfo p in result.GetType().GetProperties())
			{
				if (p.PropertyType.IsArray)
				{
					//var objectBuilderList = createListMethodInfo.Invoke(builder, parametersArray);
					//var buildListMethodInfo = objectBuilderList.GetType().GetMethod("Build");
					string typeName = p.PropertyType.FullName.Trim(new char[] { '[', ']' });
					// Is this a system type or custom type?
					Type systemType = systemAssembly.GetType(typeName);
					Type customType = assembly.GetType(typeName);
					Type typeToCreate = null;
					Assembly assemblyToUse = null;

					if (customType != null && !customType.IsAbstract)
					{
						typeToCreate = customType;
						assemblyToUse = assembly;
					}
					else if (systemType != null)
					{
						typeToCreate = systemType;
						assemblyToUse = systemAssembly;
					}
					else
					{
						Console.WriteLine("Could not find type [{0}] in system or custom assemblies.  Parent type [{1}]", typeName, type);
					}
				
					// Is this an array of strings?
					if (typeName == "System.String")
					{
						List<string> strings = new List<string>();
						for (int i = 0; i < 5; i++)
							strings.Add("String" + i);

						p.SetValue(result, strings.ToArray(), null);
					}
					else if (typeToCreate != null && assemblyToUse != null)
					{
						object[] list = BuildList(assemblyToUse, typeName);
						var arr = Array.CreateInstance(typeToCreate, 5);
						Array.Copy(list.ToArray(), arr, 5);

						p.SetValue(result, arr, null);
					}
				}
				else if (p.GetValue(result, null) == null)
				{
					// Attempt to create an object
					try
					{
						object o = BuildSingleObject(assembly, p.PropertyType.FullName);
						if (o != null)
						{
							p.SetValue(result, o, null);
						}
						else
							Console.WriteLine("Null value for property: " + p.PropertyType.FullName);
					}
					catch (Exception ex)
					{
						throw ex;
					}
				}
			}
			return result;
		}

		public static object[] BuildList(Assembly assembly, string type)
		{
			List<object> list = new List<object>();
			for (int i = 0; i < 5; i++)
			{
				object o = BuildSingleObject(assembly, type);
				list.Add(o);
			}
			return list.ToArray();			
		}
	}
}

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

namespace ExampleGenerators
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
							Console.WriteLine("Could not create abstract type [{0}]", type.FullName);
							continue;
						}

						var obj = BuildSingleObject(assembly, type.FullName);

						if (obj != null)
						{
							string jsonText = JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented);
							outJsonFile.WriteLine("\n" + type.FullName);
							outJsonFile.Write(jsonText);
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
			else
			{
				Console.WriteLine("Source {0} built into {1} successfully.",
					 sourceCsFile, cr.PathToAssembly);
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
		public static object BuildSingleObject(Assembly assembly, string type)
		{
			var entityType = assembly.GetType(type);

			//The interesting (I hope) part is starting (yeah)
			//get the Builder<T> type
			var builderClassType = typeof(Builder<>);

			//create generic argument for Builder<T> will take the type of our entity (always an array)
			Type[] args = { entityType };

			//pass generic arguments to Builder<T>. Which becomes Builder<entityType>
			var genericBuilderType = builderClassType.MakeGenericType(args);

			//create a new instance of Builder<entityType>
			var builder = Activator.CreateInstance(genericBuilderType);

			//retrieve the "CreateNew" method, which belongs to Builder<T> class
			var createNewMethodInfo = builder.GetType().GetMethod("CreateNew");

			//invoke "CreateNew" from our builder instance which gives us an ObjectBuilder<T>, so now an ObjectBuilder<entityType> (well as an ISingleObjectBuilder<entityType>, but... who minds ;))
			var objectBuilder = createNewMethodInfo.Invoke(builder, null);

			//retrieve the "Build" method, which belongs to ObjectBuilder<T> class
			var buildMethodInfo = objectBuilder.GetType().GetMethod("Build");

			//finally, invoke "Build" from our ObjectBuilder<entityType> instance, which will give us... our entity !
			var result = buildMethodInfo.Invoke(objectBuilder, null);

			//it would be sad to return nothing after all these efforts, no ??

			Assembly systemAssembly = Assembly.Load("mscorlib");
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
						Console.WriteLine("Could not find type [{0}] in system or custom assemblies", typeName);
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
			}
			return result;
		}

		public static object[] BuildList(Assembly assembly, string type)
		{
			var entityType = assembly.GetType(type);

			if (entityType == null)
			{
				Assembly theAssembly = Assembly.Load("mscorlib");
				entityType = theAssembly.GetType(type);
			}
			var builderClassType = typeof(Builder<>);

			Type[] args = { entityType };

			if (entityType.IsEnum)
			{
				int i = 0;
			}

			//pass generic arguments to Builder<T>. Which becomes Builder<entityType>
			var genericBuilderType = builderClassType.MakeGenericType(args);

			//create a new instance of Builder<entityType>
			var builder = Activator.CreateInstance(genericBuilderType);
			//retrieve the "CreateListOfSize" method, which belongs to Builder<T> class
			var createListMethodInfo = builder.GetType().GetMethod("CreateListOfSize", new Type[] { typeof(int) });

			//invoke "CreateListOfSize" from our builder instance which gives us an ObjectBuilder<T>, so now an ObjectBuilder<entityType> (well as an ISingleObjectBuilder<entityType>, but... who minds ;))
			object[] parametersArray = new object[] { 5 };
			var objectBuilder = createListMethodInfo.Invoke(builder, parametersArray);

			//retrieve the "Build" method, which belongs to ObjectBuilder<T> class
			var buildMethodInfo = objectBuilder.GetType().GetMethod("Build");

			//finally, invoke "Build" from our ObjectBuilder<entityType> instance, which will give us... our entity !
			var results = buildMethodInfo.Invoke(objectBuilder, null);

			List<object> list = new List<object>();
			foreach (object o in (results as IEnumerable))
				list.Add(o);

			return list.ToArray();
		}
	}
}

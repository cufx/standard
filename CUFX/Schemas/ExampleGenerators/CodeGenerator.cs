using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.CodeDom;
using System.IO;
using Microsoft.CSharp;
using Microsoft.VisualBasic;

namespace ExampleGenerators
{
	public static class CodeGenerator
	{
		public static void GenerateCodeFromXsd(string xsdFilePath, string outCsFileName, string outVbFileName)
		{
				using (StreamWriter outCsFile = new StreamWriter(outCsFileName, false))
				using (StreamWriter outVbFile = new StreamWriter(outVbFileName, false))
				{
					try
					{
						CSharpCodeProvider csProvider = new CSharpCodeProvider();
						VBCodeProvider vbProvider = new VBCodeProvider();
						CodeNamespace ns = CreateCodeNamespaceFromXsd(xsdFilePath, "cufxstandards.com");

						csProvider.GenerateCodeFromNamespace(ns, outCsFile, new System.CodeDom.Compiler.CodeGeneratorOptions());
						vbProvider.GenerateCodeFromNamespace(ns, outVbFile, new System.CodeDom.Compiler.CodeGeneratorOptions());
					}
					catch (Exception ex)
					{
						Console.WriteLine("Could not generate example code from the xsd [{0}]. Message: [{1}].  Press any key to continue", xsdFilePath, ex.Message);
						Console.ReadKey();
					}
					outCsFile.Close();
				}
		}

		private static CodeNamespace CreateCodeNamespaceFromXsd(string xsdFile, string targetNamespace)
		{
			// Load the XmlSchema and its collection.
			XmlSchema xsd;
			using (FileStream fs = new FileStream(xsdFile, FileMode.Open))
			{
				xsd = XmlSchema.Read(fs, null);
				xsd.Compile(null);
			}
			XmlSchemas schemas = new XmlSchemas();
			schemas.Add(xsd);
			// Create the importer for these schemas.
			XmlSchemaImporter importer = new XmlSchemaImporter(schemas);
			// System.CodeDom namespace for the XmlCodeExporter to put classes in.
			CodeNamespace ns = new CodeNamespace(targetNamespace);
			XmlCodeExporter exporter = new XmlCodeExporter(ns);
			// Iterate schema top-level elements and export code for each.

			// TODO: Iterate through the XSD and remove any of the abstract
			// properties.  For some reason the code generator will not
			// generate any of the subclasses for abstract base types
			//foreach (XmlSchemaType schemaType in xsd.SchemaTypes.Values)
			//{
			//   XmlSchemaComplexType complexSchemaType = schemaType as XmlSchemaComplexType;
			//   if(complexSchemaType != null)
			//      if(complexSchemaType.IsAbstract)
			//      {
			//         Console.WriteLine(schemaType.Name);
			//      }
			//   Console.WriteLine(schemaType.Name);
			//}

			foreach (XmlSchemaElement element in xsd.Elements.Values)
			{
				// Import the mapping first.
				XmlTypeMapping mapping = importer.ImportTypeMapping(
				  element.QualifiedName);
				// Export the code finally.
				exporter.ExportTypeMapping(mapping);
			}
			return ns;
		}
	}
}

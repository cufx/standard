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
using System.Xml;

namespace CUFX.Generator
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

		public static void GenerateCodeFromXsds(string[] xsdFiles, string outCsFileName)
		{
			using (StreamWriter outCsFile = new StreamWriter(outCsFileName, false))
			{
				try
				{
					CSharpCodeProvider csProvider = new CSharpCodeProvider();
					VBCodeProvider vbProvider = new VBCodeProvider();
					CodeNamespace ns = CreateCodeNamespaceFromXsds(xsdFiles, "cufxstandards.com");

					csProvider.GenerateCodeFromNamespace(ns, outCsFile, new System.CodeDom.Compiler.CodeGeneratorOptions());
				}
				catch (Exception ex)
				{
					Console.WriteLine("Could not generate example code from the xsds. Message: [{0}].  Press any key to continue", ex.Message);
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

		private static CodeNamespace CreateCodeNamespaceFromXsds(string[] xsdFiles, string targetNamespace)
		{
			XmlSchemaSet schemas = new XmlSchemaSet();
			List<XmlQualifiedName> xmlTypes = new List<XmlQualifiedName>();

			// Load the XmlSchema and its collection.			
			foreach (string xsdFile in xsdFiles)
			{
				using (FileStream fs = new FileStream(xsdFile, FileMode.Open))
				{
					XmlSchema xsd;
					xsd = XmlSchema.Read(fs, null);				
					schemas.Add(xsd);

					foreach (XmlSchemaElement element in xsd.Elements.Values)
					{
						if (!xmlTypes.Contains(element.QualifiedName))
							xmlTypes.Add(element.QualifiedName);
					}
				}
			}

			schemas.Compile();

			// Create the importer for these schemas.
			XmlSchemaImporter importer = new XmlSchemaImporter(MoveSchemaSetToXmlSchemas(schemas));

			// System.CodeDom namespace for the XmlCodeExporter to put classes in.
			CodeNamespace ns = new CodeNamespace(targetNamespace);
			XmlCodeExporter exporter = new XmlCodeExporter(ns);
	
			// Iterate schema top-level elements and export code for each.
			foreach (XmlQualifiedName xmlType in xmlTypes)
			{
				// Import the mapping first.
				XmlTypeMapping mapping = importer.ImportTypeMapping(xmlType);

				// Export the code finally.
				exporter.ExportTypeMapping(mapping);
			}
			RemoveAttributes(ns);
			return ns;
		}

		public static XmlSchemas MoveSchemaSetToXmlSchemas(XmlSchemaSet set)
		{
			XmlSchemas schemas = new XmlSchemas();
			XmlSchema[] schemaArray = new XmlSchema[set.Count];
			set.CopyTo(schemaArray, 0); foreach (XmlSchema xsd in schemaArray)
			{
				schemas.Add(xsd);
			}
			return schemas;
		}

		private static void RemoveAttributes(CodeNamespace codeNamespace)
		{
			foreach (CodeTypeDeclaration codeType in codeNamespace.Types)
			{
				CodeAttributeDeclaration xmlTypeAttribute = null;
				foreach (CodeAttributeDeclaration codeAttribute in codeType.CustomAttributes)
				{
					if (codeAttribute.Name == "System.Xml.Serialization.XmlTypeAttribute")
					{
						xmlTypeAttribute = codeAttribute;
					}
				}
				codeType.CustomAttributes.Clear();
				if (xmlTypeAttribute != null)
				{
					codeType.CustomAttributes.Add(xmlTypeAttribute);
				}
			}
		}
	}
}

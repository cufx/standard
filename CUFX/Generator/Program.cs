using System;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using Microsoft.Xml.XMLGen;

namespace CUFX.Generator
{
	class Program
	{
		static void Main(string[] args)
		{
			const string xsltFilePath = "xs3p.xsl";

			// Load XSLT
			XsltSettings settings = new XsltSettings(true, true);
			XslCompiledTransform transformer = new XslCompiledTransform();
			transformer.Load(xsltFilePath, settings, new XmlUrlResolver());

			string schemaProjectDirectory = @"..\..\..\Schemas"; // I hate to hardcode this, is there a better way?

			// Look in the project output directory for all xsd files
			string[] files = Directory.GetFiles(schemaProjectDirectory, "*.xsd");

			// Create the output directories for the generated HTML files, and code example files
			string outputDirectory = Path.Combine(Environment.CurrentDirectory, "Generated HTML Docs");
			if (!Directory.Exists(outputDirectory))
				Directory.CreateDirectory(outputDirectory);

			string exampleDirectory = Path.Combine(Environment.CurrentDirectory, "Generated Examples");
			if (!Directory.Exists(exampleDirectory))
				Directory.CreateDirectory(exampleDirectory);

			// For each XSD file, create the HTML documentation, and examples (.cs, .vb, .xml, json)
			foreach (string xsdFilePath in files)
			{
                //Don't create HTML documentation or XML samples for base schema
                if (xsdFilePath == "..\\..\\..\\Schemas\\Common.xsd" ||
                    xsdFilePath == "..\\..\\..\\Schemas\\ISOCountryCodeType-V2006.xsd" ||
                    xsdFilePath == "..\\..\\..\\Schemas\\ISOCurrencyCodeType.xsd" ||
                    xsdFilePath == "..\\..\\..\\Schemas\\MessageContext.xsd" ||
                    xsdFilePath == "..\\..\\..\\Schemas\\Meta.xsd")
                {
                    continue;
                }


				#region Generate the HTML documentation
				string outHtmlFileName = Path.Combine(outputDirectory, Path.GetFileNameWithoutExtension(xsdFilePath)) + ".html";
				using (StreamWriter outHtmlfile = new StreamWriter(outHtmlFileName))
				{
					string documentTitle = Path.GetFileNameWithoutExtension(xsdFilePath);
					documentTitle = documentTitle.Replace("CUFX_", "");
					documentTitle = documentTitle.Replace("_", " ");

					XsltArgumentList argsList = new XsltArgumentList();
					argsList.AddParam("title", "", documentTitle);
					argsList.AddParam("currentDateTime", "", DateTime.Now.ToString("d"));

					using (XmlTextReader xsdReader = new XmlTextReader(xsdFilePath))
					{
						XPathNavigator nav = new XPathDocument(xsdReader).CreateNavigator();

						try
						{
							transformer.Transform(nav, argsList, outHtmlfile);
						}
						catch (XsltException xsltEx)
						{
							Console.WriteLine("Could not transform the XSD file [{0}]. Message: [{1}] line: [{2}], position: [{3}]", xsdFilePath, xsltEx.Message, xsltEx.LineNumber, xsltEx.LinePosition);
							Console.ReadKey();
						}
						xsdReader.Close();
					}
					outHtmlfile.Close();
				}
				#endregion

				#region Generate the XML examples
				string outXmlFileName = Path.Combine(exampleDirectory, Path.GetFileNameWithoutExtension(xsdFilePath)) + ".xml";
				using (XmlTextWriter outXmlFile = new XmlTextWriter(outXmlFileName, null))
				{
					outXmlFile.Formatting = System.Xml.Formatting.Indented;
					XmlQualifiedName qname = new XmlQualifiedName("AccountList",
														"http://cufxstandards.com/v2/Account.xsd");
					XmlSampleGenerator generator = new XmlSampleGenerator(xsdFilePath, qname);
					generator.WriteXml(outXmlFile);
				}
				#endregion

				//#region Generate the CS and JSON examples
				//string outCsFileName = Path.Combine(exampleDirectory, Path.GetFileNameWithoutExtension(xsdFilePath)) + ".cs";
				//string outVbFileName = Path.Combine(exampleDirectory, Path.GetFileNameWithoutExtension(xsdFilePath)) + ".vb";
				//CodeGenerator.GenerateCodeFromXsd(xsdFilePath, outCsFileName, outVbFileName);

				//string outJsonFileName = Path.Combine(exampleDirectory, Path.GetFileNameWithoutExtension(xsdFilePath)) + ".json";
				//JsonGenerator.GenerateJsonFromCs(outCsFileName, outJsonFileName);
				//#endregion
			}

			// Generate one .cs for all the types and place it in the Schemas project
			string cufxCsFile = Path.Combine(schemaProjectDirectory, "CUFX.cs");
			CodeGenerator.GenerateCodeFromXsds(files, cufxCsFile);
			JsonGenerator.GenerateJsonFromCs(cufxCsFile, Path.GetFileNameWithoutExtension(cufxCsFile) + ".json");

			Console.WriteLine("Press any key to close");
			Console.ReadLine();
		}
	}
}

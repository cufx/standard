using System;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using Microsoft.Xml.XMLGen;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CUFX.Generator
{
	class Program
	{
        const string OutputFOlders = "JSON,WCF,XML,HTML";
        public static string sGeneratedPath = string.Empty;
        private static bool CreateOutputFolders()
        {
            bool bDone = false;
            try
            {
                sGeneratedPath = System.Environment.CurrentDirectory;
                sGeneratedPath = sGeneratedPath + "\\GeneratedFiles";

                //Check for Parent GeneratedFiles Folder, create if not present.
                if (Directory.Exists(sGeneratedPath))
                {
                    Console.WriteLine(sGeneratedPath + " Path Exists");
                }
                else
                {
                    System.IO.Directory.CreateDirectory(sGeneratedPath);
                    Console.WriteLine(sGeneratedPath + " Created OK");
                }

                //No the individual folders for file types
                string[] arOutputFolders = OutputFOlders.Split(',');

                foreach (string word in arOutputFolders)
                {
                    if (Directory.Exists(sGeneratedPath + "\\" + word))
                    {
                        Console.WriteLine(sGeneratedPath + "\\" + word + " Path Exists");
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(sGeneratedPath + "\\" + word);
                        Console.WriteLine(sGeneratedPath + "\\" + word + " Created OK");
                    }  
                }
                bDone = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Creating Output Folders: " + ex.ToString());
                Console.ReadKey();
            }

            return bDone;
        }

		static void Main(string[] args)
		{
            

            if (CreateOutputFolders() == false)
            {
                Console.ReadKey();
                Environment.Exit(99);
            }
			const string xsltFilePath = "xs3p.xsl";

			// Load XSLT
			XsltSettings settings = new XsltSettings(true, true);
			XslCompiledTransform transformer = new XslCompiledTransform();
			transformer.Load(xsltFilePath, settings, new XmlUrlResolver());

            string schemaProjectDirectory = System.Environment.CurrentDirectory + "\\XSD"; 

			// Look in the project output directory for all xsd files
			string[] files = Directory.GetFiles(schemaProjectDirectory, "*.xsd");

			// Create the output directories for the generated HTML files, and code example files
            //string outputDirectory = Path.Combine(Environment.CurrentDirectory, "Generated HTML Docs");
            //if (!Directory.Exists(outputDirectory))
            //    Directory.CreateDirectory(outputDirectory);

            //string exampleDirectory = Path.Combine(Environment.CurrentDirectory, "Generated Examples");
            //if (!Directory.Exists(exampleDirectory))
            //    Directory.CreateDirectory(exampleDirectory);

			// For each XSD file, create the HTML documentation, and examples (.cs, .vb, .xml, json)
            Console.WriteLine("Generating Files.....");
			foreach (string xsdFilePath in files)
			{
                //Don't create HTML documentation or XML samples for base schema
                if (xsdFilePath == schemaProjectDirectory + "\\Common.xsd" ||
                    xsdFilePath == schemaProjectDirectory + "\\ISOCountryCodeType-V2006.xsd" ||
                    xsdFilePath == schemaProjectDirectory + "\\ISOCurrencyCodeType.xsd" ||
                    xsdFilePath == schemaProjectDirectory + "\\MessageContext.xsd" ||
                    xsdFilePath == schemaProjectDirectory + "\\Meta.xsd")
                {
                    continue;
                }


				#region Generate the HTML documentation
                string outHtmlFileName = Path.Combine(sGeneratedPath + "\\HTML\\", Path.GetFileNameWithoutExtension(xsdFilePath)) + ".html";
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
                    //Console.WriteLine("HTML Files Created");
				}
				#endregion

				#region Generate the XML examples
                string outXmlFileName = Path.Combine(sGeneratedPath + "\\XML\\", Path.GetFileNameWithoutExtension(xsdFilePath)) + ".xml";
				using (XmlTextWriter outXmlFile = new XmlTextWriter(outXmlFileName, null))
				{
					outXmlFile.Formatting = System.Xml.Formatting.Indented;
					XmlQualifiedName qname = new XmlQualifiedName("AccountList",
														"http://cufxstandards.com/v2/Account.xsd");
					XmlSampleGenerator generator = new XmlSampleGenerator(xsdFilePath, qname);
					generator.WriteXml(outXmlFile);
                    //Console.WriteLine("XML Files Created");
				}
				#endregion

                // Generate one .cs for all the types and place it in the Schemas project
                //string cufxCsFile = Path.Combine(schemaProjectDirectory, "CUFX.cs");
                //string cufxCsFile = Path.Combine(sGeneratedPath + "\\WCF\\", Path.GetFileNameWithoutExtension(xsdFilePath)) + ".cs";
                //string cufxVbFile = Path.Combine(sGeneratedPath + "\\WCF\\", Path.GetFileNameWithoutExtension(xsdFilePath)) + ".vb";
                //CodeGenerator.GenerateCodeFromXsd(xsdFilePath, cufxCsFile, cufxVbFile);
                //CodeGenerator.GenerateCodeFromXsds(files, cufxCsFile);
                //JsonGenerator.GenerateJsonFromCs(cufxCsFile, Path.Combine(sGeneratedPath + "\\JSON\\", Path.GetFileNameWithoutExtension(cufxCsFile)) + ".json");

                //#region Generate the WCF examples
                //cufxCsFile = Path.Combine(sGeneratedPath + "\\WCF\\", Path.GetFileNameWithoutExtension(xsdFilePath)) + ".cs";
                //string cufxVbFile = Path.Combine(sGeneratedPath + "\\WCF\\", Path.GetFileNameWithoutExtension(xsdFilePath)) + ".vb";
                //CodeGenerator.GenerateCodeFromXsds(files, cufxCsFile);
                //CodeGenerator.GenerateCodeFromXsd(xsdFilePath, cufxCsFile, cufxVbFile);
                //Now Generate the WCF Files
                //Converter converter = new Converter(xsdFilePath);
                //bool wasSuccessful = converter.Convert(cufxCsFile);
                //#endregion

            }
            Console.WriteLine("HTML & XML Files Created.....");

            #region Generate the WCF examples
			// Generate one .cs for all the types and place it in the Schemas project
            string cufxCsFile = Path.Combine(sGeneratedPath + "\\WCF\\", "CUFXTemp.cs");
            CodeGenerator.GenerateCodeFromXsds(files, cufxCsFile);
            //Now Generate the WCF File
            Converter converter = new Converter(sGeneratedPath + "\\WCF\\CUFXTemp.cs");
            bool wasSuccessful = converter.Convert(sGeneratedPath + "\\WCF\\CUFX.cs");
            System.IO.File.Delete(sGeneratedPath + "\\WCF\\CUFXTemp.cs");

            if (wasSuccessful)
            {
                Console.WriteLine("WCF File Created");
            }
            #endregion

            JsonGenerator.GenerateJsonFromCs(sGeneratedPath + "\\WCF\\CUFX.cs", Path.Combine(sGeneratedPath, Path.GetFileNameWithoutExtension(cufxCsFile)) + ".json");

            Console.WriteLine("JSON File Created");
			Console.WriteLine("Press any key to close");
			Console.ReadLine();
		}
	}
}

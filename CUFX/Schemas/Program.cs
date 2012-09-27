using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Xml;

namespace DocGenerator
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

			// Look in the project output directory for all xsd files
			string[] files = Directory.GetFiles(Environment.CurrentDirectory, "*.xsd");

			// Create the output directory for the generated HTML files
			string outputDirectory = Path.Combine(Environment.CurrentDirectory, "Generated HTML Docs");
			if (!Directory.Exists(outputDirectory))
			{
				Directory.CreateDirectory(outputDirectory);
			}

			foreach (string xsdFilePath in files)
			{
				string outfileName = Path.Combine(outputDirectory,Path.GetFileNameWithoutExtension(xsdFilePath)) + ".html";
				using (StreamWriter outfile = new StreamWriter(outfileName))
				{
					string documentTitle = Path.GetFileNameWithoutExtension(xsdFilePath);
					documentTitle = documentTitle.Replace("CUFX_", "");
					documentTitle = documentTitle.Replace("_", " ");

					XsltArgumentList argsList = new XsltArgumentList();
					argsList.AddParam("title", "", documentTitle);
					argsList.AddParam("currentDateTime", "", DateTime.Now.ToString("d")); 

					XPathNavigator nav = new XPathDocument(new XmlTextReader(xsdFilePath)).CreateNavigator();

					try
					{
						transformer.Transform(nav, argsList, outfile);
					}
					catch (XsltException xsltEx)
					{
						Console.WriteLine("Could not transform the XSD file [{0}]. Message: [{1}] line: [{2}], position: [{3}]", xsdFilePath, xsltEx.Message, xsltEx.LineNumber, xsltEx.LinePosition);
						Console.ReadKey();
					}

					outfile.Close();
				}
 			}
		}
	}
}

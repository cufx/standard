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
using System.Text.RegularExpressions;


namespace CUFX.Generator
{
       public static class CodeGenerator
       {
              public static void GenerateCodeFromXsd(string xsdFilePath, string outCsFileName, string outVbFileName)
              {
                     List<string> toBePatched = new List<string>();
                     List<string> correctValues = new List<string>();
                     using (StreamWriter outCsFile = new StreamWriter(outCsFileName, false))
                     using (StreamWriter outVbFile = new StreamWriter(outVbFileName, false))
                     {
                           try
                           {
                                  CSharpCodeProvider csProvider = new CSharpCodeProvider();
                                  VBCodeProvider vbProvider = new VBCodeProvider();
                                  CodeNamespace ns = CreateCodeNamespaceFromXsd(xsdFilePath, "cufxstandards.com", toBePatched, correctValues);

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

                     var csCode = File.ReadAllText(outCsFileName);
                     var toBePatchedArray = toBePatched.ToArray();
                     var correctValuesArray = correctValues.ToArray();
                     var x = csCode.IndexOf(toBePatchedArray[0]);
                     var y = csCode.IndexOf(toBePatchedArray[1]);

                     for (int i = 0; i < toBePatchedArray.Length; ++i)
                     {
                           //csCode = csCode.Replace(toBePatchedArray[i], correctValuesArray[i]);
                           string pattern = toBePatchedArray[i];
                           string replacement = correctValuesArray[i];
                           Regex regex = new Regex(pattern);
                           csCode = regex.Replace(csCode, replacement);
                     }
                     File.WriteAllText(outCsFileName, csCode);
              }

              public static void GenerateCodeFromXsds(string[] xsdFiles, string outCsFileName)
              {
                     List<string> toBePatched = new List<string>();
                     List<string> correctValues = new List<string>();
                     using (StreamWriter outCsFile = new StreamWriter(outCsFileName, false))
                     {
                           try
                           {
                                  CSharpCodeProvider csProvider = new CSharpCodeProvider();
                                  VBCodeProvider vbProvider = new VBCodeProvider();
                                  CodeNamespace ns = CreateCodeNamespaceFromXsds(xsdFiles, "cufxstandards.com", toBePatched, correctValues);

                                  csProvider.GenerateCodeFromNamespace(ns, outCsFile, new System.CodeDom.Compiler.CodeGeneratorOptions());
                           }
                           catch (Exception ex)
                           {
                                  Console.WriteLine("Could not generate example code from the xsds. Message: [{0}].  Press any key to continue", ex.Message);
                                  Console.ReadKey();
                           }
                           outCsFile.Close();
                     }

                     var csCode = File.ReadAllText(outCsFileName);
                     var toBePatchedArray = toBePatched.ToArray();
                     var correctValuesArray = correctValues.ToArray();
                     var x = csCode.IndexOf(toBePatchedArray[0]);
                     var y = csCode.IndexOf(toBePatchedArray[1]);
                     for (int i = 0; i < toBePatchedArray.Length; ++i)
                     {
                           //csCode = csCode.Replace(toBePatchedArray[i], correctValuesArray[i]);
                           string pattern = toBePatchedArray[i];
                           string replacement = correctValuesArray[i];
                           Regex regex = new Regex(pattern);
                           csCode = regex.Replace(csCode, replacement);
                     }
                     File.WriteAllText(outCsFileName, csCode);
              }

              private static CodeNamespace CreateCodeNamespaceFromXsd(string xsdFile, string targetNamespace, List<string> toBePatched, List<string> correctValues)
              {
                     XmlSchemaSet schemas = new XmlSchemaSet();
                     List<XmlQualifiedName> xmlTypes = new List<XmlQualifiedName>();

                     // Load the XmlSchema and its collection.            
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
                           if (xmlType.Name.Contains("List") && mapping.TypeFullName.Contains("[]"))
                           {
                                  string typeFullNameEscaped = mapping.TypeFullName.Replace("[]", "\\[\\]");

                                  toBePatched.Add($"private {typeFullNameEscaped} {xmlType.Name}Field;");
                                  var XmlTypeName = char.ToUpper(xmlType.Name[0]) + xmlType.Name.Substring(1, xmlType.Name.Length - 1);
                                  correctValues.Add($"private {XmlTypeName} {xmlType.Name}Field;");

                                  var xmlTypeUnit = xmlType.Name.Substring(0, xmlType.Name.Length - 4);
                                  var XmlTypeUnit = char.ToUpper(xmlTypeUnit[0]) + xmlTypeUnit.Substring(1, xmlTypeUnit.Length - 1);

                                  string pattern = $@"(\[.+\])[\r\n]+\s+public\s{typeFullNameEscaped} {xmlType.Name}";
                                  toBePatched.Add(pattern);
                                  correctValues.Add($"public {XmlTypeName} {xmlType.Name}");

                                  if (xmlType.Name == "billPaymentOccurrenceList")
                                  {
                                         toBePatched.Add($"private {typeFullNameEscaped} billPaymentListField;");
                                         correctValues.Add($"private {XmlTypeName} billPaymentListField;");
                                         toBePatched.Add($@"(\[.+\])[\r\n]+\s+public\s{typeFullNameEscaped} billPaymentList");
                                         correctValues.Add($"public {XmlTypeName} BillPaymentList");
                                  }
                           }

                           // Export the code finally.
                           exporter.ExportTypeMapping(mapping);
                     }
                     RemoveAttributes(ns);
                     return ns;
              }

              private static CodeNamespace CreateCodeNamespaceFromXsds(string[] xsdFiles, string targetNamespace, List<string> toBePatched, List<string> correctValues)
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
                           if (xmlType.Name.Contains("List") && mapping.TypeFullName.Contains("[]"))
                           {
                                  string typeFullNameEscaped = mapping.TypeFullName.Replace("[]", "\\[\\]");

                                  toBePatched.Add($"private {typeFullNameEscaped} {xmlType.Name}Field;");
                                  var XmlTypeName = char.ToUpper(xmlType.Name[0]) + xmlType.Name.Substring(1, xmlType.Name.Length - 1);
                                  correctValues.Add($"private {XmlTypeName} {xmlType.Name}Field;");
                                  var xmlTypeUnit = xmlType.Name.Substring(0, xmlType.Name.Length - 4);
                                   var XmlTypeUnit = char.ToUpper(xmlTypeUnit[0]) + xmlTypeUnit.Substring(1, xmlTypeUnit.Length - 1);
                                  //toBePatched.Add($"[System.Xml.Serialization.XmlArrayItemAttribute(\"{xmlTypeUnit}\", Namespace=\"http://cufxstandards.com/v3/{XmlTypeUnit}.xsd\", IsNullable=false)]\r\n        public {mapping.TypeFullName} {xmlType.Name}");
                                  string pattern = $@"(\[.+\])[\r\n]+\s+public\s{typeFullNameEscaped} {xmlType.Name}";
                                  toBePatched.Add(pattern);
                                  correctValues.Add($"public {XmlTypeName} {xmlType.Name}");

                                  if (xmlType.Name == "billPaymentOccurrenceList")
                                  {
                                         toBePatched.Add($"private {typeFullNameEscaped} billPaymentListField;");
                                         correctValues.Add($"private {XmlTypeName} billPaymentListField;");
                                         toBePatched.Add($@"(\[.+\])[\r\n]+\s+public\s{typeFullNameEscaped} billPaymentList");
                                         correctValues.Add($"public {XmlTypeName} BillPaymentList");
                                  }
                           }

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



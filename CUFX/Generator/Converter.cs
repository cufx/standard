using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CUFX.Generator
{
    public class Converter
    {
        private enum ObjectType
        {
            Class = 0,
            Enumeration = 1,
            Unknown
        }

        private string InputFileName { get; set; }

        //private string _tmpOutputFileName = null;
        //private string TmpOutputFileName
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(_tmpOutputFileName))
        //        {
        //            string[] words = InputFileName.Split('\\');
        //            _tmpOutputFileName = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]) +"\\GeneratedFiles\\WCF\\Output.cs";

        //            //int extensionPosition = InputFileName.LastIndexOf(".");
        //            //if (extensionPosition >= 0)
        //            //{
        //            //    _tmpOutputFileName = InputFileName.Substring(0, extensionPosition);
        //            //}
        //            //else
        //            //{
        //            //    _tmpOutputFileName = InputFileName;
        //            //}
        //            //_tmpOutputFileName += ".tmp";
        //        }

        //        return _tmpOutputFileName;
        //    }
        //}

        private int _lineNum = 0;

        public Converter(string inputFileName)
        {
            InputFileName = inputFileName;
        }

        public bool Convert(string OutputFileName)
        {
            using (FileStream inputStream = new FileStream(InputFileName, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader sr = new StreamReader(inputStream))
                {
                    using (FileStream tempStream = new FileStream(OutputFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
                    {
                        using (StreamWriter sw = new StreamWriter(tempStream))
                        {
                            string objectScript = String.Empty;

                            string type = String.Empty;
                            string name = String.Empty;

                            //  Add the using statements.
                            sw.WriteLine("using System.Collections.Generic;");
                            sw.WriteLine("using System.Runtime.Serialization;");
                            sw.WriteLine();

                            string codeLine = sr.ReadLine(); // Read the namespace line.
                            sw.WriteLine(codeLine);

                            _lineNum = 1;

                            while (sr.Peek() != -1)
                            {
                                StringBuilder objectSource = new StringBuilder();

                                BaseObject objectType = BaseObject.GetObject(sr, objectSource);
                                if (objectType != null)
                                {
                                    sw.WriteLine();
                                    sw.Write(objectType.Refactor(objectSource));
                                }

                                _lineNum++;
                            }

                            // Add the final brace for the namespace.
                            sw.WriteLine("}");

                        }
                    }
                }
            }

            return true;
        }

        /*
        private string RefactorClass(StringBuilder objectSource)
        {
            // Not the most efficient to use a string but it's the most convenient.
            string source = objectSource.ToString();

            int xmlArrayItemPosition = 0;

            // Find all the XmlArrayItem attributes
            do
            {
                xmlArrayItemPosition = source.IndexOf("[System.Xml.Serialization.XmlArrayItemAttribute", xmlArrayItemPosition);
                if (xmlArrayItemPosition > 0)
                {
                    // Get the entire statement.
                    string xmlArrayItemSource = GetToEndOfLine(source, xmlArrayItemPosition);
                    // Replace this attribute with a DataMember attribute but don't use Replace() just in case more than one occurrance exists in this class.
                    source = source.Remove(xmlArrayItemPosition, xmlArrayItemSource.Length);
                    source = source.Insert(xmlArrayItemPosition, "[DataMemeber]");

                    // Get the name of the list item.
                    string listItemName = ExtractString(xmlArrayItemSource, @"XmlArrayItemAttribute\(\""([a-zA-Z0-9_]+)\"",");
                    if (!string.IsNullOrEmpty(listItemName))
                    {
                        // The next line will be in the format:
                        // public <object type>[] <property name> {
                        // Extract the items in the <>.

                        string nextSourceLine = GetNextSourceLine(source, xmlArrayItemPosition);

                        string propertyName = ExtractString(nextSourceLine, @"\[\] (.+) \{");
                        string objectType = ExtractString(nextSourceLine, @"public (.+)\[\]");

                        string newSourceLine = nextSourceLine.Replace(objectType + "[]", propertyName + "List");

                        // Replace the old property definition with the new one.
                        source = source.Replace(nextSourceLine, newSourceLine);

                        // Now, replace the private field's data type.
                        source = source.Replace(string.Format(@"private {0}[] {1}Field;", objectType, propertyName),
                            string.Format(@"private {0}List {1}Field;", propertyName, propertyName));

                        // Finally, add the new class to the bottom of the class being worked on.
                        int lastBracePosition = source.LastIndexOf('}');
                        string collectionSource = @"
        [CollectionDataContract(ItemName = ""{0}"")]
        public class {1}List : List<{2}> {{}}
";
                        source = source.Insert(lastBracePosition, string.Format(collectionSource, listItemName, propertyName, objectType));
                    }

                    // Convert this to a DataMemeber.

                    xmlArrayItemPosition += 50; // Jump past this XmlArrayItemPosition attribute.
                }
                else
                {
                    break;
                }

            } while (true);

            return source;
        }

        private ObjectType ReadObject(StreamReader sr, StringBuilder objectSource)
        {
            while (sr.Peek() != -1)
            {
                string sourceLine = sr.ReadLine();
                _lineNum++;

                if (sourceLine.Trim().Length > 0)
                {
                    objectSource.Append(sourceLine + "\r\n");
                    if (sourceLine.TrimStart().StartsWith("public partial class "))
                    {
                        ReadClass(sr, objectSource);
                        return ObjectType.Class;
                    }
                }
            }

            return ObjectType.Unknown;
        }

        private void ReadClass(StreamReader sr, StringBuilder objectSource)
        {
            int braceDepth = 1; // There will be an open brace at the end of the class definition line.
            while (sr.Peek() != -1)
            {
                string sourceLine = sr.ReadLine();
                _lineNum++;

                objectSource.Append(sourceLine + "\r\n");

                // Loop until braceDepth == 0
                if (sourceLine.IndexOf('{') > 0)
                {
                    braceDepth++;
                }
                else if (sourceLine.IndexOf('}') > 0)
                {
                    braceDepth--;
                }

                if (braceDepth == 0)
                {
                    return;
                }
            }
        }

        private string GetToEndOfLine(string source, int startIndex)
        {
            return ExtractString(source.Substring(startIndex), @"(.+)\r\n");

            //return source.Substring(startIndex, source.IndexOf('\r', startIndex) - startIndex);
        }

        private string GetNextSourceLine(string source, int startIndex)
        {
            return ExtractString(source.Substring(startIndex), @"\r\n(.+)\r\n");
        }

        /// <summary>
        /// Returns the string found using the specified regular expression.
        /// </summary>
        /// <param name="sourceCode"></param>
        /// <param name="regex"></param>
        /// <returns>The extracted string, otherwise, null if not found.</returns>
        private string ExtractString(string sourceCode, string regex)
        {
            string extractedSource = null;

            Match match = Regex.Match(sourceCode, regex, RegexOptions.IgnoreCase);
            if (match.Success)
            {
                // The item name will be the first item.
                extractedSource = match.Groups[1].Value;
            }

            return extractedSource;
        }
         */
    }
}

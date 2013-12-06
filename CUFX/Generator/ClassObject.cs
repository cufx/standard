using System;
using System.Collections.Generic;
using System.Text;

namespace CUFX.Generator
{
    public class ClassObject : BaseObject
    {
        override public string Refactor(StringBuilder objectSource)
        {
            // Not the most efficient to use a string but it's the most convenient.
            string source = objectSource.ToString();

            source = ConvertXmlIgnoreAttribute(source);

            source = ConvertXmlTypeAttribute(source);

            source = ConvertXmlArrayItemAttribute(source);

            source = ConvertXmlElementAttribute(source);

            source = ConvertXmlArrayAttribute(source);

            source = AddDataMemberAttributeToMissingProperties(source);

            return source;
        }

        private string AddDataMemberAttributeToMissingProperties(string source)
        {
            int publicPosition = 0;

            publicPosition = source.IndexOf("public partial class ");
            if (publicPosition == -1)
            {
                publicPosition = source.IndexOf("public abstract partial class ");
            }
            publicPosition++; // Pass the class definition.

            // Find all the XmlElementAttribute attributes
            do
            {
                publicPosition = source.IndexOf("public ", publicPosition);
                if (publicPosition > 0)
                {
                    string sourceLine = source.GetToEndOfLine(publicPosition);
                    if (sourceLine.IndexOf('(') == -1)
                    {
                        // Not a method declaration.
                        source = AddDataMemberAttribute(source, publicPosition);
                    }
                }
                else
                {
                    break;
                }

                publicPosition++; // So we don't keep finding the same one.

            } while (true);

            return source;
        }

        private string AddDataMemberAttribute(string source, int publicPosition)
        {
            int endOfLinePosition = source.LastIndexOf('\r', publicPosition, publicPosition);
            if (endOfLinePosition >= 0)
            {
                // Get the one before that too.
                int startOfLinePosition = source.LastIndexOf('\r', endOfLinePosition - 1, endOfLinePosition);
                string sourceLine = source.Substring(startOfLinePosition + 2, endOfLinePosition - startOfLinePosition - 2);
                if (sourceLine.IndexOf("[DataMember") == -1 &&
                    sourceLine.IndexOf("[IgnoreDataMember") == -1 &&
                    sourceLine.IndexOf("[CollectionDataContract") == -1)
                {
                    // No DataMember attribute, add it. (Get the public beginning whitespace match what it was.
                    source = source.Insert(publicPosition, "[DataMember(EmitDefaultValue = false)]\r\n".PadRight(38 + publicPosition - endOfLinePosition));
                }
            }

            return source;
        }

        private string ConvertXmlTypeAttribute(string objectSource)
        {
            int attributePosition = objectSource.IndexOf("[System.Xml.Serialization.XmlTypeAttribute"); // Should only be one per class.
            if (attributePosition >= 0)
            {
                string sourceLine = objectSource.GetToEndOfLine(attributePosition);
                //string dataNamespace = sourceLine.ExtractString(@"Namespace=""([A-Za-z0-9\.-:/]+)""");

                List<Parameter> parameters = new List<Parameter>();
                AddParameter(sourceLine, parameters, @"Namespace=\""([A-Za-z0-9\.-:/]+)\""", "Namespace");

                objectSource = objectSource.Replace(sourceLine, string.Format(@"[DataContract{0}]", EmitParameters(parameters)));
            }
            else
            {
                Console.WriteLine("Line({0}): System.Xml.Serialization.XmlTypeAttribute not found.\r\n", 1);
            }

            return objectSource;
        }

        private string ConvertXmlArrayItemAttribute(string source)
        {
            int xmlArrayItemPosition = 0;

            // Find all the XmlArrayItem attributes
            do
            {
                xmlArrayItemPosition = source.IndexOf("[System.Xml.Serialization.XmlArrayItemAttribute", xmlArrayItemPosition);
                if (xmlArrayItemPosition > 0)
                {
                    // Get the entire statement.
                    string xmlAttributeSourceLine = source.GetToEndOfLine(xmlArrayItemPosition);

                    List<Parameter> parameters = new List<Parameter>();
                    // Namespace not supported for DataMemberAttribute.
                    //AddParameter(xmlAttributeSourceLine, parameters, @"Namespace=\""([A-Za-z0-9\.-:/]+)\""", "Namespace");
                    AddParameter(xmlAttributeSourceLine, parameters, @"IsNullable=([A-Za-z]+)", "IsRequired", false);
                    parameters.Add(new Parameter()
                    {
                        Name = "EmitDefaultValue",
                        Value = "false"
                    });

                    // Replace this attribute with a DataMember attribute but don't use Replace() just in case more than one occurrance exists in this class.
                    source = source.Remove(xmlArrayItemPosition, xmlAttributeSourceLine.Length);
                    source = source.Insert(xmlArrayItemPosition, string.Format(@"[DataMember{0}]", EmitParameters(parameters)));

                    // Get the name of the list item.
                    string listItemName = xmlAttributeSourceLine.ExtractString(@"XmlArrayItemAttribute\(\""([a-zA-Z0-9_]+)\""");
                    if (!string.IsNullOrEmpty(listItemName))
                    {
                        // The next line will be in the format:
                        // public <object type>[] <property name> {
                        // Extract the items in the <>.

                        string nextSourceLine = source.GetNextSourceLine(xmlArrayItemPosition);

                        string propertyName = nextSourceLine.ExtractString(@"\[\] (.+) \{");
                        string objectType = nextSourceLine.ExtractString(@"public (.+)\[\]");

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

                    // Convert this to a DataMember.

                    xmlArrayItemPosition += 50; // Jump past this XmlArrayItemPosition attribute.
                }
                else
                {
                    break;
                }

            } while (true);

            return source;
        }

        private string ConvertXmlElementAttribute(string source)
        {
            return ConvertXmlAttribute(source, "Element");
        }

        private string ConvertXmlArrayAttribute(string source)
        {
            return ConvertXmlAttribute(source, "Array");
        }

        private string ConvertXmlAttribute(string source, string attributeType)
        {
            int xmlElementAttributePosition = 0;

            // Find all the XmlElementAttribute attributes
            do
            {
                xmlElementAttributePosition = source.IndexOf("[System.Xml.Serialization.Xml" + attributeType + "Attribute", xmlElementAttributePosition);
                if (xmlElementAttributePosition > 0)
                {
                    // Get the entire statement.
                    string xmlAttributeSourceLine = source.GetToEndOfLine(xmlElementAttributePosition);

                    List<Parameter> parameters = new List<Parameter>();
                    AddParameter(xmlAttributeSourceLine, parameters, @"Xml" + attributeType + @"Attribute\(\""([a-zA-Z0-9_]+)\""", "Name");
                    AddParameter(xmlAttributeSourceLine, parameters, @"IsNullable=([A-Za-z]+)", "IsRequired", false);
                    AddParameter(xmlAttributeSourceLine, parameters, @"DataType=\""([a-zA-Z0-9_]+)\""", "DataType");

                    // Replace this attribute with a DataMember attribute but don't use Replace() just in case more than one occurrance exists in this class.
                    source = source.Remove(xmlElementAttributePosition, xmlAttributeSourceLine.Length);
                    source = source.Insert(xmlElementAttributePosition, string.Format("[DataMember{0}]", EmitParameters(parameters)));
                }
                else
                {
                    break;
                }

            } while (true);

            return source;
        }

        private string ConvertXmlIgnoreAttribute(string source)
        {
            return source.Replace("[System.Xml.Serialization.XmlIgnoreAttribute()]", "[IgnoreDataMember]");
        }
    }
}

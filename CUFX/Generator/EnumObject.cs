using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUFX.Generator
{
    public class EnumObject : BaseObject
    {
        override public string Refactor(StringBuilder objectSource)
        {
            // Not the most efficient to use a string but it's the most convenient.
            string source = objectSource.ToString();

            source = AddDataContractAttribute(source);

            source = ConvertXmlEnumAttribute(source);

            source = AddEnumMemberAttributeToMissingProperties(source);

            return source;
        }

        private string AddDataContractAttribute(string objectSource)
        {
            int attributePosition = objectSource.IndexOf("[System.Xml.Serialization.XmlTypeAttribute"); // Should only be one per class.
            if (attributePosition >= 0)
            {
                string sourceLine = objectSource.GetToEndOfLine(attributePosition);

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

        private string ConvertXmlEnumAttribute(string source)
        {
            int xmlEnumAttributePosition = 0;

            // Find all the XmlElementAttribute attributes
            do
            {
                xmlEnumAttributePosition = source.IndexOf("[System.Xml.Serialization.XmlEnumAttribute", xmlEnumAttributePosition);
                if (xmlEnumAttributePosition > 0)
                {
                    // Get the entire statement.
                    string xmlAttributeSourceLine = source.GetToEndOfLine(xmlEnumAttributePosition);

                    // Get the name of the list item.
                    List<Parameter> parameters = new List<Parameter>();
                    AddParameter(xmlAttributeSourceLine, parameters, @"XmlEnumAttribute\(\""([a-zA-Z0-9_\- \.]+)\""", "Value");
                    if (parameters.Count == 0)
                    {
                        Console.Write("No value for {0}\r\n", xmlAttributeSourceLine);
                    }

                    // Replace this attribute with a EnumMember attribute but don't use Replace() just in case more than one occurrance exists in this enumeration.
                    source = source.Remove(xmlEnumAttributePosition, xmlAttributeSourceLine.Length);
                    source = source.Insert(xmlEnumAttributePosition, string.Format("[EnumMember{0}]", EmitParameters(parameters)));
                }
                else
                {
                    break;
                }

            } while (true);

            return source;
        }

        private string AddEnumMemberAttributeToMissingProperties(string source)
        {
            int commaPosition = 0;

            // Find all the XmlElementAttribute attributes
            do
            {
                commaPosition = source.IndexOf(",", commaPosition);
                if (commaPosition > 0)
                {
                    source = AddEnumMemberAttribute(source, source.LastIndexOf(' ', commaPosition));
                }
                else
                {
                    break;
                }

                commaPosition++; // So we don't keep finding the same one.

            } while (true);

            return source;
        }

        private string AddEnumMemberAttribute(string source, int commaPosition)
        {
            int endOfLinePosition = source.LastIndexOf('\r', commaPosition, commaPosition);
            if (endOfLinePosition >= 0)
            {
                // Get the one before that too.
                int startOfLinePosition = source.LastIndexOf('\r', endOfLinePosition - 1, endOfLinePosition);
                string sourceLine = source.Substring(startOfLinePosition + 2, endOfLinePosition - startOfLinePosition - 2);
                if (sourceLine.IndexOf("[EnumMember") == -1)
                {
                    // No EnumMember attribute, add it. (Get the public beginning whitespace match what it was.)
                    int startOfEnumValuePosition = source.LastIndexOf(' ', commaPosition);
                    source = source.Insert(commaPosition, "[EnumMember]\r\n".PadRight(12 + commaPosition - endOfLinePosition));
                }
            }

            return source;
        }
    }
}

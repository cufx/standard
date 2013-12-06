using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CUFX.Generator
{
    abstract public class BaseObject
    {
        public class Parameter
        {
            public string Name;
            public string Value;
        }

        abstract public string Refactor(StringBuilder objectSource);

        public static BaseObject GetObject(StreamReader sr, StringBuilder objectSource)
        {
            while (sr.Peek() != -1)
            {
                string sourceLine = sr.ReadLine();
                //_lineNum++;

                if (sourceLine.Trim().Length > 0)
                {
                    objectSource.Append(sourceLine + "\r\n");
                    if (sourceLine.TrimStart().StartsWith("public partial class ") ||
                        sourceLine.TrimStart().StartsWith("public abstract partial class "))
                    {
                        ReadObjectSource(sr, objectSource);
                        return new ClassObject();
                    }
                    else if (sourceLine.TrimStart().StartsWith("public enum "))
                    {
                        ReadObjectSource(sr, objectSource);
                        return new EnumObject();
                    }
                    else if (sourceLine.TrimStart().StartsWith("public "))
                    {
                        Console.WriteLine("Line({0}): Unknown type at {1}.\r\n", 1, sourceLine);
                    }
                }
            }

            return null;
        }

        private static void ReadObjectSource(StreamReader sr, StringBuilder objectSource)
        {
            int braceDepth = 1; // There will be an open brace at the end of the class definition line.
            while (sr.Peek() != -1)
            {
                string sourceLine = sr.ReadLine();
                //_lineNum++;

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

        protected static void AddParameter(string sourceLine, List<Parameter> parameterList, string valueRegEx, string parameterName, bool keepQuotes = true)
        {
            Parameter parameter = new Parameter();

            parameter.Value = sourceLine.ExtractString(valueRegEx);
            if (!string.IsNullOrEmpty(parameter.Value))
            {
                if (valueRegEx.IndexOf("IsNullable") >= 0 && parameterName == "IsRequired")
                {
                    // Flip the status.
                    if (parameter.Value == "false")
                    {
                        parameter.Value = "true";
                    }
                    else
                    {
                        parameter.Value = "false";
                    }
                }

                if (keepQuotes)
                {
                    parameter.Value = "\"" + parameter.Value + "\"";
                }

                parameter.Name = parameterName;
                parameterList.Add(parameter);
            }
        }

        protected static string EmitParameters(List<Parameter> parameterList)
        {
            string parameters = string.Empty;
            bool isFirst = true;
            foreach (Parameter parameter in parameterList)
            {
                if (isFirst)
                {
                    isFirst = false;
                }
                else
                {
                    parameters += ", ";
                }

                parameters += string.Format(@"{0}={1}", parameter.Name, parameter.Value);
            }

            if (parameters.Length > 0)
            {
                parameters = "(" + parameters + ")";
            }

            return parameters;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CUFX
{
    public static class ExtensionMethods
    {
        public static string GetToEndOfLine(this string source, int startIndex)
        {
            return ExtractString(source.Substring(startIndex), @"(.+)\r\n");

            //return source.Substring(startIndex, source.IndexOf('\r', startIndex) - startIndex);
        }

        public static string GetNextSourceLine(this string source, int startIndex)
        {
            return ExtractString(source.Substring(startIndex), @"\r\n(.+)\r\n");
        }

        /// <summary>
        /// Returns the string found using the specified regular expression.
        /// </summary>
        /// <param name="sourceCode"></param>
        /// <param name="regex"></param>
        /// <returns>The extracted string, otherwise, null if not found.</returns>
        public static string ExtractString(this string sourceCode, string regex)
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
    }
}

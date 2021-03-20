namespace Schema.NET.Tool
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Xml;

    public static class SourceUtility
    {
        private const char Space = ' ';
        private static readonly Regex NewLineReplace = new("[\n ]{0,}\n[\n ]{0,}", RegexOptions.Compiled);

        public static string RenderItems<T>(bool canRender, IEnumerable<T> items, Func<T, string> action)
        {
            if (canRender)
            {
                return RenderItems(items, action);
            }

            return string.Empty;
        }

        public static string RenderItems<T>(IEnumerable<T> items, Func<T, string> action)
        {
            var stringBuilder = new StringBuilder();
            foreach (var item in items)
            {
                stringBuilder.Append(action(item));
            }

            return stringBuilder.ToString();
        }

        public static string RenderDoc(int indent, string? text)
        {
            if (text == null)
            {
                return string.Empty;
            }

            var escapedValue = XmlEscape(text.Trim());
            return NewLineReplace.Replace(escapedValue, $"\n{new string(Space, indent)}/// ");
        }

        private static string XmlEscape(string value)
        {
            var document = new XmlDocument();
            var element = document.CreateElement("root");
            element.InnerText = value;
            return element.InnerXml;
        }
    }
}

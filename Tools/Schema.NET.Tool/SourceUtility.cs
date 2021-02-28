namespace Schema.NET.Tool
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml;

    public static class SourceUtility
    {
        private const char Space = ' ';

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

        public static string RenderDoc(int indent, string text)
        {
            if (text == null)
            {
                return string.Empty;
            }

            text = text
                   .Trim()
                   .Replace("\n\n", "\n")
                   .Replace(" \n", "\n");
            var escapedValue = XmlEscape(text);

            return escapedValue
                .Replace("\n", $"\n{new string(Space, indent)}/// ")
                .Replace("/// \n", "///\n");
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

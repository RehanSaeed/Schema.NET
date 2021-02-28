namespace Schema.NET.Tool
{
    using System.Xml;

    public static class SourceUtility
    {
        private const char Space = ' ';

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

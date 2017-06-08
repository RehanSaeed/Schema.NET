namespace Schema.NET.Tool
{
    using System.Text;
    using System.Xml;

    public static class StringBuilderExtensions
    {
        private const char Space = ' ';

        public static void AppendIndent(this StringBuilder stringBuilder, int count) =>
            stringBuilder.Append(new string(Space, count));

        public static void AppendIndent(this StringBuilder stringBuilder, int count, string value)
        {
            stringBuilder.AppendIndent(count);
            stringBuilder.Append(value);
        }

        public static void AppendIndentLine(this StringBuilder stringBuilder, int count, string value)
        {
            stringBuilder.AppendIndent(count);
            stringBuilder.AppendLine(value);
        }

        public static void AppendCommentLine(this StringBuilder stringBuilder, int count, string value)
        {
            stringBuilder.AppendIndent(count);
            stringBuilder.Append("/// ");
            value = value.Trim().Replace("\n\n", "\n").Replace(" \n", "\n");
            stringBuilder.AppendLine(XmlEscape(value)
                .Replace("\n", $"\n{new string(Space, count)}/// ")
                .Replace("/// \n", "///\n"));
        }

        public static string XmlEscape(string value)
        {
            var document = new XmlDocument();
            var element = document.CreateElement("root");
            element.InnerText = value;
            return element.InnerXml;
        }
    }
}

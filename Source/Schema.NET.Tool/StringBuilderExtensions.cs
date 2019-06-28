namespace Schema.NET.Tool
{
    using System;
    using System.Text;
    using System.Xml;

    public static class StringBuilderExtensions
    {
        private const char Space = ' ';

        public static void AppendIndent(this StringBuilder stringBuilder, int count)
        {
            if (stringBuilder == null)
            {
                throw new ArgumentNullException(nameof(stringBuilder));
            }

            stringBuilder.Append(new string(Space, count));
        }

        public static void AppendIndent(this StringBuilder stringBuilder, int count, string value)
        {
            if (stringBuilder == null)
            {
                throw new ArgumentNullException(nameof(stringBuilder));
            }

            stringBuilder.AppendIndent(count);
            stringBuilder.Append(value);
        }

        public static void AppendIndentLine(this StringBuilder stringBuilder, int count, string value)
        {
            if (stringBuilder == null)
            {
                throw new ArgumentNullException(nameof(stringBuilder));
            }

            stringBuilder.AppendIndent(count);
            stringBuilder.AppendLine(value);
        }

        public static void AppendCommentLine(this StringBuilder stringBuilder, int count, string value)
        {
            if (stringBuilder == null)
            {
                throw new ArgumentNullException(nameof(stringBuilder));
            }

            value = value ?? string.Empty;
            value = value.Trim().Replace("\n\n", "\n", StringComparison.Ordinal).Replace(" \n", "\n", StringComparison.Ordinal);
            var escapedValue = XmlEscape(value);

            stringBuilder.AppendIndent(count);
            stringBuilder.Append("/// ");
            stringBuilder.AppendLine(escapedValue
                .Replace("\n", $"\n{new string(Space, count)}/// ", StringComparison.Ordinal)
                .Replace("/// \n", "///\n", StringComparison.Ordinal));
        }

        public static void AppendCommentSummary(this StringBuilder stringBuilder, int count, string value)
        {
            if (stringBuilder == null)
            {
                throw new ArgumentNullException(nameof(stringBuilder));
            }

            stringBuilder.AppendIndentLine(count, "/// <summary>");
            stringBuilder.AppendCommentLine(count, value);
            stringBuilder.AppendIndentLine(count, "/// </summary>");
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

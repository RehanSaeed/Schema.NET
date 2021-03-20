namespace Schema.NET
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// A Property value specification.
    /// </summary>
    public partial class PropertyValueSpecification
    {
        /// <summary>
        /// Returns a <see cref="string" /> that represents the short hand representation of this instance.
        /// See https://schema.org/docs/actions.html#part-3.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents the short hand representation of this instance.
        /// </returns>
        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            if (this.ValueMaxLength.First() is double maxLength)
            {
                stringBuilder.Append("maxlength=");
                stringBuilder.Append(maxLength);
            }

            if (this.ValueMinLength.First() is double minLength)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("minlength=");
                stringBuilder.Append(minLength);
            }

            if (this.ValueName.First() is string name)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("name=");
                stringBuilder.Append(name);
            }

            if (this.ValuePattern.First() is string pattern)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("pattern=");
                stringBuilder.Append(pattern);
            }

            if (this.ValueRequired.First() is true)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("required");
            }

            return stringBuilder.ToString();
        }

        private static void AppendSpace(StringBuilder stringBuilder)
        {
            if (stringBuilder.Length > 0)
            {
                stringBuilder.Append(' ');
            }
        }
    }
}

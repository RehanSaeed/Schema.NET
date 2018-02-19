namespace Schema.NET
{
    using System.Text;

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

            if (ValueMaxLength.HasValue)
            {
                stringBuilder.Append("maxlength=");
                stringBuilder.Append(this.ValueMaxLength.Value.Item);
            }

            if (ValueMinLength.HasValue)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("minlength=");
                stringBuilder.Append(this.ValueMinLength.Value.Item);
            }

            if (ValueName.HasValue && !string.IsNullOrEmpty(ValueName.Value.Item))
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("name=");
                stringBuilder.Append(ValueName.Value.Item);
            }

            if (ValuePattern.HasValue && !string.IsNullOrEmpty(ValuePattern.Value.Item))
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("pattern=");
                stringBuilder.Append(this.ValuePattern.Value.Item);
            }

            if (ValueRequired.HasValue)
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
                stringBuilder.Append(" ");
            }
        }
    }
}

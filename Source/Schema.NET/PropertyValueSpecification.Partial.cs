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

            if (this.ValueMaxLength.HasValue)
            {
                stringBuilder.Append("maxlength=");
                stringBuilder.Append(this.ValueMaxLength.Value);
            }

            if (this.ValueMinLength.HasValue)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("minlength=");
                stringBuilder.Append(this.ValueMinLength.Value);
            }

            if (this.ValueName != null)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("name=");
                stringBuilder.Append(this.ValueName);
            }

            if (this.ValuePattern != null)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("pattern=");
                stringBuilder.Append(this.ValuePattern);
            }

            if (this.ValueRequired.HasValue)
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

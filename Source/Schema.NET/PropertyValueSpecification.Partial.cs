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

            if (this.ValueMaxLength.HasValue && this.ValueMaxLength.Value.Item.HasValue)
            {
                stringBuilder.Append("maxlength=");
                stringBuilder.Append(this.ValueMaxLength.Value.Item.Value);
            }

            if (this.ValueMinLength.HasValue && this.ValueMinLength.Value.Item.HasValue)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("minlength=");
                stringBuilder.Append(this.ValueMinLength.Value.Item.Value);
            }

            if (this.ValueName.HasValue && this.ValueName.Value.Item != null)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("name=");
                stringBuilder.Append(this.ValueName.Value.Item);
            }

            if (this.ValuePattern.HasValue && this.ValuePattern.Value.Item != null)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("pattern=");
                stringBuilder.Append(this.ValuePattern.Value.Item);
            }

            if (this.ValueRequired.HasValue && this.ValueRequired.Value.Item.HasValue)
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

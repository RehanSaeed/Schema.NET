namespace Schema.NET
{
    using System.Linq;
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

            if (this.ValueMaxLength.HasValue && this.ValueMaxLength.Value.First().HasValue)
            {
                stringBuilder.Append("maxlength=");
                stringBuilder.Append(this.ValueMaxLength.Value.First().Value);
            }

            if (this.ValueMinLength.HasValue && this.ValueMinLength.Value.First().HasValue)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("minlength=");
                stringBuilder.Append(this.ValueMinLength.Value.First().Value);
            }

            if (this.ValueName.HasValue && this.ValueName.Value.First() != null)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("name=");
                stringBuilder.Append(this.ValueName.Value.First());
            }

            if (this.ValuePattern.HasValue && this.ValuePattern.Value.First() != null)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("pattern=");
                stringBuilder.Append(this.ValuePattern.Value.First());
            }

            if (this.ValueRequired.HasValue && this.ValueRequired.Value.First().HasValue)
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

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

            if (this.ValueMaxLength != null && this.ValueMaxLength.First() != null)
            {
                stringBuilder.Append("maxlength=");
                stringBuilder.Append(this.ValueMaxLength.First().Value);
            }

            if (this.ValueMinLength != null && this.ValueMinLength.First() != null)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("minlength=");
                stringBuilder.Append(this.ValueMinLength.First().Value);
            }

            if (this.ValueName != null && this.ValueName.First() != null)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("name=");
                stringBuilder.Append(this.ValueName.First());
            }

            if (this.ValuePattern != null && this.ValuePattern.First() != null)
            {
                AppendSpace(stringBuilder);
                stringBuilder.Append("pattern=");
                stringBuilder.Append(this.ValuePattern.First());
            }

            if (this.ValueRequired != null && this.ValueRequired.First() != null)
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

namespace Schema.NET
{
    using System.Collections.Generic;
    using System.Linq;

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
            var values = new List<string>();

            if (this.ValueMaxLength.First() is double maxLength)
            {
                values.Add($"maxlength={maxLength}");
            }

            if (this.ValueMinLength.First() is double minLength)
            {
                values.Add($"minlength={minLength}");
            }

            if (this.ValueName.First() is string name)
            {
                values.Add($"name={name}");
            }

            if (this.ValuePattern.First() is string pattern)
            {
                values.Add($"pattern={pattern}");
            }

            if (this.ValueRequired.First() is true)
            {
                values.Add("required");
            }

#if NETSTANDARD2_0 || NET472 || NET461
            return string.Join(" ", values);
#else
            return string.Join(' ', values);
#endif
        }
    }
}

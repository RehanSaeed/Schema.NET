namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Structured values are used when the value of a property has a more complex structure than simply being a textual value or a reference to another thing.
    /// </summary>
    public partial interface IStructuredValue : IIntangible
    {
    }

    /// <summary>
    /// Structured values are used when the value of a property has a more complex structure than simply being a textual value or a reference to another thing.
    /// </summary>
    [DataContract]
    public partial class StructuredValue : Intangible, IStructuredValue, IEquatable<StructuredValue>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "StructuredValue";

        /// <inheritdoc/>
        public bool Equals(StructuredValue other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as StructuredValue);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

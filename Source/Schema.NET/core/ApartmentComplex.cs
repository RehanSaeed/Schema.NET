namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
    public partial interface IApartmentComplex : IResidence
    {
    }

    /// <summary>
    /// Residence type: Apartment complex.
    /// </summary>
    [DataContract]
    public partial class ApartmentComplex : Residence, IApartmentComplex, IEquatable<ApartmentComplex>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ApartmentComplex";

        /// <inheritdoc/>
        public bool Equals(ApartmentComplex other)
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
        public override bool Equals(object obj) => this.Equals(obj as ApartmentComplex);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

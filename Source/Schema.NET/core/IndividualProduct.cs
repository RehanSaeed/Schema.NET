namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A single, identifiable product instance (e.g. a laptop with a particular serial number).
    /// </summary>
    public partial interface IIndividualProduct : IProduct
    {
        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        OneOrMany<string> SerialNumber { get; set; }
    }

    /// <summary>
    /// A single, identifiable product instance (e.g. a laptop with a particular serial number).
    /// </summary>
    [DataContract]
    public partial class IndividualProduct : Product, IIndividualProduct, IEquatable<IndividualProduct>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "IndividualProduct";

        /// <summary>
        /// The serial number or any alphanumeric identifier of a particular product. When attached to an offer, it is a shortcut for the serial number of the product included in the offer.
        /// </summary>
        [DataMember(Name = "serialNumber", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SerialNumber { get; set; }

        /// <inheritdoc/>
        public bool Equals(IndividualProduct other)
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
                this.SerialNumber == other.SerialNumber &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as IndividualProduct);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.SerialNumber)
            .And(base.GetHashCode());
    }
}

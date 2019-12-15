namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// </summary>
    public partial interface IOwnershipInfo : IStructuredValue
    {
        /// <summary>
        /// The organization or person from which the product was acquired.
        /// </summary>
        Values<IOrganization, IPerson> AcquiredFrom { get; set; }

        /// <summary>
        /// The date and time of obtaining the product.
        /// </summary>
        OneOrMany<DateTimeOffset?> OwnedFrom { get; set; }

        /// <summary>
        /// The date and time of giving up ownership on the product.
        /// </summary>
        OneOrMany<DateTimeOffset?> OwnedThrough { get; set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        Values<IProduct, IService> TypeOfGood { get; set; }
    }

    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// </summary>
    [DataContract]
    public partial class OwnershipInfo : StructuredValue, IOwnershipInfo, IEquatable<OwnershipInfo>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OwnershipInfo";

        /// <summary>
        /// The organization or person from which the product was acquired.
        /// </summary>
        [DataMember(Name = "acquiredFrom", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> AcquiredFrom { get; set; }

        /// <summary>
        /// The date and time of obtaining the product.
        /// </summary>
        [DataMember(Name = "ownedFrom", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> OwnedFrom { get; set; }

        /// <summary>
        /// The date and time of giving up ownership on the product.
        /// </summary>
        [DataMember(Name = "ownedThrough", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> OwnedThrough { get; set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [DataMember(Name = "typeOfGood", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, IService> TypeOfGood { get; set; }

        /// <inheritdoc/>
        public bool Equals(OwnershipInfo other)
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
                this.AcquiredFrom == other.AcquiredFrom &&
                this.OwnedFrom == other.OwnedFrom &&
                this.OwnedThrough == other.OwnedThrough &&
                this.TypeOfGood == other.TypeOfGood &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as OwnershipInfo);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AcquiredFrom)
            .And(this.OwnedFrom)
            .And(this.OwnedThrough)
            .And(this.TypeOfGood)
            .And(base.GetHashCode());
    }
}

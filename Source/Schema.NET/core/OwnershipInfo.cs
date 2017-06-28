namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A structured value providing information about when a certain organization or person owned a certain product.
    /// </summary>
    [DataContract]
    public partial class OwnershipInfo : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OwnershipInfo";

        /// <summary>
        /// The organization or person from which the product was acquired.
        /// </summary>
        [DataMember(Name = "acquiredFrom", Order = 304)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Organization>? AcquiredFrom { get; set; }

        /// <summary>
        /// The date and time of obtaining the product.
        /// </summary>
        [DataMember(Name = "ownedFrom", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? OwnedFrom { get; set; }

        /// <summary>
        /// The date and time of giving up ownership on the product.
        /// </summary>
        [DataMember(Name = "ownedThrough", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? OwnedThrough { get; set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [DataMember(Name = "typeOfGood", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Product, Service>? TypeOfGood { get; set; }
    }
}

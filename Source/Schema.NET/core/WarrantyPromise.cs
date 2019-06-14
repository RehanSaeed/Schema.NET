namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.
    /// </summary>
    public partial interface IWarrantyPromise : IStructuredValue
    {
        /// <summary>
        /// The duration of the warranty promise. Common unitCode values are ANN for year, MON for months, or DAY for days.
        /// </summary>
        OneOrMany<IQuantitativeValue, QuantitativeValue> DurationOfWarranty { get; set; }

        /// <summary>
        /// The scope of the warranty promise.
        /// </summary>
        OneOrMany<WarrantyScope?> WarrantyScope { get; set; }
    }

    /// <summary>
    /// A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.
    /// </summary>
    [DataContract]
    public partial class WarrantyPromise : StructuredValue, IWarrantyPromise
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WarrantyPromise";

        /// <summary>
        /// The duration of the warranty promise. Common unitCode values are ANN for year, MON for months, or DAY for days.
        /// </summary>
        [DataMember(Name = "durationOfWarranty", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue, QuantitativeValue> DurationOfWarranty { get; set; }

        /// <summary>
        /// The scope of the warranty promise.
        /// </summary>
        [DataMember(Name = "warrantyScope", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<WarrantyScope?> WarrantyScope { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A structured value representing the duration and scope of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.
    /// </summary>
    [DataContract]
    public class WarrantyPromise : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "WarrantyPromise";

        /// <summary>
        /// The duration of the warranty promise. Common unitCode values are ANN for year, MON for months, or DAY for days.
        /// </summary>
        [DataMember(Name = "durationOfWarranty")]
        public QuantitativeValue DurationOfWarranty { get; set; }

        /// <summary>
        /// The scope of the warranty promise.
        /// </summary>
        [DataMember(Name = "warrantyScope")]
        public WarrantyScope WarrantyScope { get; set; }
    }
}

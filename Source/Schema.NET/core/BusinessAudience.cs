namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A set of characteristics belonging to businesses, e.g. who compose an item's target audience.
    /// </summary>
    [DataContract]
    public partial class BusinessAudience : Audience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusinessAudience";

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [DataMember(Name = "numberOfEmployees", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? NumberOfEmployees { get; set; }

        /// <summary>
        /// The size of the business in annual revenue.
        /// </summary>
        [DataMember(Name = "yearlyRevenue", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? YearlyRevenue { get; set; }

        /// <summary>
        /// The age of the business.
        /// </summary>
        [DataMember(Name = "yearsInOperation", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? YearsInOperation { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A set of characteristics belonging to businesses, e.g. who compose an item's target audience.
    /// </summary>
    public partial interface IBusinessAudience : IAudience
    {
        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        OneOrMany<IQuantitativeValue>? NumberOfEmployees { get; set; }

        /// <summary>
        /// The size of the business in annual revenue.
        /// </summary>
        OneOrMany<IQuantitativeValue>? YearlyRevenue { get; set; }

        /// <summary>
        /// The age of the business.
        /// </summary>
        OneOrMany<IQuantitativeValue>? YearsInOperation { get; set; }
    }

    /// <summary>
    /// A set of characteristics belonging to businesses, e.g. who compose an item's target audience.
    /// </summary>
    [DataContract]
    public partial class BusinessAudience : Audience, IBusinessAudience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusinessAudience";

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [DataMember(Name = "numberOfEmployees", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IQuantitativeValue>? NumberOfEmployees { get; set; }

        /// <summary>
        /// The size of the business in annual revenue.
        /// </summary>
        [DataMember(Name = "yearlyRevenue", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IQuantitativeValue>? YearlyRevenue { get; set; }

        /// <summary>
        /// The age of the business.
        /// </summary>
        [DataMember(Name = "yearsInOperation", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IQuantitativeValue>? YearsInOperation { get; set; }
    }
}

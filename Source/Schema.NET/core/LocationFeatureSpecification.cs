namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.
    /// </summary>
    public partial interface ILocationFeatureSpecification : IPropertyValue
    {
        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        OneOrMany<IOpeningHoursSpecification>? HoursAvailable { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        OneOrMany<DateTimeOffset?>? ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        OneOrMany<DateTimeOffset?>? ValidThrough { get; set; }
    }

    /// <summary>
    /// Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.
    /// </summary>
    [DataContract]
    public partial class LocationFeatureSpecification : PropertyValue, ILocationFeatureSpecification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LocationFeatureSpecification";

        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        [DataMember(Name = "hoursAvailable", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IOpeningHoursSpecification>? HoursAvailable { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 408)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? ValidThrough { get; set; }
    }
}

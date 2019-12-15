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
        OneOrMany<IOpeningHoursSpecification> HoursAvailable { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        Values<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }
    }

    /// <summary>
    /// Specifies a location feature by providing a structured value representing a feature of an accommodation as a property-value pair of varying degrees of formality.
    /// </summary>
    [DataContract]
    public partial class LocationFeatureSpecification : PropertyValue, ILocationFeatureSpecification, IEquatable<LocationFeatureSpecification>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOpeningHoursSpecification> HoursAvailable { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 407)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 408)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        /// <inheritdoc/>
        public bool Equals(LocationFeatureSpecification other)
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
                this.HoursAvailable == other.HoursAvailable &&
                this.ValidFrom == other.ValidFrom &&
                this.ValidThrough == other.ValidThrough &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as LocationFeatureSpecification);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.HoursAvailable)
            .And(this.ValidFrom)
            .And(this.ValidThrough)
            .And(base.GetHashCode());
    }
}

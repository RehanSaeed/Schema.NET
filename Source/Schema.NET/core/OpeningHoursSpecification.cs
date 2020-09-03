namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.&lt;br/&gt;&lt;br/&gt;
    /// The place is &lt;strong&gt;open&lt;/strong&gt; if the &lt;a class="localLink" href="https://schema.org/opens"&gt;opens&lt;/a&gt; property is specified, and &lt;strong&gt;closed&lt;/strong&gt; otherwise.&lt;br/&gt;&lt;br/&gt;
    /// If the value for the &lt;a class="localLink" href="https://schema.org/closes"&gt;closes&lt;/a&gt; property is less than the value for the &lt;a class="localLink" href="https://schema.org/opens"&gt;opens&lt;/a&gt; property then the hour range is assumed to span over the next day.
    /// </summary>
    public partial interface IOpeningHoursSpecification : IStructuredValue
    {
        /// <summary>
        /// The closing hour of the place or service on the given day(s) of the week.
        /// </summary>
        OneOrMany<TimeSpan?> Closes { get; set; }

        /// <summary>
        /// The day of the week for which these opening hours are valid.
        /// </summary>
        OneOrMany<DayOfWeek?> DayOfWeek { get; set; }

        /// <summary>
        /// The opening hour of the place or service on the given day(s) of the week.
        /// </summary>
        OneOrMany<TimeSpan?> Opens { get; set; }

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
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.&lt;br/&gt;&lt;br/&gt;
    /// The place is &lt;strong&gt;open&lt;/strong&gt; if the &lt;a class="localLink" href="https://schema.org/opens"&gt;opens&lt;/a&gt; property is specified, and &lt;strong&gt;closed&lt;/strong&gt; otherwise.&lt;br/&gt;&lt;br/&gt;
    /// If the value for the &lt;a class="localLink" href="https://schema.org/closes"&gt;closes&lt;/a&gt; property is less than the value for the &lt;a class="localLink" href="https://schema.org/opens"&gt;opens&lt;/a&gt; property then the hour range is assumed to span over the next day.
    /// </summary>
    [DataContract]
    public partial class OpeningHoursSpecification : StructuredValue, IOpeningHoursSpecification, IEquatable<OpeningHoursSpecification>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OpeningHoursSpecification";

        /// <summary>
        /// The closing hour of the place or service on the given day(s) of the week.
        /// </summary>
        [DataMember(Name = "closes", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<TimeSpan?> Closes { get; set; }

        /// <summary>
        /// The day of the week for which these opening hours are valid.
        /// </summary>
        [DataMember(Name = "dayOfWeek", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DayOfWeek?> DayOfWeek { get; set; }

        /// <summary>
        /// The opening hour of the place or service on the given day(s) of the week.
        /// </summary>
        [DataMember(Name = "opens", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<TimeSpan?> Opens { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 309)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 310)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> ValidThrough { get; set; }

        /// <inheritdoc/>
        public bool Equals(OpeningHoursSpecification other)
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
                this.Closes == other.Closes &&
                this.DayOfWeek == other.DayOfWeek &&
                this.Opens == other.Opens &&
                this.ValidFrom == other.ValidFrom &&
                this.ValidThrough == other.ValidThrough &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as OpeningHoursSpecification);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Closes)
            .And(this.DayOfWeek)
            .And(this.Opens)
            .And(this.ValidFrom)
            .And(this.ValidThrough)
            .And(base.GetHashCode());
    }
}

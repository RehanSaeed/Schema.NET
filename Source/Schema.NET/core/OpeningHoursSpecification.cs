namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.&lt;/p&gt;
    /// &lt;p&gt;The place is &lt;strong&gt;open&lt;/strong&gt; if the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property is specified, and &lt;strong&gt;closed&lt;/strong&gt; otherwise.&lt;/p&gt;
    /// &lt;p&gt;If the value for the &lt;a class="localLink" href="http://schema.org/closes"&gt;closes&lt;/a&gt; property is less than the value for the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property then the hour range is assumed to span over the next day.
    /// </summary>
    [DataContract]
    public partial class OpeningHoursSpecification : StructuredValue
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
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<TimeSpan?>? Closes { get; set; }

        /// <summary>
        /// The day of the week for which these opening hours are valid.
        /// </summary>
        [DataMember(Name = "dayOfWeek", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DayOfWeek?>? DayOfWeek { get; set; }

        /// <summary>
        /// The opening hour of the place or service on the given day(s) of the week.
        /// </summary>
        [DataMember(Name = "opens", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<TimeSpan?>? Opens { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? ValidThrough { get; set; }
    }
}

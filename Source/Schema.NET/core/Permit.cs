namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
    [DataContract]
    public partial class Permit : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Permit";

        /// <summary>
        /// The organization issuing the ticket or permit.
        /// </summary>
        [DataMember(Name = "issuedBy", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Organization>? IssuedBy { get; set; }

        /// <summary>
        /// The service through with the permit was granted.
        /// </summary>
        [DataMember(Name = "issuedThrough", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Service>? IssuedThrough { get; set; }

        /// <summary>
        /// The target audience for this permit.
        /// </summary>
        [DataMember(Name = "permitAudience", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Audience>? PermitAudience { get; set; }

        /// <summary>
        /// The duration of validity of a permit or similar thing.
        /// </summary>
        [DataMember(Name = "validFor", Order = 209)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public OneOrMany<TimeSpan?>? ValidFor { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? ValidFrom { get; set; }

        /// <summary>
        /// The geographic area where a permit or similar thing is valid.
        /// </summary>
        [DataMember(Name = "validIn", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<AdministrativeArea>? ValidIn { get; set; }

        /// <summary>
        /// The date when the item is no longer valid.
        /// </summary>
        [DataMember(Name = "validUntil", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? ValidUntil { get; set; }
    }
}

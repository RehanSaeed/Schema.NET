namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
    public partial interface IPermit : IIntangible
    {
        /// <summary>
        /// The organization issuing the ticket or permit.
        /// </summary>
        OneOrMany<IOrganization>? IssuedBy { get; set; }

        /// <summary>
        /// The service through with the permit was granted.
        /// </summary>
        OneOrMany<IService>? IssuedThrough { get; set; }

        /// <summary>
        /// The target audience for this permit.
        /// </summary>
        OneOrMany<IAudience>? PermitAudience { get; set; }

        /// <summary>
        /// The time validity of the permit.
        /// </summary>
        OneOrMany<TimeSpan?>? ValidFor { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        OneOrMany<DateTimeOffset?>? ValidFrom { get; set; }

        /// <summary>
        /// The geographic area where the permit is valid.
        /// </summary>
        OneOrMany<IAdministrativeArea>? ValidIn { get; set; }

        /// <summary>
        /// The date when the item is no longer valid.
        /// </summary>
        OneOrMany<DateTimeOffset?>? ValidUntil { get; set; }
    }

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
    [DataContract]
    public partial class Permit : Intangible, IPermit
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
        public OneOrMany<IOrganization>? IssuedBy { get; set; }

        /// <summary>
        /// The service through with the permit was granted.
        /// </summary>
        [DataMember(Name = "issuedThrough", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IService>? IssuedThrough { get; set; }

        /// <summary>
        /// The target audience for this permit.
        /// </summary>
        [DataMember(Name = "permitAudience", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IAudience>? PermitAudience { get; set; }

        /// <summary>
        /// The time validity of the permit.
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
        /// The geographic area where the permit is valid.
        /// </summary>
        [DataMember(Name = "validIn", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IAdministrativeArea>? ValidIn { get; set; }

        /// <summary>
        /// The date when the item is no longer valid.
        /// </summary>
        [DataMember(Name = "validUntil", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? ValidUntil { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A permit issued by an organization, e.g. a parking pass.
    /// </summary>
    [DataContract]
    public class Permit : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Permit";

        /// <summary>
        /// The organization issuing the ticket or permit.
        /// </summary>
        [DataMember(Name = "issuedBy", Order = 2)]
        public Organization IssuedBy { get; set; }

        /// <summary>
        /// The service through with the permit was granted.
        /// </summary>
        [DataMember(Name = "issuedThrough", Order = 3)]
        public Service IssuedThrough { get; set; }

        /// <summary>
        /// The target audience for this permit.
        /// </summary>
        [DataMember(Name = "permitAudience", Order = 4)]
        public Audience PermitAudience { get; set; }

        /// <summary>
        /// The time validity of the permit.
        /// </summary>
        [DataMember(Name = "validFor", Order = 5)]
        public Duration ValidFor { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 6)]
        public DateTimeOffset? ValidFrom { get; set; }

        /// <summary>
        /// The geographic area where the permit is valid.
        /// </summary>
        [DataMember(Name = "validIn", Order = 7)]
        public AdministrativeArea ValidIn { get; set; }

        /// <summary>
        /// The date when the item is no longer valid.
        /// </summary>
        [DataMember(Name = "validUntil", Order = 8)]
        public DateTimeOffset? ValidUntil { get; set; }
    }
}

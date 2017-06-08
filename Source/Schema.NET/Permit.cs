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
        [DataMember(Name = "@type")]
        public override string Type => "Permit";

        /// <summary>
        /// The time validity of the permit.
        /// </summary>
        [DataMember(Name = "validFor")]
        public Duration ValidFor { get; set; }

        /// <summary>
        /// The date when the item is no longer valid.
        /// </summary>
        [DataMember(Name = "validUntil")]
        public DateTimeOffset ValidUntil { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom")]
        public DateTimeOffset ValidFrom { get; set; }

        /// <summary>
        /// The organization issuing the ticket or permit.
        /// </summary>
        [DataMember(Name = "issuedBy")]
        public Organization IssuedBy { get; set; }

        /// <summary>
        /// The service through with the permit was granted.
        /// </summary>
        [DataMember(Name = "issuedThrough")]
        public Service IssuedThrough { get; set; }

        /// <summary>
        /// The target audience for this permit.
        /// </summary>
        [DataMember(Name = "permitAudience")]
        public Audience PermitAudience { get; set; }

        /// <summary>
        /// The geographic area where the permit is valid.
        /// </summary>
        [DataMember(Name = "validIn")]
        public AdministrativeArea ValidIn { get; set; }
    }
}

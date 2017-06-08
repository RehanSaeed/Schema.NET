namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Intended audience for an item, i.e. the group for whom the item was created.
    /// </summary>
    [DataContract]
    public class Audience : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Audience";

        /// <summary>
        /// The target group associated with a given audience (e.g. veterans, car owners, musicians, etc.).
        /// </summary>
        [DataMember(Name = "audienceType")]
        public string AudienceType { get; set; }

        /// <summary>
        /// The geographic area associated with the audience.
        /// </summary>
        [DataMember(Name = "geographicArea")]
        public AdministrativeArea GeographicArea { get; set; }
    }
}

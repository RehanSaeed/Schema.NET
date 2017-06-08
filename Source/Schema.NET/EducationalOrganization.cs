namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An educational organization.
    /// </summary>
    [DataContract]
    public class EducationalOrganization : Organization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "EducationalOrganization";

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni")]
        public override Person Alumni { get; set; }
    }
}

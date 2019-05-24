namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An educational organization.
    /// </summary>
    public partial interface IEducationalOrganization : IOrganization
    {
    }

    /// <summary>
    /// An educational organization.
    /// </summary>
    [DataContract]
    public partial class EducationalOrganization : Organization, IEducationalOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EducationalOrganization";

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Alumni { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A governmental organization or agency.
    /// </summary>
    [DataContract]
    public class GovernmentOrganization : Organization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "GovernmentOrganization";
    }
}

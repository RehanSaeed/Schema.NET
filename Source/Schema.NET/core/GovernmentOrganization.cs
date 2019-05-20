namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A governmental organization or agency.
    /// </summary>
    public partial interface IGovernmentOrganization : IOrganization
    {
    }

    /// <summary>
    /// A governmental organization or agency.
    /// </summary>
    [DataContract]
    public partial class GovernmentOrganization : Organization, IGovernmentOrganization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GovernmentOrganization";
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Organization: Non-governmental Organization.
    /// </summary>
    public partial interface INGO : IOrganization
    {
    }

    /// <summary>
    /// Organization: Non-governmental Organization.
    /// </summary>
    [DataContract]
    public partial class NGO : Organization, INGO
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NGO";
    }
}

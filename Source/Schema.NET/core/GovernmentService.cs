namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    /// </summary>
    public partial interface IGovernmentService : IService
    {
        /// <summary>
        /// The operating organization, if different from the provider.  This enables the representation of services that are provided by an organization, but operated by another organization like a subcontractor.
        /// </summary>
        OneOrMany<IOrganization> ServiceOperator { get; set; }
    }

    /// <summary>
    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    /// </summary>
    [DataContract]
    public partial class GovernmentService : Service, IGovernmentService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GovernmentService";

        /// <summary>
        /// The operating organization, if different from the provider.  This enables the representation of services that are provided by an organization, but operated by another organization like a subcontractor.
        /// </summary>
        [DataMember(Name = "serviceOperator", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> ServiceOperator { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A real-estate agent.
    /// </summary>
    public partial interface IRealEstateAgent : ILocalBusiness
    {
    }

    /// <summary>
    /// A real-estate agent.
    /// </summary>
    [DataContract]
    public partial class RealEstateAgent : LocalBusiness, IRealEstateAgent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RealEstateAgent";
    }
}

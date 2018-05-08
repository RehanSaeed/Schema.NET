namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Residence type: Gated community.
    /// </summary>
    public partial interface IGatedResidenceCommunity : IResidence
    {
    }

    /// <summary>
    /// Residence type: Gated community.
    /// </summary>
    [DataContract]
    public partial class GatedResidenceCommunity : Residence, IGatedResidenceCommunity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GatedResidenceCommunity";
    }
}

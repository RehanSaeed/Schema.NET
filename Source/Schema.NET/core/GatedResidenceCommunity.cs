namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Residence type: Gated community.
    /// </summary>
    [DataContract]
    public class GatedResidenceCommunity : Residence
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GatedResidenceCommunity";
    }
}

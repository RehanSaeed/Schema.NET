namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The frequency in MHz and the modulation used for a particular BroadcastService.
    /// </summary>
    [DataContract]
    public class BroadcastFrequencySpecification : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "BroadcastFrequencySpecification";
    }
}

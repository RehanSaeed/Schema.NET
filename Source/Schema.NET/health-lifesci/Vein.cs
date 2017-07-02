namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A type of blood vessel that specifically carries blood to the heart.
    /// </summary>
    [DataContract]
    public partial class Vein : Vessel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Vein";

        /// <summary>
        /// The vasculature that the vein drains into.
        /// </summary>
        [DataMember(Name = "drainsTo", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Vessel>? DrainsTo { get; set; }

        /// <summary>
        /// The anatomical or organ system drained by this vessel; generally refers to a specific part of an organ.
        /// </summary>
        [DataMember(Name = "regionDrained", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AnatomicalStructure, AnatomicalSystem>? RegionDrained { get; set; }

        /// <summary>
        /// The anatomical or organ system that the vein flows into; a larger structure that the vein connects to.
        /// </summary>
        [DataMember(Name = "tributary", Order = 408)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AnatomicalStructure>? Tributary { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A type of blood vessel that specifically carries lymph fluid unidirectionally toward the heart.
    /// </summary>
    [DataContract]
    public partial class LymphaticVessel : Vessel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LymphaticVessel";

        /// <summary>
        /// The vasculature the lymphatic structure originates, or afferents, from.
        /// </summary>
        [DataMember(Name = "originatesFrom", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Vessel>? OriginatesFrom { get; set; }

        /// <summary>
        /// The anatomical or organ system drained by this vessel; generally refers to a specific part of an organ.
        /// </summary>
        [DataMember(Name = "regionDrained", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AnatomicalStructure, AnatomicalSystem>? RegionDrained { get; set; }

        /// <summary>
        /// The vasculature the lymphatic structure runs, or efferents, to.
        /// </summary>
        [DataMember(Name = "runsTo", Order = 408)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Vessel>? RunsTo { get; set; }
    }
}

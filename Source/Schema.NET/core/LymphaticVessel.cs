namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A type of blood vessel that specifically carries lymph fluid unidirectionally toward the heart.
    /// </summary>
    public partial interface ILymphaticVessel : IVessel
    {
        /// <summary>
        /// The vasculature the lymphatic structure originates, or afferents, from.
        /// </summary>
        OneOrMany<IVessel> OriginatesFrom { get; set; }

        /// <summary>
        /// The anatomical or organ system drained by this vessel; generally refers to a specific part of an organ.
        /// </summary>
        Values<IAnatomicalStructure, IAnatomicalSystem>? RegionDrained { get; set; }

        /// <summary>
        /// The vasculature the lymphatic structure runs, or efferents, to.
        /// </summary>
        OneOrMany<IVessel> RunsTo { get; set; }
    }

    /// <summary>
    /// A type of blood vessel that specifically carries lymph fluid unidirectionally toward the heart.
    /// </summary>
    [DataContract]
    public partial class LymphaticVessel : Vessel, ILymphaticVessel
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IVessel> OriginatesFrom { get; set; }

        /// <summary>
        /// The anatomical or organ system drained by this vessel; generally refers to a specific part of an organ.
        /// </summary>
        [DataMember(Name = "regionDrained", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAnatomicalStructure, IAnatomicalSystem>? RegionDrained { get; set; }

        /// <summary>
        /// The vasculature the lymphatic structure runs, or efferents, to.
        /// </summary>
        [DataMember(Name = "runsTo", Order = 408)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IVessel> RunsTo { get; set; }
    }
}

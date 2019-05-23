namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A common pathway for the electrochemical nerve impulses that are transmitted along each of the axons.
    /// </summary>
    public partial interface INerve : IAnatomicalStructure
    {
        /// <summary>
        /// The neurological pathway extension that involves muscle control.
        /// </summary>
        OneOrMany<IMuscle> NerveMotor { get; set; }

        /// <summary>
        /// The neurological pathway extension that inputs and sends information to the brain or spinal cord.
        /// </summary>
        Values<IAnatomicalStructure, ISuperficialAnatomy>? SensoryUnit { get; set; }

        /// <summary>
        /// The neurological pathway that originates the neurons.
        /// </summary>
        OneOrMany<IBrainStructure> SourcedFrom { get; set; }
    }

    /// <summary>
    /// A common pathway for the electrochemical nerve impulses that are transmitted along each of the axons.
    /// </summary>
    [DataContract]
    public partial class Nerve : AnatomicalStructure, INerve
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Nerve";

        /// <summary>
        /// The neurological pathway extension that involves muscle control.
        /// </summary>
        [DataMember(Name = "nerveMotor", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMuscle> NerveMotor { get; set; }

        /// <summary>
        /// The neurological pathway extension that inputs and sends information to the brain or spinal cord.
        /// </summary>
        [DataMember(Name = "sensoryUnit", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAnatomicalStructure, ISuperficialAnatomy>? SensoryUnit { get; set; }

        /// <summary>
        /// The neurological pathway that originates the neurons.
        /// </summary>
        [DataMember(Name = "sourcedFrom", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IBrainStructure> SourcedFrom { get; set; }
    }
}

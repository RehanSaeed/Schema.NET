namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A muscle is an anatomical structure consisting of a contractile form of tissue that animals use to effect movement.
    /// </summary>
    [DataContract]
    public partial class Muscle : AnatomicalStructure
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Muscle";

        /// <summary>
        /// Obsolete term for &lt;a class="localLink" href="http://schema.org/muscleAction"&gt;muscleAction&lt;/a&gt;. Not to be confused with &lt;a class="localLink" href="http://schema.org/potentialAction"&gt;potentialAction&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "action", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Action { get; set; }

        /// <summary>
        /// The muscle whose action counteracts the specified muscle.
        /// </summary>
        [DataMember(Name = "antagonist", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Muscle>? Antagonist { get; set; }

        /// <summary>
        /// The blood vessel that carries blood from the heart to the muscle.
        /// </summary>
        [DataMember(Name = "bloodSupply", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Vessel>? BloodSupply { get; set; }

        /// <summary>
        /// The place of attachment of a muscle, or what the muscle moves.
        /// </summary>
        [DataMember(Name = "insertion", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AnatomicalStructure>? Insertion { get; set; }

        /// <summary>
        /// The movement the muscle generates.
        /// </summary>
        [DataMember(Name = "muscleAction", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? MuscleAction { get; set; }

        /// <summary>
        /// The underlying innervation associated with the muscle.
        /// </summary>
        [DataMember(Name = "nerve", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Nerve>? Nerve { get; set; }

        /// <summary>
        /// The place or point where a muscle arises.
        /// </summary>
        [DataMember(Name = "origin", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AnatomicalStructure>? Origin { get; set; }
    }
}

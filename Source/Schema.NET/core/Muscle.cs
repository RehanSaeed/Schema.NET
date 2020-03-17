namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A muscle is an anatomical structure consisting of a contractile form of tissue that animals use to effect movement.
    /// </summary>
    public partial interface IMuscle : IAnatomicalStructure
    {
        /// <summary>
        /// The muscle whose action counteracts the specified muscle.
        /// </summary>
        OneOrMany<IMuscle> Antagonist { get; set; }

        /// <summary>
        /// The blood vessel that carries blood from the heart to the muscle.
        /// </summary>
        OneOrMany<IVessel> BloodSupply { get; set; }

        /// <summary>
        /// The place of attachment of a muscle, or what the muscle moves.
        /// </summary>
        OneOrMany<IAnatomicalStructure> Insertion { get; set; }

        /// <summary>
        /// The movement the muscle generates.
        /// </summary>
        OneOrMany<string> MuscleAction { get; set; }

        /// <summary>
        /// The underlying innervation associated with the muscle.
        /// </summary>
        OneOrMany<INerve> Nerve { get; set; }
    }

    /// <summary>
    /// A muscle is an anatomical structure consisting of a contractile form of tissue that animals use to effect movement.
    /// </summary>
    [DataContract]
    public partial class Muscle : AnatomicalStructure, IMuscle, IEquatable<Muscle>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Muscle";

        /// <summary>
        /// The muscle whose action counteracts the specified muscle.
        /// </summary>
        [DataMember(Name = "antagonist", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMuscle> Antagonist { get; set; }

        /// <summary>
        /// The blood vessel that carries blood from the heart to the muscle.
        /// </summary>
        [DataMember(Name = "bloodSupply", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IVessel> BloodSupply { get; set; }

        /// <summary>
        /// The place of attachment of a muscle, or what the muscle moves.
        /// </summary>
        [DataMember(Name = "insertion", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAnatomicalStructure> Insertion { get; set; }

        /// <summary>
        /// The movement the muscle generates.
        /// </summary>
        [DataMember(Name = "muscleAction", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> MuscleAction { get; set; }

        /// <summary>
        /// The underlying innervation associated with the muscle.
        /// </summary>
        [DataMember(Name = "nerve", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<INerve> Nerve { get; set; }

        /// <inheritdoc/>
        public bool Equals(Muscle other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.Antagonist == other.Antagonist &&
                this.BloodSupply == other.BloodSupply &&
                this.Insertion == other.Insertion &&
                this.MuscleAction == other.MuscleAction &&
                this.Nerve == other.Nerve &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Muscle);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Antagonist)
            .And(this.BloodSupply)
            .And(this.Insertion)
            .And(this.MuscleAction)
            .And(this.Nerve)
            .And(base.GetHashCode());
    }
}

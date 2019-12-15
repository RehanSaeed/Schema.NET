namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A stage of a medical condition, such as 'Stage IIIa'.
    /// </summary>
    public partial interface IMedicalConditionStage : IMedicalIntangible
    {
        /// <summary>
        /// The stage represented as a number, e.g. 3.
        /// </summary>
        OneOrMany<double?> StageAsNumber { get; set; }

        /// <summary>
        /// The substage, e.g. 'a' for Stage IIIa.
        /// </summary>
        OneOrMany<string> SubStageSuffix { get; set; }
    }

    /// <summary>
    /// A stage of a medical condition, such as 'Stage IIIa'.
    /// </summary>
    [DataContract]
    public partial class MedicalConditionStage : MedicalIntangible, IMedicalConditionStage, IEquatable<MedicalConditionStage>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalConditionStage";

        /// <summary>
        /// The stage represented as a number, e.g. 3.
        /// </summary>
        [DataMember(Name = "stageAsNumber", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> StageAsNumber { get; set; }

        /// <summary>
        /// The substage, e.g. 'a' for Stage IIIa.
        /// </summary>
        [DataMember(Name = "subStageSuffix", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SubStageSuffix { get; set; }

        /// <inheritdoc/>
        public bool Equals(MedicalConditionStage other)
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
                this.StageAsNumber == other.StageAsNumber &&
                this.SubStageSuffix == other.SubStageSuffix &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalConditionStage);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.StageAsNumber)
            .And(this.SubStageSuffix)
            .And(base.GetHashCode());
    }
}

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
        OneOrMany<double?>? StageAsNumber { get; set; }

        /// <summary>
        /// The substage, e.g. 'a' for Stage IIIa.
        /// </summary>
        OneOrMany<string>? SubStageSuffix { get; set; }
    }

    /// <summary>
    /// A stage of a medical condition, such as 'Stage IIIa'.
    /// </summary>
    [DataContract]
    public partial class MedicalConditionStage : MedicalIntangible, IMedicalConditionStage
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
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<double?>? StageAsNumber { get; set; }

        /// <summary>
        /// The substage, e.g. 'a' for Stage IIIa.
        /// </summary>
        [DataMember(Name = "subStageSuffix", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? SubStageSuffix { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
    public partial interface IDiet : ICreativeWorkAndLifestyleModification
    {
        /// <summary>
        /// Nutritional information specific to the dietary plan. May include dietary recommendations on what foods to avoid, what foods to consume, and specific alterations/deviations from the USDA or other regulatory body's approved dietary guidelines.
        /// </summary>
        OneOrMany<string> DietFeatures { get; set; }

        /// <summary>
        /// People or organizations that endorse the plan.
        /// </summary>
        Values<IOrganization, IPerson> Endorsers { get; set; }

        /// <summary>
        /// Medical expert advice related to the plan.
        /// </summary>
        OneOrMany<string> ExpertConsiderations { get; set; }

        /// <summary>
        /// Specific physiologic benefits associated to the plan.
        /// </summary>
        OneOrMany<string> PhysiologicalBenefits { get; set; }

        /// <summary>
        /// Specific physiologic risks associated to the diet plan.
        /// </summary>
        OneOrMany<string> Risks { get; set; }
    }

    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
    [DataContract]
    public partial class Diet : CreativeWorkAndLifestyleModification, IDiet, IEquatable<Diet>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Diet";

        /// <summary>
        /// Nutritional information specific to the dietary plan. May include dietary recommendations on what foods to avoid, what foods to consume, and specific alterations/deviations from the USDA or other regulatory body's approved dietary guidelines.
        /// </summary>
        [DataMember(Name = "dietFeatures", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> DietFeatures { get; set; }

        /// <summary>
        /// People or organizations that endorse the plan.
        /// </summary>
        [DataMember(Name = "endorsers", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Endorsers { get; set; }

        /// <summary>
        /// Medical expert advice related to the plan.
        /// </summary>
        [DataMember(Name = "expertConsiderations", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ExpertConsiderations { get; set; }

        /// <summary>
        /// Specific physiologic benefits associated to the plan.
        /// </summary>
        [DataMember(Name = "physiologicalBenefits", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PhysiologicalBenefits { get; set; }

        /// <summary>
        /// Specific physiologic risks associated to the diet plan.
        /// </summary>
        [DataMember(Name = "risks", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Risks { get; set; }

        /// <inheritdoc/>
        public bool Equals(Diet other)
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
                this.DietFeatures == other.DietFeatures &&
                this.Endorsers == other.Endorsers &&
                this.ExpertConsiderations == other.ExpertConsiderations &&
                this.PhysiologicalBenefits == other.PhysiologicalBenefits &&
                this.Risks == other.Risks &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Diet);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.DietFeatures)
            .And(this.Endorsers)
            .And(this.ExpertConsiderations)
            .And(this.PhysiologicalBenefits)
            .And(this.Risks)
            .And(base.GetHashCode());
    }
}

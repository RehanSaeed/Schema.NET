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
        Values<IOrganization, IPerson>? Endorsers { get; set; }

        /// <summary>
        /// Medical expert advice related to the plan.
        /// </summary>
        OneOrMany<string> ExpertConsiderations { get; set; }

        /// <summary>
        /// Descriptive information establishing the overarching theory/philosophy of the plan. May include the rationale for the name, the population where the plan first came to prominence, etc.
        /// </summary>
        OneOrMany<string> Overview { get; set; }

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
    public partial class Diet : CreativeWorkAndLifestyleModification, IDiet
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
        public Values<IOrganization, IPerson>? Endorsers { get; set; }

        /// <summary>
        /// Medical expert advice related to the plan.
        /// </summary>
        [DataMember(Name = "expertConsiderations", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ExpertConsiderations { get; set; }

        /// <summary>
        /// Descriptive information establishing the overarching theory/philosophy of the plan. May include the rationale for the name, the population where the plan first came to prominence, etc.
        /// </summary>
        [DataMember(Name = "overview", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Overview { get; set; }

        /// <summary>
        /// Specific physiologic benefits associated to the plan.
        /// </summary>
        [DataMember(Name = "physiologicalBenefits", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PhysiologicalBenefits { get; set; }

        /// <summary>
        /// Specific physiologic risks associated to the diet plan.
        /// </summary>
        [DataMember(Name = "risks", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Risks { get; set; }
    }
}

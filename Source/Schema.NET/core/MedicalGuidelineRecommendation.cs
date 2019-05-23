namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A guideline recommendation that is regarded as efficacious and where quality of the data supporting the recommendation is sound.
    /// </summary>
    public partial interface IMedicalGuidelineRecommendation : IMedicalGuideline
    {
        /// <summary>
        /// Strength of the guideline's recommendation (e.g. 'class I').
        /// </summary>
        OneOrMany<string> RecommendationStrength { get; set; }
    }

    /// <summary>
    /// A guideline recommendation that is regarded as efficacious and where quality of the data supporting the recommendation is sound.
    /// </summary>
    [DataContract]
    public partial class MedicalGuidelineRecommendation : MedicalGuideline, IMedicalGuidelineRecommendation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalGuidelineRecommendation";

        /// <summary>
        /// Strength of the guideline's recommendation (e.g. 'class I').
        /// </summary>
        [DataMember(Name = "recommendationStrength", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> RecommendationStrength { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A guideline recommendation that is regarded as efficacious and where quality of the data supporting the recommendation is sound.
    /// </summary>
    [DataContract]
    public partial class MedicalGuidelineRecommendation : MedicalGuideline
    {
        public interface IRecommendationStrength : IValue {}
        public interface IRecommendationStrength<T> : IRecommendationStrength { new T Value { get; } }
        public class OneOrManyRecommendationStrength : OneOrMany<IRecommendationStrength>
        {
            public OneOrManyRecommendationStrength(IRecommendationStrength item) : base(item) { }
            public OneOrManyRecommendationStrength(IEnumerable<IRecommendationStrength> items) : base(items) { }
            public static implicit operator OneOrManyRecommendationStrength (string value) { return new OneOrManyRecommendationStrength (new RecommendationStrengthstring (value)); }
            public static implicit operator OneOrManyRecommendationStrength (string[] values) { return new OneOrManyRecommendationStrength (values.Select(v => (IRecommendationStrength) new RecommendationStrengthstring (v))); }
            public static implicit operator OneOrManyRecommendationStrength (List<string> values) { return new OneOrManyRecommendationStrength (values.Select(v => (IRecommendationStrength) new RecommendationStrengthstring (v))); }
        }
        public struct RecommendationStrengthstring : IRecommendationStrength<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public RecommendationStrengthstring (string value) { Value = value; }
            public static implicit operator RecommendationStrengthstring (string value) { return new RecommendationStrengthstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalGuidelineRecommendation";

        /// <summary>
        /// Strength of the guideline's recommendation (e.g. 'class I').
        /// </summary>
        [DataMember(Name = "recommendationStrength", Order = 306)]
        public OneOrManyRecommendationStrength RecommendationStrength { get; set; }
    }
}

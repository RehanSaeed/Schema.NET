namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
    [DataContract]
    public partial class PeopleAudience : Audience
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PeopleAudience";

        /// <summary>
        /// Specifying the health condition(s) of a patient, medical study, or other target audience.
        /// </summary>
        [DataMember(Name = "healthCondition", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<MedicalCondition>? HealthCondition { get; set; }

        /// <summary>
        /// Audiences defined by a person's gender.
        /// </summary>
        [DataMember(Name = "requiredGender", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? RequiredGender { get; set; }

        /// <summary>
        /// Audiences defined by a person's maximum age.
        /// </summary>
        [DataMember(Name = "requiredMaxAge", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? RequiredMaxAge { get; set; }

        /// <summary>
        /// Audiences defined by a person's minimum age.
        /// </summary>
        [DataMember(Name = "requiredMinAge", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? RequiredMinAge { get; set; }

        /// <summary>
        /// The gender of the person or audience.
        /// </summary>
        [DataMember(Name = "suggestedGender", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? SuggestedGender { get; set; }

        /// <summary>
        /// Maximal age recommended for viewing content.
        /// </summary>
        [DataMember(Name = "suggestedMaxAge", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? SuggestedMaxAge { get; set; }

        /// <summary>
        /// Minimal age recommended for viewing content.
        /// </summary>
        [DataMember(Name = "suggestedMinAge", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? SuggestedMinAge { get; set; }
    }
}

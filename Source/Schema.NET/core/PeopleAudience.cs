namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
    public partial interface IPeopleAudience : IAudience
    {
        /// <summary>
        /// Specifying the health condition(s) of a patient, medical study, or other target audience.
        /// </summary>
        OneOrMany<IMedicalCondition> HealthCondition { get; set; }

        /// <summary>
        /// Audiences defined by a person's gender.
        /// </summary>
        OneOrMany<string> RequiredGender { get; set; }

        /// <summary>
        /// Audiences defined by a person's maximum age.
        /// </summary>
        OneOrMany<int?> RequiredMaxAge { get; set; }

        /// <summary>
        /// Audiences defined by a person's minimum age.
        /// </summary>
        OneOrMany<int?> RequiredMinAge { get; set; }

        /// <summary>
        /// The gender of the person or audience.
        /// </summary>
        OneOrMany<string> SuggestedGender { get; set; }

        /// <summary>
        /// Maximal age recommended for viewing content.
        /// </summary>
        OneOrMany<int?> SuggestedMaxAge { get; set; }

        /// <summary>
        /// Minimal age recommended for viewing content.
        /// </summary>
        OneOrMany<int?> SuggestedMinAge { get; set; }
    }

    /// <summary>
    /// A set of characteristics belonging to people, e.g. who compose an item's target audience.
    /// </summary>
    [DataContract]
    public partial class PeopleAudience : Audience, IPeopleAudience, IEquatable<PeopleAudience>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IMedicalCondition> HealthCondition { get; set; }

        /// <summary>
        /// Audiences defined by a person's gender.
        /// </summary>
        [DataMember(Name = "requiredGender", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> RequiredGender { get; set; }

        /// <summary>
        /// Audiences defined by a person's maximum age.
        /// </summary>
        [DataMember(Name = "requiredMaxAge", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> RequiredMaxAge { get; set; }

        /// <summary>
        /// Audiences defined by a person's minimum age.
        /// </summary>
        [DataMember(Name = "requiredMinAge", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> RequiredMinAge { get; set; }

        /// <summary>
        /// The gender of the person or audience.
        /// </summary>
        [DataMember(Name = "suggestedGender", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SuggestedGender { get; set; }

        /// <summary>
        /// Maximal age recommended for viewing content.
        /// </summary>
        [DataMember(Name = "suggestedMaxAge", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> SuggestedMaxAge { get; set; }

        /// <summary>
        /// Minimal age recommended for viewing content.
        /// </summary>
        [DataMember(Name = "suggestedMinAge", Order = 312)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> SuggestedMinAge { get; set; }

        /// <inheritdoc/>
        public bool Equals(PeopleAudience other)
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
                this.HealthCondition == other.HealthCondition &&
                this.RequiredGender == other.RequiredGender &&
                this.RequiredMaxAge == other.RequiredMaxAge &&
                this.RequiredMinAge == other.RequiredMinAge &&
                this.SuggestedGender == other.SuggestedGender &&
                this.SuggestedMaxAge == other.SuggestedMaxAge &&
                this.SuggestedMinAge == other.SuggestedMinAge &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as PeopleAudience);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.HealthCondition)
            .And(this.RequiredGender)
            .And(this.RequiredMaxAge)
            .And(this.RequiredMinAge)
            .And(this.SuggestedGender)
            .And(this.SuggestedMaxAge)
            .And(this.SuggestedMinAge)
            .And(base.GetHashCode());
    }
}

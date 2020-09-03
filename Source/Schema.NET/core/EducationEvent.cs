namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Education event.
    /// </summary>
    public partial interface IEducationEvent : IEvent
    {
        /// <summary>
        /// The item being described is intended to assess the competency or learning outcome defined by the referenced term.
        /// </summary>
        OneOrMany<string> Assesses { get; set; }

        /// <summary>
        /// The level in terms of progression through an educational or training context. Examples of educational levels include 'beginner', 'intermediate' or 'advanced', and formal sets of level indicators.
        /// </summary>
        Values<string, Uri> EducationalLevel { get; set; }

        /// <summary>
        /// The item being described is intended to help a person learn the competency or learning outcome defined by the referenced term.
        /// </summary>
        OneOrMany<string> Teaches { get; set; }
    }

    /// <summary>
    /// Event type: Education event.
    /// </summary>
    [DataContract]
    public partial class EducationEvent : Event, IEducationEvent, IEquatable<EducationEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EducationEvent";

        /// <summary>
        /// The item being described is intended to assess the competency or learning outcome defined by the referenced term.
        /// </summary>
        [DataMember(Name = "assesses", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Assesses { get; set; }

        /// <summary>
        /// The level in terms of progression through an educational or training context. Examples of educational levels include 'beginner', 'intermediate' or 'advanced', and formal sets of level indicators.
        /// </summary>
        [DataMember(Name = "educationalLevel", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> EducationalLevel { get; set; }

        /// <summary>
        /// The item being described is intended to help a person learn the competency or learning outcome defined by the referenced term.
        /// </summary>
        [DataMember(Name = "teaches", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Teaches { get; set; }

        /// <inheritdoc/>
        public bool Equals(EducationEvent other)
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
                this.Assesses == other.Assesses &&
                this.EducationalLevel == other.EducationalLevel &&
                this.Teaches == other.Teaches &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as EducationEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Assesses)
            .And(this.EducationalLevel)
            .And(this.Teaches)
            .And(base.GetHashCode());
    }
}

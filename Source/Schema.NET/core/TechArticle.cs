namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    /// </summary>
    public partial interface ITechArticle : IArticle
    {
        /// <summary>
        /// Prerequisites needed to fulfill steps in article.
        /// </summary>
        OneOrMany<string> Dependencies { get; set; }

        /// <summary>
        /// Proficiency needed for this content; expected values: 'Beginner', 'Expert'.
        /// </summary>
        OneOrMany<string> ProficiencyLevel { get; set; }
    }

    /// <summary>
    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    /// </summary>
    [DataContract]
    public partial class TechArticle : Article, ITechArticle, IEquatable<TechArticle>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TechArticle";

        /// <summary>
        /// Prerequisites needed to fulfill steps in article.
        /// </summary>
        [DataMember(Name = "dependencies", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Dependencies { get; set; }

        /// <summary>
        /// Proficiency needed for this content; expected values: 'Beginner', 'Expert'.
        /// </summary>
        [DataMember(Name = "proficiencyLevel", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProficiencyLevel { get; set; }

        /// <inheritdoc/>
        public bool Equals(TechArticle other)
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
                this.Dependencies == other.Dependencies &&
                this.ProficiencyLevel == other.ProficiencyLevel &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as TechArticle);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Dependencies)
            .And(this.ProficiencyLevel)
            .And(base.GetHashCode());
    }
}

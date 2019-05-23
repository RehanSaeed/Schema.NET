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
    public partial class TechArticle : Article, ITechArticle
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
    }
}

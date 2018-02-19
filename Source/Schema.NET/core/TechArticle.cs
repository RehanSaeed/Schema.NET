using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A technical article - Example: How-to (task) topics, step-by-step, procedural troubleshooting, specifications, etc.
    /// </summary>
    [DataContract]
    public partial class TechArticle : Article
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Dependencies { get; set; } 

        /// <summary>
        /// Proficiency needed for this content; expected values: 'Beginner', 'Expert'.
        /// </summary>
        [DataMember(Name = "proficiencyLevel", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ProficiencyLevel { get; set; } 
    }
}

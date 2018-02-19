using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// </summary>
    [DataContract]
    public partial class AlignmentObject : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AlignmentObject";

        /// <summary>
        /// A category of alignment between the learning resource and the framework node. Recommended values include: 'assesses', 'teaches', 'requires', 'textComplexity', 'readingLevel', 'educationalSubject', and 'educationalLevel'.
        /// </summary>
        [DataMember(Name = "alignmentType", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AlignmentType { get; set; } 

        /// <summary>
        /// The framework to which the resource being described is aligned.
        /// </summary>
        [DataMember(Name = "educationalFramework", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? EducationalFramework { get; set; } 

        /// <summary>
        /// The description of a node in an established educational framework.
        /// </summary>
        [DataMember(Name = "targetDescription", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TargetDescription { get; set; } 

        /// <summary>
        /// The name of a node in an established educational framework.
        /// </summary>
        [DataMember(Name = "targetName", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? TargetName { get; set; } 

        /// <summary>
        /// The URL of a node in an established educational framework.
        /// </summary>
        [DataMember(Name = "targetUrl", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? TargetUrl { get; set; } 
    }
}

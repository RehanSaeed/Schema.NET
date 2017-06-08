namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.
    /// </summary>
    [DataContract]
    public class AlignmentObject : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "AlignmentObject";

        /// <summary>
        /// The description of a node in an established educational framework.
        /// </summary>
        [DataMember(Name = "targetDescription")]
        public string TargetDescription { get; set; }

        /// <summary>
        /// The URL of a node in an established educational framework.
        /// </summary>
        [DataMember(Name = "targetUrl")]
        public Uri TargetUrl { get; set; }

        /// <summary>
        /// The name of a node in an established educational framework.
        /// </summary>
        [DataMember(Name = "targetName")]
        public string TargetName { get; set; }

        /// <summary>
        /// A category of alignment between the learning resource and the framework node. Recommended values include: 'assesses', 'teaches', 'requires', 'textComplexity', 'readingLevel', 'educationalSubject', and 'educationalLevel'.
        /// </summary>
        [DataMember(Name = "alignmentType")]
        public string AlignmentType { get; set; }

        /// <summary>
        /// The framework to which the resource being described is aligned.
        /// </summary>
        [DataMember(Name = "educationalFramework")]
        public string EducationalFramework { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.&lt;br/&gt;&lt;br/&gt;
    /// Should not be used where the nature of the alignment can be described using a simple property, for example to express that a resource &lt;a class="localLink" href="https://schema.org/teaches"&gt;teaches&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/assesses"&gt;assesses&lt;/a&gt; a competency.
    /// </summary>
    public partial interface IAlignmentObject : IIntangible
    {
        /// <summary>
        /// A category of alignment between the learning resource and the framework node. Recommended values include: 'requires', 'textComplexity', 'readingLevel', and 'educationalSubject'.
        /// </summary>
        OneOrMany<string> AlignmentType { get; set; }

        /// <summary>
        /// The framework to which the resource being described is aligned.
        /// </summary>
        OneOrMany<string> EducationalFramework { get; set; }

        /// <summary>
        /// The description of a node in an established educational framework.
        /// </summary>
        OneOrMany<string> TargetDescription { get; set; }

        /// <summary>
        /// The name of a node in an established educational framework.
        /// </summary>
        OneOrMany<string> TargetName { get; set; }

        /// <summary>
        /// The URL of a node in an established educational framework.
        /// </summary>
        OneOrMany<Uri> TargetUrl { get; set; }
    }

    /// <summary>
    /// An intangible item that describes an alignment between a learning resource and a node in an educational framework.&lt;br/&gt;&lt;br/&gt;
    /// Should not be used where the nature of the alignment can be described using a simple property, for example to express that a resource &lt;a class="localLink" href="https://schema.org/teaches"&gt;teaches&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/assesses"&gt;assesses&lt;/a&gt; a competency.
    /// </summary>
    [DataContract]
    public partial class AlignmentObject : Intangible, IAlignmentObject, IEquatable<AlignmentObject>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AlignmentObject";

        /// <summary>
        /// A category of alignment between the learning resource and the framework node. Recommended values include: 'requires', 'textComplexity', 'readingLevel', and 'educationalSubject'.
        /// </summary>
        [DataMember(Name = "alignmentType", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AlignmentType { get; set; }

        /// <summary>
        /// The framework to which the resource being described is aligned.
        /// </summary>
        [DataMember(Name = "educationalFramework", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> EducationalFramework { get; set; }

        /// <summary>
        /// The description of a node in an established educational framework.
        /// </summary>
        [DataMember(Name = "targetDescription", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TargetDescription { get; set; }

        /// <summary>
        /// The name of a node in an established educational framework.
        /// </summary>
        [DataMember(Name = "targetName", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TargetName { get; set; }

        /// <summary>
        /// The URL of a node in an established educational framework.
        /// </summary>
        [DataMember(Name = "targetUrl", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> TargetUrl { get; set; }

        /// <inheritdoc/>
        public bool Equals(AlignmentObject other)
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
                this.AlignmentType == other.AlignmentType &&
                this.EducationalFramework == other.EducationalFramework &&
                this.TargetDescription == other.TargetDescription &&
                this.TargetName == other.TargetName &&
                this.TargetUrl == other.TargetUrl &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as AlignmentObject);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AlignmentType)
            .And(this.EducationalFramework)
            .And(this.TargetDescription)
            .And(this.TargetName)
            .And(this.TargetUrl)
            .And(base.GetHashCode());
    }
}

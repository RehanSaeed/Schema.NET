namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.&lt;br/&gt;&lt;br/&gt;
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// </summary>
    public partial interface IPublicationIssue : ICreativeWork
    {
        /// <summary>
        /// Identifies the issue of publication; for example, "iii" or "2".
        /// </summary>
        Values<int?, string> IssueNumber { get; set; }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        Values<int?, string> PageEnd { get; set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        Values<int?, string> PageStart { get; set; }

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        OneOrMany<string> Pagination { get; set; }
    }

    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles.&lt;br/&gt;&lt;br/&gt;
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class PublicationIssue : CreativeWork, IPublicationIssue, IEquatable<PublicationIssue>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PublicationIssue";

        /// <summary>
        /// Identifies the issue of publication; for example, "iii" or "2".
        /// </summary>
        [DataMember(Name = "issueNumber", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> IssueNumber { get; set; }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [DataMember(Name = "pageEnd", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> PageEnd { get; set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [DataMember(Name = "pageStart", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> PageStart { get; set; }

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [DataMember(Name = "pagination", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Pagination { get; set; }

        /// <inheritdoc/>
        public bool Equals(PublicationIssue other)
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
                this.IssueNumber == other.IssueNumber &&
                this.PageEnd == other.PageEnd &&
                this.PageStart == other.PageStart &&
                this.Pagination == other.Pagination &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as PublicationIssue);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.IssueNumber)
            .And(this.PageEnd)
            .And(this.PageStart)
            .And(this.Pagination)
            .And(base.GetHashCode());
    }
}

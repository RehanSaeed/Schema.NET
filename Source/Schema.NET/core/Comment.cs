namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the &lt;a class="localLink" href="https://schema.org/text"&gt;text&lt;/a&gt; property, and its topic via &lt;a class="localLink" href="https://schema.org/about"&gt;about&lt;/a&gt;, properties shared with all CreativeWorks.
    /// </summary>
    public partial interface IComment : ICreativeWork
    {
        /// <summary>
        /// The number of downvotes this question, answer or comment has received from the community.
        /// </summary>
        OneOrMany<int?> DownvoteCount { get; set; }

        /// <summary>
        /// The parent of a question, answer or item in general.
        /// </summary>
        OneOrMany<IQuestion> ParentItem { get; set; }

        /// <summary>
        /// The number of upvotes this question, answer or comment has received from the community.
        /// </summary>
        OneOrMany<int?> UpvoteCount { get; set; }
    }

    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the &lt;a class="localLink" href="https://schema.org/text"&gt;text&lt;/a&gt; property, and its topic via &lt;a class="localLink" href="https://schema.org/about"&gt;about&lt;/a&gt;, properties shared with all CreativeWorks.
    /// </summary>
    [DataContract]
    public partial class Comment : CreativeWork, IComment, IEquatable<Comment>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Comment";

        /// <summary>
        /// The number of downvotes this question, answer or comment has received from the community.
        /// </summary>
        [DataMember(Name = "downvoteCount", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> DownvoteCount { get; set; }

        /// <summary>
        /// The parent of a question, answer or item in general.
        /// </summary>
        [DataMember(Name = "parentItem", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuestion> ParentItem { get; set; }

        /// <summary>
        /// The number of upvotes this question, answer or comment has received from the community.
        /// </summary>
        [DataMember(Name = "upvoteCount", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> UpvoteCount { get; set; }

        /// <inheritdoc/>
        public bool Equals(Comment other)
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
                this.DownvoteCount == other.DownvoteCount &&
                this.ParentItem == other.ParentItem &&
                this.UpvoteCount == other.UpvoteCount &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Comment);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.DownvoteCount)
            .And(this.ParentItem)
            .And(this.UpvoteCount)
            .And(base.GetHashCode());
    }
}

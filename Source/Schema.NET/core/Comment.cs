namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the text property, and its topic via about, properties shared with all CreativeWorks.
    /// </summary>
    [DataContract]
    public partial class Comment : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Comment";

        /// <summary>
        /// The number of downvotes this question, answer or comment has received from the community.
        /// </summary>
        [DataMember(Name = "downvoteCount", Order = 204)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? DownvoteCount { get; set; }

        /// <summary>
        /// The parent of a question, answer or item in general.
        /// </summary>
        [DataMember(Name = "parentItem", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Question>? ParentItem { get; set; }

        /// <summary>
        /// The number of upvotes this question, answer or comment has received from the community.
        /// </summary>
        [DataMember(Name = "upvoteCount", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? UpvoteCount { get; set; }
    }
}

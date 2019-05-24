namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A post to a social media platform, including blog posts, tweets, Facebook posts, etc.
    /// </summary>
    public partial interface ISocialMediaPosting : IArticle
    {
        /// <summary>
        /// A CreativeWork such as an image, video, or audio clip shared as part of this posting.
        /// </summary>
        OneOrMany<ICreativeWork> SharedContent { get; set; }
    }

    /// <summary>
    /// A post to a social media platform, including blog posts, tweets, Facebook posts, etc.
    /// </summary>
    [DataContract]
    public partial class SocialMediaPosting : Article, ISocialMediaPosting
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SocialMediaPosting";

        /// <summary>
        /// A CreativeWork such as an image, video, or audio clip shared as part of this posting.
        /// </summary>
        [DataMember(Name = "sharedContent", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> SharedContent { get; set; }
    }
}

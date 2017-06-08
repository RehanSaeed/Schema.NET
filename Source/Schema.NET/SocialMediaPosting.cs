namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A post to a social media platform, including blog posts, tweets, Facebook posts, etc.
    /// </summary>
    [DataContract]
    public class SocialMediaPosting : Article
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "SocialMediaPosting";

        /// <summary>
        /// A CreativeWork such as an image, video, or audio clip shared as part of this posting.
        /// </summary>
        [DataMember(Name = "sharedContent")]
        public CreativeWork SharedContent { get; set; }
    }
}

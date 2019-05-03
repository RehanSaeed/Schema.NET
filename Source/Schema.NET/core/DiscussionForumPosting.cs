namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A posting to a discussion forum.
    /// </summary>
    [DataContract]
    public partial class DiscussionForumPosting : SocialMediaPosting
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DiscussionForumPosting";
    }
}

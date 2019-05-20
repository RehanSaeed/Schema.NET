namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A blog post.
    /// </summary>
    public partial interface IBlogPosting : ISocialMediaPosting
    {
    }

    /// <summary>
    /// A blog post.
    /// </summary>
    [DataContract]
    public partial class BlogPosting : SocialMediaPosting, IBlogPosting
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BlogPosting";
    }
}

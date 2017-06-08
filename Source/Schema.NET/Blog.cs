namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A blog.
    /// </summary>
    [DataContract]
    public class Blog : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Blog";

        /// <summary>
        /// A posting that is part of this blog.
        /// </summary>
        [DataMember(Name = "blogPost")]
        public BlogPosting BlogPost { get; set; }
    }
}

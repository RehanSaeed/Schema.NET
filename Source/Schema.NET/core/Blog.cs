namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A blog.
    /// </summary>
    public partial interface IBlog : ICreativeWork
    {
        /// <summary>
        /// A posting that is part of this blog.
        /// </summary>
        OneOrMany<IBlogPosting>? BlogPost { get; set; }

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        OneOrMany<string>? Issn { get; set; }
    }

    /// <summary>
    /// A blog.
    /// </summary>
    [DataContract]
    public partial class Blog : CreativeWork, IBlog
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Blog";

        /// <summary>
        /// A posting that is part of this blog.
        /// </summary>
        [DataMember(Name = "blogPost", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IBlogPosting>? BlogPost { get; set; }

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        [DataMember(Name = "issn", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Issn { get; set; }
    }
}

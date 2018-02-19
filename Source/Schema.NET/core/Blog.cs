using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A blog.
    /// </summary>
    [DataContract]
    public partial class Blog : CreativeWork
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
        public Values<BlogPosting>? BlogPost { get; set; } 

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        [DataMember(Name = "issn", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Issn { get; set; } 
    }
}

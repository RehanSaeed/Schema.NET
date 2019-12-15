﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A WebSite is a set of related web pages and other items typically served from a single web domain and accessible via URLs.
    /// </summary>
    public partial interface IWebSite : ICreativeWork
    {
        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        OneOrMany<string> Issn { get; set; }
    }

    /// <summary>
    /// A WebSite is a set of related web pages and other items typically served from a single web domain and accessible via URLs.
    /// </summary>
    [DataContract]
    public partial class WebSite : CreativeWork, IWebSite, IEquatable<WebSite>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebSite";

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        [DataMember(Name = "issn", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Issn { get; set; }

        /// <inheritdoc/>
        public bool Equals(WebSite other)
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
                this.Issn == other.Issn &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as WebSite);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Issn)
            .And(base.GetHashCode());
    }
}

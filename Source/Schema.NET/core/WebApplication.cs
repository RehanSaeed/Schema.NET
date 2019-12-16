namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Web applications.
    /// </summary>
    public partial interface IWebApplication : ISoftwareApplication
    {
        /// <summary>
        /// Specifies browser requirements in human-readable text. For example, 'requires HTML5 support'.
        /// </summary>
        OneOrMany<string> BrowserRequirements { get; set; }
    }

    /// <summary>
    /// Web applications.
    /// </summary>
    [DataContract]
    public partial class WebApplication : SoftwareApplication, IWebApplication, IEquatable<WebApplication>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebApplication";

        /// <summary>
        /// Specifies browser requirements in human-readable text. For example, 'requires HTML5 support'.
        /// </summary>
        [DataMember(Name = "browserRequirements", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BrowserRequirements { get; set; }

        /// <inheritdoc/>
        public bool Equals(WebApplication other)
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
                this.BrowserRequirements == other.BrowserRequirements &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as WebApplication);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.BrowserRequirements)
            .And(base.GetHashCode());
    }
}

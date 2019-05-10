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
        OneOrMany<string>? BrowserRequirements { get; set; }
    }

    /// <summary>
    /// Web applications.
    /// </summary>
    [DataContract]
    public partial class WebApplication : SoftwareApplication, IWebApplication
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
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? BrowserRequirements { get; set; }
    }
}

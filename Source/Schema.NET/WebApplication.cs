namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Web applications.
    /// </summary>
    [DataContract]
    public class WebApplication : SoftwareApplication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "WebApplication";

        /// <summary>
        /// Specifies browser requirements in human-readable text. For example, 'requires HTML5 support'.
        /// </summary>
        [DataMember(Name = "browserRequirements")]
        public string BrowserRequirements { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A software application designed specifically to work well on a mobile device such as a telephone.
    /// </summary>
    public partial interface IMobileApplication : ISoftwareApplication
    {
        /// <summary>
        /// Specifies specific carrier(s) requirements for the application (e.g. an application may only work on a specific carrier network).
        /// </summary>
        OneOrMany<string>? CarrierRequirements { get; set; }
    }

    /// <summary>
    /// A software application designed specifically to work well on a mobile device such as a telephone.
    /// </summary>
    [DataContract]
    public partial class MobileApplication : SoftwareApplication, IMobileApplication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MobileApplication";

        /// <summary>
        /// Specifies specific carrier(s) requirements for the application (e.g. an application may only work on a specific carrier network).
        /// </summary>
        [DataMember(Name = "carrierRequirements", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? CarrierRequirements { get; set; }
    }
}

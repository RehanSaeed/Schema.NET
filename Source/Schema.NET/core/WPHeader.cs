namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The header section of the page.
    /// </summary>
    public partial interface IWPHeader : IWebPageElement
    {
    }

    /// <summary>
    /// The header section of the page.
    /// </summary>
    [DataContract]
    public partial class WPHeader : WebPageElement, IWPHeader, IEquatable<WPHeader>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WPHeader";
    }
}

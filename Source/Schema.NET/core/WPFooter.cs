namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The footer section of the page.
    /// </summary>
    public partial interface IWPFooter : IWebPageElement
    {
    }

    /// <summary>
    /// The footer section of the page.
    /// </summary>
    [DataContract]
    public partial class WPFooter : WebPageElement, IWPFooter
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WPFooter";
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An advertising section of the page.
    /// </summary>
    public partial interface IWPAdBlock : IWebPageElement
    {
    }

    /// <summary>
    /// An advertising section of the page.
    /// </summary>
    [DataContract]
    public partial class WPAdBlock : WebPageElement, IWPAdBlock
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WPAdBlock";
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A navigation element of the page.
    /// </summary>
    public partial interface ISiteNavigationElement : IWebPageElement
    {
    }

    /// <summary>
    /// A navigation element of the page.
    /// </summary>
    [DataContract]
    public partial class SiteNavigationElement : WebPageElement, ISiteNavigationElement
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SiteNavigationElement";
    }
}

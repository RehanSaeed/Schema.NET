namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A sidebar section of the page.
    /// </summary>
    public partial interface IWPSideBar : IWebPageElement
    {
    }

    /// <summary>
    /// A sidebar section of the page.
    /// </summary>
    [DataContract]
    public partial class WPSideBar : WebPageElement, IWPSideBar
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WPSideBar";
    }
}

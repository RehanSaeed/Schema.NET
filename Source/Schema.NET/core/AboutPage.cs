namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Web page type: About page.
    /// </summary>
    public partial interface IAboutPage : IWebPage
    {
    }

    /// <summary>
    /// Web page type: About page.
    /// </summary>
    [DataContract]
    public partial class AboutPage : WebPage, IAboutPage, IEquatable<AboutPage>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AboutPage";
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A navigation element of the page.
    /// </summary>
    [DataContract]
    public class SiteNavigationElement : WebPageElement
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "SiteNavigationElement";
    }
}

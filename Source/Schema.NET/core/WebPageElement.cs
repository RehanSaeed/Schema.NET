namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A web page element, like a table or an image.
    /// </summary>
    public partial interface IWebPageElement : ICreativeWork
    {
    }

    /// <summary>
    /// A web page element, like a table or an image.
    /// </summary>
    [DataContract]
    public partial class WebPageElement : CreativeWork, IWebPageElement
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebPageElement";
    }
}

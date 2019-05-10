namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Web page type: Collection page.
    /// </summary>
    public partial interface ICollectionPage : IWebPage
    {
    }

    /// <summary>
    /// Web page type: Collection page.
    /// </summary>
    [DataContract]
    public partial class CollectionPage : WebPage, ICollectionPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CollectionPage";
    }
}

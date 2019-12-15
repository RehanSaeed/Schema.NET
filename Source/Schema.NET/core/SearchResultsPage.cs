namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Web page type: Search results page.
    /// </summary>
    public partial interface ISearchResultsPage : IWebPage
    {
    }

    /// <summary>
    /// Web page type: Search results page.
    /// </summary>
    [DataContract]
    public partial class SearchResultsPage : WebPage, ISearchResultsPage, IEquatable<SearchResultsPage>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SearchResultsPage";
    }
}

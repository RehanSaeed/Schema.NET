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

        /// <inheritdoc/>
        public bool Equals(SearchResultsPage other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as SearchResultsPage);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

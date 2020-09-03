namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.&lt;br/&gt;&lt;br/&gt;
    /// A more detailed overview of &lt;a href="/docs/news.html"&gt;schema.org News markup&lt;/a&gt; is also available.
    /// </summary>
    public partial interface INewsArticle : IArticle
    {
        /// <summary>
        /// A &lt;a href="https://en.wikipedia.org/wiki/Dateline"&gt;dateline&lt;/a&gt; is a brief piece of text included in news articles that describes where and when the story was written or filed though the date is often omitted. Sometimes only a placename is provided.&lt;br/&gt;&lt;br/&gt;
        /// Structured representations of dateline-related information can also be expressed more explicitly using &lt;a class="localLink" href="https://schema.org/locationCreated"&gt;locationCreated&lt;/a&gt; (which represents where a work was created e.g. where a news report was written).  For location depicted or described in the content, use &lt;a class="localLink" href="https://schema.org/contentLocation"&gt;contentLocation&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// Dateline summaries are oriented more towards human readers than towards automated processing, and can vary substantially. Some examples: "BEIRUT, Lebanon, June 2.", "Paris, France", "December 19, 2017 11:43AM Reporting from Washington", "Beijing/Moscow", "QUEZON CITY, Philippines".
        /// </summary>
        OneOrMany<string> Dateline { get; set; }

        /// <summary>
        /// The number of the column in which the NewsArticle appears in the print edition.
        /// </summary>
        OneOrMany<string> PrintColumn { get; set; }

        /// <summary>
        /// The edition of the print product in which the NewsArticle appears.
        /// </summary>
        OneOrMany<string> PrintEdition { get; set; }

        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).
        /// </summary>
        OneOrMany<string> PrintPage { get; set; }

        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the print section in which the article appeared.
        /// </summary>
        OneOrMany<string> PrintSection { get; set; }
    }

    /// <summary>
    /// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.&lt;br/&gt;&lt;br/&gt;
    /// A more detailed overview of &lt;a href="/docs/news.html"&gt;schema.org News markup&lt;/a&gt; is also available.
    /// </summary>
    [DataContract]
    public partial class NewsArticle : Article, INewsArticle, IEquatable<NewsArticle>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NewsArticle";

        /// <summary>
        /// A &lt;a href="https://en.wikipedia.org/wiki/Dateline"&gt;dateline&lt;/a&gt; is a brief piece of text included in news articles that describes where and when the story was written or filed though the date is often omitted. Sometimes only a placename is provided.&lt;br/&gt;&lt;br/&gt;
        /// Structured representations of dateline-related information can also be expressed more explicitly using &lt;a class="localLink" href="https://schema.org/locationCreated"&gt;locationCreated&lt;/a&gt; (which represents where a work was created e.g. where a news report was written).  For location depicted or described in the content, use &lt;a class="localLink" href="https://schema.org/contentLocation"&gt;contentLocation&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// Dateline summaries are oriented more towards human readers than towards automated processing, and can vary substantially. Some examples: "BEIRUT, Lebanon, June 2.", "Paris, France", "December 19, 2017 11:43AM Reporting from Washington", "Beijing/Moscow", "QUEZON CITY, Philippines".
        /// </summary>
        [DataMember(Name = "dateline", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Dateline { get; set; }

        /// <summary>
        /// The number of the column in which the NewsArticle appears in the print edition.
        /// </summary>
        [DataMember(Name = "printColumn", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PrintColumn { get; set; }

        /// <summary>
        /// The edition of the print product in which the NewsArticle appears.
        /// </summary>
        [DataMember(Name = "printEdition", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PrintEdition { get; set; }

        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).
        /// </summary>
        [DataMember(Name = "printPage", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PrintPage { get; set; }

        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the print section in which the article appeared.
        /// </summary>
        [DataMember(Name = "printSection", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PrintSection { get; set; }

        /// <inheritdoc/>
        public bool Equals(NewsArticle other)
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
                this.Dateline == other.Dateline &&
                this.PrintColumn == other.PrintColumn &&
                this.PrintEdition == other.PrintEdition &&
                this.PrintPage == other.PrintPage &&
                this.PrintSection == other.PrintSection &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as NewsArticle);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Dateline)
            .And(this.PrintColumn)
            .And(this.PrintEdition)
            .And(this.PrintPage)
            .And(this.PrintSection)
            .And(base.GetHashCode());
    }
}

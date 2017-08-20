namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.&lt;/p&gt;
    /// &lt;p&gt;A more detailed overview of &lt;a href="/docs/news.html"&gt;schema.org News markup&lt;/a&gt; is also available.
    /// </summary>
    [DataContract]
    public partial class NewsArticle : Article
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NewsArticle";

        /// <summary>
        /// A &lt;a href="https://en.wikipedia.org/wiki/Dateline"&gt;dateline&lt;/a&gt; is a brief piece of text included in news articles that describes where and when the story was written or filed though the date is often omitted. Sometimes only a placename is provided.
        /// </summary>
        [DataMember(Name = "dateline", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Dateline { get; set; }

        /// <summary>
        /// The number of the column in which the NewsArticle appears in the print edition.
        /// </summary>
        [DataMember(Name = "printColumn", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PrintColumn { get; set; }

        /// <summary>
        /// The edition of the print product in which the NewsArticle appears.
        /// </summary>
        [DataMember(Name = "printEdition", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PrintEdition { get; set; }

        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).
        /// </summary>
        [DataMember(Name = "printPage", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PrintPage { get; set; }

        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the print section in which the article appeared.
        /// </summary>
        [DataMember(Name = "printSection", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PrintSection { get; set; }
    }
}

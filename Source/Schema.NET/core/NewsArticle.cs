namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A news article.
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
        /// The location where the NewsArticle was produced.
        /// </summary>
        [DataMember(Name = "dateline", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Dateline { get; set; }

        /// <summary>
        /// The number of the column in which the NewsArticle appears in the print edition.
        /// </summary>
        [DataMember(Name = "printColumn", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PrintColumn { get; set; }

        /// <summary>
        /// The edition of the print product in which the NewsArticle appears.
        /// </summary>
        [DataMember(Name = "printEdition", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PrintEdition { get; set; }

        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).
        /// </summary>
        [DataMember(Name = "printPage", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PrintPage { get; set; }

        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the print section in which the article appeared.
        /// </summary>
        [DataMember(Name = "printSection", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PrintSection { get; set; }
    }
}

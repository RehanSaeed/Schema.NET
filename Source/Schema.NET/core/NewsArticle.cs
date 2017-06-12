namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A news article.
    /// </summary>
    [DataContract]
    public class NewsArticle : Article
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NewsArticle";

        /// <summary>
        /// The location where the NewsArticle was produced.
        /// </summary>
        [DataMember(Name = "dateline", Order = 2)]
        public string Dateline { get; set; }

        /// <summary>
        /// The number of the column in which the NewsArticle appears in the print edition.
        /// </summary>
        [DataMember(Name = "printColumn", Order = 3)]
        public string PrintColumn { get; set; }

        /// <summary>
        /// The edition of the print product in which the NewsArticle appears.
        /// </summary>
        [DataMember(Name = "printEdition", Order = 4)]
        public string PrintEdition { get; set; }

        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).
        /// </summary>
        [DataMember(Name = "printPage", Order = 5)]
        public string PrintPage { get; set; }

        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the print section in which the article appeared.
        /// </summary>
        [DataMember(Name = "printSection", Order = 6)]
        public string PrintSection { get; set; }
    }
}

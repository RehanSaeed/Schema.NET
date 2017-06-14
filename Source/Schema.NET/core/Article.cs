namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An article, such as a news article or piece of investigative report...
    /// </summary>
    [DataContract]
    public partial class Article : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Article";

        /// <summary>
        /// The actual body of the article.
        /// </summary>
        [DataMember(Name = "articleBody", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ArticleBody { get; set; }

        /// <summary>
        /// Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
        /// </summary>
        [DataMember(Name = "articleSection", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ArticleSection { get; set; }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [DataMember(Name = "pageEnd", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, int?>? PageEnd { get; set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [DataMember(Name = "pageStart", Order = 5)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, string>? PageStart { get; set; }

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [DataMember(Name = "pagination", Order = 6)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Pagination { get; set; }

        /// <summary>
        /// The number of words in the text of the Article.
        /// </summary>
        [DataMember(Name = "wordCount", Order = 7)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? WordCount { get; set; }
    }
}

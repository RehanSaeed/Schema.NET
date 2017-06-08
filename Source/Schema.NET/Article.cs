namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An article, such as a news article or piece of investigative report...
    /// </summary>
    [DataContract]
    public class Article : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Article";

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [DataMember(Name = "pagination")]
        public string Pagination { get; set; }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [DataMember(Name = "pageEnd")]
        public object PageEnd { get; protected set; }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [IgnoreDataMember]
        public string PageEndText
        {
            get => this.PageEnd as string;
            set => this.PageEnd = value;
        }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [IgnoreDataMember]
        public int? PageEndInteger
        {
            get => this.PageEnd as int?;
            set => this.PageEnd = value;
        }

        /// <summary>
        /// Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
        /// </summary>
        [DataMember(Name = "articleSection")]
        public string ArticleSection { get; set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [DataMember(Name = "pageStart")]
        public object PageStart { get; protected set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [IgnoreDataMember]
        public int? PageStartInteger
        {
            get => this.PageStart as int?;
            set => this.PageStart = value;
        }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [IgnoreDataMember]
        public string PageStartText
        {
            get => this.PageStart as string;
            set => this.PageStart = value;
        }

        /// <summary>
        /// The number of words in the text of the Article.
        /// </summary>
        [DataMember(Name = "wordCount")]
        public int WordCount { get; set; }

        /// <summary>
        /// The actual body of the article.
        /// </summary>
        [DataMember(Name = "articleBody")]
        public string ArticleBody { get; set; }
    }
}

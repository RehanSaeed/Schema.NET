namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.&lt;br/&gt;&lt;br/&gt;
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// </summary>
    public partial interface IArticle : ICreativeWork
    {
        /// <summary>
        /// The actual body of the article.
        /// </summary>
        OneOrMany<string> ArticleBody { get; set; }

        /// <summary>
        /// Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
        /// </summary>
        OneOrMany<string> ArticleSection { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="https://schema.org/Article"&gt;Article&lt;/a&gt;, typically a &lt;a class="localLink" href="https://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;, the backstory property provides a textual summary giving a brief explanation of why and how an article was created. In a journalistic setting this could include information about reporting process, methods, interviews, data sources, etc.
        /// </summary>
        Values<ICreativeWork, string> Backstory { get; set; }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        Values<int?, string> PageEnd { get; set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        Values<int?, string> PageStart { get; set; }

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        OneOrMany<string> Pagination { get; set; }

        /// <summary>
        /// Indicates sections of a Web page that are particularly 'speakable' in the sense of being highlighted as being especially appropriate for text-to-speech conversion. Other sections of a page may also be usefully spoken in particular circumstances; the 'speakable' property serves to indicate the parts most likely to be generally useful for speech.&lt;br/&gt;&lt;br/&gt;
        /// The &lt;em&gt;speakable&lt;/em&gt; property can be repeated an arbitrary number of times, with three kinds of possible 'content-locator' values:&lt;br/&gt;&lt;br/&gt;
        /// 1.) &lt;em&gt;id-value&lt;/em&gt; URL references - uses &lt;em&gt;id-value&lt;/em&gt; of an element in the page being annotated. The simplest use of &lt;em&gt;speakable&lt;/em&gt; has (potentially relative) URL values, referencing identified sections of the document concerned.&lt;br/&gt;&lt;br/&gt;
        /// 2.) CSS Selectors - addresses content in the annotated page, eg. via class attribute. Use the &lt;a class="localLink" href="https://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt; property.&lt;br/&gt;&lt;br/&gt;
        /// 3.)  XPaths - addresses content via XPaths (assuming an XML view of the content). Use the &lt;a class="localLink" href="https://schema.org/xpath"&gt;xpath&lt;/a&gt; property.&lt;br/&gt;&lt;br/&gt;
        /// For more sophisticated markup of speakable sections beyond simple ID references, either CSS selectors or XPath expressions to pick out document section(s) as speakable. For this
        /// we define a supporting type, &lt;a class="localLink" href="https://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt;  which is defined to be a possible value of the &lt;em&gt;speakable&lt;/em&gt; property.
        /// </summary>
        Values<ISpeakableSpecification, Uri> Speakable { get; set; }

        /// <summary>
        /// The number of words in the text of the Article.
        /// </summary>
        OneOrMany<int?> WordCount { get; set; }
    }

    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.&lt;br/&gt;&lt;br/&gt;
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Article : CreativeWork, IArticle, IEquatable<Article>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Article";

        /// <summary>
        /// The actual body of the article.
        /// </summary>
        [DataMember(Name = "articleBody", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ArticleBody { get; set; }

        /// <summary>
        /// Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
        /// </summary>
        [DataMember(Name = "articleSection", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ArticleSection { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="https://schema.org/Article"&gt;Article&lt;/a&gt;, typically a &lt;a class="localLink" href="https://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;, the backstory property provides a textual summary giving a brief explanation of why and how an article was created. In a journalistic setting this could include information about reporting process, methods, interviews, data sources, etc.
        /// </summary>
        [DataMember(Name = "backstory", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, string> Backstory { get; set; }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [DataMember(Name = "pageEnd", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> PageEnd { get; set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [DataMember(Name = "pageStart", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> PageStart { get; set; }

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [DataMember(Name = "pagination", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Pagination { get; set; }

        /// <summary>
        /// Indicates sections of a Web page that are particularly 'speakable' in the sense of being highlighted as being especially appropriate for text-to-speech conversion. Other sections of a page may also be usefully spoken in particular circumstances; the 'speakable' property serves to indicate the parts most likely to be generally useful for speech.&lt;br/&gt;&lt;br/&gt;
        /// The &lt;em&gt;speakable&lt;/em&gt; property can be repeated an arbitrary number of times, with three kinds of possible 'content-locator' values:&lt;br/&gt;&lt;br/&gt;
        /// 1.) &lt;em&gt;id-value&lt;/em&gt; URL references - uses &lt;em&gt;id-value&lt;/em&gt; of an element in the page being annotated. The simplest use of &lt;em&gt;speakable&lt;/em&gt; has (potentially relative) URL values, referencing identified sections of the document concerned.&lt;br/&gt;&lt;br/&gt;
        /// 2.) CSS Selectors - addresses content in the annotated page, eg. via class attribute. Use the &lt;a class="localLink" href="https://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt; property.&lt;br/&gt;&lt;br/&gt;
        /// 3.)  XPaths - addresses content via XPaths (assuming an XML view of the content). Use the &lt;a class="localLink" href="https://schema.org/xpath"&gt;xpath&lt;/a&gt; property.&lt;br/&gt;&lt;br/&gt;
        /// For more sophisticated markup of speakable sections beyond simple ID references, either CSS selectors or XPath expressions to pick out document section(s) as speakable. For this
        /// we define a supporting type, &lt;a class="localLink" href="https://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt;  which is defined to be a possible value of the &lt;em&gt;speakable&lt;/em&gt; property.
        /// </summary>
        [DataMember(Name = "speakable", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ISpeakableSpecification, Uri> Speakable { get; set; }

        /// <summary>
        /// The number of words in the text of the Article.
        /// </summary>
        [DataMember(Name = "wordCount", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> WordCount { get; set; }

        /// <inheritdoc/>
        public bool Equals(Article other)
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
                this.ArticleBody == other.ArticleBody &&
                this.ArticleSection == other.ArticleSection &&
                this.Backstory == other.Backstory &&
                this.PageEnd == other.PageEnd &&
                this.PageStart == other.PageStart &&
                this.Pagination == other.Pagination &&
                this.Speakable == other.Speakable &&
                this.WordCount == other.WordCount &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Article);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ArticleBody)
            .And(this.ArticleSection)
            .And(this.Backstory)
            .And(this.PageEnd)
            .And(this.PageStart)
            .And(this.Pagination)
            .And(this.Speakable)
            .And(this.WordCount)
            .And(base.GetHashCode());
    }
}

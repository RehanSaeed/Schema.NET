namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An article, such as a news article or piece of investigative report. Newspapers and magazines have articles of many different types and this is intended to cover them all.&lt;br/&gt;&lt;br/&gt;
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Article : CreativeWork
    {
        public interface IArticleBody : IValue {}
        public interface IArticleBody<T> : IArticleBody { new T Value { get; } }
        public class OneOrManyArticleBody : OneOrMany<IArticleBody>
        {
            public OneOrManyArticleBody(IArticleBody item) : base(item) { }
            public OneOrManyArticleBody(IEnumerable<IArticleBody> items) : base(items) { }
            public static implicit operator OneOrManyArticleBody (string value) { return new OneOrManyArticleBody (new ArticleBodystring (value)); }
            public static implicit operator OneOrManyArticleBody (string[] values) { return new OneOrManyArticleBody (values.Select(v => (IArticleBody) new ArticleBodystring (v))); }
            public static implicit operator OneOrManyArticleBody (List<string> values) { return new OneOrManyArticleBody (values.Select(v => (IArticleBody) new ArticleBodystring (v))); }
        }
        public struct ArticleBodystring : IArticleBody<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ArticleBodystring (string value) { Value = value; }
            public static implicit operator ArticleBodystring (string value) { return new ArticleBodystring (value); }
        }

        public interface IArticleSection : IValue {}
        public interface IArticleSection<T> : IArticleSection { new T Value { get; } }
        public class OneOrManyArticleSection : OneOrMany<IArticleSection>
        {
            public OneOrManyArticleSection(IArticleSection item) : base(item) { }
            public OneOrManyArticleSection(IEnumerable<IArticleSection> items) : base(items) { }
            public static implicit operator OneOrManyArticleSection (string value) { return new OneOrManyArticleSection (new ArticleSectionstring (value)); }
            public static implicit operator OneOrManyArticleSection (string[] values) { return new OneOrManyArticleSection (values.Select(v => (IArticleSection) new ArticleSectionstring (v))); }
            public static implicit operator OneOrManyArticleSection (List<string> values) { return new OneOrManyArticleSection (values.Select(v => (IArticleSection) new ArticleSectionstring (v))); }
        }
        public struct ArticleSectionstring : IArticleSection<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ArticleSectionstring (string value) { Value = value; }
            public static implicit operator ArticleSectionstring (string value) { return new ArticleSectionstring (value); }
        }

        public interface IBackstory : IValue {}
        public interface IBackstory<T> : IBackstory { new T Value { get; } }
        public class OneOrManyBackstory : OneOrMany<IBackstory>
        {
            public OneOrManyBackstory(IBackstory item) : base(item) { }
            public OneOrManyBackstory(IEnumerable<IBackstory> items) : base(items) { }
            public static implicit operator OneOrManyBackstory (CreativeWork value) { return new OneOrManyBackstory (new BackstoryCreativeWork (value)); }
            public static implicit operator OneOrManyBackstory (CreativeWork[] values) { return new OneOrManyBackstory (values.Select(v => (IBackstory) new BackstoryCreativeWork (v))); }
            public static implicit operator OneOrManyBackstory (List<CreativeWork> values) { return new OneOrManyBackstory (values.Select(v => (IBackstory) new BackstoryCreativeWork (v))); }
            public static implicit operator OneOrManyBackstory (string value) { return new OneOrManyBackstory (new Backstorystring (value)); }
            public static implicit operator OneOrManyBackstory (string[] values) { return new OneOrManyBackstory (values.Select(v => (IBackstory) new Backstorystring (v))); }
            public static implicit operator OneOrManyBackstory (List<string> values) { return new OneOrManyBackstory (values.Select(v => (IBackstory) new Backstorystring (v))); }
        }
        public struct BackstoryCreativeWork : IBackstory<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public BackstoryCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator BackstoryCreativeWork (CreativeWork value) { return new BackstoryCreativeWork (value); }
        }
        public struct Backstorystring : IBackstory<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Backstorystring (string value) { Value = value; }
            public static implicit operator Backstorystring (string value) { return new Backstorystring (value); }
        }

        public interface IPageEnd : IValue {}
        public interface IPageEnd<T> : IPageEnd { new T Value { get; } }
        public class OneOrManyPageEnd : OneOrMany<IPageEnd>
        {
            public OneOrManyPageEnd(IPageEnd item) : base(item) { }
            public OneOrManyPageEnd(IEnumerable<IPageEnd> items) : base(items) { }
            public static implicit operator OneOrManyPageEnd (int value) { return new OneOrManyPageEnd (new PageEndint (value)); }
            public static implicit operator OneOrManyPageEnd (int[] values) { return new OneOrManyPageEnd (values.Select(v => (IPageEnd) new PageEndint (v))); }
            public static implicit operator OneOrManyPageEnd (List<int> values) { return new OneOrManyPageEnd (values.Select(v => (IPageEnd) new PageEndint (v))); }
            public static implicit operator OneOrManyPageEnd (string value) { return new OneOrManyPageEnd (new PageEndstring (value)); }
            public static implicit operator OneOrManyPageEnd (string[] values) { return new OneOrManyPageEnd (values.Select(v => (IPageEnd) new PageEndstring (v))); }
            public static implicit operator OneOrManyPageEnd (List<string> values) { return new OneOrManyPageEnd (values.Select(v => (IPageEnd) new PageEndstring (v))); }
        }
        public struct PageEndint : IPageEnd<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public PageEndint (int value) { Value = value; }
            public static implicit operator PageEndint (int value) { return new PageEndint (value); }
        }
        public struct PageEndstring : IPageEnd<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PageEndstring (string value) { Value = value; }
            public static implicit operator PageEndstring (string value) { return new PageEndstring (value); }
        }

        public interface IPageStart : IValue {}
        public interface IPageStart<T> : IPageStart { new T Value { get; } }
        public class OneOrManyPageStart : OneOrMany<IPageStart>
        {
            public OneOrManyPageStart(IPageStart item) : base(item) { }
            public OneOrManyPageStart(IEnumerable<IPageStart> items) : base(items) { }
            public static implicit operator OneOrManyPageStart (int value) { return new OneOrManyPageStart (new PageStartint (value)); }
            public static implicit operator OneOrManyPageStart (int[] values) { return new OneOrManyPageStart (values.Select(v => (IPageStart) new PageStartint (v))); }
            public static implicit operator OneOrManyPageStart (List<int> values) { return new OneOrManyPageStart (values.Select(v => (IPageStart) new PageStartint (v))); }
            public static implicit operator OneOrManyPageStart (string value) { return new OneOrManyPageStart (new PageStartstring (value)); }
            public static implicit operator OneOrManyPageStart (string[] values) { return new OneOrManyPageStart (values.Select(v => (IPageStart) new PageStartstring (v))); }
            public static implicit operator OneOrManyPageStart (List<string> values) { return new OneOrManyPageStart (values.Select(v => (IPageStart) new PageStartstring (v))); }
        }
        public struct PageStartint : IPageStart<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public PageStartint (int value) { Value = value; }
            public static implicit operator PageStartint (int value) { return new PageStartint (value); }
        }
        public struct PageStartstring : IPageStart<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PageStartstring (string value) { Value = value; }
            public static implicit operator PageStartstring (string value) { return new PageStartstring (value); }
        }

        public interface IPagination : IValue {}
        public interface IPagination<T> : IPagination { new T Value { get; } }
        public class OneOrManyPagination : OneOrMany<IPagination>
        {
            public OneOrManyPagination(IPagination item) : base(item) { }
            public OneOrManyPagination(IEnumerable<IPagination> items) : base(items) { }
            public static implicit operator OneOrManyPagination (string value) { return new OneOrManyPagination (new Paginationstring (value)); }
            public static implicit operator OneOrManyPagination (string[] values) { return new OneOrManyPagination (values.Select(v => (IPagination) new Paginationstring (v))); }
            public static implicit operator OneOrManyPagination (List<string> values) { return new OneOrManyPagination (values.Select(v => (IPagination) new Paginationstring (v))); }
        }
        public struct Paginationstring : IPagination<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Paginationstring (string value) { Value = value; }
            public static implicit operator Paginationstring (string value) { return new Paginationstring (value); }
        }

        public interface ISpeakable : IValue {}
        public interface ISpeakable<T> : ISpeakable { new T Value { get; } }
        public class OneOrManySpeakable : OneOrMany<ISpeakable>
        {
            public OneOrManySpeakable(ISpeakable item) : base(item) { }
            public OneOrManySpeakable(IEnumerable<ISpeakable> items) : base(items) { }
            public static implicit operator OneOrManySpeakable (Uri value) { return new OneOrManySpeakable (new SpeakableUri (value)); }
            public static implicit operator OneOrManySpeakable (Uri[] values) { return new OneOrManySpeakable (values.Select(v => (ISpeakable) new SpeakableUri (v))); }
            public static implicit operator OneOrManySpeakable (List<Uri> values) { return new OneOrManySpeakable (values.Select(v => (ISpeakable) new SpeakableUri (v))); }
        }
        public struct SpeakableUri : ISpeakable<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public SpeakableUri (Uri value) { Value = value; }
            public static implicit operator SpeakableUri (Uri value) { return new SpeakableUri (value); }
        }

        public interface IWordCount : IValue {}
        public interface IWordCount<T> : IWordCount { new T Value { get; } }
        public class OneOrManyWordCount : OneOrMany<IWordCount>
        {
            public OneOrManyWordCount(IWordCount item) : base(item) { }
            public OneOrManyWordCount(IEnumerable<IWordCount> items) : base(items) { }
            public static implicit operator OneOrManyWordCount (int value) { return new OneOrManyWordCount (new WordCountint (value)); }
            public static implicit operator OneOrManyWordCount (int[] values) { return new OneOrManyWordCount (values.Select(v => (IWordCount) new WordCountint (v))); }
            public static implicit operator OneOrManyWordCount (List<int> values) { return new OneOrManyWordCount (values.Select(v => (IWordCount) new WordCountint (v))); }
        }
        public struct WordCountint : IWordCount<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public WordCountint (int value) { Value = value; }
            public static implicit operator WordCountint (int value) { return new WordCountint (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Article";

        /// <summary>
        /// The actual body of the article.
        /// </summary>
        [DataMember(Name = "articleBody", Order = 206)]
        public OneOrManyArticleBody ArticleBody { get; set; }

        /// <summary>
        /// Articles may belong to one or more 'sections' in a magazine or newspaper, such as Sports, Lifestyle, etc.
        /// </summary>
        [DataMember(Name = "articleSection", Order = 207)]
        public OneOrManyArticleSection ArticleSection { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Article"&gt;Article&lt;/a&gt;, typically a &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;, the backstory property provides a textual summary giving a brief explanation of why and how an article was created. In a journalistic setting this could include information about reporting process, methods, interviews, data sources, etc.
        /// </summary>
        [DataMember(Name = "backstory", Order = 208)]
        public OneOrManyBackstory Backstory { get; set; }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [DataMember(Name = "pageEnd", Order = 209)]
        public OneOrManyPageEnd PageEnd { get; set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [DataMember(Name = "pageStart", Order = 210)]
        public OneOrManyPageStart PageStart { get; set; }

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [DataMember(Name = "pagination", Order = 211)]
        public OneOrManyPagination Pagination { get; set; }

        /// <summary>
        /// Indicates sections of a Web page that are particularly 'speakable' in the sense of being highlighted as being especially appropriate for text-to-speech conversion. Other sections of a page may also be usefully spoken in particular circumstances; the 'speakable' property serves to indicate the parts most likely to be generally useful for speech.&lt;br/&gt;&lt;br/&gt;
        /// The &lt;em&gt;speakable&lt;/em&gt; property can be repeated an arbitrary number of times, with three kinds of possible 'content-locator' values:&lt;br/&gt;&lt;br/&gt;
        /// 1.) &lt;em&gt;id-value&lt;/em&gt; URL references - uses &lt;em&gt;id-value&lt;/em&gt; of an element in the page being annotated. The simplest use of &lt;em&gt;speakable&lt;/em&gt; has (potentially relative) URL values, referencing identified sections of the document concerned.&lt;br/&gt;&lt;br/&gt;
        /// 2.) CSS Selectors - addresses content in the annotated page, eg. via class attribute. Use the &lt;a class="localLink" href="http://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt; property.&lt;br/&gt;&lt;br/&gt;
        /// 3.)  XPaths - addresses content via XPaths (assuming an XML view of the content). Use the &lt;a class="localLink" href="http://schema.org/xpath"&gt;xpath&lt;/a&gt; property.&lt;br/&gt;&lt;br/&gt;
        /// For more sophisticated markup of speakable sections beyond simple ID references, either CSS selectors or XPath expressions to pick out document section(s) as speakable. For this
        /// we define a supporting type, &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt;  which is defined to be a possible value of the &lt;em&gt;speakable&lt;/em&gt; property.
        /// </summary>
        [DataMember(Name = "speakable", Order = 212)]
        public OneOrManySpeakable Speakable { get; set; }

        /// <summary>
        /// The number of words in the text of the Article.
        /// </summary>
        [DataMember(Name = "wordCount", Order = 213)]
        public OneOrManyWordCount WordCount { get; set; }
    }
}

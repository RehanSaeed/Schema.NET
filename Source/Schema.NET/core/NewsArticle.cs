namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A NewsArticle is an article whose content reports news, or provides background context and supporting materials for understanding the news.&lt;br/&gt;&lt;br/&gt;
    /// A more detailed overview of &lt;a href="/docs/news.html"&gt;schema.org News markup&lt;/a&gt; is also available.
    /// </summary>
    [DataContract]
    public partial class NewsArticle : Article
    {
        public interface IDateline : IValue {}
        public interface IDateline<T> : IDateline { new T Value { get; } }
        public class OneOrManyDateline : OneOrMany<IDateline>
        {
            public OneOrManyDateline(IDateline item) : base(item) { }
            public OneOrManyDateline(IEnumerable<IDateline> items) : base(items) { }
            public static implicit operator OneOrManyDateline (string value) { return new OneOrManyDateline (new Datelinestring (value)); }
            public static implicit operator OneOrManyDateline (string[] values) { return new OneOrManyDateline (values.Select(v => (IDateline) new Datelinestring (v))); }
            public static implicit operator OneOrManyDateline (List<string> values) { return new OneOrManyDateline (values.Select(v => (IDateline) new Datelinestring (v))); }
        }
        public struct Datelinestring : IDateline<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Datelinestring (string value) { Value = value; }
            public static implicit operator Datelinestring (string value) { return new Datelinestring (value); }
        }

        public interface IPrintColumn : IValue {}
        public interface IPrintColumn<T> : IPrintColumn { new T Value { get; } }
        public class OneOrManyPrintColumn : OneOrMany<IPrintColumn>
        {
            public OneOrManyPrintColumn(IPrintColumn item) : base(item) { }
            public OneOrManyPrintColumn(IEnumerable<IPrintColumn> items) : base(items) { }
            public static implicit operator OneOrManyPrintColumn (string value) { return new OneOrManyPrintColumn (new PrintColumnstring (value)); }
            public static implicit operator OneOrManyPrintColumn (string[] values) { return new OneOrManyPrintColumn (values.Select(v => (IPrintColumn) new PrintColumnstring (v))); }
            public static implicit operator OneOrManyPrintColumn (List<string> values) { return new OneOrManyPrintColumn (values.Select(v => (IPrintColumn) new PrintColumnstring (v))); }
        }
        public struct PrintColumnstring : IPrintColumn<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PrintColumnstring (string value) { Value = value; }
            public static implicit operator PrintColumnstring (string value) { return new PrintColumnstring (value); }
        }

        public interface IPrintEdition : IValue {}
        public interface IPrintEdition<T> : IPrintEdition { new T Value { get; } }
        public class OneOrManyPrintEdition : OneOrMany<IPrintEdition>
        {
            public OneOrManyPrintEdition(IPrintEdition item) : base(item) { }
            public OneOrManyPrintEdition(IEnumerable<IPrintEdition> items) : base(items) { }
            public static implicit operator OneOrManyPrintEdition (string value) { return new OneOrManyPrintEdition (new PrintEditionstring (value)); }
            public static implicit operator OneOrManyPrintEdition (string[] values) { return new OneOrManyPrintEdition (values.Select(v => (IPrintEdition) new PrintEditionstring (v))); }
            public static implicit operator OneOrManyPrintEdition (List<string> values) { return new OneOrManyPrintEdition (values.Select(v => (IPrintEdition) new PrintEditionstring (v))); }
        }
        public struct PrintEditionstring : IPrintEdition<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PrintEditionstring (string value) { Value = value; }
            public static implicit operator PrintEditionstring (string value) { return new PrintEditionstring (value); }
        }

        public interface IPrintPage : IValue {}
        public interface IPrintPage<T> : IPrintPage { new T Value { get; } }
        public class OneOrManyPrintPage : OneOrMany<IPrintPage>
        {
            public OneOrManyPrintPage(IPrintPage item) : base(item) { }
            public OneOrManyPrintPage(IEnumerable<IPrintPage> items) : base(items) { }
            public static implicit operator OneOrManyPrintPage (string value) { return new OneOrManyPrintPage (new PrintPagestring (value)); }
            public static implicit operator OneOrManyPrintPage (string[] values) { return new OneOrManyPrintPage (values.Select(v => (IPrintPage) new PrintPagestring (v))); }
            public static implicit operator OneOrManyPrintPage (List<string> values) { return new OneOrManyPrintPage (values.Select(v => (IPrintPage) new PrintPagestring (v))); }
        }
        public struct PrintPagestring : IPrintPage<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PrintPagestring (string value) { Value = value; }
            public static implicit operator PrintPagestring (string value) { return new PrintPagestring (value); }
        }

        public interface IPrintSection : IValue {}
        public interface IPrintSection<T> : IPrintSection { new T Value { get; } }
        public class OneOrManyPrintSection : OneOrMany<IPrintSection>
        {
            public OneOrManyPrintSection(IPrintSection item) : base(item) { }
            public OneOrManyPrintSection(IEnumerable<IPrintSection> items) : base(items) { }
            public static implicit operator OneOrManyPrintSection (string value) { return new OneOrManyPrintSection (new PrintSectionstring (value)); }
            public static implicit operator OneOrManyPrintSection (string[] values) { return new OneOrManyPrintSection (values.Select(v => (IPrintSection) new PrintSectionstring (v))); }
            public static implicit operator OneOrManyPrintSection (List<string> values) { return new OneOrManyPrintSection (values.Select(v => (IPrintSection) new PrintSectionstring (v))); }
        }
        public struct PrintSectionstring : IPrintSection<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PrintSectionstring (string value) { Value = value; }
            public static implicit operator PrintSectionstring (string value) { return new PrintSectionstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NewsArticle";

        /// <summary>
        /// A &lt;a href="https://en.wikipedia.org/wiki/Dateline"&gt;dateline&lt;/a&gt; is a brief piece of text included in news articles that describes where and when the story was written or filed though the date is often omitted. Sometimes only a placename is provided.&lt;br/&gt;&lt;br/&gt;
        /// Structured representations of dateline-related information can also be expressed more explicitly using &lt;a class="localLink" href="http://schema.org/locationCreated"&gt;locationCreated&lt;/a&gt; (which represents where a work was created e.g. where a news report was written).  For location depicted or described in the content, use &lt;a class="localLink" href="http://schema.org/contentLocation"&gt;contentLocation&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// Dateline summaries are oriented more towards human readers than towards automated processing, and can vary substantially. Some examples: "BEIRUT, Lebanon, June 2.", "Paris, France", "December 19, 2017 11:43AM Reporting from Washington", "Beijing/Moscow", "QUEZON CITY, Philippines".
        /// </summary>
        [DataMember(Name = "dateline", Order = 306)]
        public OneOrManyDateline Dateline { get; set; }

        /// <summary>
        /// The number of the column in which the NewsArticle appears in the print edition.
        /// </summary>
        [DataMember(Name = "printColumn", Order = 307)]
        public OneOrManyPrintColumn PrintColumn { get; set; }

        /// <summary>
        /// The edition of the print product in which the NewsArticle appears.
        /// </summary>
        [DataMember(Name = "printEdition", Order = 308)]
        public OneOrManyPrintEdition PrintEdition { get; set; }

        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the name of the page on which the article is found. Please note that this field is intended for the exact page name (e.g. A5, B18).
        /// </summary>
        [DataMember(Name = "printPage", Order = 309)]
        public OneOrManyPrintPage PrintPage { get; set; }

        /// <summary>
        /// If this NewsArticle appears in print, this field indicates the print section in which the article appeared.
        /// </summary>
        [DataMember(Name = "printSection", Order = 310)]
        public OneOrManyPrintSection PrintSection { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A web page element, like a table or an image.
    /// </summary>
    [DataContract]
    public partial class WebPageElement : CreativeWork
    {
        public interface ICssSelector : IValue {}
        public interface ICssSelector<T> : ICssSelector { new T Value { get; } }
        public class OneOrManyCssSelector : OneOrMany<ICssSelector>
        {
            public OneOrManyCssSelector(ICssSelector item) : base(item) { }
            public OneOrManyCssSelector(IEnumerable<ICssSelector> items) : base(items) { }
            public static implicit operator OneOrManyCssSelector (string value) { return new OneOrManyCssSelector (new CssSelectorstring (value)); }
            public static implicit operator OneOrManyCssSelector (string[] values) { return new OneOrManyCssSelector (values.Select(v => (ICssSelector) new CssSelectorstring (v))); }
            public static implicit operator OneOrManyCssSelector (List<string> values) { return new OneOrManyCssSelector (values.Select(v => (ICssSelector) new CssSelectorstring (v))); }
        }
        public struct CssSelectorstring : ICssSelector<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CssSelectorstring (string value) { Value = value; }
            public static implicit operator CssSelectorstring (string value) { return new CssSelectorstring (value); }
        }

        public interface IXpath : IValue {}
        public interface IXpath<T> : IXpath { new T Value { get; } }
        public class OneOrManyXpath : OneOrMany<IXpath>
        {
            public OneOrManyXpath(IXpath item) : base(item) { }
            public OneOrManyXpath(IEnumerable<IXpath> items) : base(items) { }
            public static implicit operator OneOrManyXpath (string value) { return new OneOrManyXpath (new Xpathstring (value)); }
            public static implicit operator OneOrManyXpath (string[] values) { return new OneOrManyXpath (values.Select(v => (IXpath) new Xpathstring (v))); }
            public static implicit operator OneOrManyXpath (List<string> values) { return new OneOrManyXpath (values.Select(v => (IXpath) new Xpathstring (v))); }
        }
        public struct Xpathstring : IXpath<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Xpathstring (string value) { Value = value; }
            public static implicit operator Xpathstring (string value) { return new Xpathstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebPageElement";

        /// <summary>
        /// A CSS selector, e.g. of a &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
        /// </summary>
        [DataMember(Name = "cssSelector", Order = 206)]
        public OneOrManyCssSelector CssSelector { get; set; }

        /// <summary>
        /// An XPath, e.g. of a &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
        /// </summary>
        [DataMember(Name = "xpath", Order = 207)]
        public OneOrManyXpath Xpath { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A web page element, like a table or an image.
    /// </summary>
    public partial interface IWebPageElement : ICreativeWork
    {
        /// <summary>
        /// A CSS selector, e.g. of a &lt;a class="localLink" href="https://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
        /// </summary>
        OneOrMany<string> CssSelector { get; set; }

        /// <summary>
        /// An XPath, e.g. of a &lt;a class="localLink" href="https://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
        /// </summary>
        OneOrMany<string> Xpath { get; set; }
    }

    /// <summary>
    /// A web page element, like a table or an image.
    /// </summary>
    [DataContract]
    public partial class WebPageElement : CreativeWork, IWebPageElement, IEquatable<WebPageElement>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebPageElement";

        /// <summary>
        /// A CSS selector, e.g. of a &lt;a class="localLink" href="https://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
        /// </summary>
        [DataMember(Name = "cssSelector", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CssSelector { get; set; }

        /// <summary>
        /// An XPath, e.g. of a &lt;a class="localLink" href="https://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
        /// </summary>
        [DataMember(Name = "xpath", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Xpath { get; set; }

        /// <inheritdoc/>
        public bool Equals(WebPageElement other)
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
                this.CssSelector == other.CssSelector &&
                this.Xpath == other.Xpath &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as WebPageElement);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.CssSelector)
            .And(this.Xpath)
            .And(base.GetHashCode());
    }
}

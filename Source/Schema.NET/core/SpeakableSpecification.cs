namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A SpeakableSpecification indicates (typically via &lt;a class="localLink" href="https://schema.org/xpath"&gt;xpath&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt;) sections of a document that are highlighted as particularly &lt;a class="localLink" href="https://schema.org/speakable"&gt;speakable&lt;/a&gt;. Instances of this type are expected to be used primarily as values of the &lt;a class="localLink" href="https://schema.org/speakable"&gt;speakable&lt;/a&gt; property.
    /// </summary>
    public partial interface ISpeakableSpecification : IIntangible
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
    /// A SpeakableSpecification indicates (typically via &lt;a class="localLink" href="https://schema.org/xpath"&gt;xpath&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt;) sections of a document that are highlighted as particularly &lt;a class="localLink" href="https://schema.org/speakable"&gt;speakable&lt;/a&gt;. Instances of this type are expected to be used primarily as values of the &lt;a class="localLink" href="https://schema.org/speakable"&gt;speakable&lt;/a&gt; property.
    /// </summary>
    [DataContract]
    public partial class SpeakableSpecification : Intangible, ISpeakableSpecification, IEquatable<SpeakableSpecification>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SpeakableSpecification";

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
        public bool Equals(SpeakableSpecification other)
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
        public override bool Equals(object obj) => this.Equals(obj as SpeakableSpecification);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.CssSelector)
            .And(this.Xpath)
            .And(base.GetHashCode());
    }
}

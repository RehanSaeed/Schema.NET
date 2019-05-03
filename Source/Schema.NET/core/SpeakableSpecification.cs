namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A SpeakableSpecification indicates (typically via &lt;a class="localLink" href="http://schema.org/xpath"&gt;xpath&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt;) sections of a document that are highlighted as particularly &lt;a class="localLink" href="http://schema.org/speakable"&gt;speakable&lt;/a&gt;. Instances of this type are expected to be used primarily as values of the &lt;a class="localLink" href="http://schema.org/speakable"&gt;speakable&lt;/a&gt; property.
    /// </summary>
    [DataContract]
    public partial class SpeakableSpecification : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SpeakableSpecification";

        /// <summary>
        /// A CSS selector, e.g. of a &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
        /// </summary>
        [DataMember(Name = "cssSelector", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? CssSelector { get; set; }

        /// <summary>
        /// An XPath, e.g. of a &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/WebPageElement"&gt;WebPageElement&lt;/a&gt;. In the latter case, multiple matches within a page can constitute a single conceptual "Web page element".
        /// </summary>
        [DataMember(Name = "xpath", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Xpath { get; set; }
    }
}

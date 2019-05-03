namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A web page element, like a table or an image.
    /// </summary>
    [DataContract]
    public partial class WebPageElement : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebPageElement";

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

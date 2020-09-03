namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
    public partial interface IWebPage : ICreativeWork
    {
        /// <summary>
        /// A set of links that can help a user understand and navigate a website hierarchy.
        /// </summary>
        Values<IBreadcrumbList, string> Breadcrumb { get; set; }

        /// <summary>
        /// Date on which the content on this web page was last reviewed for accuracy and/or completeness.
        /// </summary>
        Values<int?, DateTime?> LastReviewed { get; set; }

        /// <summary>
        /// Indicates if this web page element is the main subject of the page.
        /// </summary>
        OneOrMany<IWebPageElement> MainContentOfPage { get; set; }

        /// <summary>
        /// Indicates the main image on the page.
        /// </summary>
        OneOrMany<IImageObject> PrimaryImageOfPage { get; set; }

        /// <summary>
        /// A link related to this web page, for example to other related web pages.
        /// </summary>
        OneOrMany<Uri> RelatedLink { get; set; }

        /// <summary>
        /// People or organizations that have reviewed the content on this web page for accuracy and/or completeness.
        /// </summary>
        Values<IOrganization, IPerson> ReviewedBy { get; set; }

        /// <summary>
        /// One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
        /// </summary>
        OneOrMany<Uri> SignificantLink { get; set; }

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
        /// One of the domain specialities to which this web page's content applies.
        /// </summary>
        OneOrMany<Specialty?> Specialty { get; set; }
    }

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
    [DataContract]
    public partial class WebPage : CreativeWork, IWebPage, IEquatable<WebPage>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebPage";

        /// <summary>
        /// A set of links that can help a user understand and navigate a website hierarchy.
        /// </summary>
        [DataMember(Name = "breadcrumb", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IBreadcrumbList, string> Breadcrumb { get; set; }

        /// <summary>
        /// Date on which the content on this web page was last reviewed for accuracy and/or completeness.
        /// </summary>
        [DataMember(Name = "lastReviewed", Order = 207)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> LastReviewed { get; set; }

        /// <summary>
        /// Indicates if this web page element is the main subject of the page.
        /// </summary>
        [DataMember(Name = "mainContentOfPage", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IWebPageElement> MainContentOfPage { get; set; }

        /// <summary>
        /// Indicates the main image on the page.
        /// </summary>
        [DataMember(Name = "primaryImageOfPage", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IImageObject> PrimaryImageOfPage { get; set; }

        /// <summary>
        /// A link related to this web page, for example to other related web pages.
        /// </summary>
        [DataMember(Name = "relatedLink", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> RelatedLink { get; set; }

        /// <summary>
        /// People or organizations that have reviewed the content on this web page for accuracy and/or completeness.
        /// </summary>
        [DataMember(Name = "reviewedBy", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> ReviewedBy { get; set; }

        /// <summary>
        /// One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
        /// </summary>
        [DataMember(Name = "significantLink", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> SignificantLink { get; set; }

        /// <summary>
        /// Indicates sections of a Web page that are particularly 'speakable' in the sense of being highlighted as being especially appropriate for text-to-speech conversion. Other sections of a page may also be usefully spoken in particular circumstances; the 'speakable' property serves to indicate the parts most likely to be generally useful for speech.&lt;br/&gt;&lt;br/&gt;
        /// The &lt;em&gt;speakable&lt;/em&gt; property can be repeated an arbitrary number of times, with three kinds of possible 'content-locator' values:&lt;br/&gt;&lt;br/&gt;
        /// 1.) &lt;em&gt;id-value&lt;/em&gt; URL references - uses &lt;em&gt;id-value&lt;/em&gt; of an element in the page being annotated. The simplest use of &lt;em&gt;speakable&lt;/em&gt; has (potentially relative) URL values, referencing identified sections of the document concerned.&lt;br/&gt;&lt;br/&gt;
        /// 2.) CSS Selectors - addresses content in the annotated page, eg. via class attribute. Use the &lt;a class="localLink" href="https://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt; property.&lt;br/&gt;&lt;br/&gt;
        /// 3.)  XPaths - addresses content via XPaths (assuming an XML view of the content). Use the &lt;a class="localLink" href="https://schema.org/xpath"&gt;xpath&lt;/a&gt; property.&lt;br/&gt;&lt;br/&gt;
        /// For more sophisticated markup of speakable sections beyond simple ID references, either CSS selectors or XPath expressions to pick out document section(s) as speakable. For this
        /// we define a supporting type, &lt;a class="localLink" href="https://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt;  which is defined to be a possible value of the &lt;em&gt;speakable&lt;/em&gt; property.
        /// </summary>
        [DataMember(Name = "speakable", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ISpeakableSpecification, Uri> Speakable { get; set; }

        /// <summary>
        /// One of the domain specialities to which this web page's content applies.
        /// </summary>
        [DataMember(Name = "specialty", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Specialty?> Specialty { get; set; }

        /// <inheritdoc/>
        public bool Equals(WebPage other)
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
                this.Breadcrumb == other.Breadcrumb &&
                this.LastReviewed == other.LastReviewed &&
                this.MainContentOfPage == other.MainContentOfPage &&
                this.PrimaryImageOfPage == other.PrimaryImageOfPage &&
                this.RelatedLink == other.RelatedLink &&
                this.ReviewedBy == other.ReviewedBy &&
                this.SignificantLink == other.SignificantLink &&
                this.Speakable == other.Speakable &&
                this.Specialty == other.Specialty &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as WebPage);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Breadcrumb)
            .And(this.LastReviewed)
            .And(this.MainContentOfPage)
            .And(this.PrimaryImageOfPage)
            .And(this.RelatedLink)
            .And(this.ReviewedBy)
            .And(this.SignificantLink)
            .And(this.Speakable)
            .And(this.Specialty)
            .And(base.GetHashCode());
    }
}

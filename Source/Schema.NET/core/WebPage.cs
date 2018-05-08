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
        Values<IBreadcrumbList, string>? Breadcrumb { get; set; }

        /// <summary>
        /// Date on which the content on this web page was last reviewed for accuracy and/or completeness.
        /// </summary>
        OneOrMany<DateTimeOffset?>? LastReviewed { get; set; }

        /// <summary>
        /// Indicates if this web page element is the main subject of the page.
        /// </summary>
        OneOrMany<IWebPageElement>? MainContentOfPage { get; set; }

        /// <summary>
        /// Indicates the main image on the page.
        /// </summary>
        OneOrMany<IImageObject>? PrimaryImageOfPage { get; set; }

        /// <summary>
        /// A link related to this web page, for example to other related web pages.
        /// </summary>
        OneOrMany<Uri>? RelatedLink { get; set; }

        /// <summary>
        /// People or organizations that have reviewed the content on this web page for accuracy and/or completeness.
        /// </summary>
        Values<IOrganization, IPerson>? ReviewedBy { get; set; }

        /// <summary>
        /// One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
        /// </summary>
        OneOrMany<Uri>? SignificantLink { get; set; }

        /// <summary>
        /// Indicates sections of a Web page that are particularly 'speakable' in the sense of being highlighted as being especially appropriate for text-to-speech conversion. Other sections of a page may also be usefully spoken in particular circumstances; the 'speakable' property serves to indicate the parts most likely to be generally useful for speech.&lt;/p&gt;
        /// &lt;p&gt;The &lt;em&gt;speakable&lt;/em&gt; property can be repeated an arbitrary number of times, with three kinds of possible 'content-locator' values:&lt;/p&gt;
        /// &lt;p&gt;1.) &lt;em&gt;id-value&lt;/em&gt; URL references - uses &lt;em&gt;id-value&lt;/em&gt; of an element in the page being annotated. The simplest use of &lt;em&gt;speakable&lt;/em&gt; has (potentially relative) URL values, referencing identified sections of the document concerned.&lt;/p&gt;
        /// &lt;p&gt;2.) CSS Selectors - addresses content in the annotated page, eg. via class attribute. Use the &lt;a class="localLink" href="http://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt; property.&lt;/p&gt;
        /// &lt;p&gt;3.)  XPaths - addresses content via XPaths (assuming an XML view of the content). Use the &lt;a class="localLink" href="http://schema.org/xpath"&gt;xpath&lt;/a&gt; property.&lt;/p&gt;
        /// &lt;p&gt;For more sophisticated markup of speakable sections beyond simple ID references, either CSS selectors or XPath expressions to pick out document section(s) as speakable. For this
        /// we define a supporting type, &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt;  which is defined to be a possible value of the &lt;em&gt;speakable&lt;/em&gt; property.
        /// </summary>
        OneOrMany<Uri>? Speakable { get; set; }

        /// <summary>
        /// One of the domain specialities to which this web page's content applies.
        /// </summary>
        OneOrMany<Specialty?>? Specialty { get; set; }
    }

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as &lt;code&gt;breadcrumb&lt;/code&gt; may be used. We recommend explicit declaration if these properties are specified, but if they are found outside of an itemscope, they will be assumed to be about the page.
    /// </summary>
    [DataContract]
    public partial class WebPage : CreativeWork, IWebPage
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IBreadcrumbList, string>? Breadcrumb { get; set; }

        /// <summary>
        /// Date on which the content on this web page was last reviewed for accuracy and/or completeness.
        /// </summary>
        [DataMember(Name = "lastReviewed", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? LastReviewed { get; set; }

        /// <summary>
        /// Indicates if this web page element is the main subject of the page.
        /// </summary>
        [DataMember(Name = "mainContentOfPage", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IWebPageElement>? MainContentOfPage { get; set; }

        /// <summary>
        /// Indicates the main image on the page.
        /// </summary>
        [DataMember(Name = "primaryImageOfPage", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IImageObject>? PrimaryImageOfPage { get; set; }

        /// <summary>
        /// A link related to this web page, for example to other related web pages.
        /// </summary>
        [DataMember(Name = "relatedLink", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Uri>? RelatedLink { get; set; }

        /// <summary>
        /// People or organizations that have reviewed the content on this web page for accuracy and/or completeness.
        /// </summary>
        [DataMember(Name = "reviewedBy", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IOrganization, IPerson>? ReviewedBy { get; set; }

        /// <summary>
        /// One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
        /// </summary>
        [DataMember(Name = "significantLink", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Uri>? SignificantLink { get; set; }

        /// <summary>
        /// Indicates sections of a Web page that are particularly 'speakable' in the sense of being highlighted as being especially appropriate for text-to-speech conversion. Other sections of a page may also be usefully spoken in particular circumstances; the 'speakable' property serves to indicate the parts most likely to be generally useful for speech.&lt;/p&gt;
        /// &lt;p&gt;The &lt;em&gt;speakable&lt;/em&gt; property can be repeated an arbitrary number of times, with three kinds of possible 'content-locator' values:&lt;/p&gt;
        /// &lt;p&gt;1.) &lt;em&gt;id-value&lt;/em&gt; URL references - uses &lt;em&gt;id-value&lt;/em&gt; of an element in the page being annotated. The simplest use of &lt;em&gt;speakable&lt;/em&gt; has (potentially relative) URL values, referencing identified sections of the document concerned.&lt;/p&gt;
        /// &lt;p&gt;2.) CSS Selectors - addresses content in the annotated page, eg. via class attribute. Use the &lt;a class="localLink" href="http://schema.org/cssSelector"&gt;cssSelector&lt;/a&gt; property.&lt;/p&gt;
        /// &lt;p&gt;3.)  XPaths - addresses content via XPaths (assuming an XML view of the content). Use the &lt;a class="localLink" href="http://schema.org/xpath"&gt;xpath&lt;/a&gt; property.&lt;/p&gt;
        /// &lt;p&gt;For more sophisticated markup of speakable sections beyond simple ID references, either CSS selectors or XPath expressions to pick out document section(s) as speakable. For this
        /// we define a supporting type, &lt;a class="localLink" href="http://schema.org/SpeakableSpecification"&gt;SpeakableSpecification&lt;/a&gt;  which is defined to be a possible value of the &lt;em&gt;speakable&lt;/em&gt; property.
        /// </summary>
        [DataMember(Name = "speakable", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Uri>? Speakable { get; set; }

        /// <summary>
        /// One of the domain specialities to which this web page's content applies.
        /// </summary>
        [DataMember(Name = "specialty", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Specialty?>? Specialty { get; set; }
    }
}

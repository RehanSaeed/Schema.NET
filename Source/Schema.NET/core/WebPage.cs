namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as breadcrumb may be used...
    /// </summary>
    [DataContract]
    public partial class WebPage : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebPage";

        /// <summary>
        /// A set of links that can help a user understand and navigate a website hierarchy.
        /// </summary>
        [DataMember(Name = "breadcrumb", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BreadcrumbList, string>? Breadcrumb { get; set; }

        /// <summary>
        /// Date on which the content on this web page was last reviewed for accuracy and/or completeness.
        /// </summary>
        [DataMember(Name = "lastReviewed", Order = 3)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? LastReviewed { get; set; }

        /// <summary>
        /// Indicates if this web page element is the main subject of the page.
        /// </summary>
        [DataMember(Name = "mainContentOfPage", Order = 4)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<WebPageElement>? MainContentOfPage { get; set; }

        /// <summary>
        /// Indicates the main image on the page.
        /// </summary>
        [DataMember(Name = "primaryImageOfPage", Order = 5)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ImageObject>? PrimaryImageOfPage { get; set; }

        /// <summary>
        /// A link related to this web page, for example to other related web pages.
        /// </summary>
        [DataMember(Name = "relatedLink", Order = 6)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? RelatedLink { get; set; }

        /// <summary>
        /// People or organizations that have reviewed the content on this web page for accuracy and/or completeness.
        /// </summary>
        [DataMember(Name = "reviewedBy", Order = 7)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person, Organization>? ReviewedBy { get; set; }

        /// <summary>
        /// One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
        /// </summary>
        [DataMember(Name = "significantLink", Order = 8)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? SignificantLink { get; set; }

        /// <summary>
        /// One of the domain specialities to which this web page's content applies.
        /// </summary>
        [DataMember(Name = "specialty", Order = 9)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Specialty?>? Specialty { get; set; }
    }
}

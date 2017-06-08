namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A web page. Every web page is implicitly assumed to be declared to be of type WebPage, so the various properties about that webpage, such as breadcrumb may be used...
    /// </summary>
    [DataContract]
    public class WebPage : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "WebPage";

        /// <summary>
        /// A set of links that can help a user understand and navigate a website hierarchy.
        /// </summary>
        [DataMember(Name = "breadcrumb")]
        public object Breadcrumb { get; protected set; }

        /// <summary>
        /// A set of links that can help a user understand and navigate a website hierarchy.
        /// </summary>
        [IgnoreDataMember]
        public BreadcrumbList BreadcrumbBreadcrumbList
        {
            get => this.Breadcrumb as BreadcrumbList;
            set => this.Breadcrumb = value;
        }

        /// <summary>
        /// A set of links that can help a user understand and navigate a website hierarchy.
        /// </summary>
        [IgnoreDataMember]
        public string BreadcrumbText
        {
            get => this.Breadcrumb as string;
            set => this.Breadcrumb = value;
        }

        /// <summary>
        /// One of the more significant URLs on the page. Typically, these are the non-navigation links that are clicked on the most.
        /// </summary>
        [DataMember(Name = "significantLink")]
        public Uri SignificantLink { get; set; }

        /// <summary>
        /// A link related to this web page, for example to other related web pages.
        /// </summary>
        [DataMember(Name = "relatedLink")]
        public Uri RelatedLink { get; set; }

        /// <summary>
        /// Date on which the content on this web page was last reviewed for accuracy and/or completeness.
        /// </summary>
        [DataMember(Name = "lastReviewed")]
        public DateTimeOffset LastReviewed { get; set; }

        /// <summary>
        /// Indicates if this web page element is the main subject of the page.
        /// </summary>
        [DataMember(Name = "mainContentOfPage")]
        public WebPageElement MainContentOfPage { get; set; }

        /// <summary>
        /// People or organizations that have reviewed the content on this web page for accuracy and/or completeness.
        /// </summary>
        [DataMember(Name = "reviewedBy")]
        public object ReviewedBy { get; protected set; }

        /// <summary>
        /// People or organizations that have reviewed the content on this web page for accuracy and/or completeness.
        /// </summary>
        [IgnoreDataMember]
        public Person ReviewedByPerson
        {
            get => this.ReviewedBy as Person;
            set => this.ReviewedBy = value;
        }

        /// <summary>
        /// People or organizations that have reviewed the content on this web page for accuracy and/or completeness.
        /// </summary>
        [IgnoreDataMember]
        public Organization ReviewedByOrganization
        {
            get => this.ReviewedBy as Organization;
            set => this.ReviewedBy = value;
        }

        /// <summary>
        /// Indicates the main image on the page.
        /// </summary>
        [DataMember(Name = "primaryImageOfPage")]
        public ImageObject PrimaryImageOfPage { get; set; }

        /// <summary>
        /// One of the domain specialities to which this web page's content applies.
        /// </summary>
        [DataMember(Name = "specialty")]
        public Specialty Specialty { get; set; }
    }
}

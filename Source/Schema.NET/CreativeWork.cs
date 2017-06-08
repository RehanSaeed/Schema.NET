namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The most generic kind of creative work, including books, movies, photographs, software programs, etc.
    /// </summary>
    [DataContract]
    public class CreativeWork : Thing
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "CreativeWork";

        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        [DataMember(Name = "about")]
        public Thing About { get; set; }

        /// <summary>
        /// An alignment to an established educational framework.
        /// </summary>
        [DataMember(Name = "educationalAlignment")]
        public AlignmentObject EducationalAlignment { get; set; }

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a synonym for encoding.
        /// </summary>
        [DataMember(Name = "associatedMedia")]
        public MediaObject AssociatedMedia { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder")]
        public object Funder { get; protected set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [IgnoreDataMember]
        public Organization FunderOrganization
        {
            get => this.Funder as Organization;
            set => this.Funder = value;
        }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [IgnoreDataMember]
        public Person FunderPerson
        {
            get => this.Funder as Person;
            set => this.Funder = value;
        }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [DataMember(Name = "position")]
        public object Position { get; protected set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [IgnoreDataMember]
        public int? PositionInteger
        {
            get => this.Position as int?;
            set => this.Position = value;
        }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [IgnoreDataMember]
        public string PositionText
        {
            get => this.Position as string;
            set => this.Position = value;
        }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor")]
        public object Sponsor { get; protected set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [IgnoreDataMember]
        public Organization SponsorOrganization
        {
            get => this.Sponsor as Organization;
            set => this.Sponsor = value;
        }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [IgnoreDataMember]
        public Person SponsorPerson
        {
            get => this.Sponsor as Person;
            set => this.Sponsor = value;
        }

        /// <summary>
        /// An embedded audio object.
        /// </summary>
        [DataMember(Name = "audio")]
        public AudioObject Audio { get; set; }

        /// <summary>
        /// Example/instance/realization/derivation of the concept of this creative work. eg. The paperback edition, first edition, or eBook.
        /// </summary>
        [DataMember(Name = "workExample")]
        public CreativeWork WorkExample { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider")]
        public object Provider { get; protected set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [IgnoreDataMember]
        public Organization ProviderOrganization
        {
            get => this.Provider as Organization;
            set => this.Provider = value;
        }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [IgnoreDataMember]
        public Person ProviderPerson
        {
            get => this.Provider as Person;
            set => this.Provider = value;
        }

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a synonym for associatedMedia.
        /// </summary>
        [DataMember(Name = "encoding")]
        public MediaObject Encoding { get; set; }

        /// <summary>
        /// The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
        /// </summary>
        [DataMember(Name = "interactivityType")]
        public string InteractivityType { get; set; }

        /// <summary>
        /// Fictional person connected with a creative work.
        /// </summary>
        [DataMember(Name = "character")]
        public Person Character { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience")]
        public Audience Audience { get; set; }

        /// <summary>
        /// The Organization on whose behalf the creator was working.
        /// </summary>
        [DataMember(Name = "sourceOrganization")]
        public Organization SourceOrganization { get; set; }

        /// <summary>
        /// Indicates a CreativeWork that this CreativeWork is (in some sense) part of.
        /// </summary>
        [DataMember(Name = "isPartOf")]
        public CreativeWork IsPartOf { get; set; }

        /// <summary>
        /// An embedded video object.
        /// </summary>
        [DataMember(Name = "video")]
        public VideoObject Video { get; set; }

        /// <summary>
        /// A publication event associated with the item.
        /// </summary>
        [DataMember(Name = "publication")]
        public PublicationEvent Publication { get; set; }

        /// <summary>
        /// The textual content of this CreativeWork.
        /// </summary>
        [DataMember(Name = "text")]
        public string Text { get; set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [DataMember(Name = "contributor")]
        public object Contributor { get; protected set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [IgnoreDataMember]
        public Person ContributorPerson
        {
            get => this.Contributor as Person;
            set => this.Contributor = value;
        }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [IgnoreDataMember]
        public Organization ContributorOrganization
        {
            get => this.Contributor as Organization;
            set => this.Contributor = value;
        }

        /// <summary>
        /// The publisher of the creative work.
        /// </summary>
        [DataMember(Name = "publisher")]
        public object Publisher { get; protected set; }

        /// <summary>
        /// The publisher of the creative work.
        /// </summary>
        [IgnoreDataMember]
        public Organization PublisherOrganization
        {
            get => this.Publisher as Organization;
            set => this.Publisher = value;
        }

        /// <summary>
        /// The publisher of the creative work.
        /// </summary>
        [IgnoreDataMember]
        public Person PublisherPerson
        {
            get => this.Publisher as Person;
            set => this.Publisher = value;
        }

        /// <summary>
        /// The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        [DataMember(Name = "typicalAgeRange")]
        public string TypicalAgeRange { get; set; }

        /// <summary>
        /// The place and time the release was issued, expressed as a PublicationEvent.
        /// </summary>
        [DataMember(Name = "releasedEvent")]
        public PublicationEvent ReleasedEvent { get; set; }

        /// <summary>
        /// The location depicted or described in the content. For example, the location in a photograph or painting.
        /// </summary>
        [DataMember(Name = "contentLocation")]
        public Place ContentLocation { get; set; }

        /// <summary>
        /// Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.
        /// </summary>
        [DataMember(Name = "schemaVersion")]
        public object SchemaVersion { get; protected set; }

        /// <summary>
        /// Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.
        /// </summary>
        [IgnoreDataMember]
        public Uri SchemaVersionURL
        {
            get => this.SchemaVersion as Uri;
            set => this.SchemaVersion = value;
        }

        /// <summary>
        /// Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as http://schema.org/version/2.0/ if precise indication of schema version was required by some application.
        /// </summary>
        [IgnoreDataMember]
        public string SchemaVersionText
        {
            get => this.SchemaVersion as string;
            set => this.SchemaVersion = value;
        }

        /// <summary>
        /// Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityFeature")]
        public string AccessibilityFeature { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.
        /// </summary>
        [DataMember(Name = "locationCreated")]
        public Place LocationCreated { get; set; }

        /// <summary>
        /// A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource. Expected values include:  auditory, tactile, textual, visual.
        /// </summary>
        [DataMember(Name = "accessModeSufficient")]
        public string AccessModeSufficient { get; set; }

        /// <summary>
        /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in &lt;a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals"&gt;ISO 8601 time interval format&lt;/a&gt;. In
        ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
        ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".
        /// </summary>
        [DataMember(Name = "temporalCoverage")]
        public object TemporalCoverage { get; protected set; }

        /// <summary>
        /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in &lt;a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals"&gt;ISO 8601 time interval format&lt;/a&gt;. In
        ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
        ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".
        /// </summary>
        [IgnoreDataMember]
        public string TemporalCoverageText
        {
            get => this.TemporalCoverage as string;
            set => this.TemporalCoverage = value;
        }

        /// <summary>
        /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in &lt;a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals"&gt;ISO 8601 time interval format&lt;/a&gt;. In
        ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
        ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".
        /// </summary>
        [IgnoreDataMember]
        public DateTimeOffset? TemporalCoverageDateTime
        {
            get => this.TemporalCoverage as DateTimeOffset?;
            set => this.TemporalCoverage = value;
        }

        /// <summary>
        /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in &lt;a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals"&gt;ISO 8601 time interval format&lt;/a&gt;. In
        ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
        ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".
        /// </summary>
        [IgnoreDataMember]
        public Uri TemporalCoverageURL
        {
            get => this.TemporalCoverage as Uri;
            set => this.TemporalCoverage = value;
        }

        /// <summary>
        /// Specifies the Person that is legally accountable for the CreativeWork.
        /// </summary>
        [DataMember(Name = "accountablePerson")]
        public Person AccountablePerson { get; set; }

        /// <summary>
        /// The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of
        ///       contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates
        ///       areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York.
        /// </summary>
        [DataMember(Name = "spatialCoverage")]
        public Place SpatialCoverage { get; set; }

        /// <summary>
        /// A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed."
        /// </summary>
        [DataMember(Name = "accessibilitySummary")]
        public string AccessibilitySummary { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers")]
        public Offer Offers { get; set; }

        /// <summary>
        /// Specifies the Person who edited the CreativeWork.
        /// </summary>
        [DataMember(Name = "editor")]
        public Person Editor { get; set; }

        /// <summary>
        /// A link to the page containing the comments of the CreativeWork.
        /// </summary>
        [DataMember(Name = "discussionUrl")]
        public Uri DiscussionUrl { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award")]
        public string Award { get; set; }

        /// <summary>
        /// The party holding the legal copyright to the CreativeWork.
        /// </summary>
        [DataMember(Name = "copyrightHolder")]
        public object CopyrightHolder { get; protected set; }

        /// <summary>
        /// The party holding the legal copyright to the CreativeWork.
        /// </summary>
        [IgnoreDataMember]
        public Person CopyrightHolderPerson
        {
            get => this.CopyrightHolder as Person;
            set => this.CopyrightHolder = value;
        }

        /// <summary>
        /// The party holding the legal copyright to the CreativeWork.
        /// </summary>
        [IgnoreDataMember]
        public Organization CopyrightHolderOrganization
        {
            get => this.CopyrightHolder as Organization;
            set => this.CopyrightHolder = value;
        }

        /// <summary>
        /// A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3 (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityHazard")]
        public string AccessibilityHazard { get; set; }

        /// <summary>
        /// The year during which the claimed copyright for the CreativeWork was first asserted.
        /// </summary>
        [DataMember(Name = "copyrightYear")]
        public decimal CopyrightYear { get; set; }

        /// <summary>
        /// The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.
        /// </summary>
        [DataMember(Name = "recordedAt")]
        public Event RecordedAt { get; set; }

        /// <summary>
        /// The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.
        /// </summary>
        [DataMember(Name = "commentCount")]
        public int CommentCount { get; set; }

        /// <summary>
        /// Media type, typically MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt;) of the content e.g. application/zip of a SoftwareApplication binary. In cases where a CreativeWork has several media type representations, 'encoding' can be used to indicate each MediaObject alongside particular fileFormat information. Unregistered or niche file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia entry.
        /// </summary>
        [DataMember(Name = "fileFormat")]
        public object FileFormat { get; protected set; }

        /// <summary>
        /// Media type, typically MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt;) of the content e.g. application/zip of a SoftwareApplication binary. In cases where a CreativeWork has several media type representations, 'encoding' can be used to indicate each MediaObject alongside particular fileFormat information. Unregistered or niche file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia entry.
        /// </summary>
        [IgnoreDataMember]
        public Uri FileFormatURL
        {
            get => this.FileFormat as Uri;
            set => this.FileFormat = value;
        }

        /// <summary>
        /// Media type, typically MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt;) of the content e.g. application/zip of a SoftwareApplication binary. In cases where a CreativeWork has several media type representations, 'encoding' can be used to indicate each MediaObject alongside particular fileFormat information. Unregistered or niche file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia entry.
        /// </summary>
        [IgnoreDataMember]
        public string FileFormatText
        {
            get => this.FileFormat as string;
            set => this.FileFormat = value;
        }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage")]
        public object InLanguage { get; protected set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public Language InLanguageLanguage
        {
            get => this.InLanguage as Language;
            set => this.InLanguage = value;
        }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [IgnoreDataMember]
        public string InLanguageText
        {
            get => this.InLanguage as string;
            set => this.InLanguage = value;
        }

        /// <summary>
        /// Indicates that the resource is compatible with the referenced accessibility API (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityAPI")]
        public string AccessibilityAPI { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
        /// </summary>
        [DataMember(Name = "interactionStatistic")]
        public InteractionCounter InteractionStatistic { get; set; }

        /// <summary>
        /// Official rating of a piece of content&amp;#x2014;for example,'MPAA PG-13'.
        /// </summary>
        [DataMember(Name = "contentRating")]
        public string ContentRating { get; set; }

        /// <summary>
        /// The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.
        /// </summary>
        [DataMember(Name = "learningResourceType")]
        public string LearningResourceType { get; set; }

        /// <summary>
        /// The human sensory perceptual system or cognitive faculty through which a person may process or perceive information. Expected values include: auditory, tactile, textual, visual, colorDependent, chartOnVisual, chemOnVisual, diagramOnVisual, mathOnVisual, musicOnVisual, textOnVisual.
        /// </summary>
        [DataMember(Name = "accessMode")]
        public string AccessMode { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [DataMember(Name = "material")]
        public object Material { get; protected set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [IgnoreDataMember]
        public Uri MaterialURL
        {
            get => this.Material as Uri;
            set => this.Material = value;
        }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [IgnoreDataMember]
        public Product MaterialProduct
        {
            get => this.Material as Product;
            set => this.Material = value;
        }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [IgnoreDataMember]
        public string MaterialText
        {
            get => this.Material as string;
            set => this.Material = value;
        }

        /// <summary>
        /// Indicates whether this content is family friendly.
        /// </summary>
        [DataMember(Name = "isFamilyFriendly")]
        public bool IsFamilyFriendly { get; set; }

        /// <summary>
        /// A creative work that this work is an example/instance/realization/derivation of.
        /// </summary>
        [DataMember(Name = "exampleOfWork")]
        public CreativeWork ExampleOfWork { get; set; }

        /// <summary>
        /// The version of the CreativeWork embodied by a specified resource.
        /// </summary>
        [DataMember(Name = "version")]
        public object Version { get; protected set; }

        /// <summary>
        /// The version of the CreativeWork embodied by a specified resource.
        /// </summary>
        [IgnoreDataMember]
        public decimal? VersionNumber
        {
            get => this.Version as decimal?;
            set => this.Version = value;
        }

        /// <summary>
        /// The version of the CreativeWork embodied by a specified resource.
        /// </summary>
        [IgnoreDataMember]
        public string VersionText
        {
            get => this.Version as string;
            set => this.Version = value;
        }

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        /// </summary>
        [DataMember(Name = "dateModified")]
        public DateTimeOffset DateModified { get; set; }

        /// <summary>
        /// Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.
        /// </summary>
        [DataMember(Name = "keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [DataMember(Name = "genre")]
        public object Genre { get; protected set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [IgnoreDataMember]
        public string GenreText
        {
            get => this.Genre as string;
            set => this.Genre = value;
        }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [IgnoreDataMember]
        public Uri GenreURL
        {
            get => this.Genre as Uri;
            set => this.Genre = value;
        }

        /// <summary>
        /// Indicates the primary entity described in some page or other CreativeWork.
        /// </summary>
        [DataMember(Name = "mainEntity")]
        public Thing MainEntity { get; set; }

        /// <summary>
        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        [DataMember(Name = "author")]
        public object Author { get; protected set; }

        /// <summary>
        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        [IgnoreDataMember]
        public Organization AuthorOrganization
        {
            get => this.Author as Organization;
            set => this.Author = value;
        }

        /// <summary>
        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        [IgnoreDataMember]
        public Person AuthorPerson
        {
            get => this.Author as Person;
            set => this.Author = value;
        }

        /// <summary>
        /// A secondary title of the CreativeWork.
        /// </summary>
        [DataMember(Name = "alternativeHeadline")]
        public string AlternativeHeadline { get; set; }

        /// <summary>
        /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'P30M', 'P1H25M'.
        /// </summary>
        [DataMember(Name = "timeRequired")]
        public Duration TimeRequired { get; set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [DataMember(Name = "translator")]
        public object Translator { get; protected set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [IgnoreDataMember]
        public Person TranslatorPerson
        {
            get => this.Translator as Person;
            set => this.Translator = value;
        }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [IgnoreDataMember]
        public Organization TranslatorOrganization
        {
            get => this.Translator as Organization;
            set => this.Translator = value;
        }

        /// <summary>
        /// A thumbnail image relevant to the Thing.
        /// </summary>
        [DataMember(Name = "thumbnailUrl")]
        public Uri ThumbnailUrl { get; set; }

        /// <summary>
        /// Indicates a CreativeWork that is (in some sense) a part of this CreativeWork.
        /// </summary>
        [DataMember(Name = "hasPart")]
        public CreativeWork HasPart { get; set; }

        /// <summary>
        /// Comments, typically from users.
        /// </summary>
        [DataMember(Name = "comment")]
        public Comment Comment { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review")]
        public Review Review { get; set; }

        /// <summary>
        /// A license document that applies to this content, typically indicated by URL.
        /// </summary>
        [DataMember(Name = "license")]
        public object License { get; protected set; }

        /// <summary>
        /// A license document that applies to this content, typically indicated by URL.
        /// </summary>
        [IgnoreDataMember]
        public CreativeWork LicenseCreativeWork
        {
            get => this.License as CreativeWork;
            set => this.License = value;
        }

        /// <summary>
        /// A license document that applies to this content, typically indicated by URL.
        /// </summary>
        [IgnoreDataMember]
        public Uri LicenseURL
        {
            get => this.License as Uri;
            set => this.License = value;
        }

        /// <summary>
        /// Identifies input methods that are sufficient to fully control the described resource (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityControl")]
        public string AccessibilityControl { get; set; }

        /// <summary>
        /// Headline of the article.
        /// </summary>
        [DataMember(Name = "headline")]
        public string Headline { get; set; }

        /// <summary>
        /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html.
        /// </summary>
        [DataMember(Name = "isBasedOn")]
        public object IsBasedOn { get; protected set; }

        /// <summary>
        /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html.
        /// </summary>
        [IgnoreDataMember]
        public Uri IsBasedOnURL
        {
            get => this.IsBasedOn as Uri;
            set => this.IsBasedOn = value;
        }

        /// <summary>
        /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html.
        /// </summary>
        [IgnoreDataMember]
        public CreativeWork IsBasedOnCreativeWork
        {
            get => this.IsBasedOn as CreativeWork;
            set => this.IsBasedOn = value;
        }

        /// <summary>
        /// A resource that was used in the creation of this resource. This term can be repeated for multiple sources. For example, http://example.com/great-multiplication-intro.html.
        /// </summary>
        [IgnoreDataMember]
        public Product IsBasedOnProduct
        {
            get => this.IsBasedOn as Product;
            set => this.IsBasedOn = value;
        }

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        /// </summary>
        [DataMember(Name = "creator")]
        public object Creator { get; protected set; }

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        /// </summary>
        [IgnoreDataMember]
        public Person CreatorPerson
        {
            get => this.Creator as Person;
            set => this.Creator = value;
        }

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        /// </summary>
        [IgnoreDataMember]
        public Organization CreatorOrganization
        {
            get => this.Creator as Organization;
            set => this.Creator = value;
        }

        /// <summary>
        /// Link to page describing the editorial principles of the organization primarily responsible for the creation of the CreativeWork.
        /// </summary>
        [DataMember(Name = "publishingPrinciples")]
        public Uri PublishingPrinciples { get; set; }

        /// <summary>
        /// The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).
        /// </summary>
        [DataMember(Name = "producer")]
        public object Producer { get; protected set; }

        /// <summary>
        /// The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).
        /// </summary>
        [IgnoreDataMember]
        public Organization ProducerOrganization
        {
            get => this.Producer as Organization;
            set => this.Producer = value;
        }

        /// <summary>
        /// The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).
        /// </summary>
        [IgnoreDataMember]
        public Person ProducerPerson
        {
            get => this.Producer as Person;
            set => this.Producer = value;
        }

        /// <summary>
        /// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
        /// </summary>
        [DataMember(Name = "mentions")]
        public Thing Mentions { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        /// </summary>
        [DataMember(Name = "dateCreated")]
        public DateTimeOffset DateCreated { get; set; }

        /// <summary>
        /// The purpose of a work in the context of education; for example, 'assignment', 'group work'.
        /// </summary>
        [DataMember(Name = "educationalUse")]
        public string EducationalUse { get; set; }

        /// <summary>
        /// Date of first broadcast/publication.
        /// </summary>
        [DataMember(Name = "datePublished")]
        public DateTimeOffset DatePublished { get; set; }

        /// <summary>
        /// A flag to signal that the publication is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree")]
        public bool IsAccessibleForFree { get; set; }

        /// <summary>
        /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
        /// </summary>
        [DataMember(Name = "citation")]
        public object Citation { get; protected set; }

        /// <summary>
        /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
        /// </summary>
        [IgnoreDataMember]
        public CreativeWork CitationCreativeWork
        {
            get => this.Citation as CreativeWork;
            set => this.Citation = value;
        }

        /// <summary>
        /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
        /// </summary>
        [IgnoreDataMember]
        public string CitationText
        {
            get => this.Citation as string;
            set => this.Citation = value;
        }
    }
}

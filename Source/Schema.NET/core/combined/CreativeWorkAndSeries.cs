namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See CreativeWork, Series for more information.
    /// </summary>
    public partial interface ICreativeWorkAndSeries : ICreativeWork, ISeries
    {
    }

    /// <summary>
    /// See CreativeWork, Series for more information.
    /// </summary>
    [DataContract]
    public abstract partial class CreativeWorkAndSeries : Intangible, ICreativeWorkAndSeries, IEquatable<CreativeWorkAndSeries>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CreativeWorkAndSeries";

        /// <summary>
        /// The subject matter of the content.
        /// </summary>
        [DataMember(Name = "about", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> About { get; set; }

        /// <summary>
        /// An abstract is a short description that summarizes a &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "abstract", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Abstract { get; set; }

        /// <summary>
        /// Indicates that the resource is compatible with the referenced accessibility API (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityAPI", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccessibilityAPI { get; set; }

        /// <summary>
        /// Identifies input methods that are sufficient to fully control the described resource (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityControl", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccessibilityControl { get; set; }

        /// <summary>
        /// Content features of the resource, such as accessible media, alternatives and supported enhancements for accessibility (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityFeature", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccessibilityFeature { get; set; }

        /// <summary>
        /// A characteristic of the described resource that is physiologically dangerous to some users. Related to WCAG 2.0 guideline 2.3 (&lt;a href="http://www.w3.org/wiki/WebSchemas/Accessibility"&gt;WebSchemas wiki lists possible values&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "accessibilityHazard", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccessibilityHazard { get; set; }

        /// <summary>
        /// A human-readable summary of specific accessibility features or deficiencies, consistent with the other accessibility metadata but expressing subtleties such as "short descriptions are present but long descriptions will be needed for non-visual users" or "short descriptions are present and no long descriptions are needed."
        /// </summary>
        [DataMember(Name = "accessibilitySummary", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccessibilitySummary { get; set; }

        /// <summary>
        /// The human sensory perceptual system or cognitive faculty through which a person may process or perceive information. Expected values include: auditory, tactile, textual, visual, colorDependent, chartOnVisual, chemOnVisual, diagramOnVisual, mathOnVisual, musicOnVisual, textOnVisual.
        /// </summary>
        [DataMember(Name = "accessMode", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AccessMode { get; set; }

        /// <summary>
        /// A list of single or combined accessModes that are sufficient to understand all the intellectual content of a resource. Expected values include:  auditory, tactile, textual, visual.
        /// </summary>
        [DataMember(Name = "accessModeSufficient", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IItemList> AccessModeSufficient { get; set; }

        /// <summary>
        /// Specifies the Person that is legally accountable for the CreativeWork.
        /// </summary>
        [DataMember(Name = "accountablePerson", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> AccountablePerson { get; set; }

        /// <summary>
        /// Indicates a page documenting how licenses can be purchased or otherwise acquired, for the current item.
        /// </summary>
        [DataMember(Name = "acquireLicensePage", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> AcquireLicensePage { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 217)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// A secondary title of the CreativeWork.
        /// </summary>
        [DataMember(Name = "alternativeHeadline", Order = 218)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AlternativeHeadline { get; set; }

        /// <summary>
        /// The item being described is intended to assess the competency or learning outcome defined by the referenced term.
        /// </summary>
        [DataMember(Name = "assesses", Order = 219)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Assesses { get; set; }

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a synonym for encoding.
        /// </summary>
        [DataMember(Name = "associatedMedia", Order = 220)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMediaObject> AssociatedMedia { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 221)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// An embedded audio object.
        /// </summary>
        [DataMember(Name = "audio", Order = 222)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAudioObject, IClip, IMusicRecording> Audio { get; set; }

        /// <summary>
        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        [DataMember(Name = "author", Order = 223)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Author { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 224)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Award { get; set; }

        /// <summary>
        /// Fictional person connected with a creative work.
        /// </summary>
        [DataMember(Name = "character", Order = 225)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Character { get; set; }

        /// <summary>
        /// A citation or reference to another creative work, such as another publication, web page, scholarly article, etc.
        /// </summary>
        [DataMember(Name = "citation", Order = 226)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, string> Citation { get; set; }

        /// <summary>
        /// Comments, typically from users.
        /// </summary>
        [DataMember(Name = "comment", Order = 227)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IComment> Comment { get; set; }

        /// <summary>
        /// The number of comments this CreativeWork (e.g. Article, Question or Answer) has received. This is most applicable to works published in Web sites with commenting system; additional comments may exist elsewhere.
        /// </summary>
        [DataMember(Name = "commentCount", Order = 228)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> CommentCount { get; set; }

        /// <summary>
        /// Conditions that affect the availability of, or method(s) of access to, an item. Typically used for real world items such as an &lt;a class="localLink" href="https://schema.org/ArchiveComponent"&gt;ArchiveComponent&lt;/a&gt; held by an &lt;a class="localLink" href="https://schema.org/ArchiveOrganization"&gt;ArchiveOrganization&lt;/a&gt;. This property is not suitable for use as a general Web access control mechanism. It is expressed only in natural language.&lt;br/&gt;&lt;br/&gt;
        /// For example "Available by appointment from the Reading Room" or "Accessible only from logged-in accounts ".
        /// </summary>
        [DataMember(Name = "conditionsOfAccess", Order = 229)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ConditionsOfAccess { get; set; }

        /// <summary>
        /// The location depicted or described in the content. For example, the location in a photograph or painting.
        /// </summary>
        [DataMember(Name = "contentLocation", Order = 230)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> ContentLocation { get; set; }

        /// <summary>
        /// Official rating of a piece of content&amp;#x2014;for example,'MPAA PG-13'.
        /// </summary>
        [DataMember(Name = "contentRating", Order = 231)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IRating, string> ContentRating { get; set; }

        /// <summary>
        /// The specific time described by a creative work, for works (e.g. articles, video objects etc.) that emphasise a particular moment within an Event.
        /// </summary>
        [DataMember(Name = "contentReferenceTime", Order = 232)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> ContentReferenceTime { get; set; }

        /// <summary>
        /// A secondary contributor to the CreativeWork or Event.
        /// </summary>
        [DataMember(Name = "contributor", Order = 233)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Contributor { get; set; }

        /// <summary>
        /// The party holding the legal copyright to the CreativeWork.
        /// </summary>
        [DataMember(Name = "copyrightHolder", Order = 234)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> CopyrightHolder { get; set; }

        /// <summary>
        /// The year during which the claimed copyright for the CreativeWork was first asserted.
        /// </summary>
        [DataMember(Name = "copyrightYear", Order = 235)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> CopyrightYear { get; set; }

        /// <summary>
        /// Indicates a correction to a &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;, either via a &lt;a class="localLink" href="https://schema.org/CorrectionComment"&gt;CorrectionComment&lt;/a&gt;, textually or in another document.
        /// </summary>
        [DataMember(Name = "correction", Order = 236)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> Correction { get; set; }

        /// <summary>
        /// The status of a creative work in terms of its stage in a lifecycle. Example terms include Incomplete, Draft, Published, Obsolete. Some organizations define a set of terms for the stages of their publication lifecycle.
        /// </summary>
        [DataMember(Name = "creativeWorkStatus", Order = 237)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CreativeWorkStatus { get; set; }

        /// <summary>
        /// The creator/author of this CreativeWork. This is the same as the Author property for CreativeWork.
        /// </summary>
        [DataMember(Name = "creator", Order = 238)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Creator { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was created or the item was added to a DataFeed.
        /// </summary>
        [DataMember(Name = "dateCreated", Order = 239)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DateCreated { get; set; }

        /// <summary>
        /// The date on which the CreativeWork was most recently modified or when the item's entry was modified within a DataFeed.
        /// </summary>
        [DataMember(Name = "dateModified", Order = 240)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DateModified { get; set; }

        /// <summary>
        /// Date of first broadcast/publication.
        /// </summary>
        [DataMember(Name = "datePublished", Order = 241)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?, DateTimeOffset?> DatePublished { get; set; }

        /// <summary>
        /// A link to the page containing the comments of the CreativeWork.
        /// </summary>
        [DataMember(Name = "discussionUrl", Order = 242)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> DiscussionUrl { get; set; }

        /// <summary>
        /// An &lt;a href="https://eidr.org/"&gt;EIDR&lt;/a&gt; (Entertainment Identifier Registry) &lt;a class="localLink" href="https://schema.org/identifier"&gt;identifier&lt;/a&gt; representing a specific edit / edition for a work of film or television.&lt;br/&gt;&lt;br/&gt;
        /// For example, the motion picture known as "Ghostbusters" whose &lt;a class="localLink" href="https://schema.org/titleEIDR"&gt;titleEIDR&lt;/a&gt; is "10.5240/7EC7-228A-510A-053E-CBB8-J", has several edits e.g. "10.5240/1F2A-E1C5-680A-14C6-E76B-I" and "10.5240/8A35-3BEE-6497-5D12-9E4F-3".&lt;br/&gt;&lt;br/&gt;
        /// Since schema.org types like &lt;a class="localLink" href="https://schema.org/Movie"&gt;Movie&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/TVEpisode"&gt;TVEpisode&lt;/a&gt; can be used for both works and their multiple expressions, it is possible to use &lt;a class="localLink" href="https://schema.org/titleEIDR"&gt;titleEIDR&lt;/a&gt; alone (for a general description), or alongside &lt;a class="localLink" href="https://schema.org/editEIDR"&gt;editEIDR&lt;/a&gt; for a more edit-specific description.
        /// </summary>
        [DataMember(Name = "editEIDR", Order = 243)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> EditEIDR { get; set; }

        /// <summary>
        /// Specifies the Person who edited the CreativeWork.
        /// </summary>
        [DataMember(Name = "editor", Order = 244)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Editor { get; set; }

        /// <summary>
        /// An alignment to an established educational framework.&lt;br/&gt;&lt;br/&gt;
        /// This property should not be used where the nature of the alignment can be described using a simple property, for example to express that a resource &lt;a class="localLink" href="https://schema.org/teaches"&gt;teaches&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/assesses"&gt;assesses&lt;/a&gt; a competency.
        /// </summary>
        [DataMember(Name = "educationalAlignment", Order = 245)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAlignmentObject> EducationalAlignment { get; set; }

        /// <summary>
        /// The level in terms of progression through an educational or training context. Examples of educational levels include 'beginner', 'intermediate' or 'advanced', and formal sets of level indicators.
        /// </summary>
        [DataMember(Name = "educationalLevel", Order = 246)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> EducationalLevel { get; set; }

        /// <summary>
        /// The purpose of a work in the context of education; for example, 'assignment', 'group work'.
        /// </summary>
        [DataMember(Name = "educationalUse", Order = 247)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> EducationalUse { get; set; }

        /// <summary>
        /// A media object that encodes this CreativeWork. This property is a synonym for associatedMedia.
        /// </summary>
        [DataMember(Name = "encoding", Order = 248)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMediaObject> Encoding { get; set; }

        /// <summary>
        /// Media type typically expressed using a MIME format (see &lt;a href="http://www.iana.org/assignments/media-types/media-types.xhtml"&gt;IANA site&lt;/a&gt; and &lt;a href="https://developer.mozilla.org/en-US/docs/Web/HTTP/Basics_of_HTTP/MIME_types"&gt;MDN reference&lt;/a&gt;) e.g. application/zip for a SoftwareApplication binary, audio/mpeg for .mp3 etc.).&lt;br/&gt;&lt;br/&gt;
        /// In cases where a &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; has several media type representations, &lt;a class="localLink" href="https://schema.org/encoding"&gt;encoding&lt;/a&gt; can be used to indicate each &lt;a class="localLink" href="https://schema.org/MediaObject"&gt;MediaObject&lt;/a&gt; alongside particular &lt;a class="localLink" href="https://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt; information.&lt;br/&gt;&lt;br/&gt;
        /// Unregistered or niche encoding and file formats can be indicated instead via the most appropriate URL, e.g. defining Web page or a Wikipedia/Wikidata entry.
        /// </summary>
        [DataMember(Name = "encodingFormat", Order = 249)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> EncodingFormat { get; set; }

        /// <summary>
        /// A creative work that this work is an example/instance/realization/derivation of.
        /// </summary>
        [DataMember(Name = "exampleOfWork", Order = 250)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> ExampleOfWork { get; set; }

        /// <summary>
        /// Date the content expires and is no longer useful or available. For example a &lt;a class="localLink" href="https://schema.org/VideoObject"&gt;VideoObject&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt; whose availability or relevance is time-limited, or a &lt;a class="localLink" href="https://schema.org/ClaimReview"&gt;ClaimReview&lt;/a&gt; fact check whose publisher wants to indicate that it may no longer be relevant (or helpful to highlight) after some date.
        /// </summary>
        [DataMember(Name = "expires", Order = 251)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> Expires { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 252)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Funder { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [DataMember(Name = "genre", Order = 253)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> Genre { get; set; }

        /// <summary>
        /// Indicates an item or CreativeWork that is part of this item, or CreativeWork (in some sense).
        /// </summary>
        [DataMember(Name = "hasPart", Order = 254)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> HasPart { get; set; }

        /// <summary>
        /// Headline of the article.
        /// </summary>
        [DataMember(Name = "headline", Order = 255)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Headline { get; set; }

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="https://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage", Order = 256)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> InLanguage { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
        /// </summary>
        [DataMember(Name = "interactionStatistic", Order = 257)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IInteractionCounter> InteractionStatistic { get; set; }

        /// <summary>
        /// The predominant mode of learning supported by the learning resource. Acceptable values are 'active', 'expositive', or 'mixed'.
        /// </summary>
        [DataMember(Name = "interactivityType", Order = 258)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> InteractivityType { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 259)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsAccessibleForFree { get; set; }

        /// <summary>
        /// A resource from which this work is derived or from which it is a modification or adaption.
        /// </summary>
        [DataMember(Name = "isBasedOn", Order = 260)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, IProduct, Uri> IsBasedOn { get; set; }

        /// <summary>
        /// Indicates whether this content is family friendly.
        /// </summary>
        [DataMember(Name = "isFamilyFriendly", Order = 261)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsFamilyFriendly { get; set; }

        /// <summary>
        /// Indicates an item or CreativeWork that this item, or CreativeWork (in some sense), is part of.
        /// </summary>
        [DataMember(Name = "isPartOf", Order = 262)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> IsPartOf { get; set; }

        /// <summary>
        /// Keywords or tags used to describe this content. Multiple entries in a keywords list are typically delimited by commas.
        /// </summary>
        [DataMember(Name = "keywords", Order = 263)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Keywords { get; set; }

        /// <summary>
        /// The predominant type or kind characterizing the learning resource. For example, 'presentation', 'handout'.
        /// </summary>
        [DataMember(Name = "learningResourceType", Order = 264)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> LearningResourceType { get; set; }

        /// <summary>
        /// A license document that applies to this content, typically indicated by URL.
        /// </summary>
        [DataMember(Name = "license", Order = 265)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> License { get; set; }

        /// <summary>
        /// The location where the CreativeWork was created, which may not be the same as the location depicted in the CreativeWork.
        /// </summary>
        [DataMember(Name = "locationCreated", Order = 266)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> LocationCreated { get; set; }

        /// <summary>
        /// Indicates the primary entity described in some page or other CreativeWork.
        /// </summary>
        [DataMember(Name = "mainEntity", Order = 267)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> MainEntity { get; set; }

        /// <summary>
        /// A maintainer of a &lt;a class="localLink" href="https://schema.org/Dataset"&gt;Dataset&lt;/a&gt;, software package (&lt;a class="localLink" href="https://schema.org/SoftwareApplication"&gt;SoftwareApplication&lt;/a&gt;), or other &lt;a class="localLink" href="https://schema.org/Project"&gt;Project&lt;/a&gt;. A maintainer is a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt; or &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; that manages contributions to, and/or publication of, some (typically complex) artifact. It is common for distributions of software and data to be based on "upstream" sources. When &lt;a class="localLink" href="https://schema.org/maintainer"&gt;maintainer&lt;/a&gt; is applied to a specific version of something e.g. a particular version or packaging of a &lt;a class="localLink" href="https://schema.org/Dataset"&gt;Dataset&lt;/a&gt;, it is always  possible that the upstream source has a different maintainer. The &lt;a class="localLink" href="https://schema.org/isBasedOn"&gt;isBasedOn&lt;/a&gt; property can be used to indicate such relationships between datasets to make the different maintenance roles clear. Similarly in the case of software, a package may have dedicated maintainers working on integration into software distributions such as Ubuntu, as well as upstream maintainers of the underlying work.
        /// </summary>
        [DataMember(Name = "maintainer", Order = 268)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Maintainer { get; set; }

        /// <summary>
        /// A material that something is made from, e.g. leather, wool, cotton, paper.
        /// </summary>
        [DataMember(Name = "material", Order = 269)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, string, Uri> Material { get; set; }

        /// <summary>
        /// The quantity of the materials being described or an expression of the physical space they occupy.
        /// </summary>
        [DataMember(Name = "materialExtent", Order = 270)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IQuantitativeValue, string> MaterialExtent { get; set; }

        /// <summary>
        /// Indicates that the CreativeWork contains a reference to, but is not necessarily about a concept.
        /// </summary>
        [DataMember(Name = "mentions", Order = 271)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing> Mentions { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="https://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
        /// </summary>
        [DataMember(Name = "offers", Order = 272)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IDemand, IOffer> Offers { get; set; }

        /// <summary>
        /// A pattern that something has, for example 'polka dot', 'striped', 'Canadian flag'. Values are typically expressed as text, although links to controlled value schemes are also supported.
        /// </summary>
        [DataMember(Name = "pattern", Order = 273)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Pattern { get; set; }

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [DataMember(Name = "position", Order = 274)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> Position { get; set; }

        /// <summary>
        /// The person or organization who produced the work (e.g. music album, movie, tv/radio series etc.).
        /// </summary>
        [DataMember(Name = "producer", Order = 275)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Producer { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 276)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// A publication event associated with the item.
        /// </summary>
        [DataMember(Name = "publication", Order = 277)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPublicationEvent> Publication { get; set; }

        /// <summary>
        /// The publisher of the creative work.
        /// </summary>
        [DataMember(Name = "publisher", Order = 278)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Publisher { get; set; }

        /// <summary>
        /// The publishing division which published the comic.
        /// </summary>
        [DataMember(Name = "publisherImprint", Order = 279)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> PublisherImprint { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="https://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="https://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="https://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 280)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> PublishingPrinciples { get; set; }

        /// <summary>
        /// The Event where the CreativeWork was recorded. The CreativeWork may capture all or part of the event.
        /// </summary>
        [DataMember(Name = "recordedAt", Order = 281)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> RecordedAt { get; set; }

        /// <summary>
        /// The place and time the release was issued, expressed as a PublicationEvent.
        /// </summary>
        [DataMember(Name = "releasedEvent", Order = 282)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPublicationEvent> ReleasedEvent { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 283)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// Indicates (by URL or string) a particular version of a schema used in some CreativeWork. For example, a document could declare a schemaVersion using an URL such as https://schema.org/version/2.0/ if precise indication of schema version was required by some application.
        /// </summary>
        [DataMember(Name = "schemaVersion", Order = 284)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> SchemaVersion { get; set; }

        /// <summary>
        /// Indicates the date on which the current structured data was generated / published. Typically used alongside &lt;a class="localLink" href="https://schema.org/sdPublisher"&gt;sdPublisher&lt;/a&gt;
        /// </summary>
        [DataMember(Name = "sdDatePublished", Order = 285)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> SdDatePublished { get; set; }

        /// <summary>
        /// A license document that applies to this structured data, typically indicated by URL.
        /// </summary>
        [DataMember(Name = "sdLicense", Order = 286)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> SdLicense { get; set; }

        /// <summary>
        /// Indicates the party responsible for generating and publishing the current structured data markup, typically in cases where the structured data is derived automatically from existing published content but published on a different site. For example, student projects and open data initiatives often re-publish existing content with more explicitly structured metadata. The
        /// &lt;a class="localLink" href="https://schema.org/sdPublisher"&gt;sdPublisher&lt;/a&gt; property helps make such practices more explicit.
        /// </summary>
        [DataMember(Name = "sdPublisher", Order = 287)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> SdPublisher { get; set; }

        /// <summary>
        /// A standardized size of a product or creative work, often simplifying richer information into a simple textual string, either through referring to named sizes or (in the case of product markup), by adopting conventional simplifications. Use of QuantitativeValue with a unitCode or unitText can add more structure; in other cases, the /width, /height, /depth and /weight properties may be more applicable.
        /// </summary>
        [DataMember(Name = "size", Order = 288)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IQuantitativeValue, string> Size { get; set; }

        /// <summary>
        /// The Organization on whose behalf the creator was working.
        /// </summary>
        [DataMember(Name = "sourceOrganization", Order = 289)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> SourceOrganization { get; set; }

        /// <summary>
        /// The "spatial" property can be used in cases when more specific properties
        /// (e.g. &lt;a class="localLink" href="https://schema.org/locationCreated"&gt;locationCreated&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/spatialCoverage"&gt;spatialCoverage&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/contentLocation"&gt;contentLocation&lt;/a&gt;) are not known to be appropriate.
        /// </summary>
        [DataMember(Name = "spatial", Order = 290)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> Spatial { get; set; }

        /// <summary>
        /// The spatialCoverage of a CreativeWork indicates the place(s) which are the focus of the content. It is a subproperty of
        ///       contentLocation intended primarily for more technical and detailed materials. For example with a Dataset, it indicates
        ///       areas that the dataset describes: a dataset of New York weather would have spatialCoverage which was the place: the state of New York.
        /// </summary>
        [DataMember(Name = "spatialCoverage", Order = 291)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> SpatialCoverage { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 292)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// The item being described is intended to help a person learn the competency or learning outcome defined by the referenced term.
        /// </summary>
        [DataMember(Name = "teaches", Order = 293)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Teaches { get; set; }

        /// <summary>
        /// The "temporal" property can be used in cases where more specific properties
        /// (e.g. &lt;a class="localLink" href="https://schema.org/temporalCoverage"&gt;temporalCoverage&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/dateCreated"&gt;dateCreated&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/dateModified"&gt;dateModified&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/datePublished"&gt;datePublished&lt;/a&gt;) are not known to be appropriate.
        /// </summary>
        [DataMember(Name = "temporal", Order = 294)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, string> Temporal { get; set; }

        /// <summary>
        /// The temporalCoverage of a CreativeWork indicates the period that the content applies to, i.e. that it describes, either as a DateTime or as a textual string indicating a time period in &lt;a href="https://en.wikipedia.org/wiki/ISO_8601#Time_intervals"&gt;ISO 8601 time interval format&lt;/a&gt;. In
        ///       the case of a Dataset it will typically indicate the relevant time period in a precise notation (e.g. for a 2011 census dataset, the year 2011 would be written "2011/2012"). Other forms of content e.g. ScholarlyArticle, Book, TVSeries or TVEpisode may indicate their temporalCoverage in broader terms - textually or via well-known URL.
        ///       Written works such as books may sometimes have precise temporal coverage too, e.g. a work set in 1939 - 1945 can be indicated in ISO 8601 interval format format via "1939/1945".&lt;br/&gt;&lt;br/&gt;
        /// Open-ended date ranges can be written with ".." in place of the end date. For example, "2015-11/.." indicates a range beginning in November 2015 and with no specified final date. This is tentative and might be updated in future when ISO 8601 is officially updated.
        /// </summary>
        [DataMember(Name = "temporalCoverage", Order = 295)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, string, Uri> TemporalCoverage { get; set; }

        /// <summary>
        /// The textual content of this CreativeWork.
        /// </summary>
        [DataMember(Name = "text", Order = 296)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Text { get; set; }

        /// <summary>
        /// A thumbnail image relevant to the Thing.
        /// </summary>
        [DataMember(Name = "thumbnailUrl", Order = 297)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> ThumbnailUrl { get; set; }

        /// <summary>
        /// Approximate or typical time it takes to work with or through this learning resource for the typical intended target audience, e.g. 'PT30M', 'PT1H25M'.
        /// </summary>
        [DataMember(Name = "timeRequired", Order = 298)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> TimeRequired { get; set; }

        /// <summary>
        /// The work that this work has been translated from. e.g. 物种起源 is a translationOf “On the Origin of Species”
        /// </summary>
        [DataMember(Name = "translationOfWork", Order = 299)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> TranslationOfWork { get; set; }

        /// <summary>
        /// Organization or person who adapts a creative work to different languages, regional differences and technical requirements of a target market, or that translates during some event.
        /// </summary>
        [DataMember(Name = "translator", Order = 300)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Translator { get; set; }

        /// <summary>
        /// The typical expected age range, e.g. '7-9', '11-'.
        /// </summary>
        [DataMember(Name = "typicalAgeRange", Order = 301)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TypicalAgeRange { get; set; }

        /// <summary>
        /// The schema.org &lt;a class="localLink" href="https://schema.org/usageInfo"&gt;usageInfo&lt;/a&gt; property indicates further information about a &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;. This property is applicable both to works that are freely available and to those that require payment or other transactions. It can reference additional information e.g. community expectations on preferred linking and citation conventions, as well as purchasing details. For something that can be commercially licensed, usageInfo can provide detailed, resource-specific information about licensing options.&lt;br/&gt;&lt;br/&gt;
        /// This property can be used alongside the license property which indicates license(s) applicable to some piece of content. The usageInfo property can provide information about other licensing options, e.g. acquiring commercial usage rights for an image that is also available under non-commercial creative commons licenses.
        /// </summary>
        [DataMember(Name = "usageInfo", Order = 302)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> UsageInfo { get; set; }

        /// <summary>
        /// The version of the CreativeWork embodied by a specified resource.
        /// </summary>
        [DataMember(Name = "version", Order = 303)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, string> Version { get; set; }

        /// <summary>
        /// An embedded video object.
        /// </summary>
        [DataMember(Name = "video", Order = 304)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IClip, IVideoObject> Video { get; set; }

        /// <summary>
        /// Example/instance/realization/derivation of the concept of this creative work. eg. The paperback edition, first edition, or eBook.
        /// </summary>
        [DataMember(Name = "workExample", Order = 305)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> WorkExample { get; set; }

        /// <summary>
        /// A work that is a translation of the content of this work. e.g. 西遊記 has an English workTranslation “Journey to the West”,a German workTranslation “Monkeys Pilgerfahrt” and a Vietnamese  translation Tây du ký bình khảo.
        /// </summary>
        [DataMember(Name = "workTranslation", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> WorkTranslation { get; set; }

        /// <inheritdoc/>
        public bool Equals(CreativeWorkAndSeries other)
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
                this.About == other.About &&
                this.Abstract == other.Abstract &&
                this.AccessibilityAPI == other.AccessibilityAPI &&
                this.AccessibilityControl == other.AccessibilityControl &&
                this.AccessibilityFeature == other.AccessibilityFeature &&
                this.AccessibilityHazard == other.AccessibilityHazard &&
                this.AccessibilitySummary == other.AccessibilitySummary &&
                this.AccessMode == other.AccessMode &&
                this.AccessModeSufficient == other.AccessModeSufficient &&
                this.AccountablePerson == other.AccountablePerson &&
                this.AcquireLicensePage == other.AcquireLicensePage &&
                this.AggregateRating == other.AggregateRating &&
                this.AlternativeHeadline == other.AlternativeHeadline &&
                this.Assesses == other.Assesses &&
                this.AssociatedMedia == other.AssociatedMedia &&
                this.Audience == other.Audience &&
                this.Audio == other.Audio &&
                this.Author == other.Author &&
                this.Award == other.Award &&
                this.Character == other.Character &&
                this.Citation == other.Citation &&
                this.Comment == other.Comment &&
                this.CommentCount == other.CommentCount &&
                this.ConditionsOfAccess == other.ConditionsOfAccess &&
                this.ContentLocation == other.ContentLocation &&
                this.ContentRating == other.ContentRating &&
                this.ContentReferenceTime == other.ContentReferenceTime &&
                this.Contributor == other.Contributor &&
                this.CopyrightHolder == other.CopyrightHolder &&
                this.CopyrightYear == other.CopyrightYear &&
                this.Correction == other.Correction &&
                this.CreativeWorkStatus == other.CreativeWorkStatus &&
                this.Creator == other.Creator &&
                this.DateCreated == other.DateCreated &&
                this.DateModified == other.DateModified &&
                this.DatePublished == other.DatePublished &&
                this.DiscussionUrl == other.DiscussionUrl &&
                this.EditEIDR == other.EditEIDR &&
                this.Editor == other.Editor &&
                this.EducationalAlignment == other.EducationalAlignment &&
                this.EducationalLevel == other.EducationalLevel &&
                this.EducationalUse == other.EducationalUse &&
                this.Encoding == other.Encoding &&
                this.EncodingFormat == other.EncodingFormat &&
                this.ExampleOfWork == other.ExampleOfWork &&
                this.Expires == other.Expires &&
                this.Funder == other.Funder &&
                this.Genre == other.Genre &&
                this.HasPart == other.HasPart &&
                this.Headline == other.Headline &&
                this.InLanguage == other.InLanguage &&
                this.InteractionStatistic == other.InteractionStatistic &&
                this.InteractivityType == other.InteractivityType &&
                this.IsAccessibleForFree == other.IsAccessibleForFree &&
                this.IsBasedOn == other.IsBasedOn &&
                this.IsFamilyFriendly == other.IsFamilyFriendly &&
                this.IsPartOf == other.IsPartOf &&
                this.Keywords == other.Keywords &&
                this.LearningResourceType == other.LearningResourceType &&
                this.License == other.License &&
                this.LocationCreated == other.LocationCreated &&
                this.MainEntity == other.MainEntity &&
                this.Maintainer == other.Maintainer &&
                this.Material == other.Material &&
                this.MaterialExtent == other.MaterialExtent &&
                this.Mentions == other.Mentions &&
                this.Offers == other.Offers &&
                this.Pattern == other.Pattern &&
                this.Position == other.Position &&
                this.Producer == other.Producer &&
                this.Provider == other.Provider &&
                this.Publication == other.Publication &&
                this.Publisher == other.Publisher &&
                this.PublisherImprint == other.PublisherImprint &&
                this.PublishingPrinciples == other.PublishingPrinciples &&
                this.RecordedAt == other.RecordedAt &&
                this.ReleasedEvent == other.ReleasedEvent &&
                this.Review == other.Review &&
                this.SchemaVersion == other.SchemaVersion &&
                this.SdDatePublished == other.SdDatePublished &&
                this.SdLicense == other.SdLicense &&
                this.SdPublisher == other.SdPublisher &&
                this.Size == other.Size &&
                this.SourceOrganization == other.SourceOrganization &&
                this.Spatial == other.Spatial &&
                this.SpatialCoverage == other.SpatialCoverage &&
                this.Sponsor == other.Sponsor &&
                this.Teaches == other.Teaches &&
                this.Temporal == other.Temporal &&
                this.TemporalCoverage == other.TemporalCoverage &&
                this.Text == other.Text &&
                this.ThumbnailUrl == other.ThumbnailUrl &&
                this.TimeRequired == other.TimeRequired &&
                this.TranslationOfWork == other.TranslationOfWork &&
                this.Translator == other.Translator &&
                this.TypicalAgeRange == other.TypicalAgeRange &&
                this.UsageInfo == other.UsageInfo &&
                this.Version == other.Version &&
                this.Video == other.Video &&
                this.WorkExample == other.WorkExample &&
                this.WorkTranslation == other.WorkTranslation &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as CreativeWorkAndSeries);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.About)
            .And(this.Abstract)
            .And(this.AccessibilityAPI)
            .And(this.AccessibilityControl)
            .And(this.AccessibilityFeature)
            .And(this.AccessibilityHazard)
            .And(this.AccessibilitySummary)
            .And(this.AccessMode)
            .And(this.AccessModeSufficient)
            .And(this.AccountablePerson)
            .And(this.AcquireLicensePage)
            .And(this.AggregateRating)
            .And(this.AlternativeHeadline)
            .And(this.Assesses)
            .And(this.AssociatedMedia)
            .And(this.Audience)
            .And(this.Audio)
            .And(this.Author)
            .And(this.Award)
            .And(this.Character)
            .And(this.Citation)
            .And(this.Comment)
            .And(this.CommentCount)
            .And(this.ConditionsOfAccess)
            .And(this.ContentLocation)
            .And(this.ContentRating)
            .And(this.ContentReferenceTime)
            .And(this.Contributor)
            .And(this.CopyrightHolder)
            .And(this.CopyrightYear)
            .And(this.Correction)
            .And(this.CreativeWorkStatus)
            .And(this.Creator)
            .And(this.DateCreated)
            .And(this.DateModified)
            .And(this.DatePublished)
            .And(this.DiscussionUrl)
            .And(this.EditEIDR)
            .And(this.Editor)
            .And(this.EducationalAlignment)
            .And(this.EducationalLevel)
            .And(this.EducationalUse)
            .And(this.Encoding)
            .And(this.EncodingFormat)
            .And(this.ExampleOfWork)
            .And(this.Expires)
            .And(this.Funder)
            .And(this.Genre)
            .And(this.HasPart)
            .And(this.Headline)
            .And(this.InLanguage)
            .And(this.InteractionStatistic)
            .And(this.InteractivityType)
            .And(this.IsAccessibleForFree)
            .And(this.IsBasedOn)
            .And(this.IsFamilyFriendly)
            .And(this.IsPartOf)
            .And(this.Keywords)
            .And(this.LearningResourceType)
            .And(this.License)
            .And(this.LocationCreated)
            .And(this.MainEntity)
            .And(this.Maintainer)
            .And(this.Material)
            .And(this.MaterialExtent)
            .And(this.Mentions)
            .And(this.Offers)
            .And(this.Pattern)
            .And(this.Position)
            .And(this.Producer)
            .And(this.Provider)
            .And(this.Publication)
            .And(this.Publisher)
            .And(this.PublisherImprint)
            .And(this.PublishingPrinciples)
            .And(this.RecordedAt)
            .And(this.ReleasedEvent)
            .And(this.Review)
            .And(this.SchemaVersion)
            .And(this.SdDatePublished)
            .And(this.SdLicense)
            .And(this.SdPublisher)
            .And(this.Size)
            .And(this.SourceOrganization)
            .And(this.Spatial)
            .And(this.SpatialCoverage)
            .And(this.Sponsor)
            .And(this.Teaches)
            .And(this.Temporal)
            .And(this.TemporalCoverage)
            .And(this.Text)
            .And(this.ThumbnailUrl)
            .And(this.TimeRequired)
            .And(this.TranslationOfWork)
            .And(this.Translator)
            .And(this.TypicalAgeRange)
            .And(this.UsageInfo)
            .And(this.Version)
            .And(this.Video)
            .And(this.WorkExample)
            .And(this.WorkTranslation)
            .And(base.GetHashCode());
    }
}

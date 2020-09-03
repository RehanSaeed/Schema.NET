namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
    public partial interface IOrganization : IThing
    {
        /// <summary>
        /// For a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; or other news-related &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt;, a statement about public engagement activities (for news media, the newsroom’s), including involving the public - digitally or otherwise -- in coverage decisions, reporting and activities after publication.
        /// </summary>
        Values<ICreativeWork, Uri> ActionableFeedbackPolicy { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        OneOrMany<IPerson> Alumni { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        Values<IAdministrativeArea, IGeoShape, IPlace, string> AreaServed { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        OneOrMany<string> Award { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        Values<IBrand, IOrganization> Brand { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        OneOrMany<IContactPoint> ContactPoint { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (e.g. &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement describing (in news media, the newsroom’s) disclosure and correction policy for errors.
        /// </summary>
        Values<ICreativeWork, Uri> CorrectionsPolicy { get; set; }

        /// <summary>
        /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        OneOrMany<IOrganization> Department { get; set; }

        /// <summary>
        /// The date that this organization was dissolved.
        /// </summary>
        Values<int?, DateTime?> DissolutionDate { get; set; }

        /// <summary>
        /// Statement on diversity policy by an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; e.g. a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;. For a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, a statement describing the newsroom’s diversity policy on both staffing and sources, typically providing staffing data.
        /// </summary>
        Values<ICreativeWork, Uri> DiversityPolicy { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a report on staffing diversity issues. In a news context this might be for example ASNE or RTDNA (US) reports, or self-reported.
        /// </summary>
        Values<IArticle, Uri> DiversityStaffingReport { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        OneOrMany<string> Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        OneOrMany<string> Email { get; set; }

        /// <summary>
        /// Someone working for this organization.
        /// </summary>
        OneOrMany<IPerson> Employee { get; set; }

        /// <summary>
        /// Statement about ethics policy, e.g. of a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; regarding journalistic and publishing practices, or of a &lt;a class="localLink" href="https://schema.org/Restaurant"&gt;Restaurant&lt;/a&gt;, a page describing food source policies. In the case of a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, an ethicsPolicy is typically a statement describing the personal, organizational, and corporate standards of behavior expected by the organization.
        /// </summary>
        Values<ICreativeWork, Uri> EthicsPolicy { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        OneOrMany<IEvent> Events { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        OneOrMany<string> FaxNumber { get; set; }

        /// <summary>
        /// A person who founded this organization.
        /// </summary>
        OneOrMany<IPerson> Founder { get; set; }

        /// <summary>
        /// The date that this organization was founded.
        /// </summary>
        Values<int?, DateTime?> FoundingDate { get; set; }

        /// <summary>
        /// The place where the Organization was founded.
        /// </summary>
        OneOrMany<IPlace> FoundingLocation { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        Values<IOrganization, IPerson> Funder { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        OneOrMany<string> GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        OneOrMany<IOfferCatalog> HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        OneOrMany<IPlace> HasPOS { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
        /// </summary>
        OneOrMany<IInteractionCounter> InteractionStatistic { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        OneOrMany<string> IsicV4 { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or relate this to educational content, events, objectives or &lt;a class="localLink" href="https://schema.org/JobPosting"&gt;JobPosting&lt;/a&gt; descriptions.
        /// </summary>
        Values<string, IThing, Uri> KnowsAbout { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;.
        /// </summary>
        Values<ILanguage, string> KnowsLanguage { get; set; }

        /// <summary>
        /// The official name of the organization, e.g. the registered company name.
        /// </summary>
        OneOrMany<string> LegalName { get; set; }

        /// <summary>
        /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        /// </summary>
        OneOrMany<string> LeiCode { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        Values<IPlace, IPostalAddress, string> Location { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        Values<IImageObject, Uri> Logo { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        OneOrMany<IOffer> MakesOffer { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        Values<IOrganization, IPerson> Member { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        Values<IOrganization, IProgramMembership> MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        OneOrMany<string> Naics { get; set; }

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        OneOrMany<IQuantitativeValue> NumberOfEmployees { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a description of organizational ownership structure; funding and grants. In a news/media setting, this is with particular reference to editorial independence.   Note that the &lt;a class="localLink" href="https://schema.org/funder"&gt;funder&lt;/a&gt; is also available and can be used to make basic funder information machine-readable.
        /// </summary>
        Values<IAboutPage, ICreativeWork, string, Uri> OwnershipFundingInfo { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        Values<IOwnershipInfo, IProduct> Owns { get; set; }

        /// <summary>
        /// The larger organization that this organization is a &lt;a class="localLink" href="https://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
        /// </summary>
        OneOrMany<IOrganization> ParentOrganization { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="https://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="https://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="https://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        Values<ICreativeWork, Uri> PublishingPrinciples { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        OneOrMany<IDemand> Seeks { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        OneOrMany<string> Slogan { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
        /// </summary>
        OneOrMany<IOrganization> SubOrganization { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        OneOrMany<string> TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        OneOrMany<string> Telephone { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (typically a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement about policy on use of unnamed sources and the decision process required.
        /// </summary>
        Values<ICreativeWork, Uri> UnnamedSourcesPolicy { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        OneOrMany<string> VatID { get; set; }
    }

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
    [DataContract]
    public partial class Organization : Thing, IOrganization, IEquatable<Organization>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Organization";

        /// <summary>
        /// For a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; or other news-related &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt;, a statement about public engagement activities (for news media, the newsroom’s), including involving the public - digitally or otherwise -- in coverage decisions, reporting and activities after publication.
        /// </summary>
        [DataMember(Name = "actionableFeedbackPolicy", Order = 106)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> ActionableFeedbackPolicy { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 107)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 108)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni", Order = 109)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<IPerson> Alumni { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 110)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAdministrativeArea, IGeoShape, IPlace, string> AreaServed { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 111)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Award { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 112)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IBrand, IOrganization> Brand { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 113)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IContactPoint> ContactPoint { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (e.g. &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement describing (in news media, the newsroom’s) disclosure and correction policy for errors.
        /// </summary>
        [DataMember(Name = "correctionsPolicy", Order = 114)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> CorrectionsPolicy { get; set; }

        /// <summary>
        /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        [DataMember(Name = "department", Order = 115)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> Department { get; set; }

        /// <summary>
        /// The date that this organization was dissolved.
        /// </summary>
        [DataMember(Name = "dissolutionDate", Order = 116)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> DissolutionDate { get; set; }

        /// <summary>
        /// Statement on diversity policy by an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; e.g. a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;. For a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, a statement describing the newsroom’s diversity policy on both staffing and sources, typically providing staffing data.
        /// </summary>
        [DataMember(Name = "diversityPolicy", Order = 117)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> DiversityPolicy { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a report on staffing diversity issues. In a news context this might be for example ASNE or RTDNA (US) reports, or self-reported.
        /// </summary>
        [DataMember(Name = "diversityStaffingReport", Order = 118)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IArticle, Uri> DiversityStaffingReport { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 119)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 120)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Email { get; set; }

        /// <summary>
        /// Someone working for this organization.
        /// </summary>
        [DataMember(Name = "employee", Order = 121)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Employee { get; set; }

        /// <summary>
        /// Statement about ethics policy, e.g. of a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; regarding journalistic and publishing practices, or of a &lt;a class="localLink" href="https://schema.org/Restaurant"&gt;Restaurant&lt;/a&gt;, a page describing food source policies. In the case of a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, an ethicsPolicy is typically a statement describing the personal, organizational, and corporate standards of behavior expected by the organization.
        /// </summary>
        [DataMember(Name = "ethicsPolicy", Order = 122)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> EthicsPolicy { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 123)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> Events { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 124)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FaxNumber { get; set; }

        /// <summary>
        /// A person who founded this organization.
        /// </summary>
        [DataMember(Name = "founder", Order = 125)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Founder { get; set; }

        /// <summary>
        /// The date that this organization was founded.
        /// </summary>
        [DataMember(Name = "foundingDate", Order = 126)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> FoundingDate { get; set; }

        /// <summary>
        /// The place where the Organization was founded.
        /// </summary>
        [DataMember(Name = "foundingLocation", Order = 127)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> FoundingLocation { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 128)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Funder { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 129)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 130)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOfferCatalog> HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 131)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> HasPOS { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
        /// </summary>
        [DataMember(Name = "interactionStatistic", Order = 132)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IInteractionCounter> InteractionStatistic { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 133)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> IsicV4 { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or relate this to educational content, events, objectives or &lt;a class="localLink" href="https://schema.org/JobPosting"&gt;JobPosting&lt;/a&gt; descriptions.
        /// </summary>
        [DataMember(Name = "knowsAbout", Order = 134)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IThing, Uri> KnowsAbout { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "knowsLanguage", Order = 135)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> KnowsLanguage { get; set; }

        /// <summary>
        /// The official name of the organization, e.g. the registered company name.
        /// </summary>
        [DataMember(Name = "legalName", Order = 136)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> LegalName { get; set; }

        /// <summary>
        /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        /// </summary>
        [DataMember(Name = "leiCode", Order = 137)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> LeiCode { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 138)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPlace, IPostalAddress, string> Location { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 139)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IImageObject, Uri> Logo { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 140)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOffer> MakesOffer { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 141)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Member { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 142)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IProgramMembership> MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 143)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Naics { get; set; }

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [DataMember(Name = "numberOfEmployees", Order = 144)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> NumberOfEmployees { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a description of organizational ownership structure; funding and grants. In a news/media setting, this is with particular reference to editorial independence.   Note that the &lt;a class="localLink" href="https://schema.org/funder"&gt;funder&lt;/a&gt; is also available and can be used to make basic funder information machine-readable.
        /// </summary>
        [DataMember(Name = "ownershipFundingInfo", Order = 145)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAboutPage, ICreativeWork, string, Uri> OwnershipFundingInfo { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 146)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOwnershipInfo, IProduct> Owns { get; set; }

        /// <summary>
        /// The larger organization that this organization is a &lt;a class="localLink" href="https://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
        /// </summary>
        [DataMember(Name = "parentOrganization", Order = 147)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> ParentOrganization { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="https://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="https://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="https://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 148)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> PublishingPrinciples { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 149)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 150)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDemand> Seeks { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        [DataMember(Name = "slogan", Order = 151)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Slogan { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 152)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
        /// </summary>
        [DataMember(Name = "subOrganization", Order = 153)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> SubOrganization { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 154)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 155)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Telephone { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (typically a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement about policy on use of unnamed sources and the decision process required.
        /// </summary>
        [DataMember(Name = "unnamedSourcesPolicy", Order = 156)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> UnnamedSourcesPolicy { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 157)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VatID { get; set; }

        /// <inheritdoc/>
        public bool Equals(Organization other)
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
                this.ActionableFeedbackPolicy == other.ActionableFeedbackPolicy &&
                this.Address == other.Address &&
                this.AggregateRating == other.AggregateRating &&
                this.Alumni == other.Alumni &&
                this.AreaServed == other.AreaServed &&
                this.Award == other.Award &&
                this.Brand == other.Brand &&
                this.ContactPoint == other.ContactPoint &&
                this.CorrectionsPolicy == other.CorrectionsPolicy &&
                this.Department == other.Department &&
                this.DissolutionDate == other.DissolutionDate &&
                this.DiversityPolicy == other.DiversityPolicy &&
                this.DiversityStaffingReport == other.DiversityStaffingReport &&
                this.Duns == other.Duns &&
                this.Email == other.Email &&
                this.Employee == other.Employee &&
                this.EthicsPolicy == other.EthicsPolicy &&
                this.Events == other.Events &&
                this.FaxNumber == other.FaxNumber &&
                this.Founder == other.Founder &&
                this.FoundingDate == other.FoundingDate &&
                this.FoundingLocation == other.FoundingLocation &&
                this.Funder == other.Funder &&
                this.GlobalLocationNumber == other.GlobalLocationNumber &&
                this.HasOfferCatalog == other.HasOfferCatalog &&
                this.HasPOS == other.HasPOS &&
                this.InteractionStatistic == other.InteractionStatistic &&
                this.IsicV4 == other.IsicV4 &&
                this.KnowsAbout == other.KnowsAbout &&
                this.KnowsLanguage == other.KnowsLanguage &&
                this.LegalName == other.LegalName &&
                this.LeiCode == other.LeiCode &&
                this.Location == other.Location &&
                this.Logo == other.Logo &&
                this.MakesOffer == other.MakesOffer &&
                this.Member == other.Member &&
                this.MemberOf == other.MemberOf &&
                this.Naics == other.Naics &&
                this.NumberOfEmployees == other.NumberOfEmployees &&
                this.OwnershipFundingInfo == other.OwnershipFundingInfo &&
                this.Owns == other.Owns &&
                this.ParentOrganization == other.ParentOrganization &&
                this.PublishingPrinciples == other.PublishingPrinciples &&
                this.Review == other.Review &&
                this.Seeks == other.Seeks &&
                this.Slogan == other.Slogan &&
                this.Sponsor == other.Sponsor &&
                this.SubOrganization == other.SubOrganization &&
                this.TaxID == other.TaxID &&
                this.Telephone == other.Telephone &&
                this.UnnamedSourcesPolicy == other.UnnamedSourcesPolicy &&
                this.VatID == other.VatID &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Organization);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ActionableFeedbackPolicy)
            .And(this.Address)
            .And(this.AggregateRating)
            .And(this.Alumni)
            .And(this.AreaServed)
            .And(this.Award)
            .And(this.Brand)
            .And(this.ContactPoint)
            .And(this.CorrectionsPolicy)
            .And(this.Department)
            .And(this.DissolutionDate)
            .And(this.DiversityPolicy)
            .And(this.DiversityStaffingReport)
            .And(this.Duns)
            .And(this.Email)
            .And(this.Employee)
            .And(this.EthicsPolicy)
            .And(this.Events)
            .And(this.FaxNumber)
            .And(this.Founder)
            .And(this.FoundingDate)
            .And(this.FoundingLocation)
            .And(this.Funder)
            .And(this.GlobalLocationNumber)
            .And(this.HasOfferCatalog)
            .And(this.HasPOS)
            .And(this.InteractionStatistic)
            .And(this.IsicV4)
            .And(this.KnowsAbout)
            .And(this.KnowsLanguage)
            .And(this.LegalName)
            .And(this.LeiCode)
            .And(this.Location)
            .And(this.Logo)
            .And(this.MakesOffer)
            .And(this.Member)
            .And(this.MemberOf)
            .And(this.Naics)
            .And(this.NumberOfEmployees)
            .And(this.OwnershipFundingInfo)
            .And(this.Owns)
            .And(this.ParentOrganization)
            .And(this.PublishingPrinciples)
            .And(this.Review)
            .And(this.Seeks)
            .And(this.Slogan)
            .And(this.Sponsor)
            .And(this.SubOrganization)
            .And(this.TaxID)
            .And(this.Telephone)
            .And(this.UnnamedSourcesPolicy)
            .And(this.VatID)
            .And(base.GetHashCode());
    }
}

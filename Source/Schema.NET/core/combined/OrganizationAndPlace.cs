namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See Organization, Place for more information.
    /// </summary>
    [DataContract]
    public abstract partial class OrganizationAndPlace : Thing
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrganizationAndPlace";

        /// <summary>
        /// For a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; or other news-related &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, a statement about public engagement activities (for news media, the newsroom’s), including involving the public - digitally or otherwise -- in coverage decisions, reporting and activities after publication.
        /// </summary>
        [DataMember(Name = "actionableFeedbackPolicy", Order = 106)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<CreativeWork, Uri>? ActionableFeedbackPolicy { get; set; }

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 107)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<PropertyValue>? AdditionalProperty { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 108)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<PostalAddress, string>? Address { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 109)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<AggregateRating>? AggregateRating { get; set; }

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni", Order = 110)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Person>? Alumni { get; set; }

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 111)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<LocationFeatureSpecification>? AmenityFeature { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 112)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<AdministrativeArea, GeoShape, Place, string>? AreaServed { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 113)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<string>? Award { get; set; }

        /// <summary>
        /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;br/&gt;&lt;br/&gt;
        /// For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
        /// </summary>
        [DataMember(Name = "branchCode", Order = 114)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<string>? BranchCode { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 115)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Brand, Organization>? Brand { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 116)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<ContactPoint>? ContactPoint { get; set; }

        /// <summary>
        /// The basic containment relation between a place and one that contains it.
        /// </summary>
        [DataMember(Name = "containedInPlace", Order = 117)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Place>? ContainedInPlace { get; set; }

        /// <summary>
        /// The basic containment relation between a place and another that it contains.
        /// </summary>
        [DataMember(Name = "containsPlace", Order = 118)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Place>? ContainsPlace { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement describing (in news media, the newsroom’s) disclosure and correction policy for errors.
        /// </summary>
        [DataMember(Name = "correctionsPolicy", Order = 119)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<CreativeWork, Uri>? CorrectionsPolicy { get; set; }

        /// <summary>
        /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        [DataMember(Name = "department", Order = 120)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Organization>? Department { get; set; }

        /// <summary>
        /// The date that this organization was dissolved.
        /// </summary>
        [DataMember(Name = "dissolutionDate", Order = 121)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<DateTimeOffset?>? DissolutionDate { get; set; }

        /// <summary>
        /// Statement on diversity policy by an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; e.g. a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;. For a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, a statement describing the newsroom’s diversity policy on both staffing and sources, typically providing staffing data.
        /// </summary>
        [DataMember(Name = "diversityPolicy", Order = 122)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<CreativeWork, Uri>? DiversityPolicy { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a report on staffing diversity issues. In a news context this might be for example ASNE or RTDNA (US) reports, or self-reported.
        /// </summary>
        [DataMember(Name = "diversityStaffingReport", Order = 123)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Article, Uri>? DiversityStaffingReport { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 124)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<string>? Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 125)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<string>? Email { get; set; }

        /// <summary>
        /// Someone working for this organization.
        /// </summary>
        [DataMember(Name = "employee", Order = 126)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Person>? Employee { get; set; }

        /// <summary>
        /// Statement about ethics policy, e.g. of a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; regarding journalistic and publishing practices, or of a &lt;a class="localLink" href="http://schema.org/Restaurant"&gt;Restaurant&lt;/a&gt;, a page describing food source policies. In the case of a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, an ethicsPolicy is typically a statement describing the personal, organizational, and corporate standards of behavior expected by the organization.
        /// </summary>
        [DataMember(Name = "ethicsPolicy", Order = 127)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<CreativeWork, Uri>? EthicsPolicy { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 128)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Event>? Event { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 129)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<string>? FaxNumber { get; set; }

        /// <summary>
        /// A person who founded this organization.
        /// </summary>
        [DataMember(Name = "founder", Order = 130)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Person>? Founder { get; set; }

        /// <summary>
        /// The date that this organization was founded.
        /// </summary>
        [DataMember(Name = "foundingDate", Order = 131)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<DateTimeOffset?>? FoundingDate { get; set; }

        /// <summary>
        /// The place where the Organization was founded.
        /// </summary>
        [DataMember(Name = "foundingLocation", Order = 132)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Place>? FoundingLocation { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 133)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Organization, Person>? Funder { get; set; }

        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        [DataMember(Name = "geo", Order = 134)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<GeoCoordinates, GeoShape>? Geo { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyContains", Order = 135)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Place>? GeospatiallyContains { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCoveredBy", Order = 136)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Place>? GeospatiallyCoveredBy { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCovers", Order = 137)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Place>? GeospatiallyCovers { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCrosses", Order = 138)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Place>? GeospatiallyCrosses { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)
        /// </summary>
        [DataMember(Name = "geospatiallyDisjoint", Order = 139)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Place>? GeospatiallyDisjoint { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
        /// </summary>
        [DataMember(Name = "geospatiallyEquals", Order = 140)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Place>? GeospatiallyEquals { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyIntersects", Order = 141)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Place>? GeospatiallyIntersects { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyOverlaps", Order = 142)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Place>? GeospatiallyOverlaps { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )
        /// </summary>
        [DataMember(Name = "geospatiallyTouches", Order = 143)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Place>? GeospatiallyTouches { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyWithin", Order = 144)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Place>? GeospatiallyWithin { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 145)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<string>? GlobalLocationNumber { get; set; }

        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        [DataMember(Name = "hasMap", Order = 146)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Map, Uri>? HasMap { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 147)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<OfferCatalog>? HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 148)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Place>? HasPOS { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 149)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<bool?>? IsAccessibleForFree { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 150)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<string>? IsicV4 { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or yet relate this to educational content, events, objectives or &lt;a class="localLink" href="http://schema.org/JobPosting"&gt;JobPosting&lt;/a&gt; descriptions.
        /// </summary>
        [DataMember(Name = "knowsAbout", Order = 151)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<string, Thing, Uri>? KnowsAbout { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "knowsLanguage", Order = 152)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Language, string>? KnowsLanguage { get; set; }

        /// <summary>
        /// The official name of the organization, e.g. the registered company name.
        /// </summary>
        [DataMember(Name = "legalName", Order = 153)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<string>? LegalName { get; set; }

        /// <summary>
        /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        /// </summary>
        [DataMember(Name = "leiCode", Order = 154)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<string>? LeiCode { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 155)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Place, PostalAddress, string>? Location { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 156)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<ImageObject, Uri>? Logo { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 157)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Offer>? MakesOffer { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity", Order = 158)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<int?>? MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 159)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Organization, Person>? Member { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 160)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Organization, ProgramMembership>? MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 161)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<string>? Naics { get; set; }

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [DataMember(Name = "numberOfEmployees", Order = 162)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<QuantitativeValue>? NumberOfEmployees { get; set; }

        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        [DataMember(Name = "openingHoursSpecification", Order = 163)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<OpeningHoursSpecification>? OpeningHoursSpecification { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a description of organizational ownership structure; funding and grants. In a news/media setting, this is with particular reference to editorial independence.   Note that the &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt; is also available and can be used to make basic funder information machine-readable.
        /// </summary>
        [DataMember(Name = "ownershipFundingInfo", Order = 164)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<AboutPage, CreativeWork, string, Uri>? OwnershipFundingInfo { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 165)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<OwnershipInfo, Product>? Owns { get; set; }

        /// <summary>
        /// The larger organization that this organization is a &lt;a class="localLink" href="http://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
        /// </summary>
        [DataMember(Name = "parentOrganization", Order = 166)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Organization>? ParentOrganization { get; set; }

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        [DataMember(Name = "photo", Order = 167)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<ImageObject, Photograph>? Photo { get; set; }

        /// <summary>
        /// A flag to signal that the &lt;a class="localLink" href="http://schema.org/Place"&gt;Place&lt;/a&gt; is open to public visitors.  If this property is omitted there is no assumed default boolean value
        /// </summary>
        [DataMember(Name = "publicAccess", Order = 168)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<bool?>? PublicAccess { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 169)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<CreativeWork, Uri>? PublishingPrinciples { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 170)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Review>? Review { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 171)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Demand>? Seeks { get; set; }

        /// <summary>
        /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
        /// </summary>
        [DataMember(Name = "smokingAllowed", Order = 172)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<bool?>? SmokingAllowed { get; set; }

        /// <summary>
        /// The special opening hours of a certain place.&lt;br/&gt;&lt;br/&gt;
        /// Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="http://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "specialOpeningHoursSpecification", Order = 173)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<OpeningHoursSpecification>? SpecialOpeningHoursSpecification { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 174)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<Organization, Person>? Sponsor { get; set; }

        /// <summary>
        /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
        /// </summary>
        [DataMember(Name = "subOrganization", Order = 175)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<Organization>? SubOrganization { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 176)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<string>? TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 177)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<string>? Telephone { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (typically a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement about policy on use of unnamed sources and the decision process required.
        /// </summary>
        [DataMember(Name = "unnamedSourcesPolicy", Order = 178)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual Values<CreativeWork, Uri>? UnnamedSourcesPolicy { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 179)]
        [JsonConverter(typeof(ValuesConverter))]
        public virtual OneOrMany<string>? VatID { get; set; }
    }
}

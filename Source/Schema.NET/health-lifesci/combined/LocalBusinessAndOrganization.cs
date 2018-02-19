using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// See LocalBusiness, Organization for more information.
    /// </summary>
    [DataContract]
    public abstract partial class LocalBusinessAndOrganization : OrganizationAndPlace
    {
















        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LocalBusinessAndOrganization";

        /// <summary>
        /// For a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; or other news-related &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, a statement about public engagement activities (for news media, the newsroom’s), including involving the public - digitally or otherwise -- in coverage decisions, reporting and activities after publication.
        /// </summary>
        [DataMember(Name = "actionableFeedbackPolicy", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<IActionableFeedbackPolicy>? ActionableFeedbackPolicy { get; set; } //CreativeWork, Uri

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<IAddress>? Address { get; set; } //PostalAddress, string

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<AggregateRating>? AggregateRating { get; set; } 

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<Person>? Alumni { get; set; } 

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<IAreaServed>? AreaServed { get; set; } //AdministrativeArea, GeoShape, Place, string

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? Award { get; set; } 

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<IBrand>? Brand { get; set; } //Brand, Organization

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<ContactPoint>? ContactPoint { get; set; } 

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement describing (in news media, the newsroom’s) disclosure and correction policy for errors.
        /// </summary>
        [DataMember(Name = "correctionsPolicy", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<ICorrectionsPolicy>? CorrectionsPolicy { get; set; } //CreativeWork, Uri

        /// <summary>
        /// The currency accepted (in &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "currenciesAccepted", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? CurrenciesAccepted { get; set; } 

        /// <summary>
        /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        [DataMember(Name = "department", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<Organization>? Department { get; set; } 

        /// <summary>
        /// The date that this organization was dissolved.
        /// </summary>
        [DataMember(Name = "dissolutionDate", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<DateTimeOffset>? DissolutionDate { get; set; } 

        /// <summary>
        /// Statement on diversity policy by an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; e.g. a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;. For a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, a statement describing the newsroom’s diversity policy on both staffing and sources, typically providing staffing data.
        /// </summary>
        [DataMember(Name = "diversityPolicy", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<IDiversityPolicy>? DiversityPolicy { get; set; } //CreativeWork, Uri

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? Duns { get; set; } 

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? Email { get; set; } 

        /// <summary>
        /// Someone working for this organization.
        /// </summary>
        [DataMember(Name = "employee", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<Person>? Employee { get; set; } 

        /// <summary>
        /// Statement about ethics policy, e.g. of a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; regarding journalistic and publishing practices, or of a &lt;a class="localLink" href="http://schema.org/Restaurant"&gt;Restaurant&lt;/a&gt;, a page describing food source policies. In the case of a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, an ethicsPolicy is typically a statement describing the personal, organizational, and corporate standards of behavior expected by the organization.
        /// </summary>
        [DataMember(Name = "ethicsPolicy", Order = 222)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<IEthicsPolicy>? EthicsPolicy { get; set; } //CreativeWork, Uri

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 223)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<Event>? Event { get; set; } 

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 224)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? FaxNumber { get; set; } 

        /// <summary>
        /// A person who founded this organization.
        /// </summary>
        [DataMember(Name = "founder", Order = 225)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<Person>? Founder { get; set; } 

        /// <summary>
        /// The date that this organization was founded.
        /// </summary>
        [DataMember(Name = "foundingDate", Order = 226)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<DateTimeOffset>? FoundingDate { get; set; } 

        /// <summary>
        /// The place where the Organization was founded.
        /// </summary>
        [DataMember(Name = "foundingLocation", Order = 227)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<Place>? FoundingLocation { get; set; } 

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 228)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<IFunder>? Funder { get; set; } //Organization, Person

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 229)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? GlobalLocationNumber { get; set; } 

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 230)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<OfferCatalog>? HasOfferCatalog { get; set; } 

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 231)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<Place>? HasPOS { get; set; } 

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 232)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? IsicV4 { get; set; } 

        /// <summary>
        /// The official name of the organization, e.g. the registered company name.
        /// </summary>
        [DataMember(Name = "legalName", Order = 233)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? LegalName { get; set; } 

        /// <summary>
        /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        /// </summary>
        [DataMember(Name = "leiCode", Order = 234)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? LeiCode { get; set; } 

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 235)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<ILocation>? Location { get; set; } //Place, PostalAddress, string

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 236)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<ILogo>? Logo { get; set; } //ImageObject, Uri

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 237)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<Offer>? MakesOffer { get; set; } 

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 238)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<IMember>? Member { get; set; } //Organization, Person

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 239)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<IMemberOf>? MemberOf { get; set; } //Organization, ProgramMembership

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 240)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? Naics { get; set; } 

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [DataMember(Name = "numberOfEmployees", Order = 241)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<QuantitativeValue>? NumberOfEmployees { get; set; } 

        /// <summary>
        /// &lt;p&gt;The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Days are specified using the following two-letter combinations: &lt;code&gt;Mo&lt;/code&gt;, &lt;code&gt;Tu&lt;/code&gt;, &lt;code&gt;We&lt;/code&gt;, &lt;code&gt;Th&lt;/code&gt;, &lt;code&gt;Fr&lt;/code&gt;, &lt;code&gt;Sa&lt;/code&gt;, &lt;code&gt;Su&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;Times are specified using 24:00 time. For example, 3pm is specified as &lt;code&gt;15:00&lt;/code&gt;. &lt;/li&gt;
        /// &lt;li&gt;Here is an example: &lt;code&gt;&amp;lt;time itemprop="openingHours" datetime=&amp;quot;Tu,Th 16:00-20:00&amp;quot;&amp;gt;Tuesdays and Thursdays 4-8pm&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;If a business is open 7 days a week, then it can be specified as &lt;code&gt;&amp;lt;time itemprop=&amp;quot;openingHours&amp;quot; datetime=&amp;quot;Mo-Su&amp;quot;&amp;gt;Monday through Sunday, all day&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "openingHours", Order = 242)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? OpeningHours { get; set; } 

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 243)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<IOwns>? Owns { get; set; } //OwnershipInfo, Product

        /// <summary>
        /// The larger organization that this organization is a &lt;a class="localLink" href="http://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
        /// </summary>
        [DataMember(Name = "parentOrganization", Order = 244)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<Organization>? ParentOrganization { get; set; } 

        /// <summary>
        /// Cash, credit card, etc.
        /// </summary>
        [DataMember(Name = "paymentAccepted", Order = 245)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PaymentAccepted { get; set; } 

        /// <summary>
        /// The price range of the business, for example &lt;code&gt;$$$&lt;/code&gt;.
        /// </summary>
        [DataMember(Name = "priceRange", Order = 246)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? PriceRange { get; set; } 

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;/p&gt;
        /// &lt;p&gt;While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 247)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<IPublishingPrinciples>? PublishingPrinciples { get; set; } //CreativeWork, Uri

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 248)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<Review>? Review { get; set; } 

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 249)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<Demand>? Seeks { get; set; } 

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 250)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<ISponsor>? Sponsor { get; set; } //Organization, Person

        /// <summary>
        /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
        /// </summary>
        [DataMember(Name = "subOrganization", Order = 251)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<Organization>? SubOrganization { get; set; } 

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 252)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? TaxID { get; set; } 

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 253)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? Telephone { get; set; } 

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (typically a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement about policy on use of unnamed sources and the decision process required.
        /// </summary>
        [DataMember(Name = "unnamedSourcesPolicy", Order = 254)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<IUnnamedSourcesPolicy>? UnnamedSourcesPolicy { get; set; } //CreativeWork, Uri

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 255)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<string>? VatID { get; set; } 
    }
}

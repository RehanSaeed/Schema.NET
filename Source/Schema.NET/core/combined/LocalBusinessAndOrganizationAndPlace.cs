namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// See LocalBusiness, Organization, Place for more information.
    /// </summary>
    [DataContract]
    public abstract partial class LocalBusinessAndOrganizationAndPlace : OrganizationAndPlace
    {














        public interface ICurrenciesAccepted : IValue {}
        public interface ICurrenciesAccepted<T> : ICurrenciesAccepted { new T Value { get; } }
        public class OneOrManyCurrenciesAccepted : OneOrMany<ICurrenciesAccepted>
        {
            public OneOrManyCurrenciesAccepted(ICurrenciesAccepted item) : base(item) { }
            public OneOrManyCurrenciesAccepted(IEnumerable<ICurrenciesAccepted> items) : base(items) { }
            public static implicit operator OneOrManyCurrenciesAccepted (string value) { return new OneOrManyCurrenciesAccepted (new CurrenciesAcceptedstring (value)); }
            public static implicit operator OneOrManyCurrenciesAccepted (string[] values) { return new OneOrManyCurrenciesAccepted (values.Select(v => (ICurrenciesAccepted) new CurrenciesAcceptedstring (v))); }
            public static implicit operator OneOrManyCurrenciesAccepted (List<string> values) { return new OneOrManyCurrenciesAccepted (values.Select(v => (ICurrenciesAccepted) new CurrenciesAcceptedstring (v))); }
        }
        public struct CurrenciesAcceptedstring : ICurrenciesAccepted<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CurrenciesAcceptedstring (string value) { Value = value; }
            public static implicit operator CurrenciesAcceptedstring (string value) { return new CurrenciesAcceptedstring (value); }
        }












































        public interface IOpeningHours : IValue {}
        public interface IOpeningHours<T> : IOpeningHours { new T Value { get; } }
        public class OneOrManyOpeningHours : OneOrMany<IOpeningHours>
        {
            public OneOrManyOpeningHours(IOpeningHours item) : base(item) { }
            public OneOrManyOpeningHours(IEnumerable<IOpeningHours> items) : base(items) { }
            public static implicit operator OneOrManyOpeningHours (string value) { return new OneOrManyOpeningHours (new OpeningHoursstring (value)); }
            public static implicit operator OneOrManyOpeningHours (string[] values) { return new OneOrManyOpeningHours (values.Select(v => (IOpeningHours) new OpeningHoursstring (v))); }
            public static implicit operator OneOrManyOpeningHours (List<string> values) { return new OneOrManyOpeningHours (values.Select(v => (IOpeningHours) new OpeningHoursstring (v))); }
        }
        public struct OpeningHoursstring : IOpeningHours<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public OpeningHoursstring (string value) { Value = value; }
            public static implicit operator OpeningHoursstring (string value) { return new OpeningHoursstring (value); }
        }





        public interface IPaymentAccepted : IValue {}
        public interface IPaymentAccepted<T> : IPaymentAccepted { new T Value { get; } }
        public class OneOrManyPaymentAccepted : OneOrMany<IPaymentAccepted>
        {
            public OneOrManyPaymentAccepted(IPaymentAccepted item) : base(item) { }
            public OneOrManyPaymentAccepted(IEnumerable<IPaymentAccepted> items) : base(items) { }
            public static implicit operator OneOrManyPaymentAccepted (string value) { return new OneOrManyPaymentAccepted (new PaymentAcceptedstring (value)); }
            public static implicit operator OneOrManyPaymentAccepted (string[] values) { return new OneOrManyPaymentAccepted (values.Select(v => (IPaymentAccepted) new PaymentAcceptedstring (v))); }
            public static implicit operator OneOrManyPaymentAccepted (List<string> values) { return new OneOrManyPaymentAccepted (values.Select(v => (IPaymentAccepted) new PaymentAcceptedstring (v))); }
        }
        public struct PaymentAcceptedstring : IPaymentAccepted<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PaymentAcceptedstring (string value) { Value = value; }
            public static implicit operator PaymentAcceptedstring (string value) { return new PaymentAcceptedstring (value); }
        }


        public interface IPriceRange : IValue {}
        public interface IPriceRange<T> : IPriceRange { new T Value { get; } }
        public class OneOrManyPriceRange : OneOrMany<IPriceRange>
        {
            public OneOrManyPriceRange(IPriceRange item) : base(item) { }
            public OneOrManyPriceRange(IEnumerable<IPriceRange> items) : base(items) { }
            public static implicit operator OneOrManyPriceRange (string value) { return new OneOrManyPriceRange (new PriceRangestring (value)); }
            public static implicit operator OneOrManyPriceRange (string[] values) { return new OneOrManyPriceRange (values.Select(v => (IPriceRange) new PriceRangestring (v))); }
            public static implicit operator OneOrManyPriceRange (List<string> values) { return new OneOrManyPriceRange (values.Select(v => (IPriceRange) new PriceRangestring (v))); }
        }
        public struct PriceRangestring : IPriceRange<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public PriceRangestring (string value) { Value = value; }
            public static implicit operator PriceRangestring (string value) { return new PriceRangestring (value); }
        }













        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LocalBusinessAndOrganizationAndPlace";

        /// <summary>
        /// For a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; or other news-related &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, a statement about public engagement activities (for news media, the newsroom’s), including involving the public - digitally or otherwise -- in coverage decisions, reporting and activities after publication.
        /// </summary>
        [DataMember(Name = "actionableFeedbackPolicy", Order = 206)]
        public override OneOrManyActionableFeedbackPolicy ActionableFeedbackPolicy { get; set; }

        /// <summary>
        /// A property-value pair representing an additional characteristics of the entitity, e.g. a product feature or another characteristic for which there is no matching property in schema.org.&lt;br/&gt;&lt;br/&gt;
        /// Note: Publishers should be aware that applications designed to use specific schema.org properties (e.g. http://schema.org/width, http://schema.org/color, http://schema.org/gtin13, ...) will typically expect such data to be provided using those properties, rather than using the generic property/value mechanism.
        /// </summary>
        [DataMember(Name = "additionalProperty", Order = 207)]
        public override OneOrManyAdditionalProperty AdditionalProperty { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 208)]
        public override OneOrManyAddress Address { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 209)]
        public override OneOrManyAggregateRating AggregateRating { get; set; }

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni", Order = 210)]
        public override OneOrManyAlumni Alumni { get; set; }

        /// <summary>
        /// An amenity feature (e.g. a characteristic or service) of the Accommodation. This generic property does not make a statement about whether the feature is included in an offer for the main accommodation or available at extra costs.
        /// </summary>
        [DataMember(Name = "amenityFeature", Order = 211)]
        public override OneOrManyAmenityFeature AmenityFeature { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 212)]
        public override OneOrManyAreaServed AreaServed { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 213)]
        public override OneOrManyAward Award { get; set; }

        /// <summary>
        /// A short textual code (also called "store code") that uniquely identifies a place of business. The code is typically assigned by the parentOrganization and used in structured URLs.&lt;br/&gt;&lt;br/&gt;
        /// For example, in the URL http://www.starbucks.co.uk/store-locator/etc/detail/3047 the code "3047" is a branchCode for a particular branch.
        /// </summary>
        [DataMember(Name = "branchCode", Order = 214)]
        public override OneOrManyBranchCode BranchCode { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 215)]
        public override OneOrManyBrand Brand { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 216)]
        public override OneOrManyContactPoint ContactPoint { get; set; }

        /// <summary>
        /// The basic containment relation between a place and one that contains it.
        /// </summary>
        [DataMember(Name = "containedInPlace", Order = 217)]
        public override OneOrManyContainedInPlace ContainedInPlace { get; set; }

        /// <summary>
        /// The basic containment relation between a place and another that it contains.
        /// </summary>
        [DataMember(Name = "containsPlace", Order = 218)]
        public override OneOrManyContainsPlace ContainsPlace { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement describing (in news media, the newsroom’s) disclosure and correction policy for errors.
        /// </summary>
        [DataMember(Name = "correctionsPolicy", Order = 219)]
        public override OneOrManyCorrectionsPolicy CorrectionsPolicy { get; set; }

        /// <summary>
        /// The currency accepted.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "currenciesAccepted", Order = 220)]
        public OneOrManyCurrenciesAccepted CurrenciesAccepted { get; set; }

        /// <summary>
        /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        [DataMember(Name = "department", Order = 221)]
        public override OneOrManyDepartment Department { get; set; }

        /// <summary>
        /// The date that this organization was dissolved.
        /// </summary>
        [DataMember(Name = "dissolutionDate", Order = 222)]
        public override OneOrManyDissolutionDate DissolutionDate { get; set; }

        /// <summary>
        /// Statement on diversity policy by an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; e.g. a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;. For a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, a statement describing the newsroom’s diversity policy on both staffing and sources, typically providing staffing data.
        /// </summary>
        [DataMember(Name = "diversityPolicy", Order = 223)]
        public override OneOrManyDiversityPolicy DiversityPolicy { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a report on staffing diversity issues. In a news context this might be for example ASNE or RTDNA (US) reports, or self-reported.
        /// </summary>
        [DataMember(Name = "diversityStaffingReport", Order = 224)]
        public override OneOrManyDiversityStaffingReport DiversityStaffingReport { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 225)]
        public override OneOrManyDuns Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 226)]
        public override OneOrManyEmail Email { get; set; }

        /// <summary>
        /// Someone working for this organization.
        /// </summary>
        [DataMember(Name = "employee", Order = 227)]
        public override OneOrManyEmployee Employee { get; set; }

        /// <summary>
        /// Statement about ethics policy, e.g. of a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; regarding journalistic and publishing practices, or of a &lt;a class="localLink" href="http://schema.org/Restaurant"&gt;Restaurant&lt;/a&gt;, a page describing food source policies. In the case of a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, an ethicsPolicy is typically a statement describing the personal, organizational, and corporate standards of behavior expected by the organization.
        /// </summary>
        [DataMember(Name = "ethicsPolicy", Order = 228)]
        public override OneOrManyEthicsPolicy EthicsPolicy { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 229)]
        public override OneOrManyEvent Event { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 230)]
        public override OneOrManyFaxNumber FaxNumber { get; set; }

        /// <summary>
        /// A person who founded this organization.
        /// </summary>
        [DataMember(Name = "founder", Order = 231)]
        public override OneOrManyFounder Founder { get; set; }

        /// <summary>
        /// The date that this organization was founded.
        /// </summary>
        [DataMember(Name = "foundingDate", Order = 232)]
        public override OneOrManyFoundingDate FoundingDate { get; set; }

        /// <summary>
        /// The place where the Organization was founded.
        /// </summary>
        [DataMember(Name = "foundingLocation", Order = 233)]
        public override OneOrManyFoundingLocation FoundingLocation { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 234)]
        public override OneOrManyFunder Funder { get; set; }

        /// <summary>
        /// The geo coordinates of the place.
        /// </summary>
        [DataMember(Name = "geo", Order = 235)]
        public override OneOrManyGeo Geo { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a containing geometry to a contained geometry. "a contains b iff no points of b lie in the exterior of a, and at least one point of the interior of b lies in the interior of a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyContains", Order = 236)]
        public override OneOrManyGeospatiallyContains GeospatiallyContains { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that covers it. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCoveredBy", Order = 237)]
        public override OneOrManyGeospatiallyCoveredBy GeospatiallyCoveredBy { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a covering geometry to a covered geometry. "Every point of b is a point of (the interior or boundary of) a". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCovers", Order = 238)]
        public override OneOrManyGeospatiallyCovers GeospatiallyCovers { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that crosses it: "a crosses b: they have some but not all interior points in common, and the dimension of the intersection is less than that of at least one of them". As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyCrosses", Order = 239)]
        public override OneOrManyGeospatiallyCrosses GeospatiallyCrosses { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically disjoint: they have no point in common. They form a set of disconnected geometries." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;)
        /// </summary>
        [DataMember(Name = "geospatiallyDisjoint", Order = 240)]
        public override OneOrManyGeospatiallyDisjoint GeospatiallyDisjoint { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) are topologically equal, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;. "Two geometries are topologically equal if their interiors intersect and no part of the interior or boundary of one geometry intersects the exterior of the other" (a symmetric relationship)
        /// </summary>
        [DataMember(Name = "geospatiallyEquals", Order = 241)]
        public override OneOrManyGeospatiallyEquals GeospatiallyEquals { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) have at least one point in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyIntersects", Order = 242)]
        public override OneOrManyGeospatiallyIntersects GeospatiallyIntersects { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to another that geospatially overlaps it, i.e. they have some but not all points in common. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyOverlaps", Order = 243)]
        public override OneOrManyGeospatiallyOverlaps GeospatiallyOverlaps { get; set; }

        /// <summary>
        /// Represents spatial relations in which two geometries (or the places they represent) touch: they have at least one boundary point in common, but no interior points." (a symmetric relationship, as defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt; )
        /// </summary>
        [DataMember(Name = "geospatiallyTouches", Order = 244)]
        public override OneOrManyGeospatiallyTouches GeospatiallyTouches { get; set; }

        /// <summary>
        /// Represents a relationship between two geometries (or the places they represent), relating a geometry to one that contains it, i.e. it is inside (i.e. within) its interior. As defined in &lt;a href="https://en.wikipedia.org/wiki/DE-9IM"&gt;DE-9IM&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "geospatiallyWithin", Order = 245)]
        public override OneOrManyGeospatiallyWithin GeospatiallyWithin { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 246)]
        public override OneOrManyGlobalLocationNumber GlobalLocationNumber { get; set; }

        /// <summary>
        /// A URL to a map of the place.
        /// </summary>
        [DataMember(Name = "hasMap", Order = 247)]
        public override OneOrManyHasMap HasMap { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 248)]
        public override OneOrManyHasOfferCatalog HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 249)]
        public override OneOrManyHasPOS HasPOS { get; set; }

        /// <summary>
        /// A flag to signal that the item, event, or place is accessible for free.
        /// </summary>
        [DataMember(Name = "isAccessibleForFree", Order = 250)]
        public override OneOrManyIsAccessibleForFree IsAccessibleForFree { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 251)]
        public override OneOrManyIsicV4 IsicV4 { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or yet relate this to educational content, events, objectives or &lt;a class="localLink" href="http://schema.org/JobPosting"&gt;JobPosting&lt;/a&gt; descriptions.
        /// </summary>
        [DataMember(Name = "knowsAbout", Order = 252)]
        public override OneOrManyKnowsAbout KnowsAbout { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "knowsLanguage", Order = 253)]
        public override OneOrManyKnowsLanguage KnowsLanguage { get; set; }

        /// <summary>
        /// The official name of the organization, e.g. the registered company name.
        /// </summary>
        [DataMember(Name = "legalName", Order = 254)]
        public override OneOrManyLegalName LegalName { get; set; }

        /// <summary>
        /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        /// </summary>
        [DataMember(Name = "leiCode", Order = 255)]
        public override OneOrManyLeiCode LeiCode { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 256)]
        public override OneOrManyLocation Location { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 257)]
        public override OneOrManyLogo Logo { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 258)]
        public override OneOrManyMakesOffer MakesOffer { get; set; }

        /// <summary>
        /// The total number of individuals that may attend an event or venue.
        /// </summary>
        [DataMember(Name = "maximumAttendeeCapacity", Order = 259)]
        public override OneOrManyMaximumAttendeeCapacity MaximumAttendeeCapacity { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 260)]
        public override OneOrManyMember Member { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 261)]
        public override OneOrManyMemberOf MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 262)]
        public override OneOrManyNaics Naics { get; set; }

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [DataMember(Name = "numberOfEmployees", Order = 263)]
        public override OneOrManyNumberOfEmployees NumberOfEmployees { get; set; }

        /// <summary>
        /// The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Days are specified using the following two-letter combinations: &lt;code&gt;Mo&lt;/code&gt;, &lt;code&gt;Tu&lt;/code&gt;, &lt;code&gt;We&lt;/code&gt;, &lt;code&gt;Th&lt;/code&gt;, &lt;code&gt;Fr&lt;/code&gt;, &lt;code&gt;Sa&lt;/code&gt;, &lt;code&gt;Su&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;Times are specified using 24:00 time. For example, 3pm is specified as &lt;code&gt;15:00&lt;/code&gt;. &lt;/li&gt;
        /// &lt;li&gt;Here is an example: &lt;code&gt;&amp;lt;time itemprop="openingHours" datetime=&amp;quot;Tu,Th 16:00-20:00&amp;quot;&amp;gt;Tuesdays and Thursdays 4-8pm&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;If a business is open 7 days a week, then it can be specified as &lt;code&gt;&amp;lt;time itemprop=&amp;quot;openingHours&amp;quot; datetime=&amp;quot;Mo-Su&amp;quot;&amp;gt;Monday through Sunday, all day&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "openingHours", Order = 264)]
        public virtual OneOrManyOpeningHours OpeningHours { get; set; }

        /// <summary>
        /// The opening hours of a certain place.
        /// </summary>
        [DataMember(Name = "openingHoursSpecification", Order = 265)]
        public override OneOrManyOpeningHoursSpecification OpeningHoursSpecification { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a description of organizational ownership structure; funding and grants. In a news/media setting, this is with particular reference to editorial independence.   Note that the &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt; is also available and can be used to make basic funder information machine-readable.
        /// </summary>
        [DataMember(Name = "ownershipFundingInfo", Order = 266)]
        public override OneOrManyOwnershipFundingInfo OwnershipFundingInfo { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 267)]
        public override OneOrManyOwns Owns { get; set; }

        /// <summary>
        /// The larger organization that this organization is a &lt;a class="localLink" href="http://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
        /// </summary>
        [DataMember(Name = "parentOrganization", Order = 268)]
        public override OneOrManyParentOrganization ParentOrganization { get; set; }

        /// <summary>
        /// Cash, Credit Card, Cryptocurrency, Local Exchange Tradings System, etc.
        /// </summary>
        [DataMember(Name = "paymentAccepted", Order = 269)]
        public OneOrManyPaymentAccepted PaymentAccepted { get; set; }

        /// <summary>
        /// A photograph of this place.
        /// </summary>
        [DataMember(Name = "photo", Order = 270)]
        public override OneOrManyPhoto Photo { get; set; }

        /// <summary>
        /// The price range of the business, for example &lt;code&gt;$$$&lt;/code&gt;.
        /// </summary>
        [DataMember(Name = "priceRange", Order = 271)]
        public OneOrManyPriceRange PriceRange { get; set; }

        /// <summary>
        /// A flag to signal that the &lt;a class="localLink" href="http://schema.org/Place"&gt;Place&lt;/a&gt; is open to public visitors.  If this property is omitted there is no assumed default boolean value
        /// </summary>
        [DataMember(Name = "publicAccess", Order = 272)]
        public override OneOrManyPublicAccess PublicAccess { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 273)]
        public override OneOrManyPublishingPrinciples PublishingPrinciples { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 274)]
        public override OneOrManyReview Review { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 275)]
        public override OneOrManySeeks Seeks { get; set; }

        /// <summary>
        /// Indicates whether it is allowed to smoke in the place, e.g. in the restaurant, hotel or hotel room.
        /// </summary>
        [DataMember(Name = "smokingAllowed", Order = 276)]
        public override OneOrManySmokingAllowed SmokingAllowed { get; set; }

        /// <summary>
        /// The special opening hours of a certain place.&lt;br/&gt;&lt;br/&gt;
        /// Use this to explicitly override general opening hours brought in scope by &lt;a class="localLink" href="http://schema.org/openingHoursSpecification"&gt;openingHoursSpecification&lt;/a&gt; or &lt;a class="localLink" href="http://schema.org/openingHours"&gt;openingHours&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "specialOpeningHoursSpecification", Order = 277)]
        public override OneOrManySpecialOpeningHoursSpecification SpecialOpeningHoursSpecification { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 278)]
        public override OneOrManySponsor Sponsor { get; set; }

        /// <summary>
        /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
        /// </summary>
        [DataMember(Name = "subOrganization", Order = 279)]
        public override OneOrManySubOrganization SubOrganization { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 280)]
        public override OneOrManyTaxID TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 281)]
        public override OneOrManyTelephone Telephone { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (typically a &lt;a class="localLink" href="http://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement about policy on use of unnamed sources and the decision process required.
        /// </summary>
        [DataMember(Name = "unnamedSourcesPolicy", Order = 282)]
        public override OneOrManyUnnamedSourcesPolicy UnnamedSourcesPolicy { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 283)]
        public override OneOrManyVatID VatID { get; set; }
    }
}

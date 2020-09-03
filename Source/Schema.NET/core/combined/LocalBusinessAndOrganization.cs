namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See LocalBusiness, Organization for more information.
    /// </summary>
    public partial interface ILocalBusinessAndOrganization : ILocalBusiness, IOrganization
    {
    }

    /// <summary>
    /// See LocalBusiness, Organization for more information.
    /// </summary>
    [DataContract]
    public abstract partial class LocalBusinessAndOrganization : OrganizationAndPlace, ILocalBusinessAndOrganization, IEquatable<LocalBusinessAndOrganization>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LocalBusinessAndOrganization";

        /// <summary>
        /// For a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; or other news-related &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt;, a statement about public engagement activities (for news media, the newsroom’s), including involving the public - digitally or otherwise -- in coverage decisions, reporting and activities after publication.
        /// </summary>
        [DataMember(Name = "actionableFeedbackPolicy", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<ICreativeWork, Uri> ActionableFeedbackPolicy { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Alumni { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IAdministrativeArea, IGeoShape, IPlace, string> AreaServed { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> Award { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IBrand, IOrganization> Brand { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IContactPoint> ContactPoint { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (e.g. &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement describing (in news media, the newsroom’s) disclosure and correction policy for errors.
        /// </summary>
        [DataMember(Name = "correctionsPolicy", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<ICreativeWork, Uri> CorrectionsPolicy { get; set; }

        /// <summary>
        /// The currency accepted.&lt;br/&gt;&lt;br/&gt;
        /// Use standard formats: &lt;a href="http://en.wikipedia.org/wiki/ISO_4217"&gt;ISO 4217 currency format&lt;/a&gt; e.g. "USD"; &lt;a href="https://en.wikipedia.org/wiki/List_of_cryptocurrencies"&gt;Ticker symbol&lt;/a&gt; for cryptocurrencies e.g. "BTC"; well known names for &lt;a href="https://en.wikipedia.org/wiki/Local_exchange_trading_system"&gt;Local Exchange Tradings Systems&lt;/a&gt; (LETS) and other currency types e.g. "Ithaca HOUR".
        /// </summary>
        [DataMember(Name = "currenciesAccepted", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CurrenciesAccepted { get; set; }

        /// <summary>
        /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        [DataMember(Name = "department", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IOrganization> Department { get; set; }

        /// <summary>
        /// The date that this organization was dissolved.
        /// </summary>
        [DataMember(Name = "dissolutionDate", Order = 217)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public override Values<int?, DateTime?> DissolutionDate { get; set; }

        /// <summary>
        /// Statement on diversity policy by an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; e.g. a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;. For a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, a statement describing the newsroom’s diversity policy on both staffing and sources, typically providing staffing data.
        /// </summary>
        [DataMember(Name = "diversityPolicy", Order = 218)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<ICreativeWork, Uri> DiversityPolicy { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a report on staffing diversity issues. In a news context this might be for example ASNE or RTDNA (US) reports, or self-reported.
        /// </summary>
        [DataMember(Name = "diversityStaffingReport", Order = 219)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IArticle, Uri> DiversityStaffingReport { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 220)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 221)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> Email { get; set; }

        /// <summary>
        /// Someone working for this organization.
        /// </summary>
        [DataMember(Name = "employee", Order = 222)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Employee { get; set; }

        /// <summary>
        /// Statement about ethics policy, e.g. of a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt; regarding journalistic and publishing practices, or of a &lt;a class="localLink" href="https://schema.org/Restaurant"&gt;Restaurant&lt;/a&gt;, a page describing food source policies. In the case of a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;, an ethicsPolicy is typically a statement describing the personal, organizational, and corporate standards of behavior expected by the organization.
        /// </summary>
        [DataMember(Name = "ethicsPolicy", Order = 223)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<ICreativeWork, Uri> EthicsPolicy { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 224)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IEvent> Events { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 225)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> FaxNumber { get; set; }

        /// <summary>
        /// A person who founded this organization.
        /// </summary>
        [DataMember(Name = "founder", Order = 226)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPerson> Founder { get; set; }

        /// <summary>
        /// The date that this organization was founded.
        /// </summary>
        [DataMember(Name = "foundingDate", Order = 227)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public override Values<int?, DateTime?> FoundingDate { get; set; }

        /// <summary>
        /// The place where the Organization was founded.
        /// </summary>
        [DataMember(Name = "foundingLocation", Order = 228)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPlace> FoundingLocation { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 229)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IOrganization, IPerson> Funder { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 230)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 231)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IOfferCatalog> HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 232)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IPlace> HasPOS { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
        /// </summary>
        [DataMember(Name = "interactionStatistic", Order = 233)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IInteractionCounter> InteractionStatistic { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 234)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> IsicV4 { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or relate this to educational content, events, objectives or &lt;a class="localLink" href="https://schema.org/JobPosting"&gt;JobPosting&lt;/a&gt; descriptions.
        /// </summary>
        [DataMember(Name = "knowsAbout", Order = 235)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<string, IThing, Uri> KnowsAbout { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "knowsLanguage", Order = 236)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<ILanguage, string> KnowsLanguage { get; set; }

        /// <summary>
        /// The official name of the organization, e.g. the registered company name.
        /// </summary>
        [DataMember(Name = "legalName", Order = 237)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> LegalName { get; set; }

        /// <summary>
        /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        /// </summary>
        [DataMember(Name = "leiCode", Order = 238)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> LeiCode { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 239)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IPlace, IPostalAddress, string> Location { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 240)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IImageObject, Uri> Logo { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 241)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IOffer> MakesOffer { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 242)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IOrganization, IPerson> Member { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 243)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IOrganization, IProgramMembership> MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 244)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> Naics { get; set; }

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [DataMember(Name = "numberOfEmployees", Order = 245)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IQuantitativeValue> NumberOfEmployees { get; set; }

        /// <summary>
        /// The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Days are specified using the following two-letter combinations: &lt;code&gt;Mo&lt;/code&gt;, &lt;code&gt;Tu&lt;/code&gt;, &lt;code&gt;We&lt;/code&gt;, &lt;code&gt;Th&lt;/code&gt;, &lt;code&gt;Fr&lt;/code&gt;, &lt;code&gt;Sa&lt;/code&gt;, &lt;code&gt;Su&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;Times are specified using 24:00 time. For example, 3pm is specified as &lt;code&gt;15:00&lt;/code&gt;. &lt;/li&gt;
        /// &lt;li&gt;Here is an example: &lt;code&gt;&amp;lt;time itemprop="openingHours" datetime=&amp;quot;Tu,Th 16:00-20:00&amp;quot;&amp;gt;Tuesdays and Thursdays 4-8pm&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;If a business is open 7 days a week, then it can be specified as &lt;code&gt;&amp;lt;time itemprop=&amp;quot;openingHours&amp;quot; datetime=&amp;quot;Mo-Su&amp;quot;&amp;gt;Monday through Sunday, all day&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "openingHours", Order = 246)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> OpeningHours { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (often but not necessarily a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a description of organizational ownership structure; funding and grants. In a news/media setting, this is with particular reference to editorial independence.   Note that the &lt;a class="localLink" href="https://schema.org/funder"&gt;funder&lt;/a&gt; is also available and can be used to make basic funder information machine-readable.
        /// </summary>
        [DataMember(Name = "ownershipFundingInfo", Order = 247)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IAboutPage, ICreativeWork, string, Uri> OwnershipFundingInfo { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 248)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IOwnershipInfo, IProduct> Owns { get; set; }

        /// <summary>
        /// The larger organization that this organization is a &lt;a class="localLink" href="https://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
        /// </summary>
        [DataMember(Name = "parentOrganization", Order = 249)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IOrganization> ParentOrganization { get; set; }

        /// <summary>
        /// Cash, Credit Card, Cryptocurrency, Local Exchange Tradings System, etc.
        /// </summary>
        [DataMember(Name = "paymentAccepted", Order = 250)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PaymentAccepted { get; set; }

        /// <summary>
        /// The price range of the business, for example &lt;code&gt;$$$&lt;/code&gt;.
        /// </summary>
        [DataMember(Name = "priceRange", Order = 251)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PriceRange { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="https://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="https://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="https://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 252)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<ICreativeWork, Uri> PublishingPrinciples { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 253)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 254)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IDemand> Seeks { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        [DataMember(Name = "slogan", Order = 255)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> Slogan { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 256)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
        /// </summary>
        [DataMember(Name = "subOrganization", Order = 257)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<IOrganization> SubOrganization { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 258)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 259)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> Telephone { get; set; }

        /// <summary>
        /// For an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (typically a &lt;a class="localLink" href="https://schema.org/NewsMediaOrganization"&gt;NewsMediaOrganization&lt;/a&gt;), a statement about policy on use of unnamed sources and the decision process required.
        /// </summary>
        [DataMember(Name = "unnamedSourcesPolicy", Order = 260)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override Values<ICreativeWork, Uri> UnnamedSourcesPolicy { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 261)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> VatID { get; set; }

        /// <inheritdoc/>
        public bool Equals(LocalBusinessAndOrganization other)
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
                this.CurrenciesAccepted == other.CurrenciesAccepted &&
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
                this.OpeningHours == other.OpeningHours &&
                this.OwnershipFundingInfo == other.OwnershipFundingInfo &&
                this.Owns == other.Owns &&
                this.ParentOrganization == other.ParentOrganization &&
                this.PaymentAccepted == other.PaymentAccepted &&
                this.PriceRange == other.PriceRange &&
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
        public override bool Equals(object obj) => this.Equals(obj as LocalBusinessAndOrganization);

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
            .And(this.CurrenciesAccepted)
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
            .And(this.OpeningHours)
            .And(this.OwnershipFundingInfo)
            .And(this.Owns)
            .And(this.ParentOrganization)
            .And(this.PaymentAccepted)
            .And(this.PriceRange)
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

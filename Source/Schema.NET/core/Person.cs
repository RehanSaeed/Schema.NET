namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
    public partial interface IPerson : IThing
    {
        /// <summary>
        /// An additional name for a Person, can be used for a middle name.
        /// </summary>
        OneOrMany<string> AdditionalName { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
        /// </summary>
        OneOrMany<IOrganization> Affiliation { get; set; }

        /// <summary>
        /// An organization that the person is an alumni of.
        /// </summary>
        Values<IEducationalOrganization, IOrganization> AlumniOf { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        OneOrMany<string> Award { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        Values<int?, DateTime?> BirthDate { get; set; }

        /// <summary>
        /// The place where the person was born.
        /// </summary>
        OneOrMany<IPlace> BirthPlace { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        Values<IBrand, IOrganization> Brand { get; set; }

        /// <summary>
        /// A &lt;a href="https://en.wikipedia.org/wiki/Call_sign"&gt;callsign&lt;/a&gt;, as used in broadcasting and radio communications to identify people, radio and TV stations, or vehicles.
        /// </summary>
        OneOrMany<string> CallSign { get; set; }

        /// <summary>
        /// A child of the person.
        /// </summary>
        OneOrMany<IPerson> Children { get; set; }

        /// <summary>
        /// A colleague of the person.
        /// </summary>
        Values<IPerson, Uri> Colleague { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        OneOrMany<IContactPoint> ContactPoint { get; set; }

        /// <summary>
        /// Date of death.
        /// </summary>
        Values<int?, DateTime?> DeathDate { get; set; }

        /// <summary>
        /// The place where the person died.
        /// </summary>
        OneOrMany<IPlace> DeathPlace { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        OneOrMany<string> Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        OneOrMany<string> Email { get; set; }

        /// <summary>
        /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.
        /// </summary>
        OneOrMany<string> FamilyName { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        OneOrMany<string> FaxNumber { get; set; }

        /// <summary>
        /// The most generic uni-directional social relation.
        /// </summary>
        OneOrMany<IPerson> Follows { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        Values<IOrganization, IPerson> Funder { get; set; }

        /// <summary>
        /// Gender of something, typically a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt;, but possibly also fictional characters, animals, etc. While https://schema.org/Male and https://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender. The &lt;a class="localLink" href="https://schema.org/gender"&gt;gender&lt;/a&gt; property can also be used in an extended sense to cover e.g. the gender of sports teams. As with the gender of individuals, we do not try to enumerate all possibilities. A mixed-gender &lt;a class="localLink" href="https://schema.org/SportsTeam"&gt;SportsTeam&lt;/a&gt; can be indicated with a text value of "Mixed".
        /// </summary>
        Values<GenderType?, string> Gender { get; set; }

        /// <summary>
        /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.
        /// </summary>
        OneOrMany<string> GivenName { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        OneOrMany<string> GlobalLocationNumber { get; set; }

        /// <summary>
        /// The Person's occupation. For past professions, use Role for expressing dates.
        /// </summary>
        OneOrMany<IOccupation> HasOccupation { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        OneOrMany<IOfferCatalog> HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        OneOrMany<IPlace> HasPOS { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        Values<string, IQuantitativeValue> Height { get; set; }

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        Values<IContactPoint, IPlace> HomeLocation { get; set; }

        /// <summary>
        /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
        /// </summary>
        OneOrMany<string> HonorificPrefix { get; set; }

        /// <summary>
        /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
        /// </summary>
        OneOrMany<string> HonorificSuffix { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
        /// </summary>
        OneOrMany<IInteractionCounter> InteractionStatistic { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        OneOrMany<string> IsicV4 { get; set; }

        /// <summary>
        /// The job title of the person (for example, Financial Manager).
        /// </summary>
        OneOrMany<string> JobTitle { get; set; }

        /// <summary>
        /// The most generic bi-directional social/work relation.
        /// </summary>
        OneOrMany<IPerson> Knows { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or relate this to educational content, events, objectives or &lt;a class="localLink" href="https://schema.org/JobPosting"&gt;JobPosting&lt;/a&gt; descriptions.
        /// </summary>
        Values<string, IThing, Uri> KnowsAbout { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;.
        /// </summary>
        Values<ILanguage, string> KnowsLanguage { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        OneOrMany<IOffer> MakesOffer { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        Values<IOrganization, IProgramMembership> MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        OneOrMany<string> Naics { get; set; }

        /// <summary>
        /// Nationality of the person.
        /// </summary>
        OneOrMany<ICountry> Nationality { get; set; }

        /// <summary>
        /// The total financial value of the person as calculated by subtracting assets from liabilities.
        /// </summary>
        Values<IMonetaryAmount, IPriceSpecification> NetWorth { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        Values<IOwnershipInfo, IProduct> Owns { get; set; }

        /// <summary>
        /// A parent of this person.
        /// </summary>
        OneOrMany<IPerson> Parent { get; set; }

        /// <summary>
        /// Event that this person is a performer or participant in.
        /// </summary>
        OneOrMany<IEvent> PerformerIn { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="https://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="https://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="https://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        Values<ICreativeWork, Uri> PublishingPrinciples { get; set; }

        /// <summary>
        /// The most generic familial relation.
        /// </summary>
        OneOrMany<IPerson> RelatedTo { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        OneOrMany<IDemand> Seeks { get; set; }

        /// <summary>
        /// A sibling of the person.
        /// </summary>
        OneOrMany<IPerson> Sibling { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// The person's spouse.
        /// </summary>
        OneOrMany<IPerson> Spouse { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        OneOrMany<string> TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        OneOrMany<string> Telephone { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        OneOrMany<string> VatID { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        OneOrMany<IQuantitativeValue> Weight { get; set; }

        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        Values<IContactPoint, IPlace> WorkLocation { get; set; }

        /// <summary>
        /// Organizations that the person works for.
        /// </summary>
        OneOrMany<IOrganization> WorksFor { get; set; }
    }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
    [DataContract]
    public partial class Person : Thing, IPerson, IEquatable<Person>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Person";

        /// <summary>
        /// An additional name for a Person, can be used for a middle name.
        /// </summary>
        [DataMember(Name = "additionalName", Order = 106)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AdditionalName { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 107)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPostalAddress, string> Address { get; set; }

        /// <summary>
        /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
        /// </summary>
        [DataMember(Name = "affiliation", Order = 108)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> Affiliation { get; set; }

        /// <summary>
        /// An organization that the person is an alumni of.
        /// </summary>
        [DataMember(Name = "alumniOf", Order = 109)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IEducationalOrganization, IOrganization> AlumniOf { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 110)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Award { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        [DataMember(Name = "birthDate", Order = 111)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> BirthDate { get; set; }

        /// <summary>
        /// The place where the person was born.
        /// </summary>
        [DataMember(Name = "birthPlace", Order = 112)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> BirthPlace { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 113)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IBrand, IOrganization> Brand { get; set; }

        /// <summary>
        /// A &lt;a href="https://en.wikipedia.org/wiki/Call_sign"&gt;callsign&lt;/a&gt;, as used in broadcasting and radio communications to identify people, radio and TV stations, or vehicles.
        /// </summary>
        [DataMember(Name = "callSign", Order = 114)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CallSign { get; set; }

        /// <summary>
        /// A child of the person.
        /// </summary>
        [DataMember(Name = "children", Order = 115)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Children { get; set; }

        /// <summary>
        /// A colleague of the person.
        /// </summary>
        [DataMember(Name = "colleague", Order = 116)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPerson, Uri> Colleague { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 117)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IContactPoint> ContactPoint { get; set; }

        /// <summary>
        /// Date of death.
        /// </summary>
        [DataMember(Name = "deathDate", Order = 118)]
        [JsonConverter(typeof(DateTimeToIso8601DateValuesJsonConverter))]
        public Values<int?, DateTime?> DeathDate { get; set; }

        /// <summary>
        /// The place where the person died.
        /// </summary>
        [DataMember(Name = "deathPlace", Order = 119)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPlace> DeathPlace { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 120)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 121)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Email { get; set; }

        /// <summary>
        /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.
        /// </summary>
        [DataMember(Name = "familyName", Order = 122)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FamilyName { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 123)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FaxNumber { get; set; }

        /// <summary>
        /// The most generic uni-directional social relation.
        /// </summary>
        [DataMember(Name = "follows", Order = 124)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Follows { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 125)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Funder { get; set; }

        /// <summary>
        /// Gender of something, typically a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt;, but possibly also fictional characters, animals, etc. While https://schema.org/Male and https://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender. The &lt;a class="localLink" href="https://schema.org/gender"&gt;gender&lt;/a&gt; property can also be used in an extended sense to cover e.g. the gender of sports teams. As with the gender of individuals, we do not try to enumerate all possibilities. A mixed-gender &lt;a class="localLink" href="https://schema.org/SportsTeam"&gt;SportsTeam&lt;/a&gt; can be indicated with a text value of "Mixed".
        /// </summary>
        [DataMember(Name = "gender", Order = 126)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<GenderType?, string> Gender { get; set; }

        /// <summary>
        /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.
        /// </summary>
        [DataMember(Name = "givenName", Order = 127)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> GivenName { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 128)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> GlobalLocationNumber { get; set; }

        /// <summary>
        /// The Person's occupation. For past professions, use Role for expressing dates.
        /// </summary>
        [DataMember(Name = "hasOccupation", Order = 129)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOccupation> HasOccupation { get; set; }

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
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 132)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IQuantitativeValue> Height { get; set; }

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        [DataMember(Name = "homeLocation", Order = 133)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IContactPoint, IPlace> HomeLocation { get; set; }

        /// <summary>
        /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
        /// </summary>
        [DataMember(Name = "honorificPrefix", Order = 134)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> HonorificPrefix { get; set; }

        /// <summary>
        /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
        /// </summary>
        [DataMember(Name = "honorificSuffix", Order = 135)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> HonorificSuffix { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication. The most specific child type of InteractionCounter should be used.
        /// </summary>
        [DataMember(Name = "interactionStatistic", Order = 136)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IInteractionCounter> InteractionStatistic { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 137)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> IsicV4 { get; set; }

        /// <summary>
        /// The job title of the person (for example, Financial Manager).
        /// </summary>
        [DataMember(Name = "jobTitle", Order = 138)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> JobTitle { get; set; }

        /// <summary>
        /// The most generic bi-directional social/work relation.
        /// </summary>
        [DataMember(Name = "knows", Order = 139)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Knows { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a topic that is known about - suggesting possible expertise but not implying it. We do not distinguish skill levels here, or relate this to educational content, events, objectives or &lt;a class="localLink" href="https://schema.org/JobPosting"&gt;JobPosting&lt;/a&gt; descriptions.
        /// </summary>
        [DataMember(Name = "knowsAbout", Order = 140)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, IThing, Uri> KnowsAbout { get; set; }

        /// <summary>
        /// Of a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt;, and less typically of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt;, to indicate a known language. We do not distinguish skill levels or reading/writing/speaking/signing here. Use language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "knowsLanguage", Order = 141)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> KnowsLanguage { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 142)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOffer> MakesOffer { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 143)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IProgramMembership> MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 144)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Naics { get; set; }

        /// <summary>
        /// Nationality of the person.
        /// </summary>
        [DataMember(Name = "nationality", Order = 145)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICountry> Nationality { get; set; }

        /// <summary>
        /// The total financial value of the person as calculated by subtracting assets from liabilities.
        /// </summary>
        [DataMember(Name = "netWorth", Order = 146)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, IPriceSpecification> NetWorth { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 147)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOwnershipInfo, IProduct> Owns { get; set; }

        /// <summary>
        /// A parent of this person.
        /// </summary>
        [DataMember(Name = "parent", Order = 148)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Parent { get; set; }

        /// <summary>
        /// Event that this person is a performer or participant in.
        /// </summary>
        [DataMember(Name = "performerIn", Order = 149)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> PerformerIn { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="https://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="https://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="https://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="https://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="https://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;br/&gt;&lt;br/&gt;
        /// While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="https://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 150)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ICreativeWork, Uri> PublishingPrinciples { get; set; }

        /// <summary>
        /// The most generic familial relation.
        /// </summary>
        [DataMember(Name = "relatedTo", Order = 151)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> RelatedTo { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 152)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDemand> Seeks { get; set; }

        /// <summary>
        /// A sibling of the person.
        /// </summary>
        [DataMember(Name = "sibling", Order = 153)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Sibling { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 154)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Sponsor { get; set; }

        /// <summary>
        /// The person's spouse.
        /// </summary>
        [DataMember(Name = "spouse", Order = 155)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Spouse { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 156)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 157)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Telephone { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 158)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> VatID { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        [DataMember(Name = "weight", Order = 159)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> Weight { get; set; }

        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        [DataMember(Name = "workLocation", Order = 160)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IContactPoint, IPlace> WorkLocation { get; set; }

        /// <summary>
        /// Organizations that the person works for.
        /// </summary>
        [DataMember(Name = "worksFor", Order = 161)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> WorksFor { get; set; }

        /// <inheritdoc/>
        public bool Equals(Person other)
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
                this.AdditionalName == other.AdditionalName &&
                this.Address == other.Address &&
                this.Affiliation == other.Affiliation &&
                this.AlumniOf == other.AlumniOf &&
                this.Award == other.Award &&
                this.BirthDate == other.BirthDate &&
                this.BirthPlace == other.BirthPlace &&
                this.Brand == other.Brand &&
                this.CallSign == other.CallSign &&
                this.Children == other.Children &&
                this.Colleague == other.Colleague &&
                this.ContactPoint == other.ContactPoint &&
                this.DeathDate == other.DeathDate &&
                this.DeathPlace == other.DeathPlace &&
                this.Duns == other.Duns &&
                this.Email == other.Email &&
                this.FamilyName == other.FamilyName &&
                this.FaxNumber == other.FaxNumber &&
                this.Follows == other.Follows &&
                this.Funder == other.Funder &&
                this.Gender == other.Gender &&
                this.GivenName == other.GivenName &&
                this.GlobalLocationNumber == other.GlobalLocationNumber &&
                this.HasOccupation == other.HasOccupation &&
                this.HasOfferCatalog == other.HasOfferCatalog &&
                this.HasPOS == other.HasPOS &&
                this.Height == other.Height &&
                this.HomeLocation == other.HomeLocation &&
                this.HonorificPrefix == other.HonorificPrefix &&
                this.HonorificSuffix == other.HonorificSuffix &&
                this.InteractionStatistic == other.InteractionStatistic &&
                this.IsicV4 == other.IsicV4 &&
                this.JobTitle == other.JobTitle &&
                this.Knows == other.Knows &&
                this.KnowsAbout == other.KnowsAbout &&
                this.KnowsLanguage == other.KnowsLanguage &&
                this.MakesOffer == other.MakesOffer &&
                this.MemberOf == other.MemberOf &&
                this.Naics == other.Naics &&
                this.Nationality == other.Nationality &&
                this.NetWorth == other.NetWorth &&
                this.Owns == other.Owns &&
                this.Parent == other.Parent &&
                this.PerformerIn == other.PerformerIn &&
                this.PublishingPrinciples == other.PublishingPrinciples &&
                this.RelatedTo == other.RelatedTo &&
                this.Seeks == other.Seeks &&
                this.Sibling == other.Sibling &&
                this.Sponsor == other.Sponsor &&
                this.Spouse == other.Spouse &&
                this.TaxID == other.TaxID &&
                this.Telephone == other.Telephone &&
                this.VatID == other.VatID &&
                this.Weight == other.Weight &&
                this.WorkLocation == other.WorkLocation &&
                this.WorksFor == other.WorksFor &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Person);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AdditionalName)
            .And(this.Address)
            .And(this.Affiliation)
            .And(this.AlumniOf)
            .And(this.Award)
            .And(this.BirthDate)
            .And(this.BirthPlace)
            .And(this.Brand)
            .And(this.CallSign)
            .And(this.Children)
            .And(this.Colleague)
            .And(this.ContactPoint)
            .And(this.DeathDate)
            .And(this.DeathPlace)
            .And(this.Duns)
            .And(this.Email)
            .And(this.FamilyName)
            .And(this.FaxNumber)
            .And(this.Follows)
            .And(this.Funder)
            .And(this.Gender)
            .And(this.GivenName)
            .And(this.GlobalLocationNumber)
            .And(this.HasOccupation)
            .And(this.HasOfferCatalog)
            .And(this.HasPOS)
            .And(this.Height)
            .And(this.HomeLocation)
            .And(this.HonorificPrefix)
            .And(this.HonorificSuffix)
            .And(this.InteractionStatistic)
            .And(this.IsicV4)
            .And(this.JobTitle)
            .And(this.Knows)
            .And(this.KnowsAbout)
            .And(this.KnowsLanguage)
            .And(this.MakesOffer)
            .And(this.MemberOf)
            .And(this.Naics)
            .And(this.Nationality)
            .And(this.NetWorth)
            .And(this.Owns)
            .And(this.Parent)
            .And(this.PerformerIn)
            .And(this.PublishingPrinciples)
            .And(this.RelatedTo)
            .And(this.Seeks)
            .And(this.Sibling)
            .And(this.Sponsor)
            .And(this.Spouse)
            .And(this.TaxID)
            .And(this.Telephone)
            .And(this.VatID)
            .And(this.Weight)
            .And(this.WorkLocation)
            .And(this.WorksFor)
            .And(base.GetHashCode());
    }
}

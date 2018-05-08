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
        OneOrMany<string>? AdditionalName { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        Values<IPostalAddress, string>? Address { get; set; }

        /// <summary>
        /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
        /// </summary>
        OneOrMany<IOrganization>? Affiliation { get; set; }

        /// <summary>
        /// An organization that the person is an alumni of.
        /// </summary>
        Values<IEducationalOrganization, IOrganization>? AlumniOf { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        OneOrMany<string>? Award { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        OneOrMany<DateTimeOffset?>? BirthDate { get; set; }

        /// <summary>
        /// The place where the person was born.
        /// </summary>
        OneOrMany<IPlace>? BirthPlace { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        Values<IBrand, IOrganization>? Brand { get; set; }

        /// <summary>
        /// A child of the person.
        /// </summary>
        OneOrMany<IPerson>? Children { get; set; }

        /// <summary>
        /// A colleague of the person.
        /// </summary>
        Values<IPerson, Uri>? Colleague { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        OneOrMany<IContactPoint>? ContactPoint { get; set; }

        /// <summary>
        /// Date of death.
        /// </summary>
        OneOrMany<DateTimeOffset?>? DeathDate { get; set; }

        /// <summary>
        /// The place where the person died.
        /// </summary>
        OneOrMany<IPlace>? DeathPlace { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        OneOrMany<string>? Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        OneOrMany<string>? Email { get; set; }

        /// <summary>
        /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.
        /// </summary>
        OneOrMany<string>? FamilyName { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        OneOrMany<string>? FaxNumber { get; set; }

        /// <summary>
        /// The most generic uni-directional social relation.
        /// </summary>
        OneOrMany<IPerson>? Follows { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        Values<IOrganization, IPerson>? Funder { get; set; }

        /// <summary>
        /// Gender of the person. While http://schema.org/Male and http://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender.
        /// </summary>
        Values<GenderType?, string>? Gender { get; set; }

        /// <summary>
        /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.
        /// </summary>
        OneOrMany<string>? GivenName { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        OneOrMany<string>? GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        OneOrMany<IOfferCatalog>? HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        OneOrMany<IPlace>? HasPOS { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        Values<string, IQuantitativeValue>? Height { get; set; }

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        Values<IContactPoint, IPlace>? HomeLocation { get; set; }

        /// <summary>
        /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
        /// </summary>
        OneOrMany<string>? HonorificPrefix { get; set; }

        /// <summary>
        /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
        /// </summary>
        OneOrMany<string>? HonorificSuffix { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        OneOrMany<string>? IsicV4 { get; set; }

        /// <summary>
        /// The job title of the person (for example, Financial Manager).
        /// </summary>
        OneOrMany<string>? JobTitle { get; set; }

        /// <summary>
        /// The most generic bi-directional social/work relation.
        /// </summary>
        OneOrMany<IPerson>? Knows { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        OneOrMany<IOffer>? MakesOffer { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        Values<IOrganization, IProgramMembership>? MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        OneOrMany<string>? Naics { get; set; }

        /// <summary>
        /// Nationality of the person.
        /// </summary>
        OneOrMany<ICountry>? Nationality { get; set; }

        /// <summary>
        /// The total financial value of the person as calculated by subtracting assets from liabilities.
        /// </summary>
        Values<IMonetaryAmount, IPriceSpecification>? NetWorth { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        Values<IOwnershipInfo, IProduct>? Owns { get; set; }

        /// <summary>
        /// A parent of this person.
        /// </summary>
        OneOrMany<IPerson>? Parent { get; set; }

        /// <summary>
        /// Event that this person is a performer or participant in.
        /// </summary>
        OneOrMany<IEvent>? PerformerIn { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;/p&gt;
        /// &lt;p&gt;While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        Values<ICreativeWork, Uri>? PublishingPrinciples { get; set; }

        /// <summary>
        /// The most generic familial relation.
        /// </summary>
        OneOrMany<IPerson>? RelatedTo { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        OneOrMany<IDemand>? Seeks { get; set; }

        /// <summary>
        /// A sibling of the person.
        /// </summary>
        OneOrMany<IPerson>? Sibling { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        Values<IOrganization, IPerson>? Sponsor { get; set; }

        /// <summary>
        /// The person's spouse.
        /// </summary>
        OneOrMany<IPerson>? Spouse { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        OneOrMany<string>? TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        OneOrMany<string>? Telephone { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        OneOrMany<string>? VatID { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        OneOrMany<IQuantitativeValue>? Weight { get; set; }

        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        Values<IContactPoint, IPlace>? WorkLocation { get; set; }

        /// <summary>
        /// Organizations that the person works for.
        /// </summary>
        OneOrMany<IOrganization>? WorksFor { get; set; }
    }

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
    [DataContract]
    public partial class Person : Thing, IPerson
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
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? AdditionalName { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 107)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPostalAddress, string>? Address { get; set; }

        /// <summary>
        /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
        /// </summary>
        [DataMember(Name = "affiliation", Order = 108)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IOrganization>? Affiliation { get; set; }

        /// <summary>
        /// An organization that the person is an alumni of.
        /// </summary>
        [DataMember(Name = "alumniOf", Order = 109)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IEducationalOrganization, IOrganization>? AlumniOf { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 110)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Award { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        [DataMember(Name = "birthDate", Order = 111)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? BirthDate { get; set; }

        /// <summary>
        /// The place where the person was born.
        /// </summary>
        [DataMember(Name = "birthPlace", Order = 112)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPlace>? BirthPlace { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 113)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IBrand, IOrganization>? Brand { get; set; }

        /// <summary>
        /// A child of the person.
        /// </summary>
        [DataMember(Name = "children", Order = 114)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Children { get; set; }

        /// <summary>
        /// A colleague of the person.
        /// </summary>
        [DataMember(Name = "colleague", Order = 115)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPerson, Uri>? Colleague { get; set; }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 116)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IContactPoint>? ContactPoint { get; set; }

        /// <summary>
        /// Date of death.
        /// </summary>
        [DataMember(Name = "deathDate", Order = 117)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? DeathDate { get; set; }

        /// <summary>
        /// The place where the person died.
        /// </summary>
        [DataMember(Name = "deathPlace", Order = 118)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPlace>? DeathPlace { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 119)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 120)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Email { get; set; }

        /// <summary>
        /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.
        /// </summary>
        [DataMember(Name = "familyName", Order = 121)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? FamilyName { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 122)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? FaxNumber { get; set; }

        /// <summary>
        /// The most generic uni-directional social relation.
        /// </summary>
        [DataMember(Name = "follows", Order = 123)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Follows { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 124)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IOrganization, IPerson>? Funder { get; set; }

        /// <summary>
        /// Gender of the person. While http://schema.org/Male and http://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender.
        /// </summary>
        [DataMember(Name = "gender", Order = 125)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<GenderType?, string>? Gender { get; set; }

        /// <summary>
        /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.
        /// </summary>
        [DataMember(Name = "givenName", Order = 126)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? GivenName { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 127)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 128)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IOfferCatalog>? HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 129)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPlace>? HasPOS { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 130)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, IQuantitativeValue>? Height { get; set; }

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        [DataMember(Name = "homeLocation", Order = 131)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IContactPoint, IPlace>? HomeLocation { get; set; }

        /// <summary>
        /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
        /// </summary>
        [DataMember(Name = "honorificPrefix", Order = 132)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? HonorificPrefix { get; set; }

        /// <summary>
        /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
        /// </summary>
        [DataMember(Name = "honorificSuffix", Order = 133)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? HonorificSuffix { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 134)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? IsicV4 { get; set; }

        /// <summary>
        /// The job title of the person (for example, Financial Manager).
        /// </summary>
        [DataMember(Name = "jobTitle", Order = 135)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? JobTitle { get; set; }

        /// <summary>
        /// The most generic bi-directional social/work relation.
        /// </summary>
        [DataMember(Name = "knows", Order = 136)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Knows { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 137)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IOffer>? MakesOffer { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 138)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IOrganization, IProgramMembership>? MemberOf { get; set; }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 139)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Naics { get; set; }

        /// <summary>
        /// Nationality of the person.
        /// </summary>
        [DataMember(Name = "nationality", Order = 140)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<ICountry>? Nationality { get; set; }

        /// <summary>
        /// The total financial value of the person as calculated by subtracting assets from liabilities.
        /// </summary>
        [DataMember(Name = "netWorth", Order = 141)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMonetaryAmount, IPriceSpecification>? NetWorth { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 142)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IOwnershipInfo, IProduct>? Owns { get; set; }

        /// <summary>
        /// A parent of this person.
        /// </summary>
        [DataMember(Name = "parent", Order = 143)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Parent { get; set; }

        /// <summary>
        /// Event that this person is a performer or participant in.
        /// </summary>
        [DataMember(Name = "performerIn", Order = 144)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IEvent>? PerformerIn { get; set; }

        /// <summary>
        /// The publishingPrinciples property indicates (typically via &lt;a class="localLink" href="http://schema.org/URL"&gt;URL&lt;/a&gt;) a document describing the editorial principles of an &lt;a class="localLink" href="http://schema.org/Organization"&gt;Organization&lt;/a&gt; (or individual e.g. a &lt;a class="localLink" href="http://schema.org/Person"&gt;Person&lt;/a&gt; writing a blog) that relate to their activities as a publisher, e.g. ethics or diversity policies. When applied to a &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt; (e.g. &lt;a class="localLink" href="http://schema.org/NewsArticle"&gt;NewsArticle&lt;/a&gt;) the principles are those of the party primarily responsible for the creation of the &lt;a class="localLink" href="http://schema.org/CreativeWork"&gt;CreativeWork&lt;/a&gt;.&lt;/p&gt;
        /// &lt;p&gt;While such policies are most typically expressed in natural language, sometimes related information (e.g. indicating a &lt;a class="localLink" href="http://schema.org/funder"&gt;funder&lt;/a&gt;) can be expressed using schema.org terminology.
        /// </summary>
        [DataMember(Name = "publishingPrinciples", Order = 145)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ICreativeWork, Uri>? PublishingPrinciples { get; set; }

        /// <summary>
        /// The most generic familial relation.
        /// </summary>
        [DataMember(Name = "relatedTo", Order = 146)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? RelatedTo { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 147)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IDemand>? Seeks { get; set; }

        /// <summary>
        /// A sibling of the person.
        /// </summary>
        [DataMember(Name = "sibling", Order = 148)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Sibling { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 149)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IOrganization, IPerson>? Sponsor { get; set; }

        /// <summary>
        /// The person's spouse.
        /// </summary>
        [DataMember(Name = "spouse", Order = 150)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Spouse { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 151)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 152)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Telephone { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 153)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? VatID { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        [DataMember(Name = "weight", Order = 154)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IQuantitativeValue>? Weight { get; set; }

        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        [DataMember(Name = "workLocation", Order = 155)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IContactPoint, IPlace>? WorkLocation { get; set; }

        /// <summary>
        /// Organizations that the person works for.
        /// </summary>
        [DataMember(Name = "worksFor", Order = 156)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IOrganization>? WorksFor { get; set; }
    }
}

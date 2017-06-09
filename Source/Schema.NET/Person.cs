namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A person (alive, dead, undead, or fictional).
    /// </summary>
    [DataContract]
    public class Person : Thing
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Person";

        /// <summary>
        /// An additional name for a Person, can be used for a middle name.
        /// </summary>
        [DataMember(Name = "additionalName", Order = 2)]
        public string AdditionalName { get; set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 3)]
        public object Address { get; protected set; }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [IgnoreDataMember]
        public PostalAddress AddressPostalAddress
        {
            get => this.Address as PostalAddress;
            set => this.Address = value;
        }

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [IgnoreDataMember]
        public string AddressText
        {
            get => this.Address as string;
            set => this.Address = value;
        }

        /// <summary>
        /// An organization that this person is affiliated with. For example, a school/university, a club, or a team.
        /// </summary>
        [DataMember(Name = "affiliation", Order = 4)]
        public Organization Affiliation { get; set; }

        /// <summary>
        /// An organization that the person is an alumni of.
        /// </summary>
        [DataMember(Name = "alumniOf", Order = 5)]
        public object AlumniOf { get; protected set; }

        /// <summary>
        /// An organization that the person is an alumni of.
        /// </summary>
        [IgnoreDataMember]
        public EducationalOrganization AlumniOfEducationalOrganization
        {
            get => this.AlumniOf as EducationalOrganization;
            set => this.AlumniOf = value;
        }

        /// <summary>
        /// An organization that the person is an alumni of.
        /// </summary>
        [IgnoreDataMember]
        public Organization AlumniOfOrganization
        {
            get => this.AlumniOf as Organization;
            set => this.AlumniOf = value;
        }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 6)]
        public string Award { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        [DataMember(Name = "birthDate", Order = 7)]
        public DateTimeOffset? BirthDate { get; set; }

        /// <summary>
        /// The place where the person was born.
        /// </summary>
        [DataMember(Name = "birthPlace", Order = 8)]
        public Place BirthPlace { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 9)]
        public object Brand { get; protected set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [IgnoreDataMember]
        public Brand BrandBrand
        {
            get => this.Brand as Brand;
            set => this.Brand = value;
        }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [IgnoreDataMember]
        public Organization BrandOrganization
        {
            get => this.Brand as Organization;
            set => this.Brand = value;
        }

        /// <summary>
        /// A child of the person.
        /// </summary>
        [DataMember(Name = "children", Order = 10)]
        public Person Children { get; set; }

        /// <summary>
        /// A colleague of the person.
        /// </summary>
        [DataMember(Name = "colleague", Order = 11)]
        public object Colleague { get; protected set; }

        /// <summary>
        /// A colleague of the person.
        /// </summary>
        [IgnoreDataMember]
        public Person ColleaguePerson
        {
            get => this.Colleague as Person;
            set => this.Colleague = value;
        }

        /// <summary>
        /// A colleague of the person.
        /// </summary>
        [IgnoreDataMember]
        public Uri ColleagueURL
        {
            get => this.Colleague as Uri;
            set => this.Colleague = value;
        }

        /// <summary>
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 12)]
        public ContactPoint ContactPoint { get; set; }

        /// <summary>
        /// Date of death.
        /// </summary>
        [DataMember(Name = "deathDate", Order = 13)]
        public DateTimeOffset? DeathDate { get; set; }

        /// <summary>
        /// The place where the person died.
        /// </summary>
        [DataMember(Name = "deathPlace", Order = 14)]
        public Place DeathPlace { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 15)]
        public string Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 16)]
        public string Email { get; set; }

        /// <summary>
        /// Family name. In the U.S., the last name of an Person. This can be used along with givenName instead of the name property.
        /// </summary>
        [DataMember(Name = "familyName", Order = 17)]
        public string FamilyName { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 18)]
        public string FaxNumber { get; set; }

        /// <summary>
        /// The most generic uni-directional social relation.
        /// </summary>
        [DataMember(Name = "follows", Order = 19)]
        public Person Follows { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 20)]
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
        /// Gender of the person. While http://schema.org/Male and http://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender.
        /// </summary>
        [DataMember(Name = "gender", Order = 21)]
        public object Gender { get; protected set; }

        /// <summary>
        /// Gender of the person. While http://schema.org/Male and http://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender.
        /// </summary>
        [IgnoreDataMember]
        public string GenderText
        {
            get => this.Gender as string;
            set => this.Gender = value;
        }

        /// <summary>
        /// Gender of the person. While http://schema.org/Male and http://schema.org/Female may be used, text strings are also acceptable for people who do not identify as a binary gender.
        /// </summary>
        [IgnoreDataMember]
        public GenderType GenderGenderType
        {
            get => this.Gender as GenderType;
            set => this.Gender = value;
        }

        /// <summary>
        /// Given name. In the U.S., the first name of a Person. This can be used along with familyName instead of the name property.
        /// </summary>
        [DataMember(Name = "givenName", Order = 22)]
        public string GivenName { get; set; }

        /// <summary>
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 23)]
        public string GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 24)]
        public OfferCatalog HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 25)]
        public Place HasPOS { get; set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [DataMember(Name = "height", Order = 26)]
        public object Height { get; protected set; }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [IgnoreDataMember]
        public Distance HeightDistance
        {
            get => this.Height as Distance;
            set => this.Height = value;
        }

        /// <summary>
        /// The height of the item.
        /// </summary>
        [IgnoreDataMember]
        public QuantitativeValue HeightQuantitativeValue
        {
            get => this.Height as QuantitativeValue;
            set => this.Height = value;
        }

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        [DataMember(Name = "homeLocation", Order = 27)]
        public object HomeLocation { get; protected set; }

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        [IgnoreDataMember]
        public Place HomeLocationPlace
        {
            get => this.HomeLocation as Place;
            set => this.HomeLocation = value;
        }

        /// <summary>
        /// A contact location for a person's residence.
        /// </summary>
        [IgnoreDataMember]
        public ContactPoint HomeLocationContactPoint
        {
            get => this.HomeLocation as ContactPoint;
            set => this.HomeLocation = value;
        }

        /// <summary>
        /// An honorific prefix preceding a Person's name such as Dr/Mrs/Mr.
        /// </summary>
        [DataMember(Name = "honorificPrefix", Order = 28)]
        public string HonorificPrefix { get; set; }

        /// <summary>
        /// An honorific suffix preceding a Person's name such as M.D. /PhD/MSCSW.
        /// </summary>
        [DataMember(Name = "honorificSuffix", Order = 29)]
        public string HonorificSuffix { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 30)]
        public string IsicV4 { get; set; }

        /// <summary>
        /// The job title of the person (for example, Financial Manager).
        /// </summary>
        [DataMember(Name = "jobTitle", Order = 31)]
        public string JobTitle { get; set; }

        /// <summary>
        /// The most generic bi-directional social/work relation.
        /// </summary>
        [DataMember(Name = "knows", Order = 32)]
        public Person Knows { get; set; }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 33)]
        public Offer MakesOffer { get; set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 34)]
        public object MemberOf { get; protected set; }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [IgnoreDataMember]
        public Organization MemberOfOrganization
        {
            get => this.MemberOf as Organization;
            set => this.MemberOf = value;
        }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [IgnoreDataMember]
        public ProgramMembership MemberOfProgramMembership
        {
            get => this.MemberOf as ProgramMembership;
            set => this.MemberOf = value;
        }

        /// <summary>
        /// The North American Industry Classification System (NAICS) code for a particular organization or business person.
        /// </summary>
        [DataMember(Name = "naics", Order = 35)]
        public string Naics { get; set; }

        /// <summary>
        /// Nationality of the person.
        /// </summary>
        [DataMember(Name = "nationality", Order = 36)]
        public Country Nationality { get; set; }

        /// <summary>
        /// The total financial value of the person as calculated by subtracting assets from liabilities.
        /// </summary>
        [DataMember(Name = "netWorth", Order = 37)]
        public object NetWorth { get; protected set; }

        /// <summary>
        /// The total financial value of the person as calculated by subtracting assets from liabilities.
        /// </summary>
        [IgnoreDataMember]
        public MonetaryAmount NetWorthMonetaryAmount
        {
            get => this.NetWorth as MonetaryAmount;
            set => this.NetWorth = value;
        }

        /// <summary>
        /// The total financial value of the person as calculated by subtracting assets from liabilities.
        /// </summary>
        [IgnoreDataMember]
        public PriceSpecification NetWorthPriceSpecification
        {
            get => this.NetWorth as PriceSpecification;
            set => this.NetWorth = value;
        }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 38)]
        public object Owns { get; protected set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [IgnoreDataMember]
        public Product OwnsProduct
        {
            get => this.Owns as Product;
            set => this.Owns = value;
        }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [IgnoreDataMember]
        public OwnershipInfo OwnsOwnershipInfo
        {
            get => this.Owns as OwnershipInfo;
            set => this.Owns = value;
        }

        /// <summary>
        /// A parent of this person.
        /// </summary>
        [DataMember(Name = "parent", Order = 39)]
        public Person Parent { get; set; }

        /// <summary>
        /// Event that this person is a performer or participant in.
        /// </summary>
        [DataMember(Name = "performerIn", Order = 40)]
        public Event PerformerIn { get; set; }

        /// <summary>
        /// The most generic familial relation.
        /// </summary>
        [DataMember(Name = "relatedTo", Order = 41)]
        public Person RelatedTo { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 42)]
        public Demand Seeks { get; set; }

        /// <summary>
        /// A sibling of the person.
        /// </summary>
        [DataMember(Name = "sibling", Order = 43)]
        public Person Sibling { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 44)]
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
        /// The person's spouse.
        /// </summary>
        [DataMember(Name = "spouse", Order = 45)]
        public Person Spouse { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 46)]
        public string TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 47)]
        public string Telephone { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 48)]
        public string VatID { get; set; }

        /// <summary>
        /// The weight of the product or person.
        /// </summary>
        [DataMember(Name = "weight", Order = 49)]
        public QuantitativeValue Weight { get; set; }

        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        [DataMember(Name = "workLocation", Order = 50)]
        public object WorkLocation { get; protected set; }

        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        [IgnoreDataMember]
        public Place WorkLocationPlace
        {
            get => this.WorkLocation as Place;
            set => this.WorkLocation = value;
        }

        /// <summary>
        /// A contact location for a person's place of work.
        /// </summary>
        [IgnoreDataMember]
        public ContactPoint WorkLocationContactPoint
        {
            get => this.WorkLocation as ContactPoint;
            set => this.WorkLocation = value;
        }

        /// <summary>
        /// Organizations that the person works for.
        /// </summary>
        [DataMember(Name = "worksFor", Order = 51)]
        public Organization WorksFor { get; set; }
    }
}

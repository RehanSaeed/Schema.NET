namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An organization such as a school, NGO, corporation, club, etc.
    /// </summary>
    [DataContract]
    public class Organization : Thing
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Organization";

        /// <summary>
        /// Physical address of the item.
        /// </summary>
        [DataMember(Name = "address", Order = 2)]
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
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 3)]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// Alumni of an organization.
        /// </summary>
        [DataMember(Name = "alumni", Order = 4)]
        public virtual Person Alumni { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 5)]
        public object AreaServed { get; protected set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [IgnoreDataMember]
        public AdministrativeArea AreaServedAdministrativeArea
        {
            get => this.AreaServed as AdministrativeArea;
            set => this.AreaServed = value;
        }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [IgnoreDataMember]
        public GeoShape AreaServedGeoShape
        {
            get => this.AreaServed as GeoShape;
            set => this.AreaServed = value;
        }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [IgnoreDataMember]
        public Place AreaServedPlace
        {
            get => this.AreaServed as Place;
            set => this.AreaServed = value;
        }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [IgnoreDataMember]
        public string AreaServedText
        {
            get => this.AreaServed as string;
            set => this.AreaServed = value;
        }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 6)]
        public string Award { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 7)]
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
        /// A contact point for a person or organization.
        /// </summary>
        [DataMember(Name = "contactPoint", Order = 8)]
        public ContactPoint ContactPoint { get; set; }

        /// <summary>
        /// A relationship between an organization and a department of that organization, also described as an organization (allowing different urls, logos, opening hours). For example: a store with a pharmacy, or a bakery with a cafe.
        /// </summary>
        [DataMember(Name = "department", Order = 9)]
        public Organization Department { get; set; }

        /// <summary>
        /// The date that this organization was dissolved.
        /// </summary>
        [DataMember(Name = "dissolutionDate", Order = 10)]
        public DateTimeOffset? DissolutionDate { get; set; }

        /// <summary>
        /// The Dun &amp;amp; Bradstreet DUNS number for identifying an organization or business person.
        /// </summary>
        [DataMember(Name = "duns", Order = 11)]
        public string Duns { get; set; }

        /// <summary>
        /// Email address.
        /// </summary>
        [DataMember(Name = "email", Order = 12)]
        public string Email { get; set; }

        /// <summary>
        /// Someone working for this organization.
        /// </summary>
        [DataMember(Name = "employee", Order = 13)]
        public Person Employee { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 14)]
        public Event Event { get; set; }

        /// <summary>
        /// The fax number.
        /// </summary>
        [DataMember(Name = "faxNumber", Order = 15)]
        public string FaxNumber { get; set; }

        /// <summary>
        /// A person who founded this organization.
        /// </summary>
        [DataMember(Name = "founder", Order = 16)]
        public Person Founder { get; set; }

        /// <summary>
        /// The date that this organization was founded.
        /// </summary>
        [DataMember(Name = "foundingDate", Order = 17)]
        public DateTimeOffset? FoundingDate { get; set; }

        /// <summary>
        /// The place where the Organization was founded.
        /// </summary>
        [DataMember(Name = "foundingLocation", Order = 18)]
        public Place FoundingLocation { get; set; }

        /// <summary>
        /// A person or organization that supports (sponsors) something through some kind of financial contribution.
        /// </summary>
        [DataMember(Name = "funder", Order = 19)]
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
        /// The &lt;a href="http://www.gs1.org/gln"&gt;Global Location Number&lt;/a&gt; (GLN, sometimes also referred to as International Location Number or ILN) of the respective organization, person, or place. The GLN is a 13-digit number used to identify parties and physical locations.
        /// </summary>
        [DataMember(Name = "globalLocationNumber", Order = 20)]
        public string GlobalLocationNumber { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 21)]
        public OfferCatalog HasOfferCatalog { get; set; }

        /// <summary>
        /// Points-of-Sales operated by the organization or person.
        /// </summary>
        [DataMember(Name = "hasPOS", Order = 22)]
        public Place HasPOS { get; set; }

        /// <summary>
        /// The International Standard of Industrial Classification of All Economic Activities (ISIC), Revision 4 code for a particular organization, business person, or place.
        /// </summary>
        [DataMember(Name = "isicV4", Order = 23)]
        public string IsicV4 { get; set; }

        /// <summary>
        /// The official name of the organization, e.g. the registered company name.
        /// </summary>
        [DataMember(Name = "legalName", Order = 24)]
        public string LegalName { get; set; }

        /// <summary>
        /// An organization identifier that uniquely identifies a legal entity as defined in ISO 17442.
        /// </summary>
        [DataMember(Name = "leiCode", Order = 25)]
        public string LeiCode { get; set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [DataMember(Name = "location", Order = 26)]
        public object Location { get; protected set; }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [IgnoreDataMember]
        public Place LocationPlace
        {
            get => this.Location as Place;
            set => this.Location = value;
        }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [IgnoreDataMember]
        public string LocationText
        {
            get => this.Location as string;
            set => this.Location = value;
        }

        /// <summary>
        /// The location of for example where the event is happening, an organization is located, or where an action takes place.
        /// </summary>
        [IgnoreDataMember]
        public PostalAddress LocationPostalAddress
        {
            get => this.Location as PostalAddress;
            set => this.Location = value;
        }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 27)]
        public object Logo { get; protected set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [IgnoreDataMember]
        public Uri LogoURL
        {
            get => this.Logo as Uri;
            set => this.Logo = value;
        }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [IgnoreDataMember]
        public ImageObject LogoImageObject
        {
            get => this.Logo as ImageObject;
            set => this.Logo = value;
        }

        /// <summary>
        /// A pointer to products or services offered by the organization or person.
        /// </summary>
        [DataMember(Name = "makesOffer", Order = 28)]
        public Offer MakesOffer { get; set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [DataMember(Name = "member", Order = 29)]
        public object Member { get; protected set; }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [IgnoreDataMember]
        public Person MemberPerson
        {
            get => this.Member as Person;
            set => this.Member = value;
        }

        /// <summary>
        /// A member of an Organization or a ProgramMembership. Organizations can be members of organizations; ProgramMembership is typically for individuals.
        /// </summary>
        [IgnoreDataMember]
        public Organization MemberOrganization
        {
            get => this.Member as Organization;
            set => this.Member = value;
        }

        /// <summary>
        /// An Organization (or ProgramMembership) to which this Person or Organization belongs.
        /// </summary>
        [DataMember(Name = "memberOf", Order = 30)]
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
        [DataMember(Name = "naics", Order = 31)]
        public string Naics { get; set; }

        /// <summary>
        /// The number of employees in an organization e.g. business.
        /// </summary>
        [DataMember(Name = "numberOfEmployees", Order = 32)]
        public QuantitativeValue NumberOfEmployees { get; set; }

        /// <summary>
        /// Products owned by the organization or person.
        /// </summary>
        [DataMember(Name = "owns", Order = 33)]
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
        /// The larger organization that this organization is a &lt;a class="localLink" href="http://schema.org/subOrganization"&gt;subOrganization&lt;/a&gt; of, if any.
        /// </summary>
        [DataMember(Name = "parentOrganization", Order = 34)]
        public Organization ParentOrganization { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 35)]
        public Review Review { get; set; }

        /// <summary>
        /// A pointer to products or services sought by the organization or person (demand).
        /// </summary>
        [DataMember(Name = "seeks", Order = 36)]
        public Demand Seeks { get; set; }

        /// <summary>
        /// A person or organization that supports a thing through a pledge, promise, or financial contribution. e.g. a sponsor of a Medical Study or a corporate sponsor of an event.
        /// </summary>
        [DataMember(Name = "sponsor", Order = 37)]
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
        /// A relationship between two organizations where the first includes the second, e.g., as a subsidiary. See also: the more specific 'department' property.
        /// </summary>
        [DataMember(Name = "subOrganization", Order = 38)]
        public Organization SubOrganization { get; set; }

        /// <summary>
        /// The Tax / Fiscal ID of the organization or person, e.g. the TIN in the US or the CIF/NIF in Spain.
        /// </summary>
        [DataMember(Name = "taxID", Order = 39)]
        public string TaxID { get; set; }

        /// <summary>
        /// The telephone number.
        /// </summary>
        [DataMember(Name = "telephone", Order = 40)]
        public string Telephone { get; set; }

        /// <summary>
        /// The Value-added Tax ID of the organization or person.
        /// </summary>
        [DataMember(Name = "vatID", Order = 41)]
        public string VatID { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
    [DataContract]
    public class Service : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Service";

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider")]
        public object Provider { get; protected set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [IgnoreDataMember]
        public Organization ProviderOrganization
        {
            get => this.Provider as Organization;
            set => this.Provider = value;
        }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [IgnoreDataMember]
        public Person ProviderPerson
        {
            get => this.Provider as Person;
            set => this.Provider = value;
        }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience")]
        public Audience Audience { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog")]
        public OfferCatalog HasOfferCatalog { get; set; }

        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        [DataMember(Name = "hoursAvailable")]
        public OpeningHoursSpecification HoursAvailable { get; set; }

        /// <summary>
        /// Indicates the mobility of a provided service (e.g. 'static', 'dynamic').
        /// </summary>
        [DataMember(Name = "providerMobility")]
        public string ProviderMobility { get; set; }

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating")]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers")]
        public Offer Offers { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award")]
        public string Award { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category")]
        public object Category { get; protected set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [IgnoreDataMember]
        public Thing CategoryThing
        {
            get => this.Category as Thing;
            set => this.Category = value;
        }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [IgnoreDataMember]
        public string CategoryText
        {
            get => this.Category as string;
            set => this.Category = value;
        }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker")]
        public object Broker { get; protected set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [IgnoreDataMember]
        public Organization BrokerOrganization
        {
            get => this.Broker as Organization;
            set => this.Broker = value;
        }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [IgnoreDataMember]
        public Person BrokerPerson
        {
            get => this.Broker as Person;
            set => this.Broker = value;
        }

        /// <summary>
        /// The tangible thing generated by the service, e.g. a passport, permit, etc.
        /// </summary>
        [DataMember(Name = "serviceOutput")]
        public Thing ServiceOutput { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo")]
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
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        [DataMember(Name = "isSimilarTo")]
        public object IsSimilarTo { get; protected set; }

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        [IgnoreDataMember]
        public Service IsSimilarToService
        {
            get => this.IsSimilarTo as Service;
            set => this.IsSimilarTo = value;
        }

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        [IgnoreDataMember]
        public Product IsSimilarToProduct
        {
            get => this.IsSimilarTo as Product;
            set => this.IsSimilarTo = value;
        }

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        [DataMember(Name = "isRelatedTo")]
        public object IsRelatedTo { get; protected set; }

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        [IgnoreDataMember]
        public Product IsRelatedToProduct
        {
            get => this.IsRelatedTo as Product;
            set => this.IsRelatedTo = value;
        }

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        [IgnoreDataMember]
        public Service IsRelatedToService
        {
            get => this.IsRelatedTo as Service;
            set => this.IsRelatedTo = value;
        }

        /// <summary>
        /// A means of accessing the service (e.g. a phone bank, a web site, a location, etc.).
        /// </summary>
        [DataMember(Name = "availableChannel")]
        public ServiceChannel AvailableChannel { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review")]
        public Review Review { get; set; }

        /// <summary>
        /// The type of service being offered, e.g. veterans' benefits, emergency relief, etc.
        /// </summary>
        [DataMember(Name = "serviceType")]
        public string ServiceType { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand")]
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
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed")]
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
    }
}

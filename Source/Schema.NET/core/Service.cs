namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
    [DataContract]
    public partial class Service : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Service";

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<AggregateRating>? AggregateRating { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AdministrativeArea, GeoShape, Place, string>? AreaServed { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Audience>? Audience { get; set; }

        /// <summary>
        /// A means of accessing the service (e.g. a phone bank, a web site, a location, etc.).
        /// </summary>
        [DataMember(Name = "availableChannel", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<ServiceChannel>? AvailableChannel { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Award { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Brand, Organization>? Brand { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Broker { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<PhysicalActivityCategory?, string, Thing>? Category { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<OfferCatalog>? HasOfferCatalog { get; set; }

        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        [DataMember(Name = "hoursAvailable", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<OpeningHoursSpecification>? HoursAvailable { get; set; }

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        [DataMember(Name = "isRelatedTo", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Product, Service>? IsRelatedTo { get; set; }

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        [DataMember(Name = "isSimilarTo", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Product, Service>? IsSimilarTo { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ImageObject, Uri>? Logo { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Offer>? Offers { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Provider { get; set; }

        /// <summary>
        /// Indicates the mobility of a provided service (e.g. 'static', 'dynamic').
        /// </summary>
        [DataMember(Name = "providerMobility", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? ProviderMobility { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 222)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Review>? Review { get; set; }

        /// <summary>
        /// The tangible thing generated by the service, e.g. a passport, permit, etc.
        /// </summary>
        [DataMember(Name = "serviceOutput", Order = 223)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Thing>? ServiceOutput { get; set; }

        /// <summary>
        /// The type of service being offered, e.g. veterans' benefits, emergency relief, etc.
        /// </summary>
        [DataMember(Name = "serviceType", Order = 224)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? ServiceType { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        [DataMember(Name = "slogan", Order = 225)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Slogan { get; set; }

        /// <summary>
        /// Human-readable terms of service documentation.
        /// </summary>
        [DataMember(Name = "termsOfService", Order = 226)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? TermsOfService { get; set; }
    }
}

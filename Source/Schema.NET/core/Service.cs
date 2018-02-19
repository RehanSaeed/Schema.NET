using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
    [DataContract]
    public partial class Service : Intangible
    {
        public interface IAreaServed : IWrapper { }
        public interface IAreaServed<T> : IAreaServed { new T Data { get; set; } }
        public class AreaServedAdministrativeArea : IAreaServed<AdministrativeArea>
        {
            object IWrapper.Data { get { return Data; } set { Data = (AdministrativeArea) value; } }
            public virtual AdministrativeArea Data { get; set; }
            public AreaServedAdministrativeArea () { }
            public AreaServedAdministrativeArea (AdministrativeArea data) { Data = data; }
            public static implicit operator AreaServedAdministrativeArea (AdministrativeArea data) { return new AreaServedAdministrativeArea (data); }
        }

        public class AreaServedGeoShape : IAreaServed<GeoShape>
        {
            object IWrapper.Data { get { return Data; } set { Data = (GeoShape) value; } }
            public virtual GeoShape Data { get; set; }
            public AreaServedGeoShape () { }
            public AreaServedGeoShape (GeoShape data) { Data = data; }
            public static implicit operator AreaServedGeoShape (GeoShape data) { return new AreaServedGeoShape (data); }
        }

        public class AreaServedPlace : IAreaServed<Place>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Place) value; } }
            public virtual Place Data { get; set; }
            public AreaServedPlace () { }
            public AreaServedPlace (Place data) { Data = data; }
            public static implicit operator AreaServedPlace (Place data) { return new AreaServedPlace (data); }
        }

        public class AreaServedstring : IAreaServed<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public AreaServedstring () { }
            public AreaServedstring (string data) { Data = data; }
            public static implicit operator AreaServedstring (string data) { return new AreaServedstring (data); }
        }


        public interface IBrand : IWrapper { }
        public interface IBrand<T> : IBrand { new T Data { get; set; } }
        public class BrandBrand : IBrand<Brand>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Brand) value; } }
            public virtual Brand Data { get; set; }
            public BrandBrand () { }
            public BrandBrand (Brand data) { Data = data; }
            public static implicit operator BrandBrand (Brand data) { return new BrandBrand (data); }
        }

        public class BrandOrganization : IBrand<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public BrandOrganization () { }
            public BrandOrganization (Organization data) { Data = data; }
            public static implicit operator BrandOrganization (Organization data) { return new BrandOrganization (data); }
        }


        public interface IBroker : IWrapper { }
        public interface IBroker<T> : IBroker { new T Data { get; set; } }
        public class BrokerOrganization : IBroker<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public BrokerOrganization () { }
            public BrokerOrganization (Organization data) { Data = data; }
            public static implicit operator BrokerOrganization (Organization data) { return new BrokerOrganization (data); }
        }

        public class BrokerPerson : IBroker<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public BrokerPerson () { }
            public BrokerPerson (Person data) { Data = data; }
            public static implicit operator BrokerPerson (Person data) { return new BrokerPerson (data); }
        }


        public interface ICategory : IWrapper { }
        public interface ICategory<T> : ICategory { new T Data { get; set; } }
        public class Categorystring : ICategory<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Categorystring () { }
            public Categorystring (string data) { Data = data; }
            public static implicit operator Categorystring (string data) { return new Categorystring (data); }
        }

        public class CategoryThing : ICategory<Thing>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Thing) value; } }
            public virtual Thing Data { get; set; }
            public CategoryThing () { }
            public CategoryThing (Thing data) { Data = data; }
            public static implicit operator CategoryThing (Thing data) { return new CategoryThing (data); }
        }


        public interface IIsRelatedTo : IWrapper { }
        public interface IIsRelatedTo<T> : IIsRelatedTo { new T Data { get; set; } }
        public class IsRelatedToProduct : IIsRelatedTo<Product>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Product) value; } }
            public virtual Product Data { get; set; }
            public IsRelatedToProduct () { }
            public IsRelatedToProduct (Product data) { Data = data; }
            public static implicit operator IsRelatedToProduct (Product data) { return new IsRelatedToProduct (data); }
        }

        public class IsRelatedToService : IIsRelatedTo<Service>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Service) value; } }
            public virtual Service Data { get; set; }
            public IsRelatedToService () { }
            public IsRelatedToService (Service data) { Data = data; }
            public static implicit operator IsRelatedToService (Service data) { return new IsRelatedToService (data); }
        }


        public interface IIsSimilarTo : IWrapper { }
        public interface IIsSimilarTo<T> : IIsSimilarTo { new T Data { get; set; } }
        public class IsSimilarToProduct : IIsSimilarTo<Product>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Product) value; } }
            public virtual Product Data { get; set; }
            public IsSimilarToProduct () { }
            public IsSimilarToProduct (Product data) { Data = data; }
            public static implicit operator IsSimilarToProduct (Product data) { return new IsSimilarToProduct (data); }
        }

        public class IsSimilarToService : IIsSimilarTo<Service>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Service) value; } }
            public virtual Service Data { get; set; }
            public IsSimilarToService () { }
            public IsSimilarToService (Service data) { Data = data; }
            public static implicit operator IsSimilarToService (Service data) { return new IsSimilarToService (data); }
        }


        public interface ILogo : IWrapper { }
        public interface ILogo<T> : ILogo { new T Data { get; set; } }
        public class LogoImageObject : ILogo<ImageObject>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ImageObject) value; } }
            public virtual ImageObject Data { get; set; }
            public LogoImageObject () { }
            public LogoImageObject (ImageObject data) { Data = data; }
            public static implicit operator LogoImageObject (ImageObject data) { return new LogoImageObject (data); }
        }

        public class LogoUri : ILogo<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public LogoUri () { }
            public LogoUri (Uri data) { Data = data; }
            public static implicit operator LogoUri (Uri data) { return new LogoUri (data); }
        }


        public interface IProvider : IWrapper { }
        public interface IProvider<T> : IProvider { new T Data { get; set; } }
        public class ProviderOrganization : IProvider<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public ProviderOrganization () { }
            public ProviderOrganization (Organization data) { Data = data; }
            public static implicit operator ProviderOrganization (Organization data) { return new ProviderOrganization (data); }
        }

        public class ProviderPerson : IProvider<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public ProviderPerson () { }
            public ProviderPerson (Person data) { Data = data; }
            public static implicit operator ProviderPerson (Person data) { return new ProviderPerson (data); }
        }


        public interface ITermsOfService : IWrapper { }
        public interface ITermsOfService<T> : ITermsOfService { new T Data { get; set; } }
        public class TermsOfServicestring : ITermsOfService<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public TermsOfServicestring () { }
            public TermsOfServicestring (string data) { Data = data; }
            public static implicit operator TermsOfServicestring (string data) { return new TermsOfServicestring (data); }
        }

        public class TermsOfServiceUri : ITermsOfService<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public TermsOfServiceUri () { }
            public TermsOfServiceUri (Uri data) { Data = data; }
            public static implicit operator TermsOfServiceUri (Uri data) { return new TermsOfServiceUri (data); }
        }


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
        public Values<AggregateRating>? AggregateRating { get; set; } 

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAreaServed>? AreaServed { get; set; } //AdministrativeArea, GeoShape, Place, string

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Audience>? Audience { get; set; } 

        /// <summary>
        /// A means of accessing the service (e.g. a phone bank, a web site, a location, etc.).
        /// </summary>
        [DataMember(Name = "availableChannel", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ServiceChannel>? AvailableChannel { get; set; } 

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Award { get; set; } 

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IBrand>? Brand { get; set; } //Brand, Organization

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IBroker>? Broker { get; set; } //Organization, Person

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ICategory>? Category { get; set; } //string, Thing

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OfferCatalog>? HasOfferCatalog { get; set; } 

        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        [DataMember(Name = "hoursAvailable", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<OpeningHoursSpecification>? HoursAvailable { get; set; } 

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        [DataMember(Name = "isRelatedTo", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IIsRelatedTo>? IsRelatedTo { get; set; } //Product, Service

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        [DataMember(Name = "isSimilarTo", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IIsSimilarTo>? IsSimilarTo { get; set; } //Product, Service

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ILogo>? Logo { get; set; } //ImageObject, Uri

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Offer>? Offers { get; set; } 

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IProvider>? Provider { get; set; } //Organization, Person

        /// <summary>
        /// Indicates the mobility of a provided service (e.g. 'static', 'dynamic').
        /// </summary>
        [DataMember(Name = "providerMobility", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ProviderMobility { get; set; } 

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 222)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Review>? Review { get; set; } 

        /// <summary>
        /// The tangible thing generated by the service, e.g. a passport, permit, etc.
        /// </summary>
        [DataMember(Name = "serviceOutput", Order = 223)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? ServiceOutput { get; set; } 

        /// <summary>
        /// The type of service being offered, e.g. veterans' benefits, emergency relief, etc.
        /// </summary>
        [DataMember(Name = "serviceType", Order = 224)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ServiceType { get; set; } 

        /// <summary>
        /// Human-readable terms of service documentation.
        /// </summary>
        [DataMember(Name = "termsOfService", Order = 225)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITermsOfService>? TermsOfService { get; set; } //string, Uri
    }
}

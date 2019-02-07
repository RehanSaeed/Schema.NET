namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A service provided by an organization, e.g. delivery service, print services, etc.
    /// </summary>
    [DataContract]
    public partial class Service : Intangible
    {
        public interface IAggregateRating : IValue {}
        public interface IAggregateRating<T> : IAggregateRating { new T Value { get; } }
        public class OneOrManyAggregateRating : OneOrMany<IAggregateRating>
        {
            public OneOrManyAggregateRating(IAggregateRating item) : base(item) { }
            public OneOrManyAggregateRating(IEnumerable<IAggregateRating> items) : base(items) { }
            public static implicit operator OneOrManyAggregateRating (AggregateRating value) { return new OneOrManyAggregateRating (new AggregateRatingAggregateRating (value)); }
            public static implicit operator OneOrManyAggregateRating (AggregateRating[] values) { return new OneOrManyAggregateRating (values.Select(v => (IAggregateRating) new AggregateRatingAggregateRating (v))); }
            public static implicit operator OneOrManyAggregateRating (List<AggregateRating> values) { return new OneOrManyAggregateRating (values.Select(v => (IAggregateRating) new AggregateRatingAggregateRating (v))); }
        }
        public struct AggregateRatingAggregateRating : IAggregateRating<AggregateRating>
        {
            object IValue.Value => this.Value;
            public AggregateRating Value { get; }
            public AggregateRatingAggregateRating (AggregateRating value) { Value = value; }
            public static implicit operator AggregateRatingAggregateRating (AggregateRating value) { return new AggregateRatingAggregateRating (value); }
        }

        public interface IAreaServed : IValue {}
        public interface IAreaServed<T> : IAreaServed { new T Value { get; } }
        public class OneOrManyAreaServed : OneOrMany<IAreaServed>
        {
            public OneOrManyAreaServed(IAreaServed item) : base(item) { }
            public OneOrManyAreaServed(IEnumerable<IAreaServed> items) : base(items) { }
            public static implicit operator OneOrManyAreaServed (AdministrativeArea value) { return new OneOrManyAreaServed (new AreaServedAdministrativeArea (value)); }
            public static implicit operator OneOrManyAreaServed (AdministrativeArea[] values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedAdministrativeArea (v))); }
            public static implicit operator OneOrManyAreaServed (List<AdministrativeArea> values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedAdministrativeArea (v))); }
            public static implicit operator OneOrManyAreaServed (GeoShape value) { return new OneOrManyAreaServed (new AreaServedGeoShape (value)); }
            public static implicit operator OneOrManyAreaServed (GeoShape[] values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedGeoShape (v))); }
            public static implicit operator OneOrManyAreaServed (List<GeoShape> values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedGeoShape (v))); }
            public static implicit operator OneOrManyAreaServed (Place value) { return new OneOrManyAreaServed (new AreaServedPlace (value)); }
            public static implicit operator OneOrManyAreaServed (Place[] values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedPlace (v))); }
            public static implicit operator OneOrManyAreaServed (List<Place> values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedPlace (v))); }
            public static implicit operator OneOrManyAreaServed (string value) { return new OneOrManyAreaServed (new AreaServedstring (value)); }
            public static implicit operator OneOrManyAreaServed (string[] values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedstring (v))); }
            public static implicit operator OneOrManyAreaServed (List<string> values) { return new OneOrManyAreaServed (values.Select(v => (IAreaServed) new AreaServedstring (v))); }
        }
        public struct AreaServedAdministrativeArea : IAreaServed<AdministrativeArea>
        {
            object IValue.Value => this.Value;
            public AdministrativeArea Value { get; }
            public AreaServedAdministrativeArea (AdministrativeArea value) { Value = value; }
            public static implicit operator AreaServedAdministrativeArea (AdministrativeArea value) { return new AreaServedAdministrativeArea (value); }
        }
        public struct AreaServedGeoShape : IAreaServed<GeoShape>
        {
            object IValue.Value => this.Value;
            public GeoShape Value { get; }
            public AreaServedGeoShape (GeoShape value) { Value = value; }
            public static implicit operator AreaServedGeoShape (GeoShape value) { return new AreaServedGeoShape (value); }
        }
        public struct AreaServedPlace : IAreaServed<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public AreaServedPlace (Place value) { Value = value; }
            public static implicit operator AreaServedPlace (Place value) { return new AreaServedPlace (value); }
        }
        public struct AreaServedstring : IAreaServed<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AreaServedstring (string value) { Value = value; }
            public static implicit operator AreaServedstring (string value) { return new AreaServedstring (value); }
        }

        public interface IAudience : IValue {}
        public interface IAudience<T> : IAudience { new T Value { get; } }
        public class OneOrManyAudience : OneOrMany<IAudience>
        {
            public OneOrManyAudience(IAudience item) : base(item) { }
            public OneOrManyAudience(IEnumerable<IAudience> items) : base(items) { }
            public static implicit operator OneOrManyAudience (Audience value) { return new OneOrManyAudience (new AudienceAudience (value)); }
            public static implicit operator OneOrManyAudience (Audience[] values) { return new OneOrManyAudience (values.Select(v => (IAudience) new AudienceAudience (v))); }
            public static implicit operator OneOrManyAudience (List<Audience> values) { return new OneOrManyAudience (values.Select(v => (IAudience) new AudienceAudience (v))); }
        }
        public struct AudienceAudience : IAudience<Audience>
        {
            object IValue.Value => this.Value;
            public Audience Value { get; }
            public AudienceAudience (Audience value) { Value = value; }
            public static implicit operator AudienceAudience (Audience value) { return new AudienceAudience (value); }
        }

        public interface IAvailableChannel : IValue {}
        public interface IAvailableChannel<T> : IAvailableChannel { new T Value { get; } }
        public class OneOrManyAvailableChannel : OneOrMany<IAvailableChannel>
        {
            public OneOrManyAvailableChannel(IAvailableChannel item) : base(item) { }
            public OneOrManyAvailableChannel(IEnumerable<IAvailableChannel> items) : base(items) { }
            public static implicit operator OneOrManyAvailableChannel (ServiceChannel value) { return new OneOrManyAvailableChannel (new AvailableChannelServiceChannel (value)); }
            public static implicit operator OneOrManyAvailableChannel (ServiceChannel[] values) { return new OneOrManyAvailableChannel (values.Select(v => (IAvailableChannel) new AvailableChannelServiceChannel (v))); }
            public static implicit operator OneOrManyAvailableChannel (List<ServiceChannel> values) { return new OneOrManyAvailableChannel (values.Select(v => (IAvailableChannel) new AvailableChannelServiceChannel (v))); }
        }
        public struct AvailableChannelServiceChannel : IAvailableChannel<ServiceChannel>
        {
            object IValue.Value => this.Value;
            public ServiceChannel Value { get; }
            public AvailableChannelServiceChannel (ServiceChannel value) { Value = value; }
            public static implicit operator AvailableChannelServiceChannel (ServiceChannel value) { return new AvailableChannelServiceChannel (value); }
        }

        public interface IAward : IValue {}
        public interface IAward<T> : IAward { new T Value { get; } }
        public class OneOrManyAward : OneOrMany<IAward>
        {
            public OneOrManyAward(IAward item) : base(item) { }
            public OneOrManyAward(IEnumerable<IAward> items) : base(items) { }
            public static implicit operator OneOrManyAward (string value) { return new OneOrManyAward (new Awardstring (value)); }
            public static implicit operator OneOrManyAward (string[] values) { return new OneOrManyAward (values.Select(v => (IAward) new Awardstring (v))); }
            public static implicit operator OneOrManyAward (List<string> values) { return new OneOrManyAward (values.Select(v => (IAward) new Awardstring (v))); }
        }
        public struct Awardstring : IAward<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Awardstring (string value) { Value = value; }
            public static implicit operator Awardstring (string value) { return new Awardstring (value); }
        }

        public interface IBrand : IValue {}
        public interface IBrand<T> : IBrand { new T Value { get; } }
        public class OneOrManyBrand : OneOrMany<IBrand>
        {
            public OneOrManyBrand(IBrand item) : base(item) { }
            public OneOrManyBrand(IEnumerable<IBrand> items) : base(items) { }
            public static implicit operator OneOrManyBrand (Brand value) { return new OneOrManyBrand (new BrandBrand (value)); }
            public static implicit operator OneOrManyBrand (Brand[] values) { return new OneOrManyBrand (values.Select(v => (IBrand) new BrandBrand (v))); }
            public static implicit operator OneOrManyBrand (List<Brand> values) { return new OneOrManyBrand (values.Select(v => (IBrand) new BrandBrand (v))); }
            public static implicit operator OneOrManyBrand (Organization value) { return new OneOrManyBrand (new BrandOrganization (value)); }
            public static implicit operator OneOrManyBrand (Organization[] values) { return new OneOrManyBrand (values.Select(v => (IBrand) new BrandOrganization (v))); }
            public static implicit operator OneOrManyBrand (List<Organization> values) { return new OneOrManyBrand (values.Select(v => (IBrand) new BrandOrganization (v))); }
        }
        public struct BrandBrand : IBrand<Brand>
        {
            object IValue.Value => this.Value;
            public Brand Value { get; }
            public BrandBrand (Brand value) { Value = value; }
            public static implicit operator BrandBrand (Brand value) { return new BrandBrand (value); }
        }
        public struct BrandOrganization : IBrand<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public BrandOrganization (Organization value) { Value = value; }
            public static implicit operator BrandOrganization (Organization value) { return new BrandOrganization (value); }
        }

        public interface IBroker : IValue {}
        public interface IBroker<T> : IBroker { new T Value { get; } }
        public class OneOrManyBroker : OneOrMany<IBroker>
        {
            public OneOrManyBroker(IBroker item) : base(item) { }
            public OneOrManyBroker(IEnumerable<IBroker> items) : base(items) { }
            public static implicit operator OneOrManyBroker (Organization value) { return new OneOrManyBroker (new BrokerOrganization (value)); }
            public static implicit operator OneOrManyBroker (Organization[] values) { return new OneOrManyBroker (values.Select(v => (IBroker) new BrokerOrganization (v))); }
            public static implicit operator OneOrManyBroker (List<Organization> values) { return new OneOrManyBroker (values.Select(v => (IBroker) new BrokerOrganization (v))); }
            public static implicit operator OneOrManyBroker (Person value) { return new OneOrManyBroker (new BrokerPerson (value)); }
            public static implicit operator OneOrManyBroker (Person[] values) { return new OneOrManyBroker (values.Select(v => (IBroker) new BrokerPerson (v))); }
            public static implicit operator OneOrManyBroker (List<Person> values) { return new OneOrManyBroker (values.Select(v => (IBroker) new BrokerPerson (v))); }
        }
        public struct BrokerOrganization : IBroker<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public BrokerOrganization (Organization value) { Value = value; }
            public static implicit operator BrokerOrganization (Organization value) { return new BrokerOrganization (value); }
        }
        public struct BrokerPerson : IBroker<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public BrokerPerson (Person value) { Value = value; }
            public static implicit operator BrokerPerson (Person value) { return new BrokerPerson (value); }
        }

        public interface ICategory : IValue {}
        public interface ICategory<T> : ICategory { new T Value { get; } }
        public class OneOrManyCategory : OneOrMany<ICategory>
        {
            public OneOrManyCategory(ICategory item) : base(item) { }
            public OneOrManyCategory(IEnumerable<ICategory> items) : base(items) { }
            public static implicit operator OneOrManyCategory (string value) { return new OneOrManyCategory (new Categorystring (value)); }
            public static implicit operator OneOrManyCategory (string[] values) { return new OneOrManyCategory (values.Select(v => (ICategory) new Categorystring (v))); }
            public static implicit operator OneOrManyCategory (List<string> values) { return new OneOrManyCategory (values.Select(v => (ICategory) new Categorystring (v))); }
            public static implicit operator OneOrManyCategory (Thing value) { return new OneOrManyCategory (new CategoryThing (value)); }
            public static implicit operator OneOrManyCategory (Thing[] values) { return new OneOrManyCategory (values.Select(v => (ICategory) new CategoryThing (v))); }
            public static implicit operator OneOrManyCategory (List<Thing> values) { return new OneOrManyCategory (values.Select(v => (ICategory) new CategoryThing (v))); }
        }
        public struct Categorystring : ICategory<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Categorystring (string value) { Value = value; }
            public static implicit operator Categorystring (string value) { return new Categorystring (value); }
        }
        public struct CategoryThing : ICategory<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public CategoryThing (Thing value) { Value = value; }
            public static implicit operator CategoryThing (Thing value) { return new CategoryThing (value); }
        }

        public interface IHasOfferCatalog : IValue {}
        public interface IHasOfferCatalog<T> : IHasOfferCatalog { new T Value { get; } }
        public class OneOrManyHasOfferCatalog : OneOrMany<IHasOfferCatalog>
        {
            public OneOrManyHasOfferCatalog(IHasOfferCatalog item) : base(item) { }
            public OneOrManyHasOfferCatalog(IEnumerable<IHasOfferCatalog> items) : base(items) { }
            public static implicit operator OneOrManyHasOfferCatalog (OfferCatalog value) { return new OneOrManyHasOfferCatalog (new HasOfferCatalogOfferCatalog (value)); }
            public static implicit operator OneOrManyHasOfferCatalog (OfferCatalog[] values) { return new OneOrManyHasOfferCatalog (values.Select(v => (IHasOfferCatalog) new HasOfferCatalogOfferCatalog (v))); }
            public static implicit operator OneOrManyHasOfferCatalog (List<OfferCatalog> values) { return new OneOrManyHasOfferCatalog (values.Select(v => (IHasOfferCatalog) new HasOfferCatalogOfferCatalog (v))); }
        }
        public struct HasOfferCatalogOfferCatalog : IHasOfferCatalog<OfferCatalog>
        {
            object IValue.Value => this.Value;
            public OfferCatalog Value { get; }
            public HasOfferCatalogOfferCatalog (OfferCatalog value) { Value = value; }
            public static implicit operator HasOfferCatalogOfferCatalog (OfferCatalog value) { return new HasOfferCatalogOfferCatalog (value); }
        }

        public interface IHoursAvailable : IValue {}
        public interface IHoursAvailable<T> : IHoursAvailable { new T Value { get; } }
        public class OneOrManyHoursAvailable : OneOrMany<IHoursAvailable>
        {
            public OneOrManyHoursAvailable(IHoursAvailable item) : base(item) { }
            public OneOrManyHoursAvailable(IEnumerable<IHoursAvailable> items) : base(items) { }
            public static implicit operator OneOrManyHoursAvailable (OpeningHoursSpecification value) { return new OneOrManyHoursAvailable (new HoursAvailableOpeningHoursSpecification (value)); }
            public static implicit operator OneOrManyHoursAvailable (OpeningHoursSpecification[] values) { return new OneOrManyHoursAvailable (values.Select(v => (IHoursAvailable) new HoursAvailableOpeningHoursSpecification (v))); }
            public static implicit operator OneOrManyHoursAvailable (List<OpeningHoursSpecification> values) { return new OneOrManyHoursAvailable (values.Select(v => (IHoursAvailable) new HoursAvailableOpeningHoursSpecification (v))); }
        }
        public struct HoursAvailableOpeningHoursSpecification : IHoursAvailable<OpeningHoursSpecification>
        {
            object IValue.Value => this.Value;
            public OpeningHoursSpecification Value { get; }
            public HoursAvailableOpeningHoursSpecification (OpeningHoursSpecification value) { Value = value; }
            public static implicit operator HoursAvailableOpeningHoursSpecification (OpeningHoursSpecification value) { return new HoursAvailableOpeningHoursSpecification (value); }
        }

        public interface IIsRelatedTo : IValue {}
        public interface IIsRelatedTo<T> : IIsRelatedTo { new T Value { get; } }
        public class OneOrManyIsRelatedTo : OneOrMany<IIsRelatedTo>
        {
            public OneOrManyIsRelatedTo(IIsRelatedTo item) : base(item) { }
            public OneOrManyIsRelatedTo(IEnumerable<IIsRelatedTo> items) : base(items) { }
            public static implicit operator OneOrManyIsRelatedTo (Product value) { return new OneOrManyIsRelatedTo (new IsRelatedToProduct (value)); }
            public static implicit operator OneOrManyIsRelatedTo (Product[] values) { return new OneOrManyIsRelatedTo (values.Select(v => (IIsRelatedTo) new IsRelatedToProduct (v))); }
            public static implicit operator OneOrManyIsRelatedTo (List<Product> values) { return new OneOrManyIsRelatedTo (values.Select(v => (IIsRelatedTo) new IsRelatedToProduct (v))); }
            public static implicit operator OneOrManyIsRelatedTo (Service value) { return new OneOrManyIsRelatedTo (new IsRelatedToService (value)); }
            public static implicit operator OneOrManyIsRelatedTo (Service[] values) { return new OneOrManyIsRelatedTo (values.Select(v => (IIsRelatedTo) new IsRelatedToService (v))); }
            public static implicit operator OneOrManyIsRelatedTo (List<Service> values) { return new OneOrManyIsRelatedTo (values.Select(v => (IIsRelatedTo) new IsRelatedToService (v))); }
        }
        public struct IsRelatedToProduct : IIsRelatedTo<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public IsRelatedToProduct (Product value) { Value = value; }
            public static implicit operator IsRelatedToProduct (Product value) { return new IsRelatedToProduct (value); }
        }
        public struct IsRelatedToService : IIsRelatedTo<Service>
        {
            object IValue.Value => this.Value;
            public Service Value { get; }
            public IsRelatedToService (Service value) { Value = value; }
            public static implicit operator IsRelatedToService (Service value) { return new IsRelatedToService (value); }
        }

        public interface IIsSimilarTo : IValue {}
        public interface IIsSimilarTo<T> : IIsSimilarTo { new T Value { get; } }
        public class OneOrManyIsSimilarTo : OneOrMany<IIsSimilarTo>
        {
            public OneOrManyIsSimilarTo(IIsSimilarTo item) : base(item) { }
            public OneOrManyIsSimilarTo(IEnumerable<IIsSimilarTo> items) : base(items) { }
            public static implicit operator OneOrManyIsSimilarTo (Product value) { return new OneOrManyIsSimilarTo (new IsSimilarToProduct (value)); }
            public static implicit operator OneOrManyIsSimilarTo (Product[] values) { return new OneOrManyIsSimilarTo (values.Select(v => (IIsSimilarTo) new IsSimilarToProduct (v))); }
            public static implicit operator OneOrManyIsSimilarTo (List<Product> values) { return new OneOrManyIsSimilarTo (values.Select(v => (IIsSimilarTo) new IsSimilarToProduct (v))); }
            public static implicit operator OneOrManyIsSimilarTo (Service value) { return new OneOrManyIsSimilarTo (new IsSimilarToService (value)); }
            public static implicit operator OneOrManyIsSimilarTo (Service[] values) { return new OneOrManyIsSimilarTo (values.Select(v => (IIsSimilarTo) new IsSimilarToService (v))); }
            public static implicit operator OneOrManyIsSimilarTo (List<Service> values) { return new OneOrManyIsSimilarTo (values.Select(v => (IIsSimilarTo) new IsSimilarToService (v))); }
        }
        public struct IsSimilarToProduct : IIsSimilarTo<Product>
        {
            object IValue.Value => this.Value;
            public Product Value { get; }
            public IsSimilarToProduct (Product value) { Value = value; }
            public static implicit operator IsSimilarToProduct (Product value) { return new IsSimilarToProduct (value); }
        }
        public struct IsSimilarToService : IIsSimilarTo<Service>
        {
            object IValue.Value => this.Value;
            public Service Value { get; }
            public IsSimilarToService (Service value) { Value = value; }
            public static implicit operator IsSimilarToService (Service value) { return new IsSimilarToService (value); }
        }

        public interface ILogo : IValue {}
        public interface ILogo<T> : ILogo { new T Value { get; } }
        public class OneOrManyLogo : OneOrMany<ILogo>
        {
            public OneOrManyLogo(ILogo item) : base(item) { }
            public OneOrManyLogo(IEnumerable<ILogo> items) : base(items) { }
            public static implicit operator OneOrManyLogo (ImageObject value) { return new OneOrManyLogo (new LogoImageObject (value)); }
            public static implicit operator OneOrManyLogo (ImageObject[] values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoImageObject (v))); }
            public static implicit operator OneOrManyLogo (List<ImageObject> values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoImageObject (v))); }
            public static implicit operator OneOrManyLogo (Uri value) { return new OneOrManyLogo (new LogoUri (value)); }
            public static implicit operator OneOrManyLogo (Uri[] values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoUri (v))); }
            public static implicit operator OneOrManyLogo (List<Uri> values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoUri (v))); }
        }
        public struct LogoImageObject : ILogo<ImageObject>
        {
            object IValue.Value => this.Value;
            public ImageObject Value { get; }
            public LogoImageObject (ImageObject value) { Value = value; }
            public static implicit operator LogoImageObject (ImageObject value) { return new LogoImageObject (value); }
        }
        public struct LogoUri : ILogo<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public LogoUri (Uri value) { Value = value; }
            public static implicit operator LogoUri (Uri value) { return new LogoUri (value); }
        }

        public interface IOffers : IValue {}
        public interface IOffers<T> : IOffers { new T Value { get; } }
        public class OneOrManyOffers : OneOrMany<IOffers>
        {
            public OneOrManyOffers(IOffers item) : base(item) { }
            public OneOrManyOffers(IEnumerable<IOffers> items) : base(items) { }
            public static implicit operator OneOrManyOffers (Offer value) { return new OneOrManyOffers (new OffersOffer (value)); }
            public static implicit operator OneOrManyOffers (Offer[] values) { return new OneOrManyOffers (values.Select(v => (IOffers) new OffersOffer (v))); }
            public static implicit operator OneOrManyOffers (List<Offer> values) { return new OneOrManyOffers (values.Select(v => (IOffers) new OffersOffer (v))); }
        }
        public struct OffersOffer : IOffers<Offer>
        {
            object IValue.Value => this.Value;
            public Offer Value { get; }
            public OffersOffer (Offer value) { Value = value; }
            public static implicit operator OffersOffer (Offer value) { return new OffersOffer (value); }
        }

        public interface IProvider : IValue {}
        public interface IProvider<T> : IProvider { new T Value { get; } }
        public class OneOrManyProvider : OneOrMany<IProvider>
        {
            public OneOrManyProvider(IProvider item) : base(item) { }
            public OneOrManyProvider(IEnumerable<IProvider> items) : base(items) { }
            public static implicit operator OneOrManyProvider (Organization value) { return new OneOrManyProvider (new ProviderOrganization (value)); }
            public static implicit operator OneOrManyProvider (Organization[] values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderOrganization (v))); }
            public static implicit operator OneOrManyProvider (List<Organization> values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderOrganization (v))); }
            public static implicit operator OneOrManyProvider (Person value) { return new OneOrManyProvider (new ProviderPerson (value)); }
            public static implicit operator OneOrManyProvider (Person[] values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderPerson (v))); }
            public static implicit operator OneOrManyProvider (List<Person> values) { return new OneOrManyProvider (values.Select(v => (IProvider) new ProviderPerson (v))); }
        }
        public struct ProviderOrganization : IProvider<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ProviderOrganization (Organization value) { Value = value; }
            public static implicit operator ProviderOrganization (Organization value) { return new ProviderOrganization (value); }
        }
        public struct ProviderPerson : IProvider<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ProviderPerson (Person value) { Value = value; }
            public static implicit operator ProviderPerson (Person value) { return new ProviderPerson (value); }
        }

        public interface IProviderMobility : IValue {}
        public interface IProviderMobility<T> : IProviderMobility { new T Value { get; } }
        public class OneOrManyProviderMobility : OneOrMany<IProviderMobility>
        {
            public OneOrManyProviderMobility(IProviderMobility item) : base(item) { }
            public OneOrManyProviderMobility(IEnumerable<IProviderMobility> items) : base(items) { }
            public static implicit operator OneOrManyProviderMobility (string value) { return new OneOrManyProviderMobility (new ProviderMobilitystring (value)); }
            public static implicit operator OneOrManyProviderMobility (string[] values) { return new OneOrManyProviderMobility (values.Select(v => (IProviderMobility) new ProviderMobilitystring (v))); }
            public static implicit operator OneOrManyProviderMobility (List<string> values) { return new OneOrManyProviderMobility (values.Select(v => (IProviderMobility) new ProviderMobilitystring (v))); }
        }
        public struct ProviderMobilitystring : IProviderMobility<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ProviderMobilitystring (string value) { Value = value; }
            public static implicit operator ProviderMobilitystring (string value) { return new ProviderMobilitystring (value); }
        }

        public interface IReview : IValue {}
        public interface IReview<T> : IReview { new T Value { get; } }
        public class OneOrManyReview : OneOrMany<IReview>
        {
            public OneOrManyReview(IReview item) : base(item) { }
            public OneOrManyReview(IEnumerable<IReview> items) : base(items) { }
            public static implicit operator OneOrManyReview (Review value) { return new OneOrManyReview (new ReviewReview (value)); }
            public static implicit operator OneOrManyReview (Review[] values) { return new OneOrManyReview (values.Select(v => (IReview) new ReviewReview (v))); }
            public static implicit operator OneOrManyReview (List<Review> values) { return new OneOrManyReview (values.Select(v => (IReview) new ReviewReview (v))); }
        }
        public struct ReviewReview : IReview<Review>
        {
            object IValue.Value => this.Value;
            public Review Value { get; }
            public ReviewReview (Review value) { Value = value; }
            public static implicit operator ReviewReview (Review value) { return new ReviewReview (value); }
        }

        public interface IServiceOutput : IValue {}
        public interface IServiceOutput<T> : IServiceOutput { new T Value { get; } }
        public class OneOrManyServiceOutput : OneOrMany<IServiceOutput>
        {
            public OneOrManyServiceOutput(IServiceOutput item) : base(item) { }
            public OneOrManyServiceOutput(IEnumerable<IServiceOutput> items) : base(items) { }
            public static implicit operator OneOrManyServiceOutput (Thing value) { return new OneOrManyServiceOutput (new ServiceOutputThing (value)); }
            public static implicit operator OneOrManyServiceOutput (Thing[] values) { return new OneOrManyServiceOutput (values.Select(v => (IServiceOutput) new ServiceOutputThing (v))); }
            public static implicit operator OneOrManyServiceOutput (List<Thing> values) { return new OneOrManyServiceOutput (values.Select(v => (IServiceOutput) new ServiceOutputThing (v))); }
        }
        public struct ServiceOutputThing : IServiceOutput<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public ServiceOutputThing (Thing value) { Value = value; }
            public static implicit operator ServiceOutputThing (Thing value) { return new ServiceOutputThing (value); }
        }

        public interface IServiceType : IValue {}
        public interface IServiceType<T> : IServiceType { new T Value { get; } }
        public class OneOrManyServiceType : OneOrMany<IServiceType>
        {
            public OneOrManyServiceType(IServiceType item) : base(item) { }
            public OneOrManyServiceType(IEnumerable<IServiceType> items) : base(items) { }
            public static implicit operator OneOrManyServiceType (string value) { return new OneOrManyServiceType (new ServiceTypestring (value)); }
            public static implicit operator OneOrManyServiceType (string[] values) { return new OneOrManyServiceType (values.Select(v => (IServiceType) new ServiceTypestring (v))); }
            public static implicit operator OneOrManyServiceType (List<string> values) { return new OneOrManyServiceType (values.Select(v => (IServiceType) new ServiceTypestring (v))); }
        }
        public struct ServiceTypestring : IServiceType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ServiceTypestring (string value) { Value = value; }
            public static implicit operator ServiceTypestring (string value) { return new ServiceTypestring (value); }
        }

        public interface ITermsOfService : IValue {}
        public interface ITermsOfService<T> : ITermsOfService { new T Value { get; } }
        public class OneOrManyTermsOfService : OneOrMany<ITermsOfService>
        {
            public OneOrManyTermsOfService(ITermsOfService item) : base(item) { }
            public OneOrManyTermsOfService(IEnumerable<ITermsOfService> items) : base(items) { }
            public static implicit operator OneOrManyTermsOfService (string value) { return new OneOrManyTermsOfService (new TermsOfServicestring (value)); }
            public static implicit operator OneOrManyTermsOfService (string[] values) { return new OneOrManyTermsOfService (values.Select(v => (ITermsOfService) new TermsOfServicestring (v))); }
            public static implicit operator OneOrManyTermsOfService (List<string> values) { return new OneOrManyTermsOfService (values.Select(v => (ITermsOfService) new TermsOfServicestring (v))); }
            public static implicit operator OneOrManyTermsOfService (Uri value) { return new OneOrManyTermsOfService (new TermsOfServiceUri (value)); }
            public static implicit operator OneOrManyTermsOfService (Uri[] values) { return new OneOrManyTermsOfService (values.Select(v => (ITermsOfService) new TermsOfServiceUri (v))); }
            public static implicit operator OneOrManyTermsOfService (List<Uri> values) { return new OneOrManyTermsOfService (values.Select(v => (ITermsOfService) new TermsOfServiceUri (v))); }
        }
        public struct TermsOfServicestring : ITermsOfService<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TermsOfServicestring (string value) { Value = value; }
            public static implicit operator TermsOfServicestring (string value) { return new TermsOfServicestring (value); }
        }
        public struct TermsOfServiceUri : ITermsOfService<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public TermsOfServiceUri (Uri value) { Value = value; }
            public static implicit operator TermsOfServiceUri (Uri value) { return new TermsOfServiceUri (value); }
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
        public OneOrManyAggregateRating AggregateRating { get; set; }

        /// <summary>
        /// The geographic area where a service or offered item is provided.
        /// </summary>
        [DataMember(Name = "areaServed", Order = 207)]
        public OneOrManyAreaServed AreaServed { get; set; }

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 208)]
        public OneOrManyAudience Audience { get; set; }

        /// <summary>
        /// A means of accessing the service (e.g. a phone bank, a web site, a location, etc.).
        /// </summary>
        [DataMember(Name = "availableChannel", Order = 209)]
        public OneOrManyAvailableChannel AvailableChannel { get; set; }

        /// <summary>
        /// An award won by or for this item.
        /// </summary>
        [DataMember(Name = "award", Order = 210)]
        public OneOrManyAward Award { get; set; }

        /// <summary>
        /// The brand(s) associated with a product or service, or the brand(s) maintained by an organization or business person.
        /// </summary>
        [DataMember(Name = "brand", Order = 211)]
        public OneOrManyBrand Brand { get; set; }

        /// <summary>
        /// An entity that arranges for an exchange between a buyer and a seller.  In most cases a broker never acquires or releases ownership of a product or service involved in an exchange.  If it is not clear whether an entity is a broker, seller, or buyer, the latter two terms are preferred.
        /// </summary>
        [DataMember(Name = "broker", Order = 212)]
        public OneOrManyBroker Broker { get; set; }

        /// <summary>
        /// A category for the item. Greater signs or slashes can be used to informally indicate a category hierarchy.
        /// </summary>
        [DataMember(Name = "category", Order = 213)]
        public OneOrManyCategory Category { get; set; }

        /// <summary>
        /// Indicates an OfferCatalog listing for this Organization, Person, or Service.
        /// </summary>
        [DataMember(Name = "hasOfferCatalog", Order = 214)]
        public OneOrManyHasOfferCatalog HasOfferCatalog { get; set; }

        /// <summary>
        /// The hours during which this service or contact is available.
        /// </summary>
        [DataMember(Name = "hoursAvailable", Order = 215)]
        public OneOrManyHoursAvailable HoursAvailable { get; set; }

        /// <summary>
        /// A pointer to another, somehow related product (or multiple products).
        /// </summary>
        [DataMember(Name = "isRelatedTo", Order = 216)]
        public OneOrManyIsRelatedTo IsRelatedTo { get; set; }

        /// <summary>
        /// A pointer to another, functionally similar product (or multiple products).
        /// </summary>
        [DataMember(Name = "isSimilarTo", Order = 217)]
        public OneOrManyIsSimilarTo IsSimilarTo { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 218)]
        public OneOrManyLogo Logo { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 219)]
        public OneOrManyOffers Offers { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 220)]
        public OneOrManyProvider Provider { get; set; }

        /// <summary>
        /// Indicates the mobility of a provided service (e.g. 'static', 'dynamic').
        /// </summary>
        [DataMember(Name = "providerMobility", Order = 221)]
        public OneOrManyProviderMobility ProviderMobility { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 222)]
        public OneOrManyReview Review { get; set; }

        /// <summary>
        /// The tangible thing generated by the service, e.g. a passport, permit, etc.
        /// </summary>
        [DataMember(Name = "serviceOutput", Order = 223)]
        public OneOrManyServiceOutput ServiceOutput { get; set; }

        /// <summary>
        /// The type of service being offered, e.g. veterans' benefits, emergency relief, etc.
        /// </summary>
        [DataMember(Name = "serviceType", Order = 224)]
        public OneOrManyServiceType ServiceType { get; set; }

        /// <summary>
        /// Human-readable terms of service documentation.
        /// </summary>
        [DataMember(Name = "termsOfService", Order = 225)]
        public OneOrManyTermsOfService TermsOfService { get; set; }
    }
}

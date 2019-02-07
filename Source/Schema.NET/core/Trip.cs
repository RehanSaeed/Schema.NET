namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// </summary>
    [DataContract]
    public partial class Trip : Intangible
    {
        public interface IArrivalTime : IValue {}
        public interface IArrivalTime<T> : IArrivalTime { new T Value { get; } }
        public class OneOrManyArrivalTime : OneOrMany<IArrivalTime>
        {
            public OneOrManyArrivalTime(IArrivalTime item) : base(item) { }
            public OneOrManyArrivalTime(IEnumerable<IArrivalTime> items) : base(items) { }
            public static implicit operator OneOrManyArrivalTime (DateTimeOffset value) { return new OneOrManyArrivalTime (new ArrivalTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyArrivalTime (DateTimeOffset[] values) { return new OneOrManyArrivalTime (values.Select(v => (IArrivalTime) new ArrivalTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyArrivalTime (List<DateTimeOffset> values) { return new OneOrManyArrivalTime (values.Select(v => (IArrivalTime) new ArrivalTimeDateTimeOffset (v))); }
        }
        public struct ArrivalTimeDateTimeOffset : IArrivalTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ArrivalTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ArrivalTimeDateTimeOffset (DateTimeOffset value) { return new ArrivalTimeDateTimeOffset (value); }
        }

        public interface IDepartureTime : IValue {}
        public interface IDepartureTime<T> : IDepartureTime { new T Value { get; } }
        public class OneOrManyDepartureTime : OneOrMany<IDepartureTime>
        {
            public OneOrManyDepartureTime(IDepartureTime item) : base(item) { }
            public OneOrManyDepartureTime(IEnumerable<IDepartureTime> items) : base(items) { }
            public static implicit operator OneOrManyDepartureTime (DateTimeOffset value) { return new OneOrManyDepartureTime (new DepartureTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyDepartureTime (DateTimeOffset[] values) { return new OneOrManyDepartureTime (values.Select(v => (IDepartureTime) new DepartureTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyDepartureTime (List<DateTimeOffset> values) { return new OneOrManyDepartureTime (values.Select(v => (IDepartureTime) new DepartureTimeDateTimeOffset (v))); }
        }
        public struct DepartureTimeDateTimeOffset : IDepartureTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public DepartureTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator DepartureTimeDateTimeOffset (DateTimeOffset value) { return new DepartureTimeDateTimeOffset (value); }
        }

        public interface IItinerary : IValue {}
        public interface IItinerary<T> : IItinerary { new T Value { get; } }
        public class OneOrManyItinerary : OneOrMany<IItinerary>
        {
            public OneOrManyItinerary(IItinerary item) : base(item) { }
            public OneOrManyItinerary(IEnumerable<IItinerary> items) : base(items) { }
            public static implicit operator OneOrManyItinerary (ItemList value) { return new OneOrManyItinerary (new ItineraryItemList (value)); }
            public static implicit operator OneOrManyItinerary (ItemList[] values) { return new OneOrManyItinerary (values.Select(v => (IItinerary) new ItineraryItemList (v))); }
            public static implicit operator OneOrManyItinerary (List<ItemList> values) { return new OneOrManyItinerary (values.Select(v => (IItinerary) new ItineraryItemList (v))); }
            public static implicit operator OneOrManyItinerary (Place value) { return new OneOrManyItinerary (new ItineraryPlace (value)); }
            public static implicit operator OneOrManyItinerary (Place[] values) { return new OneOrManyItinerary (values.Select(v => (IItinerary) new ItineraryPlace (v))); }
            public static implicit operator OneOrManyItinerary (List<Place> values) { return new OneOrManyItinerary (values.Select(v => (IItinerary) new ItineraryPlace (v))); }
        }
        public struct ItineraryItemList : IItinerary<ItemList>
        {
            object IValue.Value => this.Value;
            public ItemList Value { get; }
            public ItineraryItemList (ItemList value) { Value = value; }
            public static implicit operator ItineraryItemList (ItemList value) { return new ItineraryItemList (value); }
        }
        public struct ItineraryPlace : IItinerary<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public ItineraryPlace (Place value) { Value = value; }
            public static implicit operator ItineraryPlace (Place value) { return new ItineraryPlace (value); }
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

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Trip";

        /// <summary>
        /// The expected arrival time.
        /// </summary>
        [DataMember(Name = "arrivalTime", Order = 206)]
        public OneOrManyArrivalTime ArrivalTime { get; set; }

        /// <summary>
        /// The expected departure time.
        /// </summary>
        [DataMember(Name = "departureTime", Order = 207)]
        public OneOrManyDepartureTime DepartureTime { get; set; }

        /// <summary>
        /// Destination(s) ( &lt;a class="localLink" href="http://schema.org/Place"&gt;Place&lt;/a&gt; ) that make up a trip. For a trip where destination order is important use &lt;a class="localLink" href="http://schema.org/ItemList"&gt;ItemList&lt;/a&gt; to specify that order (see examples).
        /// </summary>
        [DataMember(Name = "itinerary", Order = 208)]
        public OneOrManyItinerary Itinerary { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 209)]
        public OneOrManyOffers Offers { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 210)]
        public OneOrManyProvider Provider { get; set; }
    }
}

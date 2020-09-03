namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// </summary>
    public partial interface ITrip : IIntangible
    {
        /// <summary>
        /// The expected arrival time.
        /// </summary>
        Values<DateTimeOffset?, TimeSpan?> ArrivalTime { get; set; }

        /// <summary>
        /// The expected departure time.
        /// </summary>
        Values<DateTimeOffset?, TimeSpan?> DepartureTime { get; set; }

        /// <summary>
        /// Destination(s) ( &lt;a class="localLink" href="https://schema.org/Place"&gt;Place&lt;/a&gt; ) that make up a trip. For a trip where destination order is important use &lt;a class="localLink" href="https://schema.org/ItemList"&gt;ItemList&lt;/a&gt; to specify that order (see examples).
        /// </summary>
        Values<IItemList, IPlace> Itinerary { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="https://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
        /// </summary>
        Values<IDemand, IOffer> Offers { get; set; }

        /// <summary>
        /// Identifies that this &lt;a class="localLink" href="https://schema.org/Trip"&gt;Trip&lt;/a&gt; is a subTrip of another Trip.  For example Day 1, Day 2, etc. of a multi-day trip.
        /// </summary>
        OneOrMany<ITrip> PartOfTrip { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// Identifies a &lt;a class="localLink" href="https://schema.org/Trip"&gt;Trip&lt;/a&gt; that is a subTrip of this Trip.  For example Day 1, Day 2, etc. of a multi-day trip.
        /// </summary>
        OneOrMany<ITrip> SubTrip { get; set; }
    }

    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// </summary>
    [DataContract]
    public partial class Trip : Intangible, ITrip, IEquatable<Trip>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Trip";

        /// <summary>
        /// The expected arrival time.
        /// </summary>
        [DataMember(Name = "arrivalTime", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, TimeSpan?> ArrivalTime { get; set; }

        /// <summary>
        /// The expected departure time.
        /// </summary>
        [DataMember(Name = "departureTime", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<DateTimeOffset?, TimeSpan?> DepartureTime { get; set; }

        /// <summary>
        /// Destination(s) ( &lt;a class="localLink" href="https://schema.org/Place"&gt;Place&lt;/a&gt; ) that make up a trip. For a trip where destination order is important use &lt;a class="localLink" href="https://schema.org/ItemList"&gt;ItemList&lt;/a&gt; to specify that order (see examples).
        /// </summary>
        [DataMember(Name = "itinerary", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IItemList, IPlace> Itinerary { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="https://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
        /// </summary>
        [DataMember(Name = "offers", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IDemand, IOffer> Offers { get; set; }

        /// <summary>
        /// Identifies that this &lt;a class="localLink" href="https://schema.org/Trip"&gt;Trip&lt;/a&gt; is a subTrip of another Trip.  For example Day 1, Day 2, etc. of a multi-day trip.
        /// </summary>
        [DataMember(Name = "partOfTrip", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ITrip> PartOfTrip { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// Identifies a &lt;a class="localLink" href="https://schema.org/Trip"&gt;Trip&lt;/a&gt; that is a subTrip of this Trip.  For example Day 1, Day 2, etc. of a multi-day trip.
        /// </summary>
        [DataMember(Name = "subTrip", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ITrip> SubTrip { get; set; }

        /// <inheritdoc/>
        public bool Equals(Trip other)
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
                this.ArrivalTime == other.ArrivalTime &&
                this.DepartureTime == other.DepartureTime &&
                this.Itinerary == other.Itinerary &&
                this.Offers == other.Offers &&
                this.PartOfTrip == other.PartOfTrip &&
                this.Provider == other.Provider &&
                this.SubTrip == other.SubTrip &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Trip);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ArrivalTime)
            .And(this.DepartureTime)
            .And(this.Itinerary)
            .And(this.Offers)
            .And(this.PartOfTrip)
            .And(this.Provider)
            .And(this.SubTrip)
            .And(base.GetHashCode());
    }
}

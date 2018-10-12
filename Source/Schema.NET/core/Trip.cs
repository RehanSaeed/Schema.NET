namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A trip or journey. An itinerary of visits to one or more places.
    /// </summary>
    [DataContract]
    public partial class Trip : Intangible
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
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? ArrivalTime { get; set; }

        /// <summary>
        /// The expected departure time.
        /// </summary>
        [DataMember(Name = "departureTime", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? DepartureTime { get; set; }

        /// <summary>
        /// Destination(s) ( &lt;a class="localLink" href="http://schema.org/Place"&gt;Place&lt;/a&gt; ) that make up a trip. For a trip where destination order is important use &lt;a class="localLink" href="http://schema.org/ItemList"&gt;ItemList&lt;/a&gt; to specify that order (see examples).
        /// </summary>
        [DataMember(Name = "itinerary", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ItemList, Place>? Itinerary { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Offer>? Offers { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Provider { get; set; }
    }
}

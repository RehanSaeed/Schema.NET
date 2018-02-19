using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A reservation for a taxi.&lt;/p&gt;
    /// &lt;p&gt;Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="http://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class TaxiReservation : Reservation
    {
        public interface IPartySize : IWrapper { }
        public interface IPartySize<T> : IPartySize { new T Data { get; set; } }
        public class PartySizeint : IPartySize<int>
        {
            object IWrapper.Data { get { return Data; } set { Data = (int) value; } }
            public virtual int Data { get; set; }
            public PartySizeint () { }
            public PartySizeint (int data) { Data = data; }
            public static implicit operator PartySizeint (int data) { return new PartySizeint (data); }
        }

        public class PartySizeQuantitativeValue : IPartySize<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public PartySizeQuantitativeValue () { }
            public PartySizeQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator PartySizeQuantitativeValue (QuantitativeValue data) { return new PartySizeQuantitativeValue (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TaxiReservation";

        /// <summary>
        /// Number of people the reservation should accommodate.
        /// </summary>
        [DataMember(Name = "partySize", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPartySize>? PartySize { get; set; } //int?, QuantitativeValue

        /// <summary>
        /// Where a taxi will pick up a passenger or a rental car can be picked up.
        /// </summary>
        [DataMember(Name = "pickupLocation", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? PickupLocation { get; set; } 

        /// <summary>
        /// When a taxi will pickup a passenger or a rental car can be picked up.
        /// </summary>
        [DataMember(Name = "pickupTime", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? PickupTime { get; set; } 
    }
}

using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A reservation to dine at a food-related business.Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
    [DataContract]
    public partial class FoodEstablishmentReservation : Reservation
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
        public override string Type => "FoodEstablishmentReservation";

        /// <summary>
        /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;.&lt;/p&gt;
        /// &lt;p&gt;Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "endTime", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? EndTime { get; set; } 

        /// <summary>
        /// Number of people the reservation should accommodate.
        /// </summary>
        [DataMember(Name = "partySize", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPartySize>? PartySize { get; set; } //int?, QuantitativeValue

        /// <summary>
        /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December.&lt;/p&gt;
        /// &lt;p&gt;Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "startTime", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? StartTime { get; set; } 
    }
}

using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A reservation for lodging at a hotel, motel, inn, etc.&lt;/p&gt;
    /// &lt;p&gt;Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
    [DataContract]
    public partial class LodgingReservation : Reservation
    {
        public interface INumAdults : IWrapper { }
        public interface INumAdults<T> : INumAdults { new T Data { get; set; } }
        public class NumAdultsint : INumAdults<int>
        {
            object IWrapper.Data { get { return Data; } set { Data = (int) value; } }
            public virtual int Data { get; set; }
            public NumAdultsint () { }
            public NumAdultsint (int data) { Data = data; }
            public static implicit operator NumAdultsint (int data) { return new NumAdultsint (data); }
        }

        public class NumAdultsQuantitativeValue : INumAdults<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public NumAdultsQuantitativeValue () { }
            public NumAdultsQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator NumAdultsQuantitativeValue (QuantitativeValue data) { return new NumAdultsQuantitativeValue (data); }
        }


        public interface INumChildren : IWrapper { }
        public interface INumChildren<T> : INumChildren { new T Data { get; set; } }
        public class NumChildrenint : INumChildren<int>
        {
            object IWrapper.Data { get { return Data; } set { Data = (int) value; } }
            public virtual int Data { get; set; }
            public NumChildrenint () { }
            public NumChildrenint (int data) { Data = data; }
            public static implicit operator NumChildrenint (int data) { return new NumChildrenint (data); }
        }

        public class NumChildrenQuantitativeValue : INumChildren<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public NumChildrenQuantitativeValue () { }
            public NumChildrenQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator NumChildrenQuantitativeValue (QuantitativeValue data) { return new NumChildrenQuantitativeValue (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LodgingReservation";

        /// <summary>
        /// The earliest someone may check into a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkinTime", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? CheckinTime { get; set; } 

        /// <summary>
        /// The latest someone may check out of a lodging establishment.
        /// </summary>
        [DataMember(Name = "checkoutTime", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? CheckoutTime { get; set; } 

        /// <summary>
        /// A full description of the lodging unit.
        /// </summary>
        [DataMember(Name = "lodgingUnitDescription", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? LodgingUnitDescription { get; set; } 

        /// <summary>
        /// Textual description of the unit type (including suite vs. room, size of bed, etc.).
        /// </summary>
        [DataMember(Name = "lodgingUnitType", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? LodgingUnitType { get; set; } 

        /// <summary>
        /// The number of adults staying in the unit.
        /// </summary>
        [DataMember(Name = "numAdults", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<INumAdults>? NumAdults { get; set; } //int?, QuantitativeValue

        /// <summary>
        /// The number of children staying in the unit.
        /// </summary>
        [DataMember(Name = "numChildren", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<INumChildren>? NumChildren { get; set; } //int?, QuantitativeValue
    }
}

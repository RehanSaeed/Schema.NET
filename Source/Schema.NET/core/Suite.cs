using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A suite in a hotel or other public accommodation, denotes a class of luxury accommodations, the key feature of which is multiple rooms (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Suite_(hotel)"&gt;http://en.wikipedia.org/wiki/Suite_(hotel)&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Suite : Accommodation
    {
        public interface IBed : IWrapper { }
        public interface IBed<T> : IBed { new T Data { get; set; } }
        public class BedBedDetails : IBed<BedDetails>
        {
            object IWrapper.Data { get { return Data; } set { Data = (BedDetails) value; } }
            public virtual BedDetails Data { get; set; }
            public BedBedDetails () { }
            public BedBedDetails (BedDetails data) { Data = data; }
            public static implicit operator BedBedDetails (BedDetails data) { return new BedBedDetails (data); }
        }

        public class Bedstring : IBed<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Bedstring () { }
            public Bedstring (string data) { Data = data; }
            public static implicit operator Bedstring (string data) { return new Bedstring (data); }
        }



        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Suite";

        /// <summary>
        /// The type of bed or beds included in the accommodation. For the single case of just one bed of a certain type, you use bed directly with a text.
        ///       If you want to indicate the quantity of a certain kind of bed, use an instance of BedDetails. For more detailed information, use the amenityFeature property.
        /// </summary>
        [DataMember(Name = "bed", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IBed>? Bed { get; set; } //BedDetails, string

        /// <summary>
        /// The number of rooms (excluding bathrooms and closets) of the acccommodation or lodging business.
        /// Typical unit code(s): ROM for room or C62 for no unit. The type of room can be put in the unitText property of the QuantitativeValue.
        /// </summary>
        [DataMember(Name = "numberOfRooms", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public override Values<INumberOfRooms>? NumberOfRooms { get; set; } //int?, QuantitativeValue

        /// <summary>
        /// The allowed total occupancy for the accommodation in persons (including infants etc). For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement (e.g. a double room used by a single person).
        /// Typical unit code(s): C62 for person
        /// </summary>
        [DataMember(Name = "occupancy", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? Occupancy { get; set; } 
    }
}

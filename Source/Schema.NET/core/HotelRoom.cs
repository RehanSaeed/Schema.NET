namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A hotel room is a single room in a hotel.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    public partial interface IHotelRoom : IRoom
    {
        /// <summary>
        /// The type of bed or beds included in the accommodation. For the single case of just one bed of a certain type, you use bed directly with a text.
        ///       If you want to indicate the quantity of a certain kind of bed, use an instance of BedDetails. For more detailed information, use the amenityFeature property.
        /// </summary>
        Values<IBedDetails, BedType?, string>? Bed { get; set; }

        /// <summary>
        /// The allowed total occupancy for the accommodation in persons (including infants etc). For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement (e.g. a double room used by a single person).
        /// Typical unit code(s): C62 for person
        /// </summary>
        OneOrMany<IQuantitativeValue>? Occupancy { get; set; }
    }

    /// <summary>
    /// A hotel room is a single room in a hotel.
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class HotelRoom : Room, IHotelRoom
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HotelRoom";

        /// <summary>
        /// The type of bed or beds included in the accommodation. For the single case of just one bed of a certain type, you use bed directly with a text.
        ///       If you want to indicate the quantity of a certain kind of bed, use an instance of BedDetails. For more detailed information, use the amenityFeature property.
        /// </summary>
        [DataMember(Name = "bed", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IBedDetails, BedType?, string>? Bed { get; set; }

        /// <summary>
        /// The allowed total occupancy for the accommodation in persons (including infants etc). For individual accommodations, this is not necessarily the legal maximum but defines the permitted usage as per the contractual agreement (e.g. a double room used by a single person).
        /// Typical unit code(s): C62 for person
        /// </summary>
        [DataMember(Name = "occupancy", Order = 407)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IQuantitativeValue>? Occupancy { get; set; }
    }
}

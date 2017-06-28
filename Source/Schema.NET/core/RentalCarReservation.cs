namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A reservation for a rental car.
    /// Note: This type is for information about actual reservations, e...
    /// </summary>
    [DataContract]
    public partial class RentalCarReservation : Reservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RentalCarReservation";

        /// <summary>
        /// Where a rental car can be dropped off.
        /// </summary>
        [DataMember(Name = "dropoffLocation", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Place>? DropoffLocation { get; set; }

        /// <summary>
        /// When a rental car can be dropped off.
        /// </summary>
        [DataMember(Name = "dropoffTime", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? DropoffTime { get; set; }

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
        public Values<DateTimeOffset?>? PickupTime { get; set; }
    }
}

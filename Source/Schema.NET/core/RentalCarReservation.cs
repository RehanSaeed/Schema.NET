namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A reservation for a rental car.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
    public partial interface IRentalCarReservation : IReservation
    {
        /// <summary>
        /// Where a rental car can be dropped off.
        /// </summary>
        OneOrMany<IPlace>? DropoffLocation { get; set; }

        /// <summary>
        /// When a rental car can be dropped off.
        /// </summary>
        OneOrMany<DateTimeOffset?>? DropoffTime { get; set; }

        /// <summary>
        /// Where a taxi will pick up a passenger or a rental car can be picked up.
        /// </summary>
        OneOrMany<IPlace>? PickupLocation { get; set; }

        /// <summary>
        /// When a taxi will pickup a passenger or a rental car can be picked up.
        /// </summary>
        OneOrMany<DateTimeOffset?>? PickupTime { get; set; }
    }

    /// <summary>
    /// A reservation for a rental car.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations.
    /// </summary>
    [DataContract]
    public partial class RentalCarReservation : Reservation, IRentalCarReservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RentalCarReservation";

        /// <summary>
        /// Where a rental car can be dropped off.
        /// </summary>
        [DataMember(Name = "dropoffLocation", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPlace>? DropoffLocation { get; set; }

        /// <summary>
        /// When a rental car can be dropped off.
        /// </summary>
        [DataMember(Name = "dropoffTime", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? DropoffTime { get; set; }

        /// <summary>
        /// Where a taxi will pick up a passenger or a rental car can be picked up.
        /// </summary>
        [DataMember(Name = "pickupLocation", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPlace>? PickupLocation { get; set; }

        /// <summary>
        /// When a taxi will pickup a passenger or a rental car can be picked up.
        /// </summary>
        [DataMember(Name = "pickupTime", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? PickupTime { get; set; }
    }
}

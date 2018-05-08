namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A group of multiple reservations with common values for all sub-reservations.
    /// </summary>
    public partial interface IReservationPackage : IReservation
    {
        /// <summary>
        /// The individual reservations included in the package. Typically a repeated property.
        /// </summary>
        OneOrMany<IReservation>? SubReservation { get; set; }
    }

    /// <summary>
    /// A group of multiple reservations with common values for all sub-reservations.
    /// </summary>
    [DataContract]
    public partial class ReservationPackage : Reservation, IReservationPackage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReservationPackage";

        /// <summary>
        /// The individual reservations included in the package. Typically a repeated property.
        /// </summary>
        [DataMember(Name = "subReservation", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IReservation>? SubReservation { get; set; }
    }
}

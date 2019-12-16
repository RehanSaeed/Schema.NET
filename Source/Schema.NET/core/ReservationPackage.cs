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
        OneOrMany<IReservation> SubReservation { get; set; }
    }

    /// <summary>
    /// A group of multiple reservations with common values for all sub-reservations.
    /// </summary>
    [DataContract]
    public partial class ReservationPackage : Reservation, IReservationPackage, IEquatable<ReservationPackage>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IReservation> SubReservation { get; set; }

        /// <inheritdoc/>
        public bool Equals(ReservationPackage other)
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
                this.SubReservation == other.SubReservation &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ReservationPackage);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.SubReservation)
            .And(base.GetHashCode());
    }
}

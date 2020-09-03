namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A reservation for train travel.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="https://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    public partial interface ITrainReservation : IReservation
    {
    }

    /// <summary>
    /// A reservation for train travel.&lt;br/&gt;&lt;br/&gt;
    /// Note: This type is for information about actual reservations, e.g. in confirmation emails or HTML pages with individual confirmations of reservations. For offers of tickets, use &lt;a class="localLink" href="https://schema.org/Offer"&gt;Offer&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class TrainReservation : Reservation, ITrainReservation, IEquatable<TrainReservation>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TrainReservation";

        /// <inheritdoc/>
        public bool Equals(TrainReservation other)
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
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as TrainReservation);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

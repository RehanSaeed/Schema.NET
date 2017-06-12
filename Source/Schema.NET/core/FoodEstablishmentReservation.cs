namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A reservation to dine at a food-related business.Note: This type is for information about actual reservations, e...
    /// </summary>
    [DataContract]
    public partial class FoodEstablishmentReservation : Reservation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FoodEstablishmentReservation";

        /// <summary>
        /// The endTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to end. For actions that span a period of time, when the action was performed. e.g. John wrote a book from January to &lt;em&gt;December&lt;/em&gt;.&lt;/p&gt;
        /// &lt;p&gt;Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "endTime", Order = 2)]
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// Number of people the reservation should accommodate.
        /// </summary>
        [DataMember(Name = "partySize", Order = 3)]
        public object PartySize { get; protected set; }

        /// <summary>
        /// Number of people the reservation should accommodate.
        /// </summary>
        [IgnoreDataMember]
        public QuantitativeValue PartySizeQuantitativeValue
        {
            get => this.PartySize as QuantitativeValue;
            set => this.PartySize = value;
        }

        /// <summary>
        /// Number of people the reservation should accommodate.
        /// </summary>
        [IgnoreDataMember]
        public int? PartySizeInteger
        {
            get => this.PartySize as int?;
            set => this.PartySize = value;
        }

        /// <summary>
        /// The startTime of something. For a reserved event or service (e.g. FoodEstablishmentReservation), the time that it is expected to start. For actions that span a period of time, when the action was performed. e.g. John wrote a book from &lt;em&gt;January&lt;/em&gt; to December.&lt;/p&gt;
        /// &lt;p&gt;Note that Event uses startDate/endDate instead of startTime/endTime, even when describing dates with times. This situation may be clarified in future revisions.
        /// </summary>
        [DataMember(Name = "startTime", Order = 4)]
        public DateTimeOffset? StartTime { get; set; }
    }
}

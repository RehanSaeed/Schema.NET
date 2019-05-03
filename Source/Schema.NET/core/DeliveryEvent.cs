namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An event involving the delivery of an item.
    /// </summary>
    [DataContract]
    public partial class DeliveryEvent : Event
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DeliveryEvent";

        /// <summary>
        /// Password, PIN, or access code needed for delivery (e.g. from a locker).
        /// </summary>
        [DataMember(Name = "accessCode", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? AccessCode { get; set; }

        /// <summary>
        /// When the item is available for pickup from the store, locker, etc.
        /// </summary>
        [DataMember(Name = "availableFrom", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? AvailableFrom { get; set; }

        /// <summary>
        /// After this date, the item will no longer be available for pickup.
        /// </summary>
        [DataMember(Name = "availableThrough", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DateTimeOffset?>? AvailableThrough { get; set; }

        /// <summary>
        /// Method used for delivery or shipping.
        /// </summary>
        [DataMember(Name = "hasDeliveryMethod", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DeliveryMethod?>? HasDeliveryMethod { get; set; }
    }
}

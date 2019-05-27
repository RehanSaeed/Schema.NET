namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
    public partial interface IParcelDelivery : IIntangible
    {
        /// <summary>
        /// Destination address.
        /// </summary>
        OneOrMany<IPostalAddress> DeliveryAddress { get; set; }

        /// <summary>
        /// New entry added as the package passes through each leg of its journey (from shipment to final delivery).
        /// </summary>
        OneOrMany<IDeliveryEvent> DeliveryStatus { get; set; }

        /// <summary>
        /// The earliest date the package may arrive.
        /// </summary>
        OneOrMany<DateTimeOffset?> ExpectedArrivalFrom { get; set; }

        /// <summary>
        /// The latest date the package may arrive.
        /// </summary>
        OneOrMany<DateTimeOffset?> ExpectedArrivalUntil { get; set; }

        /// <summary>
        /// Method used for delivery or shipping.
        /// </summary>
        OneOrMany<DeliveryMethod?> HasDeliveryMethod { get; set; }

        /// <summary>
        /// Item(s) being shipped.
        /// </summary>
        OneOrMany<IProduct> ItemShipped { get; set; }

        /// <summary>
        /// Shipper's address.
        /// </summary>
        OneOrMany<IPostalAddress> OriginAddress { get; set; }

        /// <summary>
        /// The overall order the items in this delivery were included in.
        /// </summary>
        OneOrMany<IOrder> PartOfOrder { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// Shipper tracking number.
        /// </summary>
        OneOrMany<string> TrackingNumber { get; set; }

        /// <summary>
        /// Tracking url for the parcel delivery.
        /// </summary>
        OneOrMany<Uri> TrackingUrl { get; set; }
    }

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
    [DataContract]
    public partial class ParcelDelivery : Intangible, IParcelDelivery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ParcelDelivery";

        /// <summary>
        /// Destination address.
        /// </summary>
        [DataMember(Name = "deliveryAddress", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPostalAddress> DeliveryAddress { get; set; }

        /// <summary>
        /// New entry added as the package passes through each leg of its journey (from shipment to final delivery).
        /// </summary>
        [DataMember(Name = "deliveryStatus", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDeliveryEvent> DeliveryStatus { get; set; }

        /// <summary>
        /// The earliest date the package may arrive.
        /// </summary>
        [DataMember(Name = "expectedArrivalFrom", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> ExpectedArrivalFrom { get; set; }

        /// <summary>
        /// The latest date the package may arrive.
        /// </summary>
        [DataMember(Name = "expectedArrivalUntil", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> ExpectedArrivalUntil { get; set; }

        /// <summary>
        /// Method used for delivery or shipping.
        /// </summary>
        [DataMember(Name = "hasDeliveryMethod", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DeliveryMethod?> HasDeliveryMethod { get; set; }

        /// <summary>
        /// Item(s) being shipped.
        /// </summary>
        [DataMember(Name = "itemShipped", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IProduct> ItemShipped { get; set; }

        /// <summary>
        /// Shipper's address.
        /// </summary>
        [DataMember(Name = "originAddress", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPostalAddress> OriginAddress { get; set; }

        /// <summary>
        /// The overall order the items in this delivery were included in.
        /// </summary>
        [DataMember(Name = "partOfOrder", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrder> PartOfOrder { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IOrganization, IPerson> Provider { get; set; }

        /// <summary>
        /// Shipper tracking number.
        /// </summary>
        [DataMember(Name = "trackingNumber", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TrackingNumber { get; set; }

        /// <summary>
        /// Tracking url for the parcel delivery.
        /// </summary>
        [DataMember(Name = "trackingUrl", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> TrackingUrl { get; set; }
    }
}

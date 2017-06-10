namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The delivery of a parcel either via the postal service or a commercial service.
    /// </summary>
    [DataContract]
    public class ParcelDelivery : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ParcelDelivery";

        /// <summary>
        /// Destination address.
        /// </summary>
        [DataMember(Name = "deliveryAddress", Order = 2)]
        public PostalAddress DeliveryAddress { get; set; }

        /// <summary>
        /// New entry added as the package passes through each leg of its journey (from shipment to final delivery).
        /// </summary>
        [DataMember(Name = "deliveryStatus", Order = 3)]
        public DeliveryEvent DeliveryStatus { get; set; }

        /// <summary>
        /// The earliest date the package may arrive.
        /// </summary>
        [DataMember(Name = "expectedArrivalFrom", Order = 4)]
        public DateTimeOffset? ExpectedArrivalFrom { get; set; }

        /// <summary>
        /// The latest date the package may arrive.
        /// </summary>
        [DataMember(Name = "expectedArrivalUntil", Order = 5)]
        public DateTimeOffset? ExpectedArrivalUntil { get; set; }

        /// <summary>
        /// Method used for delivery or shipping.
        /// </summary>
        [DataMember(Name = "hasDeliveryMethod", Order = 6)]
        public DeliveryMethod? HasDeliveryMethod { get; set; }

        /// <summary>
        /// Item(s) being shipped.
        /// </summary>
        [DataMember(Name = "itemShipped", Order = 7)]
        public Product ItemShipped { get; set; }

        /// <summary>
        /// Shipper's address.
        /// </summary>
        [DataMember(Name = "originAddress", Order = 8)]
        public PostalAddress OriginAddress { get; set; }

        /// <summary>
        /// The overall order the items in this delivery were included in.
        /// </summary>
        [DataMember(Name = "partOfOrder", Order = 9)]
        public Order PartOfOrder { get; set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider", Order = 10)]
        public object Provider { get; protected set; }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [IgnoreDataMember]
        public Organization ProviderOrganization
        {
            get => this.Provider as Organization;
            set => this.Provider = value;
        }

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [IgnoreDataMember]
        public Person ProviderPerson
        {
            get => this.Provider as Person;
            set => this.Provider = value;
        }

        /// <summary>
        /// Shipper tracking number.
        /// </summary>
        [DataMember(Name = "trackingNumber", Order = 11)]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Tracking url for the parcel delivery.
        /// </summary>
        [DataMember(Name = "trackingUrl", Order = 12)]
        public Uri TrackingUrl { get; set; }
    }
}

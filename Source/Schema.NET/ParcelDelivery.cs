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
        [DataMember(Name = "@type")]
        public override string Type => "ParcelDelivery";

        /// <summary>
        /// The service provider, service operator, or service performer; the goods producer. Another party (a seller) may offer those services or goods on behalf of the provider. A provider may also serve as the seller.
        /// </summary>
        [DataMember(Name = "provider")]
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
        /// Tracking url for the parcel delivery.
        /// </summary>
        [DataMember(Name = "trackingUrl")]
        public Uri TrackingUrl { get; set; }

        /// <summary>
        /// Destination address.
        /// </summary>
        [DataMember(Name = "deliveryAddress")]
        public PostalAddress DeliveryAddress { get; set; }

        /// <summary>
        /// Shipper tracking number.
        /// </summary>
        [DataMember(Name = "trackingNumber")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Method used for delivery or shipping.
        /// </summary>
        [DataMember(Name = "hasDeliveryMethod")]
        public DeliveryMethod HasDeliveryMethod { get; set; }

        /// <summary>
        /// New entry added as the package passes through each leg of its journey (from shipment to final delivery).
        /// </summary>
        [DataMember(Name = "deliveryStatus")]
        public DeliveryEvent DeliveryStatus { get; set; }

        /// <summary>
        /// Shipper's address.
        /// </summary>
        [DataMember(Name = "originAddress")]
        public PostalAddress OriginAddress { get; set; }

        /// <summary>
        /// Item(s) being shipped.
        /// </summary>
        [DataMember(Name = "itemShipped")]
        public Product ItemShipped { get; set; }

        /// <summary>
        /// The overall order the items in this delivery were included in.
        /// </summary>
        [DataMember(Name = "partOfOrder")]
        public Order PartOfOrder { get; set; }

        /// <summary>
        /// The earliest date the package may arrive.
        /// </summary>
        [DataMember(Name = "expectedArrivalFrom")]
        public DateTimeOffset ExpectedArrivalFrom { get; set; }

        /// <summary>
        /// The latest date the package may arrive.
        /// </summary>
        [DataMember(Name = "expectedArrivalUntil")]
        public DateTimeOffset ExpectedArrivalUntil { get; set; }
    }
}

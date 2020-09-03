namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A delivery method is a standardized procedure for transferring the product or service to the destination of fulfillment chosen by the customer. Delivery methods are characterized by the means of transportation used, and by the organization or group that is the contracting party for the sending organization or person.&lt;br/&gt;&lt;br/&gt;
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModeDirectDownload&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModeFreight&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModeMail&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModeOwnFleet&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DeliveryModePickUp&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DHL&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#FederalExpress&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#UPS&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DeliveryMethod
    {
        /// <summary>
        /// A DeliveryMethod in which an item is made available via locker.
        /// </summary>
        [EnumMember(Value = "https://schema.org/LockerDelivery")]
        LockerDelivery,

        /// <summary>
        /// A DeliveryMethod in which an item is collected on site, e.g. in a store or at a box office.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OnSitePickup")]
        OnSitePickup,

        /// <summary>
        /// A private parcel service as the delivery mode available for a certain offer.&lt;br/&gt;&lt;br/&gt;
        /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;http://purl.org/goodrelations/v1#DHL&lt;/li&gt;
        /// &lt;li&gt;http://purl.org/goodrelations/v1#FederalExpress&lt;/li&gt;
        /// &lt;li&gt;http://purl.org/goodrelations/v1#UPS&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [EnumMember(Value = "https://schema.org/ParcelService")]
        ParcelService,
    }
}

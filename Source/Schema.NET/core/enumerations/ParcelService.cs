namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A private parcel service as the delivery mode available for a certain offer.&lt;br/&gt;&lt;br/&gt;
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#DHL&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#FederalExpress&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#UPS&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ParcelService
    {
    }
}

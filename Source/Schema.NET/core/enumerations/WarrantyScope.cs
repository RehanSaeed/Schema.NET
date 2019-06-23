namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A range of of services that will be provided to a customer free of charge in case of a defect or malfunction of a product.&lt;br/&gt;&lt;br/&gt;
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Labor-BringIn&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#PartsAndLabor-BringIn&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#PartsAndLabor-PickUp&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WarrantyScope
    {
    }
}

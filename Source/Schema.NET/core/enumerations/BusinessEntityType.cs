namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A business entity type is a conceptual entity representing the legal form, the size, the main line of business, the position in the value chain, or any combination thereof, of an organization or business person.&lt;br/&gt;&lt;br/&gt;
    /// Commonly used values:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Business&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Enduser&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#PublicInstitution&lt;/li&gt;
    /// &lt;li&gt;http://purl.org/goodrelations/v1#Reseller&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BusinessEntityType
    {
    }
}

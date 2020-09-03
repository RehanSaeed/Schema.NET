namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Lists or enumerations dealing with status types.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StatusEnumeration
    {
    }
}

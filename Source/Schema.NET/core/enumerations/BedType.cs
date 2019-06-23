namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A type of bed. This is used for indicating the bed or beds available in an accommodation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BedType
    {
    }
}

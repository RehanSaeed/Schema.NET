namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A patient is any person recipient of health care services.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Patient
    {
    }
}

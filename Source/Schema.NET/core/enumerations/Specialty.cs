namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Any branch of a field in which people typically develop specific expertise, usually after significant study, time, and effort.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Specialty
    {
    }
}

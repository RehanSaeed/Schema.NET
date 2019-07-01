namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A DeliveryMethod in which an item is made available via locker.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LockerDelivery
    {
    }
}

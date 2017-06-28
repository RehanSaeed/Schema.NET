namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A map.
    /// </summary>
    [DataContract]
    public partial class Map : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Map";

        /// <summary>
        /// Indicates the kind of Map, from the MapCategoryType Enumeration.
        /// </summary>
        [DataMember(Name = "mapType", Order = 204)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MapCategoryType?>? MapType { get; set; }
    }
}

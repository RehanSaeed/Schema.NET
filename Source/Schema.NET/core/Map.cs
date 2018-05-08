namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A map.
    /// </summary>
    public partial interface IMap : ICreativeWork
    {
        /// <summary>
        /// Indicates the kind of Map, from the MapCategoryType Enumeration.
        /// </summary>
        OneOrMany<MapCategoryType?>? MapType { get; set; }
    }

    /// <summary>
    /// A map.
    /// </summary>
    [DataContract]
    public partial class Map : CreativeWork, IMap
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Map";

        /// <summary>
        /// Indicates the kind of Map, from the MapCategoryType Enumeration.
        /// </summary>
        [DataMember(Name = "mapType", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<MapCategoryType?>? MapType { get; set; }
    }
}

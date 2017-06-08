namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A map.
    /// </summary>
    [DataContract]
    public class Map : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Map";

        /// <summary>
        /// Indicates the kind of Map, from the MapCategoryType Enumeration.
        /// </summary>
        [DataMember(Name = "mapType")]
        public MapCategoryType MapType { get; set; }
    }
}

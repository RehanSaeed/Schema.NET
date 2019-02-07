namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A map.
    /// </summary>
    [DataContract]
    public partial class Map : CreativeWork
    {
        public interface IMapType : IValue {}
        public interface IMapType<T> : IMapType { new T Value { get; } }
        public class OneOrManyMapType : OneOrMany<IMapType>
        {
            public OneOrManyMapType(IMapType item) : base(item) { }
            public OneOrManyMapType(IEnumerable<IMapType> items) : base(items) { }
            public static implicit operator OneOrManyMapType (MapCategoryType value) { return new OneOrManyMapType (new MapTypeMapCategoryType (value)); }
            public static implicit operator OneOrManyMapType (MapCategoryType[] values) { return new OneOrManyMapType (values.Select(v => (IMapType) new MapTypeMapCategoryType (v))); }
            public static implicit operator OneOrManyMapType (List<MapCategoryType> values) { return new OneOrManyMapType (values.Select(v => (IMapType) new MapTypeMapCategoryType (v))); }
        }
        public struct MapTypeMapCategoryType : IMapType<MapCategoryType>
        {
            object IValue.Value => this.Value;
            public MapCategoryType Value { get; }
            public MapTypeMapCategoryType (MapCategoryType value) { Value = value; }
            public static implicit operator MapTypeMapCategoryType (MapCategoryType value) { return new MapTypeMapCategoryType (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Map";

        /// <summary>
        /// Indicates the kind of Map, from the MapCategoryType Enumeration.
        /// </summary>
        [DataMember(Name = "mapType", Order = 206)]
        public OneOrManyMapType MapType { get; set; }
    }
}

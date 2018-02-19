using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An list item, e.g. a step in a checklist or how-to description.
    /// </summary>
    [DataContract]
    public partial class ListItem : Intangible
    {
        public interface IPosition : IWrapper { }
        public interface IPosition<T> : IPosition { new T Data { get; set; } }
        public class Positionint : IPosition<int>
        {
            object IWrapper.Data { get { return Data; } set { Data = (int) value; } }
            public virtual int Data { get; set; }
            public Positionint () { }
            public Positionint (int data) { Data = data; }
            public static implicit operator Positionint (int data) { return new Positionint (data); }
        }

        public class Positionstring : IPosition<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Positionstring () { }
            public Positionstring (string data) { Data = data; }
            public static implicit operator Positionstring (string data) { return new Positionstring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ListItem";

        /// <summary>
        /// An entity represented by an entry in a list or data feed (e.g. an 'artist' in a list of 'artists')’.
        /// </summary>
        [DataMember(Name = "item", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Item { get; set; } 

        /// <summary>
        /// A link to the ListItem that follows the current one.
        /// </summary>
        [DataMember(Name = "nextItem", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ListItem>? NextItem { get; set; } 

        /// <summary>
        /// The position of an item in a series or sequence of items.
        /// </summary>
        [DataMember(Name = "position", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IPosition>? Position { get; set; } //int?, string

        /// <summary>
        /// A link to the ListItem that preceeds the current one.
        /// </summary>
        [DataMember(Name = "previousItem", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ListItem>? PreviousItem { get; set; } 
    }
}

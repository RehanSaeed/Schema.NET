using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A single feed providing structured information about one or more entities or topics.
    /// </summary>
    [DataContract]
    public partial class DataFeed : Dataset
    {
        public interface IDataFeedElement : IWrapper { }
        public interface IDataFeedElement<T> : IDataFeedElement { new T Data { get; set; } }
        public class DataFeedElementDataFeedItem : IDataFeedElement<DataFeedItem>
        {
            object IWrapper.Data { get { return Data; } set { Data = (DataFeedItem) value; } }
            public virtual DataFeedItem Data { get; set; }
            public DataFeedElementDataFeedItem () { }
            public DataFeedElementDataFeedItem (DataFeedItem data) { Data = data; }
            public static implicit operator DataFeedElementDataFeedItem (DataFeedItem data) { return new DataFeedElementDataFeedItem (data); }
        }

        public class DataFeedElementstring : IDataFeedElement<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public DataFeedElementstring () { }
            public DataFeedElementstring (string data) { Data = data; }
            public static implicit operator DataFeedElementstring (string data) { return new DataFeedElementstring (data); }
        }

        public class DataFeedElementThing : IDataFeedElement<Thing>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Thing) value; } }
            public virtual Thing Data { get; set; }
            public DataFeedElementThing () { }
            public DataFeedElementThing (Thing data) { Data = data; }
            public static implicit operator DataFeedElementThing (Thing data) { return new DataFeedElementThing (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataFeed";

        /// <summary>
        /// An item within in a data feed. Data feeds may have many elements.
        /// </summary>
        [DataMember(Name = "dataFeedElement", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IDataFeedElement>? DataFeedElement { get; set; } //DataFeedItem, string, Thing
    }
}

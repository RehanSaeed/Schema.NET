namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A single feed providing structured information about one or more entities or topics.
    /// </summary>
    [DataContract]
    public partial class DataFeed : Dataset
    {
        public interface IDataFeedElement : IValue {}
        public interface IDataFeedElement<T> : IDataFeedElement { new T Value { get; } }
        public class OneOrManyDataFeedElement : OneOrMany<IDataFeedElement>
        {
            public OneOrManyDataFeedElement(IDataFeedElement item) : base(item) { }
            public OneOrManyDataFeedElement(IEnumerable<IDataFeedElement> items) : base(items) { }
            public static implicit operator OneOrManyDataFeedElement (DataFeedItem value) { return new OneOrManyDataFeedElement (new DataFeedElementDataFeedItem (value)); }
            public static implicit operator OneOrManyDataFeedElement (DataFeedItem[] values) { return new OneOrManyDataFeedElement (values.Select(v => (IDataFeedElement) new DataFeedElementDataFeedItem (v))); }
            public static implicit operator OneOrManyDataFeedElement (List<DataFeedItem> values) { return new OneOrManyDataFeedElement (values.Select(v => (IDataFeedElement) new DataFeedElementDataFeedItem (v))); }
            public static implicit operator OneOrManyDataFeedElement (string value) { return new OneOrManyDataFeedElement (new DataFeedElementstring (value)); }
            public static implicit operator OneOrManyDataFeedElement (string[] values) { return new OneOrManyDataFeedElement (values.Select(v => (IDataFeedElement) new DataFeedElementstring (v))); }
            public static implicit operator OneOrManyDataFeedElement (List<string> values) { return new OneOrManyDataFeedElement (values.Select(v => (IDataFeedElement) new DataFeedElementstring (v))); }
            public static implicit operator OneOrManyDataFeedElement (Thing value) { return new OneOrManyDataFeedElement (new DataFeedElementThing (value)); }
            public static implicit operator OneOrManyDataFeedElement (Thing[] values) { return new OneOrManyDataFeedElement (values.Select(v => (IDataFeedElement) new DataFeedElementThing (v))); }
            public static implicit operator OneOrManyDataFeedElement (List<Thing> values) { return new OneOrManyDataFeedElement (values.Select(v => (IDataFeedElement) new DataFeedElementThing (v))); }
        }
        public struct DataFeedElementDataFeedItem : IDataFeedElement<DataFeedItem>
        {
            object IValue.Value => this.Value;
            public DataFeedItem Value { get; }
            public DataFeedElementDataFeedItem (DataFeedItem value) { Value = value; }
            public static implicit operator DataFeedElementDataFeedItem (DataFeedItem value) { return new DataFeedElementDataFeedItem (value); }
        }
        public struct DataFeedElementstring : IDataFeedElement<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public DataFeedElementstring (string value) { Value = value; }
            public static implicit operator DataFeedElementstring (string value) { return new DataFeedElementstring (value); }
        }
        public struct DataFeedElementThing : IDataFeedElement<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public DataFeedElementThing (Thing value) { Value = value; }
            public static implicit operator DataFeedElementThing (Thing value) { return new DataFeedElementThing (value); }
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
        public OneOrManyDataFeedElement DataFeedElement { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A single feed providing structured information about one or more entities or topics.
    /// </summary>
    [DataContract]
    public class DataFeed : Dataset
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataFeed";

        /// <summary>
        /// An item within in a data feed. Data feeds may have many elements.
        /// </summary>
        [DataMember(Name = "dataFeedElement", Order = 2)]
        public object DataFeedElement { get; protected set; }

        /// <summary>
        /// An item within in a data feed. Data feeds may have many elements.
        /// </summary>
        [IgnoreDataMember]
        public DataFeedItem DataFeedElementDataFeedItem
        {
            get => this.DataFeedElement as DataFeedItem;
            set => this.DataFeedElement = value;
        }

        /// <summary>
        /// An item within in a data feed. Data feeds may have many elements.
        /// </summary>
        [IgnoreDataMember]
        public Thing DataFeedElementThing
        {
            get => this.DataFeedElement as Thing;
            set => this.DataFeedElement = value;
        }

        /// <summary>
        /// An item within in a data feed. Data feeds may have many elements.
        /// </summary>
        [IgnoreDataMember]
        public string DataFeedElementText
        {
            get => this.DataFeedElement as string;
            set => this.DataFeedElement = value;
        }
    }
}

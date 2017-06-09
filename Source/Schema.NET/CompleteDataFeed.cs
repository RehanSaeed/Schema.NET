namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A CompleteDataFeed is a DataFeed whose standard representation includes content for every item currently in the feed...
    /// </summary>
    [DataContract]
    public class CompleteDataFeed : DataFeed
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CompleteDataFeed";
    }
}

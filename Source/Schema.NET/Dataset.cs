namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
    [DataContract]
    public class Dataset : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Dataset";

        /// <summary>
        /// A data catalog which contains this dataset.
        /// </summary>
        [DataMember(Name = "includedInDataCatalog")]
        public DataCatalog IncludedInDataCatalog { get; set; }

        /// <summary>
        /// A downloadable form of this dataset, at a specific location, in a specific format.
        /// </summary>
        [DataMember(Name = "distribution")]
        public DataDownload Distribution { get; set; }
    }
}

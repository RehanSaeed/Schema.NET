namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A collection of datasets.
    /// </summary>
    [DataContract]
    public class DataCatalog : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DataCatalog";

        /// <summary>
        /// A dataset contained in this catalog.
        /// </summary>
        [DataMember(Name = "dataset")]
        public Dataset Dataset { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A publication in any medium issued in successive parts bearing numerical or chronological designations and intended, such as a magazine, scholarly journal, or newspaper to continue indefinitely...
    /// </summary>
    [DataContract]
    public class Periodical : CreativeWorkSeries
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Periodical";

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this periodical. You can repeat this property to (for example) identify different formats of this periodical.
        /// </summary>
        [DataMember(Name = "issn")]
        public string Issn { get; set; }
    }
}

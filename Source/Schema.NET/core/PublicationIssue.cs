namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A part of a successively published publication such as a periodical or publication volume, often numbered, usually containing a grouping of works such as articles...
    /// </summary>
    [DataContract]
    public partial class PublicationIssue : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PublicationIssue";

        /// <summary>
        /// Identifies the issue of publication; for example, "iii" or "2".
        /// </summary>
        [DataMember(Name = "issueNumber", Order = 204)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, int?>? IssueNumber { get; set; }

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [DataMember(Name = "pageEnd", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, int?>? PageEnd { get; set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [DataMember(Name = "pageStart", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?, string>? PageStart { get; set; }

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [DataMember(Name = "pagination", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Pagination { get; set; }
    }
}

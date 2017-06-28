namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A blog post intended to provide a rolling textual coverage of an ongoing event through continuous updates.
    /// </summary>
    [DataContract]
    public partial class LiveBlogPosting : BlogPosting
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LiveBlogPosting";

        /// <summary>
        /// The time when the live blog will stop covering the Event. Note that coverage may continue after the Event concludes.
        /// </summary>
        [DataMember(Name = "coverageEndTime", Order = 504)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? CoverageEndTime { get; set; }

        /// <summary>
        /// The time when the live blog will begin covering the Event. Note that coverage may begin before the Event's start time. The LiveBlogPosting may also be created before coverage begins.
        /// </summary>
        [DataMember(Name = "coverageStartTime", Order = 505)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset?>? CoverageStartTime { get; set; }

        /// <summary>
        /// An update to the LiveBlog.
        /// </summary>
        [DataMember(Name = "liveBlogUpdate", Order = 506)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BlogPosting>? LiveBlogUpdate { get; set; }
    }
}

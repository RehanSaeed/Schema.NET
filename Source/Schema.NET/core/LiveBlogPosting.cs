namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A blog post intended to provide a rolling textual coverage of an ongoing event through continuous updates.
    /// </summary>
    public partial interface ILiveBlogPosting : IBlogPosting
    {
        /// <summary>
        /// The time when the live blog will stop covering the Event. Note that coverage may continue after the Event concludes.
        /// </summary>
        OneOrMany<DateTimeOffset?> CoverageEndTime { get; set; }

        /// <summary>
        /// The time when the live blog will begin covering the Event. Note that coverage may begin before the Event's start time. The LiveBlogPosting may also be created before coverage begins.
        /// </summary>
        OneOrMany<DateTimeOffset?> CoverageStartTime { get; set; }

        /// <summary>
        /// An update to the LiveBlog.
        /// </summary>
        OneOrMany<IBlogPosting, BlogPosting> LiveBlogUpdate { get; set; }
    }

    /// <summary>
    /// A blog post intended to provide a rolling textual coverage of an ongoing event through continuous updates.
    /// </summary>
    [DataContract]
    public partial class LiveBlogPosting : BlogPosting, ILiveBlogPosting
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LiveBlogPosting";

        /// <summary>
        /// The time when the live blog will stop covering the Event. Note that coverage may continue after the Event concludes.
        /// </summary>
        [DataMember(Name = "coverageEndTime", Order = 506)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> CoverageEndTime { get; set; }

        /// <summary>
        /// The time when the live blog will begin covering the Event. Note that coverage may begin before the Event's start time. The LiveBlogPosting may also be created before coverage begins.
        /// </summary>
        [DataMember(Name = "coverageStartTime", Order = 507)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> CoverageStartTime { get; set; }

        /// <summary>
        /// An update to the LiveBlog.
        /// </summary>
        [DataMember(Name = "liveBlogUpdate", Order = 508)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IBlogPosting, BlogPosting> LiveBlogUpdate { get; set; }
    }
}

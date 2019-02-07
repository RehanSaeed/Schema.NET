namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A blog post intended to provide a rolling textual coverage of an ongoing event through continuous updates.
    /// </summary>
    [DataContract]
    public partial class LiveBlogPosting : BlogPosting
    {
        public interface ICoverageEndTime : IValue {}
        public interface ICoverageEndTime<T> : ICoverageEndTime { new T Value { get; } }
        public class OneOrManyCoverageEndTime : OneOrMany<ICoverageEndTime>
        {
            public OneOrManyCoverageEndTime(ICoverageEndTime item) : base(item) { }
            public OneOrManyCoverageEndTime(IEnumerable<ICoverageEndTime> items) : base(items) { }
            public static implicit operator OneOrManyCoverageEndTime (DateTimeOffset value) { return new OneOrManyCoverageEndTime (new CoverageEndTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyCoverageEndTime (DateTimeOffset[] values) { return new OneOrManyCoverageEndTime (values.Select(v => (ICoverageEndTime) new CoverageEndTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyCoverageEndTime (List<DateTimeOffset> values) { return new OneOrManyCoverageEndTime (values.Select(v => (ICoverageEndTime) new CoverageEndTimeDateTimeOffset (v))); }
        }
        public struct CoverageEndTimeDateTimeOffset : ICoverageEndTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public CoverageEndTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator CoverageEndTimeDateTimeOffset (DateTimeOffset value) { return new CoverageEndTimeDateTimeOffset (value); }
        }

        public interface ICoverageStartTime : IValue {}
        public interface ICoverageStartTime<T> : ICoverageStartTime { new T Value { get; } }
        public class OneOrManyCoverageStartTime : OneOrMany<ICoverageStartTime>
        {
            public OneOrManyCoverageStartTime(ICoverageStartTime item) : base(item) { }
            public OneOrManyCoverageStartTime(IEnumerable<ICoverageStartTime> items) : base(items) { }
            public static implicit operator OneOrManyCoverageStartTime (DateTimeOffset value) { return new OneOrManyCoverageStartTime (new CoverageStartTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyCoverageStartTime (DateTimeOffset[] values) { return new OneOrManyCoverageStartTime (values.Select(v => (ICoverageStartTime) new CoverageStartTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyCoverageStartTime (List<DateTimeOffset> values) { return new OneOrManyCoverageStartTime (values.Select(v => (ICoverageStartTime) new CoverageStartTimeDateTimeOffset (v))); }
        }
        public struct CoverageStartTimeDateTimeOffset : ICoverageStartTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public CoverageStartTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator CoverageStartTimeDateTimeOffset (DateTimeOffset value) { return new CoverageStartTimeDateTimeOffset (value); }
        }

        public interface ILiveBlogUpdate : IValue {}
        public interface ILiveBlogUpdate<T> : ILiveBlogUpdate { new T Value { get; } }
        public class OneOrManyLiveBlogUpdate : OneOrMany<ILiveBlogUpdate>
        {
            public OneOrManyLiveBlogUpdate(ILiveBlogUpdate item) : base(item) { }
            public OneOrManyLiveBlogUpdate(IEnumerable<ILiveBlogUpdate> items) : base(items) { }
            public static implicit operator OneOrManyLiveBlogUpdate (BlogPosting value) { return new OneOrManyLiveBlogUpdate (new LiveBlogUpdateBlogPosting (value)); }
            public static implicit operator OneOrManyLiveBlogUpdate (BlogPosting[] values) { return new OneOrManyLiveBlogUpdate (values.Select(v => (ILiveBlogUpdate) new LiveBlogUpdateBlogPosting (v))); }
            public static implicit operator OneOrManyLiveBlogUpdate (List<BlogPosting> values) { return new OneOrManyLiveBlogUpdate (values.Select(v => (ILiveBlogUpdate) new LiveBlogUpdateBlogPosting (v))); }
        }
        public struct LiveBlogUpdateBlogPosting : ILiveBlogUpdate<BlogPosting>
        {
            object IValue.Value => this.Value;
            public BlogPosting Value { get; }
            public LiveBlogUpdateBlogPosting (BlogPosting value) { Value = value; }
            public static implicit operator LiveBlogUpdateBlogPosting (BlogPosting value) { return new LiveBlogUpdateBlogPosting (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LiveBlogPosting";

        /// <summary>
        /// The time when the live blog will stop covering the Event. Note that coverage may continue after the Event concludes.
        /// </summary>
        [DataMember(Name = "coverageEndTime", Order = 506)]
        public OneOrManyCoverageEndTime CoverageEndTime { get; set; }

        /// <summary>
        /// The time when the live blog will begin covering the Event. Note that coverage may begin before the Event's start time. The LiveBlogPosting may also be created before coverage begins.
        /// </summary>
        [DataMember(Name = "coverageStartTime", Order = 507)]
        public OneOrManyCoverageStartTime CoverageStartTime { get; set; }

        /// <summary>
        /// An update to the LiveBlog.
        /// </summary>
        [DataMember(Name = "liveBlogUpdate", Order = 508)]
        public OneOrManyLiveBlogUpdate LiveBlogUpdate { get; set; }
    }
}

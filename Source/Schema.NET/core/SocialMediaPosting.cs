namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A post to a social media platform, including blog posts, tweets, Facebook posts, etc.
    /// </summary>
    [DataContract]
    public partial class SocialMediaPosting : Article
    {
        public interface ISharedContent : IValue {}
        public interface ISharedContent<T> : ISharedContent { new T Value { get; } }
        public class OneOrManySharedContent : OneOrMany<ISharedContent>
        {
            public OneOrManySharedContent(ISharedContent item) : base(item) { }
            public OneOrManySharedContent(IEnumerable<ISharedContent> items) : base(items) { }
            public static implicit operator OneOrManySharedContent (CreativeWork value) { return new OneOrManySharedContent (new SharedContentCreativeWork (value)); }
            public static implicit operator OneOrManySharedContent (CreativeWork[] values) { return new OneOrManySharedContent (values.Select(v => (ISharedContent) new SharedContentCreativeWork (v))); }
            public static implicit operator OneOrManySharedContent (List<CreativeWork> values) { return new OneOrManySharedContent (values.Select(v => (ISharedContent) new SharedContentCreativeWork (v))); }
        }
        public struct SharedContentCreativeWork : ISharedContent<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public SharedContentCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator SharedContentCreativeWork (CreativeWork value) { return new SharedContentCreativeWork (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SocialMediaPosting";

        /// <summary>
        /// A CreativeWork such as an image, video, or audio clip shared as part of this posting.
        /// </summary>
        [DataMember(Name = "sharedContent", Order = 306)]
        public OneOrManySharedContent SharedContent { get; set; }
    }
}

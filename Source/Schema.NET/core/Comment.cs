namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A comment on an item - for example, a comment on a blog post. The comment's content is expressed via the &lt;a class="localLink" href="http://schema.org/text"&gt;text&lt;/a&gt; property, and its topic via &lt;a class="localLink" href="http://schema.org/about"&gt;about&lt;/a&gt;, properties shared with all CreativeWorks.
    /// </summary>
    [DataContract]
    public partial class Comment : CreativeWork
    {
        public interface IDownvoteCount : IValue {}
        public interface IDownvoteCount<T> : IDownvoteCount { new T Value { get; } }
        public class OneOrManyDownvoteCount : OneOrMany<IDownvoteCount>
        {
            public OneOrManyDownvoteCount(IDownvoteCount item) : base(item) { }
            public OneOrManyDownvoteCount(IEnumerable<IDownvoteCount> items) : base(items) { }
            public static implicit operator OneOrManyDownvoteCount (int value) { return new OneOrManyDownvoteCount (new DownvoteCountint (value)); }
            public static implicit operator OneOrManyDownvoteCount (int[] values) { return new OneOrManyDownvoteCount (values.Select(v => (IDownvoteCount) new DownvoteCountint (v))); }
            public static implicit operator OneOrManyDownvoteCount (List<int> values) { return new OneOrManyDownvoteCount (values.Select(v => (IDownvoteCount) new DownvoteCountint (v))); }
        }
        public struct DownvoteCountint : IDownvoteCount<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public DownvoteCountint (int value) { Value = value; }
            public static implicit operator DownvoteCountint (int value) { return new DownvoteCountint (value); }
        }

        public interface IParentItem : IValue {}
        public interface IParentItem<T> : IParentItem { new T Value { get; } }
        public class OneOrManyParentItem : OneOrMany<IParentItem>
        {
            public OneOrManyParentItem(IParentItem item) : base(item) { }
            public OneOrManyParentItem(IEnumerable<IParentItem> items) : base(items) { }
            public static implicit operator OneOrManyParentItem (Question value) { return new OneOrManyParentItem (new ParentItemQuestion (value)); }
            public static implicit operator OneOrManyParentItem (Question[] values) { return new OneOrManyParentItem (values.Select(v => (IParentItem) new ParentItemQuestion (v))); }
            public static implicit operator OneOrManyParentItem (List<Question> values) { return new OneOrManyParentItem (values.Select(v => (IParentItem) new ParentItemQuestion (v))); }
        }
        public struct ParentItemQuestion : IParentItem<Question>
        {
            object IValue.Value => this.Value;
            public Question Value { get; }
            public ParentItemQuestion (Question value) { Value = value; }
            public static implicit operator ParentItemQuestion (Question value) { return new ParentItemQuestion (value); }
        }

        public interface IUpvoteCount : IValue {}
        public interface IUpvoteCount<T> : IUpvoteCount { new T Value { get; } }
        public class OneOrManyUpvoteCount : OneOrMany<IUpvoteCount>
        {
            public OneOrManyUpvoteCount(IUpvoteCount item) : base(item) { }
            public OneOrManyUpvoteCount(IEnumerable<IUpvoteCount> items) : base(items) { }
            public static implicit operator OneOrManyUpvoteCount (int value) { return new OneOrManyUpvoteCount (new UpvoteCountint (value)); }
            public static implicit operator OneOrManyUpvoteCount (int[] values) { return new OneOrManyUpvoteCount (values.Select(v => (IUpvoteCount) new UpvoteCountint (v))); }
            public static implicit operator OneOrManyUpvoteCount (List<int> values) { return new OneOrManyUpvoteCount (values.Select(v => (IUpvoteCount) new UpvoteCountint (v))); }
        }
        public struct UpvoteCountint : IUpvoteCount<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public UpvoteCountint (int value) { Value = value; }
            public static implicit operator UpvoteCountint (int value) { return new UpvoteCountint (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Comment";

        /// <summary>
        /// The number of downvotes this question, answer or comment has received from the community.
        /// </summary>
        [DataMember(Name = "downvoteCount", Order = 206)]
        public OneOrManyDownvoteCount DownvoteCount { get; set; }

        /// <summary>
        /// The parent of a question, answer or item in general.
        /// </summary>
        [DataMember(Name = "parentItem", Order = 207)]
        public OneOrManyParentItem ParentItem { get; set; }

        /// <summary>
        /// The number of upvotes this question, answer or comment has received from the community.
        /// </summary>
        [DataMember(Name = "upvoteCount", Order = 208)]
        public OneOrManyUpvoteCount UpvoteCount { get; set; }
    }
}

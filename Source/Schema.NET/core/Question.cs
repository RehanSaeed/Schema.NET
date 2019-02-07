namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A specific question - e.g. from a user seeking answers online, or collected in a Frequently Asked Questions (FAQ) document.
    /// </summary>
    [DataContract]
    public partial class Question : CreativeWork
    {
        public interface IAcceptedAnswer : IValue {}
        public interface IAcceptedAnswer<T> : IAcceptedAnswer { new T Value { get; } }
        public class OneOrManyAcceptedAnswer : OneOrMany<IAcceptedAnswer>
        {
            public OneOrManyAcceptedAnswer(IAcceptedAnswer item) : base(item) { }
            public OneOrManyAcceptedAnswer(IEnumerable<IAcceptedAnswer> items) : base(items) { }
            public static implicit operator OneOrManyAcceptedAnswer (Answer value) { return new OneOrManyAcceptedAnswer (new AcceptedAnswerAnswer (value)); }
            public static implicit operator OneOrManyAcceptedAnswer (Answer[] values) { return new OneOrManyAcceptedAnswer (values.Select(v => (IAcceptedAnswer) new AcceptedAnswerAnswer (v))); }
            public static implicit operator OneOrManyAcceptedAnswer (List<Answer> values) { return new OneOrManyAcceptedAnswer (values.Select(v => (IAcceptedAnswer) new AcceptedAnswerAnswer (v))); }
            public static implicit operator OneOrManyAcceptedAnswer (ItemList value) { return new OneOrManyAcceptedAnswer (new AcceptedAnswerItemList (value)); }
            public static implicit operator OneOrManyAcceptedAnswer (ItemList[] values) { return new OneOrManyAcceptedAnswer (values.Select(v => (IAcceptedAnswer) new AcceptedAnswerItemList (v))); }
            public static implicit operator OneOrManyAcceptedAnswer (List<ItemList> values) { return new OneOrManyAcceptedAnswer (values.Select(v => (IAcceptedAnswer) new AcceptedAnswerItemList (v))); }
        }
        public struct AcceptedAnswerAnswer : IAcceptedAnswer<Answer>
        {
            object IValue.Value => this.Value;
            public Answer Value { get; }
            public AcceptedAnswerAnswer (Answer value) { Value = value; }
            public static implicit operator AcceptedAnswerAnswer (Answer value) { return new AcceptedAnswerAnswer (value); }
        }
        public struct AcceptedAnswerItemList : IAcceptedAnswer<ItemList>
        {
            object IValue.Value => this.Value;
            public ItemList Value { get; }
            public AcceptedAnswerItemList (ItemList value) { Value = value; }
            public static implicit operator AcceptedAnswerItemList (ItemList value) { return new AcceptedAnswerItemList (value); }
        }

        public interface IAnswerCount : IValue {}
        public interface IAnswerCount<T> : IAnswerCount { new T Value { get; } }
        public class OneOrManyAnswerCount : OneOrMany<IAnswerCount>
        {
            public OneOrManyAnswerCount(IAnswerCount item) : base(item) { }
            public OneOrManyAnswerCount(IEnumerable<IAnswerCount> items) : base(items) { }
            public static implicit operator OneOrManyAnswerCount (int value) { return new OneOrManyAnswerCount (new AnswerCountint (value)); }
            public static implicit operator OneOrManyAnswerCount (int[] values) { return new OneOrManyAnswerCount (values.Select(v => (IAnswerCount) new AnswerCountint (v))); }
            public static implicit operator OneOrManyAnswerCount (List<int> values) { return new OneOrManyAnswerCount (values.Select(v => (IAnswerCount) new AnswerCountint (v))); }
        }
        public struct AnswerCountint : IAnswerCount<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public AnswerCountint (int value) { Value = value; }
            public static implicit operator AnswerCountint (int value) { return new AnswerCountint (value); }
        }

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

        public interface ISuggestedAnswer : IValue {}
        public interface ISuggestedAnswer<T> : ISuggestedAnswer { new T Value { get; } }
        public class OneOrManySuggestedAnswer : OneOrMany<ISuggestedAnswer>
        {
            public OneOrManySuggestedAnswer(ISuggestedAnswer item) : base(item) { }
            public OneOrManySuggestedAnswer(IEnumerable<ISuggestedAnswer> items) : base(items) { }
            public static implicit operator OneOrManySuggestedAnswer (Answer value) { return new OneOrManySuggestedAnswer (new SuggestedAnswerAnswer (value)); }
            public static implicit operator OneOrManySuggestedAnswer (Answer[] values) { return new OneOrManySuggestedAnswer (values.Select(v => (ISuggestedAnswer) new SuggestedAnswerAnswer (v))); }
            public static implicit operator OneOrManySuggestedAnswer (List<Answer> values) { return new OneOrManySuggestedAnswer (values.Select(v => (ISuggestedAnswer) new SuggestedAnswerAnswer (v))); }
            public static implicit operator OneOrManySuggestedAnswer (ItemList value) { return new OneOrManySuggestedAnswer (new SuggestedAnswerItemList (value)); }
            public static implicit operator OneOrManySuggestedAnswer (ItemList[] values) { return new OneOrManySuggestedAnswer (values.Select(v => (ISuggestedAnswer) new SuggestedAnswerItemList (v))); }
            public static implicit operator OneOrManySuggestedAnswer (List<ItemList> values) { return new OneOrManySuggestedAnswer (values.Select(v => (ISuggestedAnswer) new SuggestedAnswerItemList (v))); }
        }
        public struct SuggestedAnswerAnswer : ISuggestedAnswer<Answer>
        {
            object IValue.Value => this.Value;
            public Answer Value { get; }
            public SuggestedAnswerAnswer (Answer value) { Value = value; }
            public static implicit operator SuggestedAnswerAnswer (Answer value) { return new SuggestedAnswerAnswer (value); }
        }
        public struct SuggestedAnswerItemList : ISuggestedAnswer<ItemList>
        {
            object IValue.Value => this.Value;
            public ItemList Value { get; }
            public SuggestedAnswerItemList (ItemList value) { Value = value; }
            public static implicit operator SuggestedAnswerItemList (ItemList value) { return new SuggestedAnswerItemList (value); }
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
        public override string Type => "Question";

        /// <summary>
        /// The answer(s) that has been accepted as best, typically on a Question/Answer site. Sites vary in their selection mechanisms, e.g. drawing on community opinion and/or the view of the Question author.
        /// </summary>
        [DataMember(Name = "acceptedAnswer", Order = 206)]
        public OneOrManyAcceptedAnswer AcceptedAnswer { get; set; }

        /// <summary>
        /// The number of answers this question has received.
        /// </summary>
        [DataMember(Name = "answerCount", Order = 207)]
        public OneOrManyAnswerCount AnswerCount { get; set; }

        /// <summary>
        /// The number of downvotes this question, answer or comment has received from the community.
        /// </summary>
        [DataMember(Name = "downvoteCount", Order = 208)]
        public OneOrManyDownvoteCount DownvoteCount { get; set; }

        /// <summary>
        /// An answer (possibly one of several, possibly incorrect) to a Question, e.g. on a Question/Answer site.
        /// </summary>
        [DataMember(Name = "suggestedAnswer", Order = 209)]
        public OneOrManySuggestedAnswer SuggestedAnswer { get; set; }

        /// <summary>
        /// The number of upvotes this question, answer or comment has received from the community.
        /// </summary>
        [DataMember(Name = "upvoteCount", Order = 210)]
        public OneOrManyUpvoteCount UpvoteCount { get; set; }
    }
}

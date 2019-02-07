namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The average rating based on multiple ratings or reviews.
    /// </summary>
    [DataContract]
    public partial class AggregateRating : Rating
    {
        public interface IItemReviewed : IValue {}
        public interface IItemReviewed<T> : IItemReviewed { new T Value { get; } }
        public class OneOrManyItemReviewed : OneOrMany<IItemReviewed>
        {
            public OneOrManyItemReviewed(IItemReviewed item) : base(item) { }
            public OneOrManyItemReviewed(IEnumerable<IItemReviewed> items) : base(items) { }
            public static implicit operator OneOrManyItemReviewed (Thing value) { return new OneOrManyItemReviewed (new ItemReviewedThing (value)); }
            public static implicit operator OneOrManyItemReviewed (Thing[] values) { return new OneOrManyItemReviewed (values.Select(v => (IItemReviewed) new ItemReviewedThing (v))); }
            public static implicit operator OneOrManyItemReviewed (List<Thing> values) { return new OneOrManyItemReviewed (values.Select(v => (IItemReviewed) new ItemReviewedThing (v))); }
        }
        public struct ItemReviewedThing : IItemReviewed<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public ItemReviewedThing (Thing value) { Value = value; }
            public static implicit operator ItemReviewedThing (Thing value) { return new ItemReviewedThing (value); }
        }

        public interface IRatingCount : IValue {}
        public interface IRatingCount<T> : IRatingCount { new T Value { get; } }
        public class OneOrManyRatingCount : OneOrMany<IRatingCount>
        {
            public OneOrManyRatingCount(IRatingCount item) : base(item) { }
            public OneOrManyRatingCount(IEnumerable<IRatingCount> items) : base(items) { }
            public static implicit operator OneOrManyRatingCount (int value) { return new OneOrManyRatingCount (new RatingCountint (value)); }
            public static implicit operator OneOrManyRatingCount (int[] values) { return new OneOrManyRatingCount (values.Select(v => (IRatingCount) new RatingCountint (v))); }
            public static implicit operator OneOrManyRatingCount (List<int> values) { return new OneOrManyRatingCount (values.Select(v => (IRatingCount) new RatingCountint (v))); }
        }
        public struct RatingCountint : IRatingCount<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public RatingCountint (int value) { Value = value; }
            public static implicit operator RatingCountint (int value) { return new RatingCountint (value); }
        }

        public interface IReviewCount : IValue {}
        public interface IReviewCount<T> : IReviewCount { new T Value { get; } }
        public class OneOrManyReviewCount : OneOrMany<IReviewCount>
        {
            public OneOrManyReviewCount(IReviewCount item) : base(item) { }
            public OneOrManyReviewCount(IEnumerable<IReviewCount> items) : base(items) { }
            public static implicit operator OneOrManyReviewCount (int value) { return new OneOrManyReviewCount (new ReviewCountint (value)); }
            public static implicit operator OneOrManyReviewCount (int[] values) { return new OneOrManyReviewCount (values.Select(v => (IReviewCount) new ReviewCountint (v))); }
            public static implicit operator OneOrManyReviewCount (List<int> values) { return new OneOrManyReviewCount (values.Select(v => (IReviewCount) new ReviewCountint (v))); }
        }
        public struct ReviewCountint : IReviewCount<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public ReviewCountint (int value) { Value = value; }
            public static implicit operator ReviewCountint (int value) { return new ReviewCountint (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AggregateRating";

        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        [DataMember(Name = "itemReviewed", Order = 306)]
        public OneOrManyItemReviewed ItemReviewed { get; set; }

        /// <summary>
        /// The count of total number of ratings.
        /// </summary>
        [DataMember(Name = "ratingCount", Order = 307)]
        public OneOrManyRatingCount RatingCount { get; set; }

        /// <summary>
        /// The count of total number of reviews.
        /// </summary>
        [DataMember(Name = "reviewCount", Order = 308)]
        public OneOrManyReviewCount ReviewCount { get; set; }
    }
}

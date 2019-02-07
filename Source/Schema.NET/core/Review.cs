namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A review of an item - for example, of a restaurant, movie, or store.
    /// </summary>
    [DataContract]
    public partial class Review : CreativeWork
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

        public interface IReviewAspect : IValue {}
        public interface IReviewAspect<T> : IReviewAspect { new T Value { get; } }
        public class OneOrManyReviewAspect : OneOrMany<IReviewAspect>
        {
            public OneOrManyReviewAspect(IReviewAspect item) : base(item) { }
            public OneOrManyReviewAspect(IEnumerable<IReviewAspect> items) : base(items) { }
            public static implicit operator OneOrManyReviewAspect (string value) { return new OneOrManyReviewAspect (new ReviewAspectstring (value)); }
            public static implicit operator OneOrManyReviewAspect (string[] values) { return new OneOrManyReviewAspect (values.Select(v => (IReviewAspect) new ReviewAspectstring (v))); }
            public static implicit operator OneOrManyReviewAspect (List<string> values) { return new OneOrManyReviewAspect (values.Select(v => (IReviewAspect) new ReviewAspectstring (v))); }
        }
        public struct ReviewAspectstring : IReviewAspect<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ReviewAspectstring (string value) { Value = value; }
            public static implicit operator ReviewAspectstring (string value) { return new ReviewAspectstring (value); }
        }

        public interface IReviewBody : IValue {}
        public interface IReviewBody<T> : IReviewBody { new T Value { get; } }
        public class OneOrManyReviewBody : OneOrMany<IReviewBody>
        {
            public OneOrManyReviewBody(IReviewBody item) : base(item) { }
            public OneOrManyReviewBody(IEnumerable<IReviewBody> items) : base(items) { }
            public static implicit operator OneOrManyReviewBody (string value) { return new OneOrManyReviewBody (new ReviewBodystring (value)); }
            public static implicit operator OneOrManyReviewBody (string[] values) { return new OneOrManyReviewBody (values.Select(v => (IReviewBody) new ReviewBodystring (v))); }
            public static implicit operator OneOrManyReviewBody (List<string> values) { return new OneOrManyReviewBody (values.Select(v => (IReviewBody) new ReviewBodystring (v))); }
        }
        public struct ReviewBodystring : IReviewBody<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ReviewBodystring (string value) { Value = value; }
            public static implicit operator ReviewBodystring (string value) { return new ReviewBodystring (value); }
        }

        public interface IReviewRating : IValue {}
        public interface IReviewRating<T> : IReviewRating { new T Value { get; } }
        public class OneOrManyReviewRating : OneOrMany<IReviewRating>
        {
            public OneOrManyReviewRating(IReviewRating item) : base(item) { }
            public OneOrManyReviewRating(IEnumerable<IReviewRating> items) : base(items) { }
            public static implicit operator OneOrManyReviewRating (Rating value) { return new OneOrManyReviewRating (new ReviewRatingRating (value)); }
            public static implicit operator OneOrManyReviewRating (Rating[] values) { return new OneOrManyReviewRating (values.Select(v => (IReviewRating) new ReviewRatingRating (v))); }
            public static implicit operator OneOrManyReviewRating (List<Rating> values) { return new OneOrManyReviewRating (values.Select(v => (IReviewRating) new ReviewRatingRating (v))); }
        }
        public struct ReviewRatingRating : IReviewRating<Rating>
        {
            object IValue.Value => this.Value;
            public Rating Value { get; }
            public ReviewRatingRating (Rating value) { Value = value; }
            public static implicit operator ReviewRatingRating (Rating value) { return new ReviewRatingRating (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Review";

        /// <summary>
        /// The item that is being reviewed/rated.
        /// </summary>
        [DataMember(Name = "itemReviewed", Order = 206)]
        public OneOrManyItemReviewed ItemReviewed { get; set; }

        /// <summary>
        /// This Review or Rating is relevant to this part or facet of the itemReviewed.
        /// </summary>
        [DataMember(Name = "reviewAspect", Order = 207)]
        public OneOrManyReviewAspect ReviewAspect { get; set; }

        /// <summary>
        /// The actual body of the review.
        /// </summary>
        [DataMember(Name = "reviewBody", Order = 208)]
        public OneOrManyReviewBody ReviewBody { get; set; }

        /// <summary>
        /// The rating given in this review. Note that reviews can themselves be rated. The &lt;code&gt;reviewRating&lt;/code&gt; applies to rating given by the review. The &lt;a class="localLink" href="http://schema.org/aggregateRating"&gt;aggregateRating&lt;/a&gt; property applies to the review itself, as a creative work.
        /// </summary>
        [DataMember(Name = "reviewRating", Order = 209)]
        public OneOrManyReviewRating ReviewRating { get; set; }
    }
}

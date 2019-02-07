namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
    [DataContract]
    public partial class Brand : Intangible
    {
        public interface IAggregateRating : IValue {}
        public interface IAggregateRating<T> : IAggregateRating { new T Value { get; } }
        public class OneOrManyAggregateRating : OneOrMany<IAggregateRating>
        {
            public OneOrManyAggregateRating(IAggregateRating item) : base(item) { }
            public OneOrManyAggregateRating(IEnumerable<IAggregateRating> items) : base(items) { }
            public static implicit operator OneOrManyAggregateRating (AggregateRating value) { return new OneOrManyAggregateRating (new AggregateRatingAggregateRating (value)); }
            public static implicit operator OneOrManyAggregateRating (AggregateRating[] values) { return new OneOrManyAggregateRating (values.Select(v => (IAggregateRating) new AggregateRatingAggregateRating (v))); }
            public static implicit operator OneOrManyAggregateRating (List<AggregateRating> values) { return new OneOrManyAggregateRating (values.Select(v => (IAggregateRating) new AggregateRatingAggregateRating (v))); }
        }
        public struct AggregateRatingAggregateRating : IAggregateRating<AggregateRating>
        {
            object IValue.Value => this.Value;
            public AggregateRating Value { get; }
            public AggregateRatingAggregateRating (AggregateRating value) { Value = value; }
            public static implicit operator AggregateRatingAggregateRating (AggregateRating value) { return new AggregateRatingAggregateRating (value); }
        }

        public interface ILogo : IValue {}
        public interface ILogo<T> : ILogo { new T Value { get; } }
        public class OneOrManyLogo : OneOrMany<ILogo>
        {
            public OneOrManyLogo(ILogo item) : base(item) { }
            public OneOrManyLogo(IEnumerable<ILogo> items) : base(items) { }
            public static implicit operator OneOrManyLogo (ImageObject value) { return new OneOrManyLogo (new LogoImageObject (value)); }
            public static implicit operator OneOrManyLogo (ImageObject[] values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoImageObject (v))); }
            public static implicit operator OneOrManyLogo (List<ImageObject> values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoImageObject (v))); }
            public static implicit operator OneOrManyLogo (Uri value) { return new OneOrManyLogo (new LogoUri (value)); }
            public static implicit operator OneOrManyLogo (Uri[] values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoUri (v))); }
            public static implicit operator OneOrManyLogo (List<Uri> values) { return new OneOrManyLogo (values.Select(v => (ILogo) new LogoUri (v))); }
        }
        public struct LogoImageObject : ILogo<ImageObject>
        {
            object IValue.Value => this.Value;
            public ImageObject Value { get; }
            public LogoImageObject (ImageObject value) { Value = value; }
            public static implicit operator LogoImageObject (ImageObject value) { return new LogoImageObject (value); }
        }
        public struct LogoUri : ILogo<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public LogoUri (Uri value) { Value = value; }
            public static implicit operator LogoUri (Uri value) { return new LogoUri (value); }
        }

        public interface IReview : IValue {}
        public interface IReview<T> : IReview { new T Value { get; } }
        public class OneOrManyReview : OneOrMany<IReview>
        {
            public OneOrManyReview(IReview item) : base(item) { }
            public OneOrManyReview(IEnumerable<IReview> items) : base(items) { }
            public static implicit operator OneOrManyReview (Review value) { return new OneOrManyReview (new ReviewReview (value)); }
            public static implicit operator OneOrManyReview (Review[] values) { return new OneOrManyReview (values.Select(v => (IReview) new ReviewReview (v))); }
            public static implicit operator OneOrManyReview (List<Review> values) { return new OneOrManyReview (values.Select(v => (IReview) new ReviewReview (v))); }
        }
        public struct ReviewReview : IReview<Review>
        {
            object IValue.Value => this.Value;
            public Review Value { get; }
            public ReviewReview (Review value) { Value = value; }
            public static implicit operator ReviewReview (Review value) { return new ReviewReview (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Brand";

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 206)]
        public OneOrManyAggregateRating AggregateRating { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 207)]
        public OneOrManyLogo Logo { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 208)]
        public OneOrManyReview Review { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// </summary>
    [DataContract]
    public partial class Rating : Intangible
    {
        public interface IAuthor : IValue {}
        public interface IAuthor<T> : IAuthor { new T Value { get; } }
        public class OneOrManyAuthor : OneOrMany<IAuthor>
        {
            public OneOrManyAuthor(IAuthor item) : base(item) { }
            public OneOrManyAuthor(IEnumerable<IAuthor> items) : base(items) { }
            public static implicit operator OneOrManyAuthor (Organization value) { return new OneOrManyAuthor (new AuthorOrganization (value)); }
            public static implicit operator OneOrManyAuthor (Organization[] values) { return new OneOrManyAuthor (values.Select(v => (IAuthor) new AuthorOrganization (v))); }
            public static implicit operator OneOrManyAuthor (List<Organization> values) { return new OneOrManyAuthor (values.Select(v => (IAuthor) new AuthorOrganization (v))); }
            public static implicit operator OneOrManyAuthor (Person value) { return new OneOrManyAuthor (new AuthorPerson (value)); }
            public static implicit operator OneOrManyAuthor (Person[] values) { return new OneOrManyAuthor (values.Select(v => (IAuthor) new AuthorPerson (v))); }
            public static implicit operator OneOrManyAuthor (List<Person> values) { return new OneOrManyAuthor (values.Select(v => (IAuthor) new AuthorPerson (v))); }
        }
        public struct AuthorOrganization : IAuthor<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public AuthorOrganization (Organization value) { Value = value; }
            public static implicit operator AuthorOrganization (Organization value) { return new AuthorOrganization (value); }
        }
        public struct AuthorPerson : IAuthor<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public AuthorPerson (Person value) { Value = value; }
            public static implicit operator AuthorPerson (Person value) { return new AuthorPerson (value); }
        }

        public interface IBestRating : IValue {}
        public interface IBestRating<T> : IBestRating { new T Value { get; } }
        public class OneOrManyBestRating : OneOrMany<IBestRating>
        {
            public OneOrManyBestRating(IBestRating item) : base(item) { }
            public OneOrManyBestRating(IEnumerable<IBestRating> items) : base(items) { }
            public static implicit operator OneOrManyBestRating (double value) { return new OneOrManyBestRating (new BestRatingdouble (value)); }
            public static implicit operator OneOrManyBestRating (double[] values) { return new OneOrManyBestRating (values.Select(v => (IBestRating) new BestRatingdouble (v))); }
            public static implicit operator OneOrManyBestRating (List<double> values) { return new OneOrManyBestRating (values.Select(v => (IBestRating) new BestRatingdouble (v))); }
            public static implicit operator OneOrManyBestRating (string value) { return new OneOrManyBestRating (new BestRatingstring (value)); }
            public static implicit operator OneOrManyBestRating (string[] values) { return new OneOrManyBestRating (values.Select(v => (IBestRating) new BestRatingstring (v))); }
            public static implicit operator OneOrManyBestRating (List<string> values) { return new OneOrManyBestRating (values.Select(v => (IBestRating) new BestRatingstring (v))); }
        }
        public struct BestRatingdouble : IBestRating<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public BestRatingdouble (double value) { Value = value; }
            public static implicit operator BestRatingdouble (double value) { return new BestRatingdouble (value); }
        }
        public struct BestRatingstring : IBestRating<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BestRatingstring (string value) { Value = value; }
            public static implicit operator BestRatingstring (string value) { return new BestRatingstring (value); }
        }

        public interface IRatingValue : IValue {}
        public interface IRatingValue<T> : IRatingValue { new T Value { get; } }
        public class OneOrManyRatingValue : OneOrMany<IRatingValue>
        {
            public OneOrManyRatingValue(IRatingValue item) : base(item) { }
            public OneOrManyRatingValue(IEnumerable<IRatingValue> items) : base(items) { }
            public static implicit operator OneOrManyRatingValue (double value) { return new OneOrManyRatingValue (new RatingValuedouble (value)); }
            public static implicit operator OneOrManyRatingValue (double[] values) { return new OneOrManyRatingValue (values.Select(v => (IRatingValue) new RatingValuedouble (v))); }
            public static implicit operator OneOrManyRatingValue (List<double> values) { return new OneOrManyRatingValue (values.Select(v => (IRatingValue) new RatingValuedouble (v))); }
            public static implicit operator OneOrManyRatingValue (string value) { return new OneOrManyRatingValue (new RatingValuestring (value)); }
            public static implicit operator OneOrManyRatingValue (string[] values) { return new OneOrManyRatingValue (values.Select(v => (IRatingValue) new RatingValuestring (v))); }
            public static implicit operator OneOrManyRatingValue (List<string> values) { return new OneOrManyRatingValue (values.Select(v => (IRatingValue) new RatingValuestring (v))); }
        }
        public struct RatingValuedouble : IRatingValue<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public RatingValuedouble (double value) { Value = value; }
            public static implicit operator RatingValuedouble (double value) { return new RatingValuedouble (value); }
        }
        public struct RatingValuestring : IRatingValue<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public RatingValuestring (string value) { Value = value; }
            public static implicit operator RatingValuestring (string value) { return new RatingValuestring (value); }
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

        public interface IWorstRating : IValue {}
        public interface IWorstRating<T> : IWorstRating { new T Value { get; } }
        public class OneOrManyWorstRating : OneOrMany<IWorstRating>
        {
            public OneOrManyWorstRating(IWorstRating item) : base(item) { }
            public OneOrManyWorstRating(IEnumerable<IWorstRating> items) : base(items) { }
            public static implicit operator OneOrManyWorstRating (double value) { return new OneOrManyWorstRating (new WorstRatingdouble (value)); }
            public static implicit operator OneOrManyWorstRating (double[] values) { return new OneOrManyWorstRating (values.Select(v => (IWorstRating) new WorstRatingdouble (v))); }
            public static implicit operator OneOrManyWorstRating (List<double> values) { return new OneOrManyWorstRating (values.Select(v => (IWorstRating) new WorstRatingdouble (v))); }
            public static implicit operator OneOrManyWorstRating (string value) { return new OneOrManyWorstRating (new WorstRatingstring (value)); }
            public static implicit operator OneOrManyWorstRating (string[] values) { return new OneOrManyWorstRating (values.Select(v => (IWorstRating) new WorstRatingstring (v))); }
            public static implicit operator OneOrManyWorstRating (List<string> values) { return new OneOrManyWorstRating (values.Select(v => (IWorstRating) new WorstRatingstring (v))); }
        }
        public struct WorstRatingdouble : IWorstRating<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public WorstRatingdouble (double value) { Value = value; }
            public static implicit operator WorstRatingdouble (double value) { return new WorstRatingdouble (value); }
        }
        public struct WorstRatingstring : IWorstRating<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public WorstRatingstring (string value) { Value = value; }
            public static implicit operator WorstRatingstring (string value) { return new WorstRatingstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Rating";

        /// <summary>
        /// The author of this content or rating. Please note that author is special in that HTML 5 provides a special mechanism for indicating authorship via the rel tag. That is equivalent to this and may be used interchangeably.
        /// </summary>
        [DataMember(Name = "author", Order = 206)]
        public OneOrManyAuthor Author { get; set; }

        /// <summary>
        /// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
        /// </summary>
        [DataMember(Name = "bestRating", Order = 207)]
        public OneOrManyBestRating BestRating { get; set; }

        /// <summary>
        /// The rating for the content.
        /// </summary>
        [DataMember(Name = "ratingValue", Order = 208)]
        public OneOrManyRatingValue RatingValue { get; set; }

        /// <summary>
        /// This Review or Rating is relevant to this part or facet of the itemReviewed.
        /// </summary>
        [DataMember(Name = "reviewAspect", Order = 209)]
        public OneOrManyReviewAspect ReviewAspect { get; set; }

        /// <summary>
        /// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
        /// </summary>
        [DataMember(Name = "worstRating", Order = 210)]
        public OneOrManyWorstRating WorstRating { get; set; }
    }
}

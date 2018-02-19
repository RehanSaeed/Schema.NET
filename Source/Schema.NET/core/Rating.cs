using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A rating is an evaluation on a numeric scale, such as 1 to 5 stars.
    /// </summary>
    [DataContract]
    public partial class Rating : Intangible
    {
        public interface IAuthor : IWrapper { }
        public interface IAuthor<T> : IAuthor { new T Data { get; set; } }
        public class AuthorOrganization : IAuthor<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public AuthorOrganization () { }
            public AuthorOrganization (Organization data) { Data = data; }
            public static implicit operator AuthorOrganization (Organization data) { return new AuthorOrganization (data); }
        }

        public class AuthorPerson : IAuthor<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public AuthorPerson () { }
            public AuthorPerson (Person data) { Data = data; }
            public static implicit operator AuthorPerson (Person data) { return new AuthorPerson (data); }
        }


        public interface IBestRating : IWrapper { }
        public interface IBestRating<T> : IBestRating { new T Data { get; set; } }
        public class BestRatingdouble : IBestRating<double>
        {
            object IWrapper.Data { get { return Data; } set { Data = (double) value; } }
            public virtual double Data { get; set; }
            public BestRatingdouble () { }
            public BestRatingdouble (double data) { Data = data; }
            public static implicit operator BestRatingdouble (double data) { return new BestRatingdouble (data); }
        }

        public class BestRatingstring : IBestRating<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public BestRatingstring () { }
            public BestRatingstring (string data) { Data = data; }
            public static implicit operator BestRatingstring (string data) { return new BestRatingstring (data); }
        }


        public interface IRatingValue : IWrapper { }
        public interface IRatingValue<T> : IRatingValue { new T Data { get; set; } }
        public class RatingValuedouble : IRatingValue<double>
        {
            object IWrapper.Data { get { return Data; } set { Data = (double) value; } }
            public virtual double Data { get; set; }
            public RatingValuedouble () { }
            public RatingValuedouble (double data) { Data = data; }
            public static implicit operator RatingValuedouble (double data) { return new RatingValuedouble (data); }
        }

        public class RatingValuestring : IRatingValue<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public RatingValuestring () { }
            public RatingValuestring (string data) { Data = data; }
            public static implicit operator RatingValuestring (string data) { return new RatingValuestring (data); }
        }


        public interface IWorstRating : IWrapper { }
        public interface IWorstRating<T> : IWorstRating { new T Data { get; set; } }
        public class WorstRatingdouble : IWorstRating<double>
        {
            object IWrapper.Data { get { return Data; } set { Data = (double) value; } }
            public virtual double Data { get; set; }
            public WorstRatingdouble () { }
            public WorstRatingdouble (double data) { Data = data; }
            public static implicit operator WorstRatingdouble (double data) { return new WorstRatingdouble (data); }
        }

        public class WorstRatingstring : IWorstRating<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public WorstRatingstring () { }
            public WorstRatingstring (string data) { Data = data; }
            public static implicit operator WorstRatingstring (string data) { return new WorstRatingstring (data); }
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAuthor>? Author { get; set; } //Organization, Person

        /// <summary>
        /// The highest value allowed in this rating system. If bestRating is omitted, 5 is assumed.
        /// </summary>
        [DataMember(Name = "bestRating", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IBestRating>? BestRating { get; set; } //double?, string

        /// <summary>
        /// The rating for the content.
        /// </summary>
        [DataMember(Name = "ratingValue", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IRatingValue>? RatingValue { get; set; } //double?, string

        /// <summary>
        /// The lowest value allowed in this rating system. If worstRating is omitted, 1 is assumed.
        /// </summary>
        [DataMember(Name = "worstRating", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IWorstRating>? WorstRating { get; set; } //double?, string
    }
}

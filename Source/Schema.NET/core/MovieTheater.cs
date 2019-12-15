namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A movie theater.
    /// </summary>
    public partial interface IMovieTheater : ICivicStructureAndEntertainmentBusiness
    {
        /// <summary>
        /// The number of screens in the movie theater.
        /// </summary>
        OneOrMany<int?> ScreenCount { get; set; }
    }

    /// <summary>
    /// A movie theater.
    /// </summary>
    [DataContract]
    public partial class MovieTheater : CivicStructureAndEntertainmentBusiness, IMovieTheater, IEquatable<MovieTheater>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MovieTheater";

        /// <summary>
        /// The number of screens in the movie theater.
        /// </summary>
        [DataMember(Name = "screenCount", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> ScreenCount { get; set; }

        /// <inheritdoc/>
        public bool Equals(MovieTheater other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.ScreenCount == other.ScreenCount &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MovieTheater);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ScreenCount)
            .And(base.GetHashCode());
    }
}

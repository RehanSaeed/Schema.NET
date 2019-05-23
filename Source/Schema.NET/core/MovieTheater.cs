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
    public partial class MovieTheater : CivicStructureAndEntertainmentBusiness, IMovieTheater
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
    }
}

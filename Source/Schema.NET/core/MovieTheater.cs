namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A movie theater.
    /// </summary>
    [DataContract]
    public partial class MovieTheater : CivicStructureAndEntertainmentBusiness
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
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<int?>? ScreenCount { get; set; }
    }
}

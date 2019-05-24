namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Season dedicated to TV broadcast and associated online delivery.
    /// </summary>
    public partial interface ITVSeason : ICreativeWorkSeason
    {
        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        OneOrMany<ICountry> CountryOfOrigin { get; set; }
    }

    /// <summary>
    /// Season dedicated to TV broadcast and associated online delivery.
    /// </summary>
    [DataContract]
    public partial class TVSeason : CreativeWorkSeason, ITVSeason
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TVSeason";

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [DataMember(Name = "countryOfOrigin", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICountry> CountryOfOrigin { get; set; }
    }
}

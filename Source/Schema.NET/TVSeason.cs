namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Season dedicated to TV broadcast and associated online delivery.
    /// </summary>
    [DataContract]
    public class TVSeason : CreativeWorkSeason
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "TVSeason";

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [DataMember(Name = "countryOfOrigin")]
        public Country CountryOfOrigin { get; set; }
    }
}

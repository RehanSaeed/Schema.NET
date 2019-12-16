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
    public partial class TVSeason : CreativeWorkSeason, ITVSeason, IEquatable<TVSeason>
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

        /// <inheritdoc/>
        public bool Equals(TVSeason other)
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
                this.CountryOfOrigin == other.CountryOfOrigin &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as TVSeason);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.CountryOfOrigin)
            .And(base.GetHashCode());
    }
}

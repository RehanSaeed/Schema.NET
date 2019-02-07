namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Season dedicated to TV broadcast and associated online delivery.
    /// </summary>
    [DataContract]
    public partial class TVSeason : CreativeWorkSeason
    {
        public interface ICountryOfOrigin : IValue {}
        public interface ICountryOfOrigin<T> : ICountryOfOrigin { new T Value { get; } }
        public class OneOrManyCountryOfOrigin : OneOrMany<ICountryOfOrigin>
        {
            public OneOrManyCountryOfOrigin(ICountryOfOrigin item) : base(item) { }
            public OneOrManyCountryOfOrigin(IEnumerable<ICountryOfOrigin> items) : base(items) { }
            public static implicit operator OneOrManyCountryOfOrigin (Country value) { return new OneOrManyCountryOfOrigin (new CountryOfOriginCountry (value)); }
            public static implicit operator OneOrManyCountryOfOrigin (Country[] values) { return new OneOrManyCountryOfOrigin (values.Select(v => (ICountryOfOrigin) new CountryOfOriginCountry (v))); }
            public static implicit operator OneOrManyCountryOfOrigin (List<Country> values) { return new OneOrManyCountryOfOrigin (values.Select(v => (ICountryOfOrigin) new CountryOfOriginCountry (v))); }
        }
        public struct CountryOfOriginCountry : ICountryOfOrigin<Country>
        {
            object IValue.Value => this.Value;
            public Country Value { get; }
            public CountryOfOriginCountry (Country value) { Value = value; }
            public static implicit operator CountryOfOriginCountry (Country value) { return new CountryOfOriginCountry (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TVSeason";

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [DataMember(Name = "countryOfOrigin", Order = 306)]
        public OneOrManyCountryOfOrigin CountryOfOrigin { get; set; }
    }
}

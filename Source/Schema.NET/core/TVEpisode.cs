namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A TV episode which can be part of a series or season.
    /// </summary>
    [DataContract]
    public partial class TVEpisode : Episode
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

        public interface ISubtitleLanguage : IValue {}
        public interface ISubtitleLanguage<T> : ISubtitleLanguage { new T Value { get; } }
        public class OneOrManySubtitleLanguage : OneOrMany<ISubtitleLanguage>
        {
            public OneOrManySubtitleLanguage(ISubtitleLanguage item) : base(item) { }
            public OneOrManySubtitleLanguage(IEnumerable<ISubtitleLanguage> items) : base(items) { }
            public static implicit operator OneOrManySubtitleLanguage (Language value) { return new OneOrManySubtitleLanguage (new SubtitleLanguageLanguage (value)); }
            public static implicit operator OneOrManySubtitleLanguage (Language[] values) { return new OneOrManySubtitleLanguage (values.Select(v => (ISubtitleLanguage) new SubtitleLanguageLanguage (v))); }
            public static implicit operator OneOrManySubtitleLanguage (List<Language> values) { return new OneOrManySubtitleLanguage (values.Select(v => (ISubtitleLanguage) new SubtitleLanguageLanguage (v))); }
            public static implicit operator OneOrManySubtitleLanguage (string value) { return new OneOrManySubtitleLanguage (new SubtitleLanguagestring (value)); }
            public static implicit operator OneOrManySubtitleLanguage (string[] values) { return new OneOrManySubtitleLanguage (values.Select(v => (ISubtitleLanguage) new SubtitleLanguagestring (v))); }
            public static implicit operator OneOrManySubtitleLanguage (List<string> values) { return new OneOrManySubtitleLanguage (values.Select(v => (ISubtitleLanguage) new SubtitleLanguagestring (v))); }
        }
        public struct SubtitleLanguageLanguage : ISubtitleLanguage<Language>
        {
            object IValue.Value => this.Value;
            public Language Value { get; }
            public SubtitleLanguageLanguage (Language value) { Value = value; }
            public static implicit operator SubtitleLanguageLanguage (Language value) { return new SubtitleLanguageLanguage (value); }
        }
        public struct SubtitleLanguagestring : ISubtitleLanguage<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SubtitleLanguagestring (string value) { Value = value; }
            public static implicit operator SubtitleLanguagestring (string value) { return new SubtitleLanguagestring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TVEpisode";

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [DataMember(Name = "countryOfOrigin", Order = 306)]
        public OneOrManyCountryOfOrigin CountryOfOrigin { get; set; }

        /// <summary>
        /// Languages in which subtitles/captions are available, in &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "subtitleLanguage", Order = 307)]
        public OneOrManySubtitleLanguage SubtitleLanguage { get; set; }
    }
}

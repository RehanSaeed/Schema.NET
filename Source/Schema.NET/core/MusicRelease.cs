using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
    [DataContract]
    public partial class MusicRelease : MusicPlaylist
    {
        public interface ICreditedTo : IWrapper { }
        public interface ICreditedTo<T> : ICreditedTo { new T Data { get; set; } }
        public class CreditedToOrganization : ICreditedTo<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public CreditedToOrganization () { }
            public CreditedToOrganization (Organization data) { Data = data; }
            public static implicit operator CreditedToOrganization (Organization data) { return new CreditedToOrganization (data); }
        }

        public class CreditedToPerson : ICreditedTo<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public CreditedToPerson () { }
            public CreditedToPerson (Person data) { Data = data; }
            public static implicit operator CreditedToPerson (Person data) { return new CreditedToPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicRelease";

        /// <summary>
        /// The catalog number for the release.
        /// </summary>
        [DataMember(Name = "catalogNumber", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? CatalogNumber { get; set; } 

        /// <summary>
        /// The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.
        /// </summary>
        [DataMember(Name = "creditedTo", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ICreditedTo>? CreditedTo { get; set; } //Organization, Person

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 308)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan>? Duration { get; set; } 

        /// <summary>
        /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
        /// </summary>
        [DataMember(Name = "musicReleaseFormat", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MusicReleaseFormatType>? MusicReleaseFormat { get; set; } 

        /// <summary>
        /// The label that issued the release.
        /// </summary>
        [DataMember(Name = "recordLabel", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? RecordLabel { get; set; } 

        /// <summary>
        /// The album this is a release of.
        /// </summary>
        [DataMember(Name = "releaseOf", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MusicAlbum>? ReleaseOf { get; set; } 
    }
}

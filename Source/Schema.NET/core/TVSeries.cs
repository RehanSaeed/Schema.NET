using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// CreativeWorkSeries dedicated to TV broadcast and associated online delivery.
    /// </summary>
    [DataContract]
    public partial class TVSeries : CreativeWorkSeries
    {
        public interface IMusicBy : IWrapper { }
        public interface IMusicBy<T> : IMusicBy { new T Data { get; set; } }
        public class MusicByMusicGroup : IMusicBy<MusicGroup>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MusicGroup) value; } }
            public virtual MusicGroup Data { get; set; }
            public MusicByMusicGroup () { }
            public MusicByMusicGroup (MusicGroup data) { Data = data; }
            public static implicit operator MusicByMusicGroup (MusicGroup data) { return new MusicByMusicGroup (data); }
        }

        public class MusicByPerson : IMusicBy<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public MusicByPerson () { }
            public MusicByPerson (Person data) { Data = data; }
            public static implicit operator MusicByPerson (Person data) { return new MusicByPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TVSeries";

        /// <summary>
        /// An actor, e.g. in tv, radio, movie, video games etc., or in an event. Actors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "actor", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Actor { get; set; } 

        /// <summary>
        /// A season that is part of the media series.
        /// </summary>
        [DataMember(Name = "containsSeason", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWorkSeason>? ContainsSeason { get; set; } 

        /// <summary>
        /// The country of the principal offices of the production company or individual responsible for the movie or program.
        /// </summary>
        [DataMember(Name = "countryOfOrigin", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Country>? CountryOfOrigin { get; set; } 

        /// <summary>
        /// A director of e.g. tv, radio, movie, video gaming etc. content, or of an event. Directors can be associated with individual items or with a series, episode, clip.
        /// </summary>
        [DataMember(Name = "director", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Director { get; set; } 

        /// <summary>
        /// An episode of a tv, radio or game media within a series or season.
        /// </summary>
        [DataMember(Name = "episode", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Episode>? Episode { get; set; } 

        /// <summary>
        /// The composer of the soundtrack.
        /// </summary>
        [DataMember(Name = "musicBy", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMusicBy>? MusicBy { get; set; } //MusicGroup, Person

        /// <summary>
        /// The number of episodes in this season or series.
        /// </summary>
        [DataMember(Name = "numberOfEpisodes", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int>? NumberOfEpisodes { get; set; } 

        /// <summary>
        /// The number of seasons in this series.
        /// </summary>
        [DataMember(Name = "numberOfSeasons", Order = 313)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int>? NumberOfSeasons { get; set; } 

        /// <summary>
        /// The production company or studio responsible for the item e.g. series, video game, episode etc.
        /// </summary>
        [DataMember(Name = "productionCompany", Order = 314)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? ProductionCompany { get; set; } 

        /// <summary>
        /// The trailer of a movie or tv/radio series, season, episode, etc.
        /// </summary>
        [DataMember(Name = "trailer", Order = 315)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<VideoObject>? Trailer { get; set; } 
    }
}

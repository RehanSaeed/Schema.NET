using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A musical composition.
    /// </summary>
    [DataContract]
    public partial class MusicComposition : CreativeWork
    {
        public interface IComposer : IWrapper { }
        public interface IComposer<T> : IComposer { new T Data { get; set; } }
        public class ComposerOrganization : IComposer<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public ComposerOrganization () { }
            public ComposerOrganization (Organization data) { Data = data; }
            public static implicit operator ComposerOrganization (Organization data) { return new ComposerOrganization (data); }
        }

        public class ComposerPerson : IComposer<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public ComposerPerson () { }
            public ComposerPerson (Person data) { Data = data; }
            public static implicit operator ComposerPerson (Person data) { return new ComposerPerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicComposition";

        /// <summary>
        /// The person or organization who wrote a composition, or who is the composer of a work performed at some event.
        /// </summary>
        [DataMember(Name = "composer", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IComposer>? Composer { get; set; } //Organization, Person

        /// <summary>
        /// The date and place the work was first performed.
        /// </summary>
        [DataMember(Name = "firstPerformance", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Event>? FirstPerformance { get; set; } 

        /// <summary>
        /// Smaller compositions included in this work (e.g. a movement in a symphony).
        /// </summary>
        [DataMember(Name = "includedComposition", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MusicComposition>? IncludedComposition { get; set; } 

        /// <summary>
        /// The International Standard Musical Work Code for the composition.
        /// </summary>
        [DataMember(Name = "iswcCode", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? IswcCode { get; set; } 

        /// <summary>
        /// The person who wrote the words.
        /// </summary>
        [DataMember(Name = "lyricist", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Lyricist { get; set; } 

        /// <summary>
        /// The words in the song.
        /// </summary>
        [DataMember(Name = "lyrics", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? Lyrics { get; set; } 

        /// <summary>
        /// The key, mode, or scale this composition uses.
        /// </summary>
        [DataMember(Name = "musicalKey", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? MusicalKey { get; set; } 

        /// <summary>
        /// An arrangement derived from the composition.
        /// </summary>
        [DataMember(Name = "musicArrangement", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MusicComposition>? MusicArrangement { get; set; } 

        /// <summary>
        /// The type of composition (e.g. overture, sonata, symphony, etc.).
        /// </summary>
        [DataMember(Name = "musicCompositionForm", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? MusicCompositionForm { get; set; } 

        /// <summary>
        /// An audio recording of the work.
        /// </summary>
        [DataMember(Name = "recordedAs", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MusicRecording>? RecordedAs { get; set; } 
    }
}

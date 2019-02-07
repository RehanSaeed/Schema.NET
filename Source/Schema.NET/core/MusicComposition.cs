namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A musical composition.
    /// </summary>
    [DataContract]
    public partial class MusicComposition : CreativeWork
    {
        public interface IComposer : IValue {}
        public interface IComposer<T> : IComposer { new T Value { get; } }
        public class OneOrManyComposer : OneOrMany<IComposer>
        {
            public OneOrManyComposer(IComposer item) : base(item) { }
            public OneOrManyComposer(IEnumerable<IComposer> items) : base(items) { }
            public static implicit operator OneOrManyComposer (Organization value) { return new OneOrManyComposer (new ComposerOrganization (value)); }
            public static implicit operator OneOrManyComposer (Organization[] values) { return new OneOrManyComposer (values.Select(v => (IComposer) new ComposerOrganization (v))); }
            public static implicit operator OneOrManyComposer (List<Organization> values) { return new OneOrManyComposer (values.Select(v => (IComposer) new ComposerOrganization (v))); }
            public static implicit operator OneOrManyComposer (Person value) { return new OneOrManyComposer (new ComposerPerson (value)); }
            public static implicit operator OneOrManyComposer (Person[] values) { return new OneOrManyComposer (values.Select(v => (IComposer) new ComposerPerson (v))); }
            public static implicit operator OneOrManyComposer (List<Person> values) { return new OneOrManyComposer (values.Select(v => (IComposer) new ComposerPerson (v))); }
        }
        public struct ComposerOrganization : IComposer<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public ComposerOrganization (Organization value) { Value = value; }
            public static implicit operator ComposerOrganization (Organization value) { return new ComposerOrganization (value); }
        }
        public struct ComposerPerson : IComposer<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ComposerPerson (Person value) { Value = value; }
            public static implicit operator ComposerPerson (Person value) { return new ComposerPerson (value); }
        }

        public interface IFirstPerformance : IValue {}
        public interface IFirstPerformance<T> : IFirstPerformance { new T Value { get; } }
        public class OneOrManyFirstPerformance : OneOrMany<IFirstPerformance>
        {
            public OneOrManyFirstPerformance(IFirstPerformance item) : base(item) { }
            public OneOrManyFirstPerformance(IEnumerable<IFirstPerformance> items) : base(items) { }
            public static implicit operator OneOrManyFirstPerformance (Event value) { return new OneOrManyFirstPerformance (new FirstPerformanceEvent (value)); }
            public static implicit operator OneOrManyFirstPerformance (Event[] values) { return new OneOrManyFirstPerformance (values.Select(v => (IFirstPerformance) new FirstPerformanceEvent (v))); }
            public static implicit operator OneOrManyFirstPerformance (List<Event> values) { return new OneOrManyFirstPerformance (values.Select(v => (IFirstPerformance) new FirstPerformanceEvent (v))); }
        }
        public struct FirstPerformanceEvent : IFirstPerformance<Event>
        {
            object IValue.Value => this.Value;
            public Event Value { get; }
            public FirstPerformanceEvent (Event value) { Value = value; }
            public static implicit operator FirstPerformanceEvent (Event value) { return new FirstPerformanceEvent (value); }
        }

        public interface IIncludedComposition : IValue {}
        public interface IIncludedComposition<T> : IIncludedComposition { new T Value { get; } }
        public class OneOrManyIncludedComposition : OneOrMany<IIncludedComposition>
        {
            public OneOrManyIncludedComposition(IIncludedComposition item) : base(item) { }
            public OneOrManyIncludedComposition(IEnumerable<IIncludedComposition> items) : base(items) { }
            public static implicit operator OneOrManyIncludedComposition (MusicComposition value) { return new OneOrManyIncludedComposition (new IncludedCompositionMusicComposition (value)); }
            public static implicit operator OneOrManyIncludedComposition (MusicComposition[] values) { return new OneOrManyIncludedComposition (values.Select(v => (IIncludedComposition) new IncludedCompositionMusicComposition (v))); }
            public static implicit operator OneOrManyIncludedComposition (List<MusicComposition> values) { return new OneOrManyIncludedComposition (values.Select(v => (IIncludedComposition) new IncludedCompositionMusicComposition (v))); }
        }
        public struct IncludedCompositionMusicComposition : IIncludedComposition<MusicComposition>
        {
            object IValue.Value => this.Value;
            public MusicComposition Value { get; }
            public IncludedCompositionMusicComposition (MusicComposition value) { Value = value; }
            public static implicit operator IncludedCompositionMusicComposition (MusicComposition value) { return new IncludedCompositionMusicComposition (value); }
        }

        public interface IIswcCode : IValue {}
        public interface IIswcCode<T> : IIswcCode { new T Value { get; } }
        public class OneOrManyIswcCode : OneOrMany<IIswcCode>
        {
            public OneOrManyIswcCode(IIswcCode item) : base(item) { }
            public OneOrManyIswcCode(IEnumerable<IIswcCode> items) : base(items) { }
            public static implicit operator OneOrManyIswcCode (string value) { return new OneOrManyIswcCode (new IswcCodestring (value)); }
            public static implicit operator OneOrManyIswcCode (string[] values) { return new OneOrManyIswcCode (values.Select(v => (IIswcCode) new IswcCodestring (v))); }
            public static implicit operator OneOrManyIswcCode (List<string> values) { return new OneOrManyIswcCode (values.Select(v => (IIswcCode) new IswcCodestring (v))); }
        }
        public struct IswcCodestring : IIswcCode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public IswcCodestring (string value) { Value = value; }
            public static implicit operator IswcCodestring (string value) { return new IswcCodestring (value); }
        }

        public interface ILyricist : IValue {}
        public interface ILyricist<T> : ILyricist { new T Value { get; } }
        public class OneOrManyLyricist : OneOrMany<ILyricist>
        {
            public OneOrManyLyricist(ILyricist item) : base(item) { }
            public OneOrManyLyricist(IEnumerable<ILyricist> items) : base(items) { }
            public static implicit operator OneOrManyLyricist (Person value) { return new OneOrManyLyricist (new LyricistPerson (value)); }
            public static implicit operator OneOrManyLyricist (Person[] values) { return new OneOrManyLyricist (values.Select(v => (ILyricist) new LyricistPerson (v))); }
            public static implicit operator OneOrManyLyricist (List<Person> values) { return new OneOrManyLyricist (values.Select(v => (ILyricist) new LyricistPerson (v))); }
        }
        public struct LyricistPerson : ILyricist<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public LyricistPerson (Person value) { Value = value; }
            public static implicit operator LyricistPerson (Person value) { return new LyricistPerson (value); }
        }

        public interface ILyrics : IValue {}
        public interface ILyrics<T> : ILyrics { new T Value { get; } }
        public class OneOrManyLyrics : OneOrMany<ILyrics>
        {
            public OneOrManyLyrics(ILyrics item) : base(item) { }
            public OneOrManyLyrics(IEnumerable<ILyrics> items) : base(items) { }
            public static implicit operator OneOrManyLyrics (CreativeWork value) { return new OneOrManyLyrics (new LyricsCreativeWork (value)); }
            public static implicit operator OneOrManyLyrics (CreativeWork[] values) { return new OneOrManyLyrics (values.Select(v => (ILyrics) new LyricsCreativeWork (v))); }
            public static implicit operator OneOrManyLyrics (List<CreativeWork> values) { return new OneOrManyLyrics (values.Select(v => (ILyrics) new LyricsCreativeWork (v))); }
        }
        public struct LyricsCreativeWork : ILyrics<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public LyricsCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator LyricsCreativeWork (CreativeWork value) { return new LyricsCreativeWork (value); }
        }

        public interface IMusicalKey : IValue {}
        public interface IMusicalKey<T> : IMusicalKey { new T Value { get; } }
        public class OneOrManyMusicalKey : OneOrMany<IMusicalKey>
        {
            public OneOrManyMusicalKey(IMusicalKey item) : base(item) { }
            public OneOrManyMusicalKey(IEnumerable<IMusicalKey> items) : base(items) { }
            public static implicit operator OneOrManyMusicalKey (string value) { return new OneOrManyMusicalKey (new MusicalKeystring (value)); }
            public static implicit operator OneOrManyMusicalKey (string[] values) { return new OneOrManyMusicalKey (values.Select(v => (IMusicalKey) new MusicalKeystring (v))); }
            public static implicit operator OneOrManyMusicalKey (List<string> values) { return new OneOrManyMusicalKey (values.Select(v => (IMusicalKey) new MusicalKeystring (v))); }
        }
        public struct MusicalKeystring : IMusicalKey<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public MusicalKeystring (string value) { Value = value; }
            public static implicit operator MusicalKeystring (string value) { return new MusicalKeystring (value); }
        }

        public interface IMusicArrangement : IValue {}
        public interface IMusicArrangement<T> : IMusicArrangement { new T Value { get; } }
        public class OneOrManyMusicArrangement : OneOrMany<IMusicArrangement>
        {
            public OneOrManyMusicArrangement(IMusicArrangement item) : base(item) { }
            public OneOrManyMusicArrangement(IEnumerable<IMusicArrangement> items) : base(items) { }
            public static implicit operator OneOrManyMusicArrangement (MusicComposition value) { return new OneOrManyMusicArrangement (new MusicArrangementMusicComposition (value)); }
            public static implicit operator OneOrManyMusicArrangement (MusicComposition[] values) { return new OneOrManyMusicArrangement (values.Select(v => (IMusicArrangement) new MusicArrangementMusicComposition (v))); }
            public static implicit operator OneOrManyMusicArrangement (List<MusicComposition> values) { return new OneOrManyMusicArrangement (values.Select(v => (IMusicArrangement) new MusicArrangementMusicComposition (v))); }
        }
        public struct MusicArrangementMusicComposition : IMusicArrangement<MusicComposition>
        {
            object IValue.Value => this.Value;
            public MusicComposition Value { get; }
            public MusicArrangementMusicComposition (MusicComposition value) { Value = value; }
            public static implicit operator MusicArrangementMusicComposition (MusicComposition value) { return new MusicArrangementMusicComposition (value); }
        }

        public interface IMusicCompositionForm : IValue {}
        public interface IMusicCompositionForm<T> : IMusicCompositionForm { new T Value { get; } }
        public class OneOrManyMusicCompositionForm : OneOrMany<IMusicCompositionForm>
        {
            public OneOrManyMusicCompositionForm(IMusicCompositionForm item) : base(item) { }
            public OneOrManyMusicCompositionForm(IEnumerable<IMusicCompositionForm> items) : base(items) { }
            public static implicit operator OneOrManyMusicCompositionForm (string value) { return new OneOrManyMusicCompositionForm (new MusicCompositionFormstring (value)); }
            public static implicit operator OneOrManyMusicCompositionForm (string[] values) { return new OneOrManyMusicCompositionForm (values.Select(v => (IMusicCompositionForm) new MusicCompositionFormstring (v))); }
            public static implicit operator OneOrManyMusicCompositionForm (List<string> values) { return new OneOrManyMusicCompositionForm (values.Select(v => (IMusicCompositionForm) new MusicCompositionFormstring (v))); }
        }
        public struct MusicCompositionFormstring : IMusicCompositionForm<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public MusicCompositionFormstring (string value) { Value = value; }
            public static implicit operator MusicCompositionFormstring (string value) { return new MusicCompositionFormstring (value); }
        }

        public interface IRecordedAs : IValue {}
        public interface IRecordedAs<T> : IRecordedAs { new T Value { get; } }
        public class OneOrManyRecordedAs : OneOrMany<IRecordedAs>
        {
            public OneOrManyRecordedAs(IRecordedAs item) : base(item) { }
            public OneOrManyRecordedAs(IEnumerable<IRecordedAs> items) : base(items) { }
            public static implicit operator OneOrManyRecordedAs (MusicRecording value) { return new OneOrManyRecordedAs (new RecordedAsMusicRecording (value)); }
            public static implicit operator OneOrManyRecordedAs (MusicRecording[] values) { return new OneOrManyRecordedAs (values.Select(v => (IRecordedAs) new RecordedAsMusicRecording (v))); }
            public static implicit operator OneOrManyRecordedAs (List<MusicRecording> values) { return new OneOrManyRecordedAs (values.Select(v => (IRecordedAs) new RecordedAsMusicRecording (v))); }
        }
        public struct RecordedAsMusicRecording : IRecordedAs<MusicRecording>
        {
            object IValue.Value => this.Value;
            public MusicRecording Value { get; }
            public RecordedAsMusicRecording (MusicRecording value) { Value = value; }
            public static implicit operator RecordedAsMusicRecording (MusicRecording value) { return new RecordedAsMusicRecording (value); }
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
        public OneOrManyComposer Composer { get; set; }

        /// <summary>
        /// The date and place the work was first performed.
        /// </summary>
        [DataMember(Name = "firstPerformance", Order = 207)]
        public OneOrManyFirstPerformance FirstPerformance { get; set; }

        /// <summary>
        /// Smaller compositions included in this work (e.g. a movement in a symphony).
        /// </summary>
        [DataMember(Name = "includedComposition", Order = 208)]
        public OneOrManyIncludedComposition IncludedComposition { get; set; }

        /// <summary>
        /// The International Standard Musical Work Code for the composition.
        /// </summary>
        [DataMember(Name = "iswcCode", Order = 209)]
        public OneOrManyIswcCode IswcCode { get; set; }

        /// <summary>
        /// The person who wrote the words.
        /// </summary>
        [DataMember(Name = "lyricist", Order = 210)]
        public OneOrManyLyricist Lyricist { get; set; }

        /// <summary>
        /// The words in the song.
        /// </summary>
        [DataMember(Name = "lyrics", Order = 211)]
        public OneOrManyLyrics Lyrics { get; set; }

        /// <summary>
        /// The key, mode, or scale this composition uses.
        /// </summary>
        [DataMember(Name = "musicalKey", Order = 212)]
        public OneOrManyMusicalKey MusicalKey { get; set; }

        /// <summary>
        /// An arrangement derived from the composition.
        /// </summary>
        [DataMember(Name = "musicArrangement", Order = 213)]
        public OneOrManyMusicArrangement MusicArrangement { get; set; }

        /// <summary>
        /// The type of composition (e.g. overture, sonata, symphony, etc.).
        /// </summary>
        [DataMember(Name = "musicCompositionForm", Order = 214)]
        public OneOrManyMusicCompositionForm MusicCompositionForm { get; set; }

        /// <summary>
        /// An audio recording of the work.
        /// </summary>
        [DataMember(Name = "recordedAs", Order = 215)]
        public OneOrManyRecordedAs RecordedAs { get; set; }
    }
}

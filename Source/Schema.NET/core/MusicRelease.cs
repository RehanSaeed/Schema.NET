namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A MusicRelease is a specific release of a music album.
    /// </summary>
    [DataContract]
    public partial class MusicRelease : MusicPlaylist
    {
        public interface ICatalogNumber : IValue {}
        public interface ICatalogNumber<T> : ICatalogNumber { new T Value { get; } }
        public class OneOrManyCatalogNumber : OneOrMany<ICatalogNumber>
        {
            public OneOrManyCatalogNumber(ICatalogNumber item) : base(item) { }
            public OneOrManyCatalogNumber(IEnumerable<ICatalogNumber> items) : base(items) { }
            public static implicit operator OneOrManyCatalogNumber (string value) { return new OneOrManyCatalogNumber (new CatalogNumberstring (value)); }
            public static implicit operator OneOrManyCatalogNumber (string[] values) { return new OneOrManyCatalogNumber (values.Select(v => (ICatalogNumber) new CatalogNumberstring (v))); }
            public static implicit operator OneOrManyCatalogNumber (List<string> values) { return new OneOrManyCatalogNumber (values.Select(v => (ICatalogNumber) new CatalogNumberstring (v))); }
        }
        public struct CatalogNumberstring : ICatalogNumber<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CatalogNumberstring (string value) { Value = value; }
            public static implicit operator CatalogNumberstring (string value) { return new CatalogNumberstring (value); }
        }

        public interface ICreditedTo : IValue {}
        public interface ICreditedTo<T> : ICreditedTo { new T Value { get; } }
        public class OneOrManyCreditedTo : OneOrMany<ICreditedTo>
        {
            public OneOrManyCreditedTo(ICreditedTo item) : base(item) { }
            public OneOrManyCreditedTo(IEnumerable<ICreditedTo> items) : base(items) { }
            public static implicit operator OneOrManyCreditedTo (Organization value) { return new OneOrManyCreditedTo (new CreditedToOrganization (value)); }
            public static implicit operator OneOrManyCreditedTo (Organization[] values) { return new OneOrManyCreditedTo (values.Select(v => (ICreditedTo) new CreditedToOrganization (v))); }
            public static implicit operator OneOrManyCreditedTo (List<Organization> values) { return new OneOrManyCreditedTo (values.Select(v => (ICreditedTo) new CreditedToOrganization (v))); }
            public static implicit operator OneOrManyCreditedTo (Person value) { return new OneOrManyCreditedTo (new CreditedToPerson (value)); }
            public static implicit operator OneOrManyCreditedTo (Person[] values) { return new OneOrManyCreditedTo (values.Select(v => (ICreditedTo) new CreditedToPerson (v))); }
            public static implicit operator OneOrManyCreditedTo (List<Person> values) { return new OneOrManyCreditedTo (values.Select(v => (ICreditedTo) new CreditedToPerson (v))); }
        }
        public struct CreditedToOrganization : ICreditedTo<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public CreditedToOrganization (Organization value) { Value = value; }
            public static implicit operator CreditedToOrganization (Organization value) { return new CreditedToOrganization (value); }
        }
        public struct CreditedToPerson : ICreditedTo<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public CreditedToPerson (Person value) { Value = value; }
            public static implicit operator CreditedToPerson (Person value) { return new CreditedToPerson (value); }
        }

        public interface IDuration : IValue {}
        public interface IDuration<T> : IDuration { new T Value { get; } }
        public class OneOrManyDuration : OneOrMany<IDuration>
        {
            public OneOrManyDuration(IDuration item) : base(item) { }
            public OneOrManyDuration(IEnumerable<IDuration> items) : base(items) { }
            public static implicit operator OneOrManyDuration (TimeSpan value) { return new OneOrManyDuration (new DurationTimeSpan (value)); }
            public static implicit operator OneOrManyDuration (TimeSpan[] values) { return new OneOrManyDuration (values.Select(v => (IDuration) new DurationTimeSpan (v))); }
            public static implicit operator OneOrManyDuration (List<TimeSpan> values) { return new OneOrManyDuration (values.Select(v => (IDuration) new DurationTimeSpan (v))); }
        }
        public struct DurationTimeSpan : IDuration<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public DurationTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator DurationTimeSpan (TimeSpan value) { return new DurationTimeSpan (value); }
        }

        public interface IMusicReleaseFormat : IValue {}
        public interface IMusicReleaseFormat<T> : IMusicReleaseFormat { new T Value { get; } }
        public class OneOrManyMusicReleaseFormat : OneOrMany<IMusicReleaseFormat>
        {
            public OneOrManyMusicReleaseFormat(IMusicReleaseFormat item) : base(item) { }
            public OneOrManyMusicReleaseFormat(IEnumerable<IMusicReleaseFormat> items) : base(items) { }
            public static implicit operator OneOrManyMusicReleaseFormat (MusicReleaseFormatType value) { return new OneOrManyMusicReleaseFormat (new MusicReleaseFormatMusicReleaseFormatType (value)); }
            public static implicit operator OneOrManyMusicReleaseFormat (MusicReleaseFormatType[] values) { return new OneOrManyMusicReleaseFormat (values.Select(v => (IMusicReleaseFormat) new MusicReleaseFormatMusicReleaseFormatType (v))); }
            public static implicit operator OneOrManyMusicReleaseFormat (List<MusicReleaseFormatType> values) { return new OneOrManyMusicReleaseFormat (values.Select(v => (IMusicReleaseFormat) new MusicReleaseFormatMusicReleaseFormatType (v))); }
        }
        public struct MusicReleaseFormatMusicReleaseFormatType : IMusicReleaseFormat<MusicReleaseFormatType>
        {
            object IValue.Value => this.Value;
            public MusicReleaseFormatType Value { get; }
            public MusicReleaseFormatMusicReleaseFormatType (MusicReleaseFormatType value) { Value = value; }
            public static implicit operator MusicReleaseFormatMusicReleaseFormatType (MusicReleaseFormatType value) { return new MusicReleaseFormatMusicReleaseFormatType (value); }
        }

        public interface IRecordLabel : IValue {}
        public interface IRecordLabel<T> : IRecordLabel { new T Value { get; } }
        public class OneOrManyRecordLabel : OneOrMany<IRecordLabel>
        {
            public OneOrManyRecordLabel(IRecordLabel item) : base(item) { }
            public OneOrManyRecordLabel(IEnumerable<IRecordLabel> items) : base(items) { }
            public static implicit operator OneOrManyRecordLabel (Organization value) { return new OneOrManyRecordLabel (new RecordLabelOrganization (value)); }
            public static implicit operator OneOrManyRecordLabel (Organization[] values) { return new OneOrManyRecordLabel (values.Select(v => (IRecordLabel) new RecordLabelOrganization (v))); }
            public static implicit operator OneOrManyRecordLabel (List<Organization> values) { return new OneOrManyRecordLabel (values.Select(v => (IRecordLabel) new RecordLabelOrganization (v))); }
        }
        public struct RecordLabelOrganization : IRecordLabel<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public RecordLabelOrganization (Organization value) { Value = value; }
            public static implicit operator RecordLabelOrganization (Organization value) { return new RecordLabelOrganization (value); }
        }

        public interface IReleaseOf : IValue {}
        public interface IReleaseOf<T> : IReleaseOf { new T Value { get; } }
        public class OneOrManyReleaseOf : OneOrMany<IReleaseOf>
        {
            public OneOrManyReleaseOf(IReleaseOf item) : base(item) { }
            public OneOrManyReleaseOf(IEnumerable<IReleaseOf> items) : base(items) { }
            public static implicit operator OneOrManyReleaseOf (MusicAlbum value) { return new OneOrManyReleaseOf (new ReleaseOfMusicAlbum (value)); }
            public static implicit operator OneOrManyReleaseOf (MusicAlbum[] values) { return new OneOrManyReleaseOf (values.Select(v => (IReleaseOf) new ReleaseOfMusicAlbum (v))); }
            public static implicit operator OneOrManyReleaseOf (List<MusicAlbum> values) { return new OneOrManyReleaseOf (values.Select(v => (IReleaseOf) new ReleaseOfMusicAlbum (v))); }
        }
        public struct ReleaseOfMusicAlbum : IReleaseOf<MusicAlbum>
        {
            object IValue.Value => this.Value;
            public MusicAlbum Value { get; }
            public ReleaseOfMusicAlbum (MusicAlbum value) { Value = value; }
            public static implicit operator ReleaseOfMusicAlbum (MusicAlbum value) { return new ReleaseOfMusicAlbum (value); }
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
        public OneOrManyCatalogNumber CatalogNumber { get; set; }

        /// <summary>
        /// The group the release is credited to if different than the byArtist. For example, Red and Blue is credited to "Stefani Germanotta Band", but by Lady Gaga.
        /// </summary>
        [DataMember(Name = "creditedTo", Order = 307)]
        public OneOrManyCreditedTo CreditedTo { get; set; }

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 308)]
        public OneOrManyDuration Duration { get; set; }

        /// <summary>
        /// Format of this release (the type of recording media used, ie. compact disc, digital media, LP, etc.).
        /// </summary>
        [DataMember(Name = "musicReleaseFormat", Order = 309)]
        public OneOrManyMusicReleaseFormat MusicReleaseFormat { get; set; }

        /// <summary>
        /// The label that issued the release.
        /// </summary>
        [DataMember(Name = "recordLabel", Order = 310)]
        public OneOrManyRecordLabel RecordLabel { get; set; }

        /// <summary>
        /// The album this is a release of.
        /// </summary>
        [DataMember(Name = "releaseOf", Order = 311)]
        public OneOrManyReleaseOf ReleaseOf { get; set; }
    }
}

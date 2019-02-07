namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Individual comic issues are serially published as
    ///     part of a larger series. For the sake of consistency, even one-shot issues
    ///     belong to a series comprised of a single issue. All comic issues can be
    ///     uniquely identified by: the combination of the name and volume number of the
    ///     series to which the issue belongs; the issue number; and the variant
    ///     description of the issue (if any).
    /// </summary>
    [DataContract]
    public partial class ComicIssue : PublicationIssue
    {
        public interface IArtist : IValue {}
        public interface IArtist<T> : IArtist { new T Value { get; } }
        public class OneOrManyArtist : OneOrMany<IArtist>
        {
            public OneOrManyArtist(IArtist item) : base(item) { }
            public OneOrManyArtist(IEnumerable<IArtist> items) : base(items) { }
            public static implicit operator OneOrManyArtist (Person value) { return new OneOrManyArtist (new ArtistPerson (value)); }
            public static implicit operator OneOrManyArtist (Person[] values) { return new OneOrManyArtist (values.Select(v => (IArtist) new ArtistPerson (v))); }
            public static implicit operator OneOrManyArtist (List<Person> values) { return new OneOrManyArtist (values.Select(v => (IArtist) new ArtistPerson (v))); }
        }
        public struct ArtistPerson : IArtist<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ArtistPerson (Person value) { Value = value; }
            public static implicit operator ArtistPerson (Person value) { return new ArtistPerson (value); }
        }

        public interface IColorist : IValue {}
        public interface IColorist<T> : IColorist { new T Value { get; } }
        public class OneOrManyColorist : OneOrMany<IColorist>
        {
            public OneOrManyColorist(IColorist item) : base(item) { }
            public OneOrManyColorist(IEnumerable<IColorist> items) : base(items) { }
            public static implicit operator OneOrManyColorist (Person value) { return new OneOrManyColorist (new ColoristPerson (value)); }
            public static implicit operator OneOrManyColorist (Person[] values) { return new OneOrManyColorist (values.Select(v => (IColorist) new ColoristPerson (v))); }
            public static implicit operator OneOrManyColorist (List<Person> values) { return new OneOrManyColorist (values.Select(v => (IColorist) new ColoristPerson (v))); }
        }
        public struct ColoristPerson : IColorist<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public ColoristPerson (Person value) { Value = value; }
            public static implicit operator ColoristPerson (Person value) { return new ColoristPerson (value); }
        }

        public interface IInker : IValue {}
        public interface IInker<T> : IInker { new T Value { get; } }
        public class OneOrManyInker : OneOrMany<IInker>
        {
            public OneOrManyInker(IInker item) : base(item) { }
            public OneOrManyInker(IEnumerable<IInker> items) : base(items) { }
            public static implicit operator OneOrManyInker (Person value) { return new OneOrManyInker (new InkerPerson (value)); }
            public static implicit operator OneOrManyInker (Person[] values) { return new OneOrManyInker (values.Select(v => (IInker) new InkerPerson (v))); }
            public static implicit operator OneOrManyInker (List<Person> values) { return new OneOrManyInker (values.Select(v => (IInker) new InkerPerson (v))); }
        }
        public struct InkerPerson : IInker<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public InkerPerson (Person value) { Value = value; }
            public static implicit operator InkerPerson (Person value) { return new InkerPerson (value); }
        }

        public interface ILetterer : IValue {}
        public interface ILetterer<T> : ILetterer { new T Value { get; } }
        public class OneOrManyLetterer : OneOrMany<ILetterer>
        {
            public OneOrManyLetterer(ILetterer item) : base(item) { }
            public OneOrManyLetterer(IEnumerable<ILetterer> items) : base(items) { }
            public static implicit operator OneOrManyLetterer (Person value) { return new OneOrManyLetterer (new LettererPerson (value)); }
            public static implicit operator OneOrManyLetterer (Person[] values) { return new OneOrManyLetterer (values.Select(v => (ILetterer) new LettererPerson (v))); }
            public static implicit operator OneOrManyLetterer (List<Person> values) { return new OneOrManyLetterer (values.Select(v => (ILetterer) new LettererPerson (v))); }
        }
        public struct LettererPerson : ILetterer<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public LettererPerson (Person value) { Value = value; }
            public static implicit operator LettererPerson (Person value) { return new LettererPerson (value); }
        }

        public interface IPenciler : IValue {}
        public interface IPenciler<T> : IPenciler { new T Value { get; } }
        public class OneOrManyPenciler : OneOrMany<IPenciler>
        {
            public OneOrManyPenciler(IPenciler item) : base(item) { }
            public OneOrManyPenciler(IEnumerable<IPenciler> items) : base(items) { }
            public static implicit operator OneOrManyPenciler (Person value) { return new OneOrManyPenciler (new PencilerPerson (value)); }
            public static implicit operator OneOrManyPenciler (Person[] values) { return new OneOrManyPenciler (values.Select(v => (IPenciler) new PencilerPerson (v))); }
            public static implicit operator OneOrManyPenciler (List<Person> values) { return new OneOrManyPenciler (values.Select(v => (IPenciler) new PencilerPerson (v))); }
        }
        public struct PencilerPerson : IPenciler<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public PencilerPerson (Person value) { Value = value; }
            public static implicit operator PencilerPerson (Person value) { return new PencilerPerson (value); }
        }

        public interface IVariantCover : IValue {}
        public interface IVariantCover<T> : IVariantCover { new T Value { get; } }
        public class OneOrManyVariantCover : OneOrMany<IVariantCover>
        {
            public OneOrManyVariantCover(IVariantCover item) : base(item) { }
            public OneOrManyVariantCover(IEnumerable<IVariantCover> items) : base(items) { }
            public static implicit operator OneOrManyVariantCover (string value) { return new OneOrManyVariantCover (new VariantCoverstring (value)); }
            public static implicit operator OneOrManyVariantCover (string[] values) { return new OneOrManyVariantCover (values.Select(v => (IVariantCover) new VariantCoverstring (v))); }
            public static implicit operator OneOrManyVariantCover (List<string> values) { return new OneOrManyVariantCover (values.Select(v => (IVariantCover) new VariantCoverstring (v))); }
        }
        public struct VariantCoverstring : IVariantCover<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VariantCoverstring (string value) { Value = value; }
            public static implicit operator VariantCoverstring (string value) { return new VariantCoverstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComicIssue";

        /// <summary>
        /// The primary artist for a work
        ///     in a medium other than pencils or digital line art--for example, if the
        ///     primary artwork is done in watercolors or digital paints.
        /// </summary>
        [DataMember(Name = "artist", Order = 306)]
        public OneOrManyArtist Artist { get; set; }

        /// <summary>
        /// The individual who adds color to inked drawings.
        /// </summary>
        [DataMember(Name = "colorist", Order = 307)]
        public OneOrManyColorist Colorist { get; set; }

        /// <summary>
        /// The individual who traces over the pencil drawings in ink after pencils are complete.
        /// </summary>
        [DataMember(Name = "inker", Order = 308)]
        public OneOrManyInker Inker { get; set; }

        /// <summary>
        /// The individual who adds lettering, including speech balloons and sound effects, to artwork.
        /// </summary>
        [DataMember(Name = "letterer", Order = 309)]
        public OneOrManyLetterer Letterer { get; set; }

        /// <summary>
        /// The individual who draws the primary narrative artwork.
        /// </summary>
        [DataMember(Name = "penciler", Order = 310)]
        public OneOrManyPenciler Penciler { get; set; }

        /// <summary>
        /// A description of the variant cover
        ///     for the issue, if the issue is a variant printing. For example, "Bryan Hitch
        ///     Variant Cover" or "2nd Printing Variant".
        /// </summary>
        [DataMember(Name = "variantCover", Order = 311)]
        public OneOrManyVariantCover VariantCover { get; set; }
    }
}

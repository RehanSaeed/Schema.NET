namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See AudioObject, Book for more information.
    /// </summary>
    public partial interface IAudioObjectAndBook : IAudioObject, IBook
    {
    }

    /// <summary>
    /// See AudioObject, Book for more information.
    /// </summary>
    [DataContract]
    public abstract partial class AudioObjectAndBook : MediaObject, IAudioObjectAndBook, IEquatable<AudioObjectAndBook>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AudioObjectAndBook";

        /// <summary>
        /// Indicates whether the book is an abridged edition.
        /// </summary>
        [DataMember(Name = "abridged", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> Abridged { get; set; }

        /// <summary>
        /// The edition of the book.
        /// </summary>
        [DataMember(Name = "bookEdition", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BookEdition { get; set; }

        /// <summary>
        /// The format of the book.
        /// </summary>
        [DataMember(Name = "bookFormat", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<BookFormatType?> BookFormat { get; set; }

        /// <summary>
        /// The caption for this object. For downloadable machine formats (closed caption, subtitles etc.) use MediaObject and indicate the &lt;a class="localLink" href="https://schema.org/encodingFormat"&gt;encodingFormat&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "caption", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMediaObject, string> Caption { get; set; }

        /// <summary>
        /// The illustrator of the book.
        /// </summary>
        [DataMember(Name = "illustrator", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Illustrator { get; set; }

        /// <summary>
        /// The ISBN of the book.
        /// </summary>
        [DataMember(Name = "isbn", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Isbn { get; set; }

        /// <summary>
        /// The number of pages in the book.
        /// </summary>
        [DataMember(Name = "numberOfPages", Order = 312)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> NumberOfPages { get; set; }

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        [DataMember(Name = "transcript", Order = 313)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Transcript { get; set; }

        /// <inheritdoc/>
        public bool Equals(AudioObjectAndBook other)
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
                this.Abridged == other.Abridged &&
                this.BookEdition == other.BookEdition &&
                this.BookFormat == other.BookFormat &&
                this.Caption == other.Caption &&
                this.Illustrator == other.Illustrator &&
                this.Isbn == other.Isbn &&
                this.NumberOfPages == other.NumberOfPages &&
                this.Transcript == other.Transcript &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as AudioObjectAndBook);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Abridged)
            .And(this.BookEdition)
            .And(this.BookFormat)
            .And(this.Caption)
            .And(this.Illustrator)
            .And(this.Isbn)
            .And(this.NumberOfPages)
            .And(this.Transcript)
            .And(base.GetHashCode());
    }
}

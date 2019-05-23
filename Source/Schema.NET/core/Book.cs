namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A book.
    /// </summary>
    public partial interface IBook : ICreativeWork
    {
        /// <summary>
        /// Indicates whether the book is an abridged edition.
        /// </summary>
        OneOrMany<bool?> Abridged { get; set; }

        /// <summary>
        /// The edition of the book.
        /// </summary>
        OneOrMany<string> BookEdition { get; set; }

        /// <summary>
        /// The format of the book.
        /// </summary>
        OneOrMany<BookFormatType?> BookFormat { get; set; }

        /// <summary>
        /// The illustrator of the book.
        /// </summary>
        OneOrMany<IPerson> Illustrator { get; set; }

        /// <summary>
        /// The ISBN of the book.
        /// </summary>
        OneOrMany<string> Isbn { get; set; }

        /// <summary>
        /// The number of pages in the book.
        /// </summary>
        OneOrMany<int?> NumberOfPages { get; set; }
    }

    /// <summary>
    /// A book.
    /// </summary>
    [DataContract]
    public partial class Book : CreativeWork, IBook
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Book";

        /// <summary>
        /// Indicates whether the book is an abridged edition.
        /// </summary>
        [DataMember(Name = "abridged", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> Abridged { get; set; }

        /// <summary>
        /// The edition of the book.
        /// </summary>
        [DataMember(Name = "bookEdition", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> BookEdition { get; set; }

        /// <summary>
        /// The format of the book.
        /// </summary>
        [DataMember(Name = "bookFormat", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<BookFormatType?> BookFormat { get; set; }

        /// <summary>
        /// The illustrator of the book.
        /// </summary>
        [DataMember(Name = "illustrator", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IPerson> Illustrator { get; set; }

        /// <summary>
        /// The ISBN of the book.
        /// </summary>
        [DataMember(Name = "isbn", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Isbn { get; set; }

        /// <summary>
        /// The number of pages in the book.
        /// </summary>
        [DataMember(Name = "numberOfPages", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<int?> NumberOfPages { get; set; }
    }
}

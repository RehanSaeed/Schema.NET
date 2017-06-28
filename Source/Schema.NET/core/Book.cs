namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A book.
    /// </summary>
    [DataContract]
    public partial class Book : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Book";

        /// <summary>
        /// The edition of the book.
        /// </summary>
        [DataMember(Name = "bookEdition", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? BookEdition { get; set; }

        /// <summary>
        /// The format of the book.
        /// </summary>
        [DataMember(Name = "bookFormat", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BookFormatType?>? BookFormat { get; set; }

        /// <summary>
        /// The illustrator of the book.
        /// </summary>
        [DataMember(Name = "illustrator", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Illustrator { get; set; }

        /// <summary>
        /// The ISBN of the book.
        /// </summary>
        [DataMember(Name = "isbn", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Isbn { get; set; }

        /// <summary>
        /// The number of pages in the book.
        /// </summary>
        [DataMember(Name = "numberOfPages", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int?>? NumberOfPages { get; set; }
    }
}

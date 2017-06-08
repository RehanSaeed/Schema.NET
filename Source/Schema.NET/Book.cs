namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A book.
    /// </summary>
    [DataContract]
    public class Book : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Book";

        /// <summary>
        /// The ISBN of the book.
        /// </summary>
        [DataMember(Name = "isbn")]
        public string Isbn { get; set; }

        /// <summary>
        /// The edition of the book.
        /// </summary>
        [DataMember(Name = "bookEdition")]
        public string BookEdition { get; set; }

        /// <summary>
        /// The format of the book.
        /// </summary>
        [DataMember(Name = "bookFormat")]
        public BookFormatType BookFormat { get; set; }

        /// <summary>
        /// The number of pages in the book.
        /// </summary>
        [DataMember(Name = "numberOfPages")]
        public int NumberOfPages { get; set; }

        /// <summary>
        /// The illustrator of the book.
        /// </summary>
        [DataMember(Name = "illustrator")]
        public Person Illustrator { get; set; }
    }
}

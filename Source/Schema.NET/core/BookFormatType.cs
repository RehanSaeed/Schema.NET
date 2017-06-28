namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// The publication format of the book.
    /// </summary>
    public enum BookFormatType
    {
        /// <summary>
        /// Book format: Audiobook. This is an enumerated value for use with the bookFormat property. There is also a type 'Audiobook' in the bib extension which includes Audiobook specific properties.
        /// </summary>
        [EnumMember(Value = "http://schema.org/AudiobookFormat")]
        AudiobookFormat,

        /// <summary>
        /// Book format: Ebook.
        /// </summary>
        [EnumMember(Value = "http://schema.org/EBook")]
        EBook,

        /// <summary>
        /// Book format: Hardcover.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Hardcover")]
        Hardcover,

        /// <summary>
        /// Book format: Paperback.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Paperback")]
        Paperback
    }
}

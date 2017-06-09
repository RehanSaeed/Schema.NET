namespace Schema.NET
{
    /// <summary>
    /// The publication format of the book.
    /// </summary>
    public enum BookFormatType
    {
        /// <summary>
        /// Book format: Audiobook. This is an enumerated value for use with the bookFormat property. There is also a type 'Audiobook' in the bib extension which includes Audiobook specific properties.
        /// </summary>
        AudiobookFormat,

        /// <summary>
        /// Book format: Ebook.
        /// </summary>
        EBook,

        /// <summary>
        /// Book format: Hardcover.
        /// </summary>
        Hardcover,

        /// <summary>
        /// Book format: Paperback.
        /// </summary>
        Paperback
    }
}

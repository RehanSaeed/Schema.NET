﻿namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The publication format of the book.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BookFormatType
    {
        /// <summary>
        /// Book format: Audiobook. This is an enumerated value for use with the bookFormat property. There is also a type 'Audiobook' in the bib extension which includes Audiobook specific properties.
        /// </summary>
        [EnumMember(Value = "https://schema.org/AudiobookFormat")]
        AudiobookFormat,

        /// <summary>
        /// Book format: Ebook.
        /// </summary>
        [EnumMember(Value = "https://schema.org/EBook")]
        EBook,

        /// <summary>
        /// Book format: GraphicNovel. May represent a bound collection of ComicIssue instances.
        /// </summary>
        [EnumMember(Value = "https://schema.org/GraphicNovel")]
        GraphicNovel,

        /// <summary>
        /// Book format: Hardcover.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Hardcover")]
        Hardcover,

        /// <summary>
        /// Book format: Paperback.
        /// </summary>
        [EnumMember(Value = "https://schema.org/Paperback")]
        Paperback
    }
}

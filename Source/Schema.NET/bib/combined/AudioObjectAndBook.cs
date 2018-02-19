using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// See AudioObject, Book for more information.
    /// </summary>
    [DataContract]
    public abstract partial class AudioObjectAndBook : MediaObject
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<bool>? Abridged { get; set; } 

        /// <summary>
        /// The edition of the book.
        /// </summary>
        [DataMember(Name = "bookEdition", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? BookEdition { get; set; } 

        /// <summary>
        /// The format of the book.
        /// </summary>
        [DataMember(Name = "bookFormat", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BookFormatType>? BookFormat { get; set; } 

        /// <summary>
        /// The illustrator of the book.
        /// </summary>
        [DataMember(Name = "illustrator", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Person>? Illustrator { get; set; } 

        /// <summary>
        /// The ISBN of the book.
        /// </summary>
        [DataMember(Name = "isbn", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Isbn { get; set; } 

        /// <summary>
        /// The number of pages in the book.
        /// </summary>
        [DataMember(Name = "numberOfPages", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int>? NumberOfPages { get; set; } 

        /// <summary>
        /// If this MediaObject is an AudioObject or VideoObject, the transcript of that object.
        /// </summary>
        [DataMember(Name = "transcript", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Transcript { get; set; } 
    }
}

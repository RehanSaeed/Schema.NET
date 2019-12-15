namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// One of the sections into which a book is divided. A chapter usually has a section number or a name.
    /// </summary>
    public partial interface IChapter : ICreativeWork
    {
        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        Values<int?, string> PageEnd { get; set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        Values<int?, string> PageStart { get; set; }

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        OneOrMany<string> Pagination { get; set; }
    }

    /// <summary>
    /// One of the sections into which a book is divided. A chapter usually has a section number or a name.
    /// </summary>
    [DataContract]
    public partial class Chapter : CreativeWork, IChapter, IEquatable<Chapter>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Chapter";

        /// <summary>
        /// The page on which the work ends; for example "138" or "xvi".
        /// </summary>
        [DataMember(Name = "pageEnd", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> PageEnd { get; set; }

        /// <summary>
        /// The page on which the work starts; for example "135" or "xiii".
        /// </summary>
        [DataMember(Name = "pageStart", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> PageStart { get; set; }

        /// <summary>
        /// Any description of pages that is not separated into pageStart and pageEnd; for example, "1-6, 9, 55" or "10-12, 46-49".
        /// </summary>
        [DataMember(Name = "pagination", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Pagination { get; set; }

        /// <inheritdoc/>
        public bool Equals(Chapter other)
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
                this.PageEnd == other.PageEnd &&
                this.PageStart == other.PageStart &&
                this.Pagination == other.Pagination &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Chapter);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.PageEnd)
            .And(this.PageStart)
            .And(this.Pagination)
            .And(base.GetHashCode());
    }
}

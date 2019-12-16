namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.&lt;br/&gt;&lt;br/&gt;
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// </summary>
    public partial interface IPublicationVolume : ICreativeWork
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

        /// <summary>
        /// Identifies the volume of publication or multi-part work; for example, "iii" or "2".
        /// </summary>
        Values<int?, string> VolumeNumber { get; set; }
    }

    /// <summary>
    /// A part of a successively published publication such as a periodical or multi-volume work, often numbered. It may represent a time span, such as a year.&lt;br/&gt;&lt;br/&gt;
    /// See also &lt;a href="http://blog.schema.org/2014/09/schemaorg-support-for-bibliographic_2.html"&gt;blog post&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class PublicationVolume : CreativeWork, IPublicationVolume, IEquatable<PublicationVolume>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PublicationVolume";

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

        /// <summary>
        /// Identifies the volume of publication or multi-part work; for example, "iii" or "2".
        /// </summary>
        [DataMember(Name = "volumeNumber", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<int?, string> VolumeNumber { get; set; }

        /// <inheritdoc/>
        public bool Equals(PublicationVolume other)
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
                this.VolumeNumber == other.VolumeNumber &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as PublicationVolume);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.PageEnd)
            .And(this.PageStart)
            .And(this.Pagination)
            .And(this.VolumeNumber)
            .And(base.GetHashCode());
    }
}

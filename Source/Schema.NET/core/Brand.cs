namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
    public partial interface IBrand : IIntangible
    {
        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        Values<IImageObject, Uri> Logo { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        OneOrMany<string> Slogan { get; set; }
    }

    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
    [DataContract]
    public partial class Brand : Intangible, IBrand, IEquatable<Brand>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Brand";

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAggregateRating> AggregateRating { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IImageObject, Uri> Logo { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IReview> Review { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        [DataMember(Name = "slogan", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Slogan { get; set; }

        /// <inheritdoc/>
        public bool Equals(Brand other)
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
                this.AggregateRating == other.AggregateRating &&
                this.Logo == other.Logo &&
                this.Review == other.Review &&
                this.Slogan == other.Slogan &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Brand);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AggregateRating)
            .And(this.Logo)
            .And(this.Review)
            .And(this.Slogan)
            .And(base.GetHashCode());
    }
}

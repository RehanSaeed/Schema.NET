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
        OneOrMany<IAggregateRating>? AggregateRating { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        Values<IImageObject, Uri>? Logo { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        OneOrMany<IReview>? Review { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        OneOrMany<string>? Slogan { get; set; }
    }

    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
    [DataContract]
    public partial class Brand : Intangible, IBrand
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
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IAggregateRating>? AggregateRating { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IImageObject, Uri>? Logo { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IReview>? Review { get; set; }

        /// <summary>
        /// A slogan or motto associated with the item.
        /// </summary>
        [DataMember(Name = "slogan", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Slogan { get; set; }
    }
}

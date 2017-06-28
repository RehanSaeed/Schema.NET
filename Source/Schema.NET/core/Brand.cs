namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
    [DataContract]
    public partial class Brand : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Brand";

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 205)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AggregateRating>? AggregateRating { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri, ImageObject>? Logo { get; set; }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Review>? Review { get; set; }
    }
}

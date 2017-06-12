namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
    [DataContract]
    public class Brand : Intangible
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Brand";

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 2)]
        public AggregateRating AggregateRating { get; set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 3)]
        public object Logo { get; protected set; }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [IgnoreDataMember]
        public Uri LogoURL
        {
            get => this.Logo as Uri;
            set => this.Logo = value;
        }

        /// <summary>
        /// An associated logo.
        /// </summary>
        [IgnoreDataMember]
        public ImageObject LogoImageObject
        {
            get => this.Logo as ImageObject;
            set => this.Logo = value;
        }

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 4)]
        public Review Review { get; set; }
    }
}

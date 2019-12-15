namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A food-related business.
    /// </summary>
    public partial interface IFoodEstablishment : ILocalBusiness
    {
        /// <summary>
        /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings &lt;code&gt;Yes&lt;/code&gt; or &lt;code&gt;No&lt;/code&gt;.
        /// </summary>
        Values<bool?, string, Uri> AcceptsReservations { get; set; }

        /// <summary>
        /// Either the actual menu as a structured representation, as text, or a URL of the menu.
        /// </summary>
        Values<IMenu, string, Uri> HasMenu { get; set; }

        /// <summary>
        /// The cuisine of the restaurant.
        /// </summary>
        OneOrMany<string> ServesCuisine { get; set; }

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        OneOrMany<IRating> StarRating { get; set; }
    }

    /// <summary>
    /// A food-related business.
    /// </summary>
    [DataContract]
    public partial class FoodEstablishment : LocalBusiness, IFoodEstablishment, IEquatable<FoodEstablishment>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FoodEstablishment";

        /// <summary>
        /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings &lt;code&gt;Yes&lt;/code&gt; or &lt;code&gt;No&lt;/code&gt;.
        /// </summary>
        [DataMember(Name = "acceptsReservations", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<bool?, string, Uri> AcceptsReservations { get; set; }

        /// <summary>
        /// Either the actual menu as a structured representation, as text, or a URL of the menu.
        /// </summary>
        [DataMember(Name = "hasMenu", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMenu, string, Uri> HasMenu { get; set; }

        /// <summary>
        /// The cuisine of the restaurant.
        /// </summary>
        [DataMember(Name = "servesCuisine", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ServesCuisine { get; set; }

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        [DataMember(Name = "starRating", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IRating> StarRating { get; set; }

        /// <inheritdoc/>
        public bool Equals(FoodEstablishment other)
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
                this.AcceptsReservations == other.AcceptsReservations &&
                this.HasMenu == other.HasMenu &&
                this.ServesCuisine == other.ServesCuisine &&
                this.StarRating == other.StarRating &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as FoodEstablishment);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AcceptsReservations)
            .And(this.HasMenu)
            .And(this.ServesCuisine)
            .And(this.StarRating)
            .And(base.GetHashCode());
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A food-related business.
    /// </summary>
    [DataContract]
    public class FoodEstablishment : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "FoodEstablishment";

        /// <summary>
        /// The cuisine of the restaurant.
        /// </summary>
        [DataMember(Name = "servesCuisine")]
        public string ServesCuisine { get; set; }

        /// <summary>
        /// Either the actual menu as a structured representation, as text, or a URL of the menu.
        /// </summary>
        [DataMember(Name = "hasMenu")]
        public object HasMenu { get; protected set; }

        /// <summary>
        /// Either the actual menu as a structured representation, as text, or a URL of the menu.
        /// </summary>
        [IgnoreDataMember]
        public Menu HasMenuMenu
        {
            get => this.HasMenu as Menu;
            set => this.HasMenu = value;
        }

        /// <summary>
        /// Either the actual menu as a structured representation, as text, or a URL of the menu.
        /// </summary>
        [IgnoreDataMember]
        public string HasMenuText
        {
            get => this.HasMenu as string;
            set => this.HasMenu = value;
        }

        /// <summary>
        /// Either the actual menu as a structured representation, as text, or a URL of the menu.
        /// </summary>
        [IgnoreDataMember]
        public Uri HasMenuURL
        {
            get => this.HasMenu as Uri;
            set => this.HasMenu = value;
        }

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        [DataMember(Name = "starRating")]
        public Rating StarRating { get; set; }

        /// <summary>
        /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings &lt;code&gt;Yes&lt;/code&gt; or &lt;code&gt;No&lt;/code&gt;.
        /// </summary>
        [DataMember(Name = "acceptsReservations")]
        public object AcceptsReservations { get; protected set; }

        /// <summary>
        /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings &lt;code&gt;Yes&lt;/code&gt; or &lt;code&gt;No&lt;/code&gt;.
        /// </summary>
        [IgnoreDataMember]
        public string AcceptsReservationsText
        {
            get => this.AcceptsReservations as string;
            set => this.AcceptsReservations = value;
        }

        /// <summary>
        /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings &lt;code&gt;Yes&lt;/code&gt; or &lt;code&gt;No&lt;/code&gt;.
        /// </summary>
        [IgnoreDataMember]
        public Uri AcceptsReservationsURL
        {
            get => this.AcceptsReservations as Uri;
            set => this.AcceptsReservations = value;
        }

        /// <summary>
        /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings &lt;code&gt;Yes&lt;/code&gt; or &lt;code&gt;No&lt;/code&gt;.
        /// </summary>
        [IgnoreDataMember]
        public bool? AcceptsReservationsBoolean
        {
            get => this.AcceptsReservations as bool?;
            set => this.AcceptsReservations = value;
        }
    }
}

using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A food-related business.
    /// </summary>
    [DataContract]
    public partial class FoodEstablishment : LocalBusiness
    {
        public interface IAcceptsReservations : IWrapper { }
        public interface IAcceptsReservations<T> : IAcceptsReservations { new T Data { get; set; } }
        public class AcceptsReservationsbool : IAcceptsReservations<bool>
        {
            object IWrapper.Data { get { return Data; } set { Data = (bool) value; } }
            public virtual bool Data { get; set; }
            public AcceptsReservationsbool () { }
            public AcceptsReservationsbool (bool data) { Data = data; }
            public static implicit operator AcceptsReservationsbool (bool data) { return new AcceptsReservationsbool (data); }
        }

        public class AcceptsReservationsstring : IAcceptsReservations<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public AcceptsReservationsstring () { }
            public AcceptsReservationsstring (string data) { Data = data; }
            public static implicit operator AcceptsReservationsstring (string data) { return new AcceptsReservationsstring (data); }
        }

        public class AcceptsReservationsUri : IAcceptsReservations<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public AcceptsReservationsUri () { }
            public AcceptsReservationsUri (Uri data) { Data = data; }
            public static implicit operator AcceptsReservationsUri (Uri data) { return new AcceptsReservationsUri (data); }
        }


        public interface IHasMenu : IWrapper { }
        public interface IHasMenu<T> : IHasMenu { new T Data { get; set; } }
        public class HasMenuMenu : IHasMenu<Menu>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Menu) value; } }
            public virtual Menu Data { get; set; }
            public HasMenuMenu () { }
            public HasMenuMenu (Menu data) { Data = data; }
            public static implicit operator HasMenuMenu (Menu data) { return new HasMenuMenu (data); }
        }

        public class HasMenustring : IHasMenu<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public HasMenustring () { }
            public HasMenustring (string data) { Data = data; }
            public static implicit operator HasMenustring (string data) { return new HasMenustring (data); }
        }

        public class HasMenuUri : IHasMenu<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public HasMenuUri () { }
            public HasMenuUri (Uri data) { Data = data; }
            public static implicit operator HasMenuUri (Uri data) { return new HasMenuUri (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FoodEstablishment";

        /// <summary>
        /// Indicates whether a FoodEstablishment accepts reservations. Values can be Boolean, an URL at which reservations can be made or (for backwards compatibility) the strings &lt;code&gt;Yes&lt;/code&gt; or &lt;code&gt;No&lt;/code&gt;.
        /// </summary>
        [DataMember(Name = "acceptsReservations", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IAcceptsReservations>? AcceptsReservations { get; set; } //bool?, string, Uri

        /// <summary>
        /// Either the actual menu as a structured representation, as text, or a URL of the menu.
        /// </summary>
        [DataMember(Name = "hasMenu", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IHasMenu>? HasMenu { get; set; } //Menu, string, Uri

        /// <summary>
        /// The cuisine of the restaurant.
        /// </summary>
        [DataMember(Name = "servesCuisine", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ServesCuisine { get; set; } 

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        [DataMember(Name = "starRating", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Rating>? StarRating { get; set; } 
    }
}

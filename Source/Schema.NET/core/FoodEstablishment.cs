namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A food-related business.
    /// </summary>
    [DataContract]
    public partial class FoodEstablishment : LocalBusiness
    {
        public interface IAcceptsReservations : IValue {}
        public interface IAcceptsReservations<T> : IAcceptsReservations { new T Value { get; } }
        public class OneOrManyAcceptsReservations : OneOrMany<IAcceptsReservations>
        {
            public OneOrManyAcceptsReservations(IAcceptsReservations item) : base(item) { }
            public OneOrManyAcceptsReservations(IEnumerable<IAcceptsReservations> items) : base(items) { }
            public static implicit operator OneOrManyAcceptsReservations (bool value) { return new OneOrManyAcceptsReservations (new AcceptsReservationsbool (value)); }
            public static implicit operator OneOrManyAcceptsReservations (bool[] values) { return new OneOrManyAcceptsReservations (values.Select(v => (IAcceptsReservations) new AcceptsReservationsbool (v))); }
            public static implicit operator OneOrManyAcceptsReservations (List<bool> values) { return new OneOrManyAcceptsReservations (values.Select(v => (IAcceptsReservations) new AcceptsReservationsbool (v))); }
            public static implicit operator OneOrManyAcceptsReservations (string value) { return new OneOrManyAcceptsReservations (new AcceptsReservationsstring (value)); }
            public static implicit operator OneOrManyAcceptsReservations (string[] values) { return new OneOrManyAcceptsReservations (values.Select(v => (IAcceptsReservations) new AcceptsReservationsstring (v))); }
            public static implicit operator OneOrManyAcceptsReservations (List<string> values) { return new OneOrManyAcceptsReservations (values.Select(v => (IAcceptsReservations) new AcceptsReservationsstring (v))); }
            public static implicit operator OneOrManyAcceptsReservations (Uri value) { return new OneOrManyAcceptsReservations (new AcceptsReservationsUri (value)); }
            public static implicit operator OneOrManyAcceptsReservations (Uri[] values) { return new OneOrManyAcceptsReservations (values.Select(v => (IAcceptsReservations) new AcceptsReservationsUri (v))); }
            public static implicit operator OneOrManyAcceptsReservations (List<Uri> values) { return new OneOrManyAcceptsReservations (values.Select(v => (IAcceptsReservations) new AcceptsReservationsUri (v))); }
        }
        public struct AcceptsReservationsbool : IAcceptsReservations<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public AcceptsReservationsbool (bool value) { Value = value; }
            public static implicit operator AcceptsReservationsbool (bool value) { return new AcceptsReservationsbool (value); }
        }
        public struct AcceptsReservationsstring : IAcceptsReservations<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AcceptsReservationsstring (string value) { Value = value; }
            public static implicit operator AcceptsReservationsstring (string value) { return new AcceptsReservationsstring (value); }
        }
        public struct AcceptsReservationsUri : IAcceptsReservations<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public AcceptsReservationsUri (Uri value) { Value = value; }
            public static implicit operator AcceptsReservationsUri (Uri value) { return new AcceptsReservationsUri (value); }
        }

        public interface IHasMenu : IValue {}
        public interface IHasMenu<T> : IHasMenu { new T Value { get; } }
        public class OneOrManyHasMenu : OneOrMany<IHasMenu>
        {
            public OneOrManyHasMenu(IHasMenu item) : base(item) { }
            public OneOrManyHasMenu(IEnumerable<IHasMenu> items) : base(items) { }
            public static implicit operator OneOrManyHasMenu (Menu value) { return new OneOrManyHasMenu (new HasMenuMenu (value)); }
            public static implicit operator OneOrManyHasMenu (Menu[] values) { return new OneOrManyHasMenu (values.Select(v => (IHasMenu) new HasMenuMenu (v))); }
            public static implicit operator OneOrManyHasMenu (List<Menu> values) { return new OneOrManyHasMenu (values.Select(v => (IHasMenu) new HasMenuMenu (v))); }
            public static implicit operator OneOrManyHasMenu (string value) { return new OneOrManyHasMenu (new HasMenustring (value)); }
            public static implicit operator OneOrManyHasMenu (string[] values) { return new OneOrManyHasMenu (values.Select(v => (IHasMenu) new HasMenustring (v))); }
            public static implicit operator OneOrManyHasMenu (List<string> values) { return new OneOrManyHasMenu (values.Select(v => (IHasMenu) new HasMenustring (v))); }
            public static implicit operator OneOrManyHasMenu (Uri value) { return new OneOrManyHasMenu (new HasMenuUri (value)); }
            public static implicit operator OneOrManyHasMenu (Uri[] values) { return new OneOrManyHasMenu (values.Select(v => (IHasMenu) new HasMenuUri (v))); }
            public static implicit operator OneOrManyHasMenu (List<Uri> values) { return new OneOrManyHasMenu (values.Select(v => (IHasMenu) new HasMenuUri (v))); }
        }
        public struct HasMenuMenu : IHasMenu<Menu>
        {
            object IValue.Value => this.Value;
            public Menu Value { get; }
            public HasMenuMenu (Menu value) { Value = value; }
            public static implicit operator HasMenuMenu (Menu value) { return new HasMenuMenu (value); }
        }
        public struct HasMenustring : IHasMenu<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public HasMenustring (string value) { Value = value; }
            public static implicit operator HasMenustring (string value) { return new HasMenustring (value); }
        }
        public struct HasMenuUri : IHasMenu<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public HasMenuUri (Uri value) { Value = value; }
            public static implicit operator HasMenuUri (Uri value) { return new HasMenuUri (value); }
        }

        public interface IServesCuisine : IValue {}
        public interface IServesCuisine<T> : IServesCuisine { new T Value { get; } }
        public class OneOrManyServesCuisine : OneOrMany<IServesCuisine>
        {
            public OneOrManyServesCuisine(IServesCuisine item) : base(item) { }
            public OneOrManyServesCuisine(IEnumerable<IServesCuisine> items) : base(items) { }
            public static implicit operator OneOrManyServesCuisine (string value) { return new OneOrManyServesCuisine (new ServesCuisinestring (value)); }
            public static implicit operator OneOrManyServesCuisine (string[] values) { return new OneOrManyServesCuisine (values.Select(v => (IServesCuisine) new ServesCuisinestring (v))); }
            public static implicit operator OneOrManyServesCuisine (List<string> values) { return new OneOrManyServesCuisine (values.Select(v => (IServesCuisine) new ServesCuisinestring (v))); }
        }
        public struct ServesCuisinestring : IServesCuisine<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ServesCuisinestring (string value) { Value = value; }
            public static implicit operator ServesCuisinestring (string value) { return new ServesCuisinestring (value); }
        }

        public interface IStarRating : IValue {}
        public interface IStarRating<T> : IStarRating { new T Value { get; } }
        public class OneOrManyStarRating : OneOrMany<IStarRating>
        {
            public OneOrManyStarRating(IStarRating item) : base(item) { }
            public OneOrManyStarRating(IEnumerable<IStarRating> items) : base(items) { }
            public static implicit operator OneOrManyStarRating (Rating value) { return new OneOrManyStarRating (new StarRatingRating (value)); }
            public static implicit operator OneOrManyStarRating (Rating[] values) { return new OneOrManyStarRating (values.Select(v => (IStarRating) new StarRatingRating (v))); }
            public static implicit operator OneOrManyStarRating (List<Rating> values) { return new OneOrManyStarRating (values.Select(v => (IStarRating) new StarRatingRating (v))); }
        }
        public struct StarRatingRating : IStarRating<Rating>
        {
            object IValue.Value => this.Value;
            public Rating Value { get; }
            public StarRatingRating (Rating value) { Value = value; }
            public static implicit operator StarRatingRating (Rating value) { return new StarRatingRating (value); }
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
        public OneOrManyAcceptsReservations AcceptsReservations { get; set; }

        /// <summary>
        /// Either the actual menu as a structured representation, as text, or a URL of the menu.
        /// </summary>
        [DataMember(Name = "hasMenu", Order = 307)]
        public OneOrManyHasMenu HasMenu { get; set; }

        /// <summary>
        /// The cuisine of the restaurant.
        /// </summary>
        [DataMember(Name = "servesCuisine", Order = 308)]
        public OneOrManyServesCuisine ServesCuisine { get; set; }

        /// <summary>
        /// An official rating for a lodging business or food establishment, e.g. from national associations or standards bodies. Use the author property to indicate the rating organization, e.g. as an Organization with name such as (e.g. HOTREC, DEHOGA, WHR, or Hotelstars).
        /// </summary>
        [DataMember(Name = "starRating", Order = 309)]
        public OneOrManyStarRating StarRating { get; set; }
    }
}

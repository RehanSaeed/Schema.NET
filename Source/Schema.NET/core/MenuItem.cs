namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// </summary>
    public partial interface IMenuItem : IIntangible
    {
        /// <summary>
        /// Additional menu item(s) such as a side dish of salad or side order of fries that can be added to this menu item. Additionally it can be a menu section containing allowed add-on menu items for this menu item.
        /// </summary>
        Values<IMenuItem, IMenuSection> MenuAddOn { get; set; }

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        OneOrMany<INutritionInformation> Nutrition { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="https://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
        /// </summary>
        Values<IDemand, IOffer> Offers { get; set; }

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        OneOrMany<RestrictedDiet?> SuitableForDiet { get; set; }
    }

    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// </summary>
    [DataContract]
    public partial class MenuItem : Intangible, IMenuItem, IEquatable<MenuItem>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MenuItem";

        /// <summary>
        /// Additional menu item(s) such as a side dish of salad or side order of fries that can be added to this menu item. Additionally it can be a menu section containing allowed add-on menu items for this menu item.
        /// </summary>
        [DataMember(Name = "menuAddOn", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMenuItem, IMenuSection> MenuAddOn { get; set; }

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        [DataMember(Name = "nutrition", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<INutritionInformation> Nutrition { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event. Use &lt;a class="localLink" href="https://schema.org/businessFunction"&gt;businessFunction&lt;/a&gt; to indicate the kind of transaction offered, i.e. sell, lease, etc. This property can also be used to describe a &lt;a class="localLink" href="https://schema.org/Demand"&gt;Demand&lt;/a&gt;. While this property is listed as expected on a number of common types, it can be used in others. In that case, using a second type, such as Product or a subtype of Product, can clarify the nature of the offer.
        /// </summary>
        [DataMember(Name = "offers", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IDemand, IOffer> Offers { get; set; }

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        [DataMember(Name = "suitableForDiet", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<RestrictedDiet?> SuitableForDiet { get; set; }

        /// <inheritdoc/>
        public bool Equals(MenuItem other)
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
                this.MenuAddOn == other.MenuAddOn &&
                this.Nutrition == other.Nutrition &&
                this.Offers == other.Offers &&
                this.SuitableForDiet == other.SuitableForDiet &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MenuItem);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.MenuAddOn)
            .And(this.Nutrition)
            .And(this.Offers)
            .And(this.SuitableForDiet)
            .And(base.GetHashCode());
    }
}

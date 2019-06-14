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
        Values<IMenuItem, IMenuSection>? MenuAddOn { get; set; }

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        OneOrMany<INutritionInformation, NutritionInformation> Nutrition { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        OneOrMany<IOffer, Offer> Offers { get; set; }

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        OneOrMany<RestrictedDiet?> SuitableForDiet { get; set; }
    }

    /// <summary>
    /// A food or drink item listed in a menu or menu section.
    /// </summary>
    [DataContract]
    public partial class MenuItem : Intangible, IMenuItem
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
        public Values<IMenuItem, IMenuSection>? MenuAddOn { get; set; }

        /// <summary>
        /// Nutrition information about the recipe or menu item.
        /// </summary>
        [DataMember(Name = "nutrition", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<INutritionInformation, NutritionInformation> Nutrition { get; set; }

        /// <summary>
        /// An offer to provide this item&amp;#x2014;for example, an offer to sell a product, rent the DVD of a movie, perform a service, or give away tickets to an event.
        /// </summary>
        [DataMember(Name = "offers", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOffer, Offer> Offers { get; set; }

        /// <summary>
        /// Indicates a dietary restriction or guideline for which this recipe or menu item is suitable, e.g. diabetic, halal etc.
        /// </summary>
        [DataMember(Name = "suitableForDiet", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<RestrictedDiet?> SuitableForDiet { get; set; }
    }
}

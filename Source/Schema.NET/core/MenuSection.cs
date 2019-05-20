namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A sub-grouping of food or drink items in a menu. E.g. courses (such as 'Dinner', 'Breakfast', etc.), specific type of dishes (such as 'Meat', 'Vegan', 'Drinks', etc.), or some other classification made by the menu provider.
    /// </summary>
    public partial interface IMenuSection : ICreativeWork
    {
        /// <summary>
        /// A food or drink item contained in a menu or menu section.
        /// </summary>
        OneOrMany<IMenuItem>? HasMenuItem { get; set; }

        /// <summary>
        /// A subgrouping of the menu (by dishes, course, serving time period, etc.).
        /// </summary>
        OneOrMany<IMenuSection>? HasMenuSection { get; set; }
    }

    /// <summary>
    /// A sub-grouping of food or drink items in a menu. E.g. courses (such as 'Dinner', 'Breakfast', etc.), specific type of dishes (such as 'Meat', 'Vegan', 'Drinks', etc.), or some other classification made by the menu provider.
    /// </summary>
    [DataContract]
    public partial class MenuSection : CreativeWork, IMenuSection
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MenuSection";

        /// <summary>
        /// A food or drink item contained in a menu or menu section.
        /// </summary>
        [DataMember(Name = "hasMenuItem", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IMenuItem>? HasMenuItem { get; set; }

        /// <summary>
        /// A subgrouping of the menu (by dishes, course, serving time period, etc.).
        /// </summary>
        [DataMember(Name = "hasMenuSection", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IMenuSection>? HasMenuSection { get; set; }
    }
}

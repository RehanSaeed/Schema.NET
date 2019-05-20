namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A structured representation of food or drink items available from a FoodEstablishment.
    /// </summary>
    public partial interface IMenu : ICreativeWork
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
    /// A structured representation of food or drink items available from a FoodEstablishment.
    /// </summary>
    [DataContract]
    public partial class Menu : CreativeWork, IMenu
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Menu";

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

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A sub-grouping of food or drink items in a menu. E.g. courses (such as 'Dinner', 'Breakfast', etc...
    /// </summary>
    [DataContract]
    public class MenuSection : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MenuSection";

        /// <summary>
        /// A food or drink item contained in a menu or menu section.
        /// </summary>
        [DataMember(Name = "hasMenuItem")]
        public MenuItem HasMenuItem { get; set; }

        /// <summary>
        /// A subgrouping of the menu (by dishes, course, serving time period, etc.).
        /// </summary>
        [DataMember(Name = "hasMenuSection")]
        public MenuSection HasMenuSection { get; set; }
    }
}

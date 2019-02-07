namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A sub-grouping of food or drink items in a menu. E.g. courses (such as 'Dinner', 'Breakfast', etc.), specific type of dishes (such as 'Meat', 'Vegan', 'Drinks', etc.), or some other classification made by the menu provider.
    /// </summary>
    [DataContract]
    public partial class MenuSection : CreativeWork
    {
        public interface IHasMenuItem : IValue {}
        public interface IHasMenuItem<T> : IHasMenuItem { new T Value { get; } }
        public class OneOrManyHasMenuItem : OneOrMany<IHasMenuItem>
        {
            public OneOrManyHasMenuItem(IHasMenuItem item) : base(item) { }
            public OneOrManyHasMenuItem(IEnumerable<IHasMenuItem> items) : base(items) { }
            public static implicit operator OneOrManyHasMenuItem (MenuItem value) { return new OneOrManyHasMenuItem (new HasMenuItemMenuItem (value)); }
            public static implicit operator OneOrManyHasMenuItem (MenuItem[] values) { return new OneOrManyHasMenuItem (values.Select(v => (IHasMenuItem) new HasMenuItemMenuItem (v))); }
            public static implicit operator OneOrManyHasMenuItem (List<MenuItem> values) { return new OneOrManyHasMenuItem (values.Select(v => (IHasMenuItem) new HasMenuItemMenuItem (v))); }
        }
        public struct HasMenuItemMenuItem : IHasMenuItem<MenuItem>
        {
            object IValue.Value => this.Value;
            public MenuItem Value { get; }
            public HasMenuItemMenuItem (MenuItem value) { Value = value; }
            public static implicit operator HasMenuItemMenuItem (MenuItem value) { return new HasMenuItemMenuItem (value); }
        }

        public interface IHasMenuSection : IValue {}
        public interface IHasMenuSection<T> : IHasMenuSection { new T Value { get; } }
        public class OneOrManyHasMenuSection : OneOrMany<IHasMenuSection>
        {
            public OneOrManyHasMenuSection(IHasMenuSection item) : base(item) { }
            public OneOrManyHasMenuSection(IEnumerable<IHasMenuSection> items) : base(items) { }
            public static implicit operator OneOrManyHasMenuSection (MenuSection value) { return new OneOrManyHasMenuSection (new HasMenuSectionMenuSection (value)); }
            public static implicit operator OneOrManyHasMenuSection (MenuSection[] values) { return new OneOrManyHasMenuSection (values.Select(v => (IHasMenuSection) new HasMenuSectionMenuSection (v))); }
            public static implicit operator OneOrManyHasMenuSection (List<MenuSection> values) { return new OneOrManyHasMenuSection (values.Select(v => (IHasMenuSection) new HasMenuSectionMenuSection (v))); }
        }
        public struct HasMenuSectionMenuSection : IHasMenuSection<MenuSection>
        {
            object IValue.Value => this.Value;
            public MenuSection Value { get; }
            public HasMenuSectionMenuSection (MenuSection value) { Value = value; }
            public static implicit operator HasMenuSectionMenuSection (MenuSection value) { return new HasMenuSectionMenuSection (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MenuSection";

        /// <summary>
        /// A food or drink item contained in a menu or menu section.
        /// </summary>
        [DataMember(Name = "hasMenuItem", Order = 206)]
        public OneOrManyHasMenuItem HasMenuItem { get; set; }

        /// <summary>
        /// A subgrouping of the menu (by dishes, course, serving time period, etc.).
        /// </summary>
        [DataMember(Name = "hasMenuSection", Order = 207)]
        public OneOrManyHasMenuSection HasMenuSection { get; set; }
    }
}

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
        OneOrMany<IMenuItem> HasMenuItem { get; set; }

        /// <summary>
        /// A subgrouping of the menu (by dishes, course, serving time period, etc.).
        /// </summary>
        OneOrMany<IMenuSection> HasMenuSection { get; set; }
    }

    /// <summary>
    /// A structured representation of food or drink items available from a FoodEstablishment.
    /// </summary>
    [DataContract]
    public partial class Menu : CreativeWork, IMenu, IEquatable<Menu>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMenuItem> HasMenuItem { get; set; }

        /// <summary>
        /// A subgrouping of the menu (by dishes, course, serving time period, etc.).
        /// </summary>
        [DataMember(Name = "hasMenuSection", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMenuSection> HasMenuSection { get; set; }

        /// <inheritdoc/>
        public bool Equals(Menu other)
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
                this.HasMenuItem == other.HasMenuItem &&
                this.HasMenuSection == other.HasMenuSection &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Menu);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.HasMenuItem)
            .And(this.HasMenuSection)
            .And(base.GetHashCode());
    }
}

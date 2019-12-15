namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A page devoted to a single item, such as a particular product or hotel.
    /// </summary>
    public partial interface IItemPage : IWebPage
    {
    }

    /// <summary>
    /// A page devoted to a single item, such as a particular product or hotel.
    /// </summary>
    [DataContract]
    public partial class ItemPage : WebPage, IItemPage, IEquatable<ItemPage>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ItemPage";

        /// <inheritdoc/>
        public bool Equals(ItemPage other)
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
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ItemPage);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

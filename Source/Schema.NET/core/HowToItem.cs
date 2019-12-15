namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An item used as either a tool or supply when performing the instructions for how to to achieve a result.
    /// </summary>
    public partial interface IHowToItem : IListItem
    {
        /// <summary>
        /// The required quantity of the item(s).
        /// </summary>
        Values<double?, IQuantitativeValue, string> RequiredQuantity { get; set; }
    }

    /// <summary>
    /// An item used as either a tool or supply when performing the instructions for how to to achieve a result.
    /// </summary>
    [DataContract]
    public partial class HowToItem : ListItem, IHowToItem, IEquatable<HowToItem>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToItem";

        /// <summary>
        /// The required quantity of the item(s).
        /// </summary>
        [DataMember(Name = "requiredQuantity", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<double?, IQuantitativeValue, string> RequiredQuantity { get; set; }

        /// <inheritdoc/>
        public bool Equals(HowToItem other)
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
                this.RequiredQuantity == other.RequiredQuantity &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as HowToItem);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.RequiredQuantity)
            .And(base.GetHashCode());
    }
}

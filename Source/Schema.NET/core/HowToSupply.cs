namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A supply consumed when performing the instructions for how to achieve a result.
    /// </summary>
    public partial interface IHowToSupply : IHowToItem
    {
        /// <summary>
        /// The estimated cost of the supply or supplies consumed when performing instructions.
        /// </summary>
        Values<IMonetaryAmount, string> EstimatedCost { get; set; }
    }

    /// <summary>
    /// A supply consumed when performing the instructions for how to achieve a result.
    /// </summary>
    [DataContract]
    public partial class HowToSupply : HowToItem, IHowToSupply, IEquatable<HowToSupply>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToSupply";

        /// <summary>
        /// The estimated cost of the supply or supplies consumed when performing instructions.
        /// </summary>
        [DataMember(Name = "estimatedCost", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMonetaryAmount, string> EstimatedCost { get; set; }

        /// <inheritdoc/>
        public bool Equals(HowToSupply other)
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
                this.EstimatedCost == other.EstimatedCost &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as HowToSupply);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.EstimatedCost)
            .And(base.GetHashCode());
    }
}

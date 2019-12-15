namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Auto body shop.
    /// </summary>
    public partial interface IAutoBodyShop : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// Auto body shop.
    /// </summary>
    [DataContract]
    public partial class AutoBodyShop : AutomotiveBusiness, IAutoBodyShop, IEquatable<AutoBodyShop>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutoBodyShop";

        /// <inheritdoc/>
        public bool Equals(AutoBodyShop other)
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
        public override bool Equals(object obj) => this.Equals(obj as AutoBodyShop);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

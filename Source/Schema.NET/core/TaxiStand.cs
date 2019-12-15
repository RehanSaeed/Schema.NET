namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A taxi stand.
    /// </summary>
    public partial interface ITaxiStand : ICivicStructure
    {
    }

    /// <summary>
    /// A taxi stand.
    /// </summary>
    [DataContract]
    public partial class TaxiStand : CivicStructure, ITaxiStand, IEquatable<TaxiStand>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TaxiStand";

        /// <inheritdoc/>
        public bool Equals(TaxiStand other)
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
        public override bool Equals(object obj) => this.Equals(obj as TaxiStand);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

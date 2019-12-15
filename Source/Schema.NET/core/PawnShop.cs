namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A shop that will buy, or lend money against the security of, personal possessions.
    /// </summary>
    public partial interface IPawnShop : IStore
    {
    }

    /// <summary>
    /// A shop that will buy, or lend money against the security of, personal possessions.
    /// </summary>
    [DataContract]
    public partial class PawnShop : Store, IPawnShop, IEquatable<PawnShop>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PawnShop";

        /// <inheritdoc/>
        public bool Equals(PawnShop other)
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
        public override bool Equals(object obj) => this.Equals(obj as PawnShop);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

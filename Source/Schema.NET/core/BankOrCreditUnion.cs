namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Bank or credit union.
    /// </summary>
    public partial interface IBankOrCreditUnion : IFinancialService
    {
    }

    /// <summary>
    /// Bank or credit union.
    /// </summary>
    [DataContract]
    public partial class BankOrCreditUnion : FinancialService, IBankOrCreditUnion, IEquatable<BankOrCreditUnion>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BankOrCreditUnion";

        /// <inheritdoc/>
        public bool Equals(BankOrCreditUnion other)
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
        public override bool Equals(object obj) => this.Equals(obj as BankOrCreditUnion);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

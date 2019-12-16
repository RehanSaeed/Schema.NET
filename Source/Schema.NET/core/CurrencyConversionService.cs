namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A service to convert funds from one currency to another currency.
    /// </summary>
    public partial interface ICurrencyConversionService : IFinancialProduct
    {
    }

    /// <summary>
    /// A service to convert funds from one currency to another currency.
    /// </summary>
    [DataContract]
    public partial class CurrencyConversionService : FinancialProduct, ICurrencyConversionService, IEquatable<CurrencyConversionService>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CurrencyConversionService";

        /// <inheritdoc/>
        public bool Equals(CurrencyConversionService other)
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
        public override bool Equals(object obj) => this.Equals(obj as CurrencyConversionService);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

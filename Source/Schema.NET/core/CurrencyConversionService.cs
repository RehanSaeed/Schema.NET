namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A service to convert funds from one currency to another currency.
    /// </summary>
    [DataContract]
    public partial class CurrencyConversionService : FinancialProduct
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CurrencyConversionService";
    }
}

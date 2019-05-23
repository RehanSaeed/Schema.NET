namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// </summary>
    public partial interface IUnitPriceSpecification : IPriceSpecification
    {
        /// <summary>
        /// This property specifies the minimal quantity and rounding increment that will be the basis for the billing. The unit of measurement is specified by the unitCode property.
        /// </summary>
        OneOrMany<double?> BillingIncrement { get; set; }

        /// <summary>
        /// A short text or acronym indicating multiple price specifications for the same offer, e.g. SRP for the suggested retail price or INVOICE for the invoice price, mostly used in the car industry.
        /// </summary>
        OneOrMany<string> PriceType { get; set; }

        /// <summary>
        /// The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity. This property is a replacement for unitOfMeasurement for the advanced cases where the price does not relate to a standard unit.
        /// </summary>
        OneOrMany<IQuantitativeValue> ReferenceQuantity { get; set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        Values<string, Uri>? UnitCode { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        OneOrMany<string> UnitText { get; set; }
    }

    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// </summary>
    [DataContract]
    public partial class UnitPriceSpecification : PriceSpecification, IUnitPriceSpecification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "UnitPriceSpecification";

        /// <summary>
        /// This property specifies the minimal quantity and rounding increment that will be the basis for the billing. The unit of measurement is specified by the unitCode property.
        /// </summary>
        [DataMember(Name = "billingIncrement", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> BillingIncrement { get; set; }

        /// <summary>
        /// A short text or acronym indicating multiple price specifications for the same offer, e.g. SRP for the suggested retail price or INVOICE for the invoice price, mostly used in the car industry.
        /// </summary>
        [DataMember(Name = "priceType", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> PriceType { get; set; }

        /// <summary>
        /// The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity. This property is a replacement for unitOfMeasurement for the advanced cases where the price does not relate to a standard unit.
        /// </summary>
        [DataMember(Name = "referenceQuantity", Order = 408)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> ReferenceQuantity { get; set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode", Order = 409)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri>? UnitCode { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText", Order = 410)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> UnitText { get; set; }
    }
}

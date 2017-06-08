namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The price asked for a given offer by the respective organization or person.
    /// </summary>
    [DataContract]
    public class UnitPriceSpecification : PriceSpecification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "UnitPriceSpecification";

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode")]
        public object UnitCode { get; protected set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [IgnoreDataMember]
        public string UnitCodeText
        {
            get => this.UnitCode as string;
            set => this.UnitCode = value;
        }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [IgnoreDataMember]
        public Uri UnitCodeURL
        {
            get => this.UnitCode as Uri;
            set => this.UnitCode = value;
        }

        /// <summary>
        /// This property specifies the minimal quantity and rounding increment that will be the basis for the billing. The unit of measurement is specified by the unitCode property.
        /// </summary>
        [DataMember(Name = "billingIncrement")]
        public decimal BillingIncrement { get; set; }

        /// <summary>
        /// The reference quantity for which a certain price applies, e.g. 1 EUR per 4 kWh of electricity. This property is a replacement for unitOfMeasurement for the advanced cases where the price does not relate to a standard unit.
        /// </summary>
        [DataMember(Name = "referenceQuantity")]
        public QuantitativeValue ReferenceQuantity { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText")]
        public string UnitText { get; set; }

        /// <summary>
        /// A short text or acronym indicating multiple price specifications for the same offer, e.g. SRP for the suggested retail price or INVOICE for the invoice price, mostly used in the car industry.
        /// </summary>
        [DataMember(Name = "priceType")]
        public string PriceType { get; set; }
    }
}

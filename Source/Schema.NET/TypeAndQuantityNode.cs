namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
    [DataContract]
    public class TypeAndQuantityNode : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TypeAndQuantityNode";

        /// <summary>
        /// The quantity of the goods included in the offer.
        /// </summary>
        [DataMember(Name = "amountOfThisGood", Order = 2)]
        public decimal? AmountOfThisGood { get; set; }

        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        [DataMember(Name = "businessFunction", Order = 3)]
        public BusinessFunction? BusinessFunction { get; set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [DataMember(Name = "typeOfGood", Order = 4)]
        public object TypeOfGood { get; protected set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [IgnoreDataMember]
        public Product TypeOfGoodProduct
        {
            get => this.TypeOfGood as Product;
            set => this.TypeOfGood = value;
        }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [IgnoreDataMember]
        public Service TypeOfGoodService
        {
            get => this.TypeOfGood as Service;
            set => this.TypeOfGood = value;
        }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode", Order = 5)]
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
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText", Order = 6)]
        public string UnitText { get; set; }
    }
}

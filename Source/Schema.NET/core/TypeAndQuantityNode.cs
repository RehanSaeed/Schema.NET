namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
    [DataContract]
    public partial class TypeAndQuantityNode : StructuredValue
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TypeAndQuantityNode";

        /// <summary>
        /// The quantity of the goods included in the offer.
        /// </summary>
        [DataMember(Name = "amountOfThisGood", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<decimal?>? AmountOfThisGood { get; set; }

        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        [DataMember(Name = "businessFunction", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BusinessFunction?>? BusinessFunction { get; set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [DataMember(Name = "typeOfGood", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Product, Service>? TypeOfGood { get; set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? UnitCode { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? UnitText { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
    public partial interface ITypeAndQuantityNode : IStructuredValue
    {
        /// <summary>
        /// The quantity of the goods included in the offer.
        /// </summary>
        OneOrMany<decimal?> AmountOfThisGood { get; set; }

        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        OneOrMany<BusinessFunction?> BusinessFunction { get; set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        Values<IProduct, IService> TypeOfGood { get; set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        Values<string, Uri> UnitCode { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        OneOrMany<string> UnitText { get; set; }
    }

    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
    [DataContract]
    public partial class TypeAndQuantityNode : StructuredValue, ITypeAndQuantityNode, IEquatable<TypeAndQuantityNode>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TypeAndQuantityNode";

        /// <summary>
        /// The quantity of the goods included in the offer.
        /// </summary>
        [DataMember(Name = "amountOfThisGood", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<decimal?> AmountOfThisGood { get; set; }

        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        [DataMember(Name = "businessFunction", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<BusinessFunction?> BusinessFunction { get; set; }

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [DataMember(Name = "typeOfGood", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IProduct, IService> TypeOfGood { get; set; }

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> UnitCode { get; set; }

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> UnitText { get; set; }

        /// <inheritdoc/>
        public bool Equals(TypeAndQuantityNode other)
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
                this.AmountOfThisGood == other.AmountOfThisGood &&
                this.BusinessFunction == other.BusinessFunction &&
                this.TypeOfGood == other.TypeOfGood &&
                this.UnitCode == other.UnitCode &&
                this.UnitText == other.UnitText &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as TypeAndQuantityNode);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AmountOfThisGood)
            .And(this.BusinessFunction)
            .And(this.TypeOfGood)
            .And(this.UnitCode)
            .And(this.UnitText)
            .And(base.GetHashCode());
    }
}

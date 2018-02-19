using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A structured value indicating the quantity, unit of measurement, and business function of goods included in a bundle offer.
    /// </summary>
    [DataContract]
    public partial class TypeAndQuantityNode : StructuredValue
    {
        public interface ITypeOfGood : IWrapper { }
        public interface ITypeOfGood<T> : ITypeOfGood { new T Data { get; set; } }
        public class TypeOfGoodProduct : ITypeOfGood<Product>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Product) value; } }
            public virtual Product Data { get; set; }
            public TypeOfGoodProduct () { }
            public TypeOfGoodProduct (Product data) { Data = data; }
            public static implicit operator TypeOfGoodProduct (Product data) { return new TypeOfGoodProduct (data); }
        }

        public class TypeOfGoodService : ITypeOfGood<Service>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Service) value; } }
            public virtual Service Data { get; set; }
            public TypeOfGoodService () { }
            public TypeOfGoodService (Service data) { Data = data; }
            public static implicit operator TypeOfGoodService (Service data) { return new TypeOfGoodService (data); }
        }


        public interface IUnitCode : IWrapper { }
        public interface IUnitCode<T> : IUnitCode { new T Data { get; set; } }
        public class UnitCodestring : IUnitCode<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public UnitCodestring () { }
            public UnitCodestring (string data) { Data = data; }
            public static implicit operator UnitCodestring (string data) { return new UnitCodestring (data); }
        }

        public class UnitCodeUri : IUnitCode<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public UnitCodeUri () { }
            public UnitCodeUri (Uri data) { Data = data; }
            public static implicit operator UnitCodeUri (Uri data) { return new UnitCodeUri (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TypeAndQuantityNode";

        /// <summary>
        /// The quantity of the goods included in the offer.
        /// </summary>
        [DataMember(Name = "amountOfThisGood", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<decimal>? AmountOfThisGood { get; set; } 

        /// <summary>
        /// The business function (e.g. sell, lease, repair, dispose) of the offer or component of a bundle (TypeAndQuantityNode). The default is http://purl.org/goodrelations/v1#Sell.
        /// </summary>
        [DataMember(Name = "businessFunction", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BusinessFunction>? BusinessFunction { get; set; } 

        /// <summary>
        /// The product that this structured value is referring to.
        /// </summary>
        [DataMember(Name = "typeOfGood", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITypeOfGood>? TypeOfGood { get; set; } //Product, Service

        /// <summary>
        /// The unit of measurement given using the UN/CEFACT Common Code (3 characters) or a URL. Other codes than the UN/CEFACT Common Code may be used with a prefix followed by a colon.
        /// </summary>
        [DataMember(Name = "unitCode", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IUnitCode>? UnitCode { get; set; } //string, Uri

        /// <summary>
        /// A string or text indicating the unit of measurement. Useful if you cannot provide a standard unit code for
        /// &lt;a href='unitCode'&gt;unitCode&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "unitText", Order = 310)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? UnitText { get; set; } 
    }
}

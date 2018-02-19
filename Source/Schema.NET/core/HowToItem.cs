using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An item used as either a tool or supply when performing the instructions for how to to achieve a result.
    /// </summary>
    [DataContract]
    public partial class HowToItem : ListItem
    {
        public interface IRequiredQuantity : IWrapper { }
        public interface IRequiredQuantity<T> : IRequiredQuantity { new T Data { get; set; } }
        public class RequiredQuantitydouble : IRequiredQuantity<double>
        {
            object IWrapper.Data { get { return Data; } set { Data = (double) value; } }
            public virtual double Data { get; set; }
            public RequiredQuantitydouble () { }
            public RequiredQuantitydouble (double data) { Data = data; }
            public static implicit operator RequiredQuantitydouble (double data) { return new RequiredQuantitydouble (data); }
        }

        public class RequiredQuantityQuantitativeValue : IRequiredQuantity<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public RequiredQuantityQuantitativeValue () { }
            public RequiredQuantityQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator RequiredQuantityQuantitativeValue (QuantitativeValue data) { return new RequiredQuantityQuantitativeValue (data); }
        }

        public class RequiredQuantitystring : IRequiredQuantity<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public RequiredQuantitystring () { }
            public RequiredQuantitystring (string data) { Data = data; }
            public static implicit operator RequiredQuantitystring (string data) { return new RequiredQuantitystring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToItem";

        /// <summary>
        /// The required quantity of the item(s).
        /// </summary>
        [DataMember(Name = "requiredQuantity", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IRequiredQuantity>? RequiredQuantity { get; set; } //double?, QuantitativeValue, string
    }
}

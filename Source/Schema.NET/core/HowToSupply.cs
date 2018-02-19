using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A supply consumed when performing the instructions for how to achieve a result.
    /// </summary>
    [DataContract]
    public partial class HowToSupply : HowToItem
    {
        public interface IEstimatedCost : IWrapper { }
        public interface IEstimatedCost<T> : IEstimatedCost { new T Data { get; set; } }
        public class EstimatedCostMonetaryAmount : IEstimatedCost<MonetaryAmount>
        {
            object IWrapper.Data { get { return Data; } set { Data = (MonetaryAmount) value; } }
            public virtual MonetaryAmount Data { get; set; }
            public EstimatedCostMonetaryAmount () { }
            public EstimatedCostMonetaryAmount (MonetaryAmount data) { Data = data; }
            public static implicit operator EstimatedCostMonetaryAmount (MonetaryAmount data) { return new EstimatedCostMonetaryAmount (data); }
        }

        public class EstimatedCoststring : IEstimatedCost<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public EstimatedCoststring () { }
            public EstimatedCoststring (string data) { Data = data; }
            public static implicit operator EstimatedCoststring (string data) { return new EstimatedCoststring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToSupply";

        /// <summary>
        /// The estimated cost of the supply or supplies consumed when performing instructions.
        /// </summary>
        [DataMember(Name = "estimatedCost", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IEstimatedCost>? EstimatedCost { get; set; } //MonetaryAmount, string
    }
}

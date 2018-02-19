using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
    [DataContract]
    public partial class HowTo : CreativeWork
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


        public interface ISteps : IWrapper { }
        public interface ISteps<T> : ISteps { new T Data { get; set; } }
        public class StepsCreativeWork : ISteps<CreativeWork>
        {
            object IWrapper.Data { get { return Data; } set { Data = (CreativeWork) value; } }
            public virtual CreativeWork Data { get; set; }
            public StepsCreativeWork () { }
            public StepsCreativeWork (CreativeWork data) { Data = data; }
            public static implicit operator StepsCreativeWork (CreativeWork data) { return new StepsCreativeWork (data); }
        }

        public class StepsItemList : ISteps<ItemList>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ItemList) value; } }
            public virtual ItemList Data { get; set; }
            public StepsItemList () { }
            public StepsItemList (ItemList data) { Data = data; }
            public static implicit operator StepsItemList (ItemList data) { return new StepsItemList (data); }
        }

        public class Stepsstring : ISteps<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Stepsstring () { }
            public Stepsstring (string data) { Data = data; }
            public static implicit operator Stepsstring (string data) { return new Stepsstring (data); }
        }


        public interface ISupply : IWrapper { }
        public interface ISupply<T> : ISupply { new T Data { get; set; } }
        public class SupplyHowToSupply : ISupply<HowToSupply>
        {
            object IWrapper.Data { get { return Data; } set { Data = (HowToSupply) value; } }
            public virtual HowToSupply Data { get; set; }
            public SupplyHowToSupply () { }
            public SupplyHowToSupply (HowToSupply data) { Data = data; }
            public static implicit operator SupplyHowToSupply (HowToSupply data) { return new SupplyHowToSupply (data); }
        }

        public class Supplystring : ISupply<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Supplystring () { }
            public Supplystring (string data) { Data = data; }
            public static implicit operator Supplystring (string data) { return new Supplystring (data); }
        }


        public interface ITool : IWrapper { }
        public interface ITool<T> : ITool { new T Data { get; set; } }
        public class ToolHowToTool : ITool<HowToTool>
        {
            object IWrapper.Data { get { return Data; } set { Data = (HowToTool) value; } }
            public virtual HowToTool Data { get; set; }
            public ToolHowToTool () { }
            public ToolHowToTool (HowToTool data) { Data = data; }
            public static implicit operator ToolHowToTool (HowToTool data) { return new ToolHowToTool (data); }
        }

        public class Toolstring : ITool<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Toolstring () { }
            public Toolstring (string data) { Data = data; }
            public static implicit operator Toolstring (string data) { return new Toolstring (data); }
        }


        public interface IYield : IWrapper { }
        public interface IYield<T> : IYield { new T Data { get; set; } }
        public class YieldQuantitativeValue : IYield<QuantitativeValue>
        {
            object IWrapper.Data { get { return Data; } set { Data = (QuantitativeValue) value; } }
            public virtual QuantitativeValue Data { get; set; }
            public YieldQuantitativeValue () { }
            public YieldQuantitativeValue (QuantitativeValue data) { Data = data; }
            public static implicit operator YieldQuantitativeValue (QuantitativeValue data) { return new YieldQuantitativeValue (data); }
        }

        public class Yieldstring : IYield<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Yieldstring () { }
            public Yieldstring (string data) { Data = data; }
            public static implicit operator Yieldstring (string data) { return new Yieldstring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowTo";

        /// <summary>
        /// The estimated cost of the supply or supplies consumed when performing instructions.
        /// </summary>
        [DataMember(Name = "estimatedCost", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IEstimatedCost>? EstimatedCost { get; set; } //MonetaryAmount, string

        /// <summary>
        /// The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "performTime", Order = 207)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan>? PerformTime { get; set; } 

        /// <summary>
        /// The length of time it takes to prepare the items to be used in instructions or a direction, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "prepTime", Order = 208)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan>? PrepTime { get; set; } 

        /// <summary>
        /// The steps in the form of a single item (text, document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
        /// </summary>
        [DataMember(Name = "steps", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISteps>? Steps { get; set; } //CreativeWork, ItemList, string

        /// <summary>
        /// A sub-property of instrument. A supply consumed when performing instructions or a direction.
        /// </summary>
        [DataMember(Name = "supply", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISupply>? Supply { get; set; } //HowToSupply, string

        /// <summary>
        /// A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.
        /// </summary>
        [DataMember(Name = "tool", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITool>? Tool { get; set; } //HowToTool, string

        /// <summary>
        /// The total time required to perform instructions or a direction (including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "totalTime", Order = 212)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan>? TotalTime { get; set; } 

        /// <summary>
        /// The quantity that results by performing instructions. For example, a paper airplane, 10 personalized candles.
        /// </summary>
        [DataMember(Name = "yield", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IYield>? Yield { get; set; } //QuantitativeValue, string
    }
}

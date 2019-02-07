namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
    [DataContract]
    public partial class HowTo : CreativeWork
    {
        public interface IEstimatedCost : IValue {}
        public interface IEstimatedCost<T> : IEstimatedCost { new T Value { get; } }
        public class OneOrManyEstimatedCost : OneOrMany<IEstimatedCost>
        {
            public OneOrManyEstimatedCost(IEstimatedCost item) : base(item) { }
            public OneOrManyEstimatedCost(IEnumerable<IEstimatedCost> items) : base(items) { }
            public static implicit operator OneOrManyEstimatedCost (MonetaryAmount value) { return new OneOrManyEstimatedCost (new EstimatedCostMonetaryAmount (value)); }
            public static implicit operator OneOrManyEstimatedCost (MonetaryAmount[] values) { return new OneOrManyEstimatedCost (values.Select(v => (IEstimatedCost) new EstimatedCostMonetaryAmount (v))); }
            public static implicit operator OneOrManyEstimatedCost (List<MonetaryAmount> values) { return new OneOrManyEstimatedCost (values.Select(v => (IEstimatedCost) new EstimatedCostMonetaryAmount (v))); }
            public static implicit operator OneOrManyEstimatedCost (string value) { return new OneOrManyEstimatedCost (new EstimatedCoststring (value)); }
            public static implicit operator OneOrManyEstimatedCost (string[] values) { return new OneOrManyEstimatedCost (values.Select(v => (IEstimatedCost) new EstimatedCoststring (v))); }
            public static implicit operator OneOrManyEstimatedCost (List<string> values) { return new OneOrManyEstimatedCost (values.Select(v => (IEstimatedCost) new EstimatedCoststring (v))); }
        }
        public struct EstimatedCostMonetaryAmount : IEstimatedCost<MonetaryAmount>
        {
            object IValue.Value => this.Value;
            public MonetaryAmount Value { get; }
            public EstimatedCostMonetaryAmount (MonetaryAmount value) { Value = value; }
            public static implicit operator EstimatedCostMonetaryAmount (MonetaryAmount value) { return new EstimatedCostMonetaryAmount (value); }
        }
        public struct EstimatedCoststring : IEstimatedCost<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EstimatedCoststring (string value) { Value = value; }
            public static implicit operator EstimatedCoststring (string value) { return new EstimatedCoststring (value); }
        }

        public interface IPerformTime : IValue {}
        public interface IPerformTime<T> : IPerformTime { new T Value { get; } }
        public class OneOrManyPerformTime : OneOrMany<IPerformTime>
        {
            public OneOrManyPerformTime(IPerformTime item) : base(item) { }
            public OneOrManyPerformTime(IEnumerable<IPerformTime> items) : base(items) { }
            public static implicit operator OneOrManyPerformTime (TimeSpan value) { return new OneOrManyPerformTime (new PerformTimeTimeSpan (value)); }
            public static implicit operator OneOrManyPerformTime (TimeSpan[] values) { return new OneOrManyPerformTime (values.Select(v => (IPerformTime) new PerformTimeTimeSpan (v))); }
            public static implicit operator OneOrManyPerformTime (List<TimeSpan> values) { return new OneOrManyPerformTime (values.Select(v => (IPerformTime) new PerformTimeTimeSpan (v))); }
        }
        public struct PerformTimeTimeSpan : IPerformTime<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public PerformTimeTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator PerformTimeTimeSpan (TimeSpan value) { return new PerformTimeTimeSpan (value); }
        }

        public interface IPrepTime : IValue {}
        public interface IPrepTime<T> : IPrepTime { new T Value { get; } }
        public class OneOrManyPrepTime : OneOrMany<IPrepTime>
        {
            public OneOrManyPrepTime(IPrepTime item) : base(item) { }
            public OneOrManyPrepTime(IEnumerable<IPrepTime> items) : base(items) { }
            public static implicit operator OneOrManyPrepTime (TimeSpan value) { return new OneOrManyPrepTime (new PrepTimeTimeSpan (value)); }
            public static implicit operator OneOrManyPrepTime (TimeSpan[] values) { return new OneOrManyPrepTime (values.Select(v => (IPrepTime) new PrepTimeTimeSpan (v))); }
            public static implicit operator OneOrManyPrepTime (List<TimeSpan> values) { return new OneOrManyPrepTime (values.Select(v => (IPrepTime) new PrepTimeTimeSpan (v))); }
        }
        public struct PrepTimeTimeSpan : IPrepTime<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public PrepTimeTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator PrepTimeTimeSpan (TimeSpan value) { return new PrepTimeTimeSpan (value); }
        }

        public interface IStep : IValue {}
        public interface IStep<T> : IStep { new T Value { get; } }
        public class OneOrManyStep : OneOrMany<IStep>
        {
            public OneOrManyStep(IStep item) : base(item) { }
            public OneOrManyStep(IEnumerable<IStep> items) : base(items) { }
            public static implicit operator OneOrManyStep (CreativeWork value) { return new OneOrManyStep (new StepCreativeWork (value)); }
            public static implicit operator OneOrManyStep (CreativeWork[] values) { return new OneOrManyStep (values.Select(v => (IStep) new StepCreativeWork (v))); }
            public static implicit operator OneOrManyStep (List<CreativeWork> values) { return new OneOrManyStep (values.Select(v => (IStep) new StepCreativeWork (v))); }
            public static implicit operator OneOrManyStep (HowToSection value) { return new OneOrManyStep (new StepHowToSection (value)); }
            public static implicit operator OneOrManyStep (HowToSection[] values) { return new OneOrManyStep (values.Select(v => (IStep) new StepHowToSection (v))); }
            public static implicit operator OneOrManyStep (List<HowToSection> values) { return new OneOrManyStep (values.Select(v => (IStep) new StepHowToSection (v))); }
            public static implicit operator OneOrManyStep (HowToStep value) { return new OneOrManyStep (new StepHowToStep (value)); }
            public static implicit operator OneOrManyStep (HowToStep[] values) { return new OneOrManyStep (values.Select(v => (IStep) new StepHowToStep (v))); }
            public static implicit operator OneOrManyStep (List<HowToStep> values) { return new OneOrManyStep (values.Select(v => (IStep) new StepHowToStep (v))); }
            public static implicit operator OneOrManyStep (string value) { return new OneOrManyStep (new Stepstring (value)); }
            public static implicit operator OneOrManyStep (string[] values) { return new OneOrManyStep (values.Select(v => (IStep) new Stepstring (v))); }
            public static implicit operator OneOrManyStep (List<string> values) { return new OneOrManyStep (values.Select(v => (IStep) new Stepstring (v))); }
        }
        public struct StepCreativeWork : IStep<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public StepCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator StepCreativeWork (CreativeWork value) { return new StepCreativeWork (value); }
        }
        public struct StepHowToSection : IStep<HowToSection>
        {
            object IValue.Value => this.Value;
            public HowToSection Value { get; }
            public StepHowToSection (HowToSection value) { Value = value; }
            public static implicit operator StepHowToSection (HowToSection value) { return new StepHowToSection (value); }
        }
        public struct StepHowToStep : IStep<HowToStep>
        {
            object IValue.Value => this.Value;
            public HowToStep Value { get; }
            public StepHowToStep (HowToStep value) { Value = value; }
            public static implicit operator StepHowToStep (HowToStep value) { return new StepHowToStep (value); }
        }
        public struct Stepstring : IStep<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Stepstring (string value) { Value = value; }
            public static implicit operator Stepstring (string value) { return new Stepstring (value); }
        }

        public interface ISupply : IValue {}
        public interface ISupply<T> : ISupply { new T Value { get; } }
        public class OneOrManySupply : OneOrMany<ISupply>
        {
            public OneOrManySupply(ISupply item) : base(item) { }
            public OneOrManySupply(IEnumerable<ISupply> items) : base(items) { }
            public static implicit operator OneOrManySupply (HowToSupply value) { return new OneOrManySupply (new SupplyHowToSupply (value)); }
            public static implicit operator OneOrManySupply (HowToSupply[] values) { return new OneOrManySupply (values.Select(v => (ISupply) new SupplyHowToSupply (v))); }
            public static implicit operator OneOrManySupply (List<HowToSupply> values) { return new OneOrManySupply (values.Select(v => (ISupply) new SupplyHowToSupply (v))); }
            public static implicit operator OneOrManySupply (string value) { return new OneOrManySupply (new Supplystring (value)); }
            public static implicit operator OneOrManySupply (string[] values) { return new OneOrManySupply (values.Select(v => (ISupply) new Supplystring (v))); }
            public static implicit operator OneOrManySupply (List<string> values) { return new OneOrManySupply (values.Select(v => (ISupply) new Supplystring (v))); }
        }
        public struct SupplyHowToSupply : ISupply<HowToSupply>
        {
            object IValue.Value => this.Value;
            public HowToSupply Value { get; }
            public SupplyHowToSupply (HowToSupply value) { Value = value; }
            public static implicit operator SupplyHowToSupply (HowToSupply value) { return new SupplyHowToSupply (value); }
        }
        public struct Supplystring : ISupply<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Supplystring (string value) { Value = value; }
            public static implicit operator Supplystring (string value) { return new Supplystring (value); }
        }

        public interface ITool : IValue {}
        public interface ITool<T> : ITool { new T Value { get; } }
        public class OneOrManyTool : OneOrMany<ITool>
        {
            public OneOrManyTool(ITool item) : base(item) { }
            public OneOrManyTool(IEnumerable<ITool> items) : base(items) { }
            public static implicit operator OneOrManyTool (HowToTool value) { return new OneOrManyTool (new ToolHowToTool (value)); }
            public static implicit operator OneOrManyTool (HowToTool[] values) { return new OneOrManyTool (values.Select(v => (ITool) new ToolHowToTool (v))); }
            public static implicit operator OneOrManyTool (List<HowToTool> values) { return new OneOrManyTool (values.Select(v => (ITool) new ToolHowToTool (v))); }
            public static implicit operator OneOrManyTool (string value) { return new OneOrManyTool (new Toolstring (value)); }
            public static implicit operator OneOrManyTool (string[] values) { return new OneOrManyTool (values.Select(v => (ITool) new Toolstring (v))); }
            public static implicit operator OneOrManyTool (List<string> values) { return new OneOrManyTool (values.Select(v => (ITool) new Toolstring (v))); }
        }
        public struct ToolHowToTool : ITool<HowToTool>
        {
            object IValue.Value => this.Value;
            public HowToTool Value { get; }
            public ToolHowToTool (HowToTool value) { Value = value; }
            public static implicit operator ToolHowToTool (HowToTool value) { return new ToolHowToTool (value); }
        }
        public struct Toolstring : ITool<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Toolstring (string value) { Value = value; }
            public static implicit operator Toolstring (string value) { return new Toolstring (value); }
        }

        public interface ITotalTime : IValue {}
        public interface ITotalTime<T> : ITotalTime { new T Value { get; } }
        public class OneOrManyTotalTime : OneOrMany<ITotalTime>
        {
            public OneOrManyTotalTime(ITotalTime item) : base(item) { }
            public OneOrManyTotalTime(IEnumerable<ITotalTime> items) : base(items) { }
            public static implicit operator OneOrManyTotalTime (TimeSpan value) { return new OneOrManyTotalTime (new TotalTimeTimeSpan (value)); }
            public static implicit operator OneOrManyTotalTime (TimeSpan[] values) { return new OneOrManyTotalTime (values.Select(v => (ITotalTime) new TotalTimeTimeSpan (v))); }
            public static implicit operator OneOrManyTotalTime (List<TimeSpan> values) { return new OneOrManyTotalTime (values.Select(v => (ITotalTime) new TotalTimeTimeSpan (v))); }
        }
        public struct TotalTimeTimeSpan : ITotalTime<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public TotalTimeTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator TotalTimeTimeSpan (TimeSpan value) { return new TotalTimeTimeSpan (value); }
        }

        public interface IYield : IValue {}
        public interface IYield<T> : IYield { new T Value { get; } }
        public class OneOrManyYield : OneOrMany<IYield>
        {
            public OneOrManyYield(IYield item) : base(item) { }
            public OneOrManyYield(IEnumerable<IYield> items) : base(items) { }
            public static implicit operator OneOrManyYield (QuantitativeValue value) { return new OneOrManyYield (new YieldQuantitativeValue (value)); }
            public static implicit operator OneOrManyYield (QuantitativeValue[] values) { return new OneOrManyYield (values.Select(v => (IYield) new YieldQuantitativeValue (v))); }
            public static implicit operator OneOrManyYield (List<QuantitativeValue> values) { return new OneOrManyYield (values.Select(v => (IYield) new YieldQuantitativeValue (v))); }
            public static implicit operator OneOrManyYield (string value) { return new OneOrManyYield (new Yieldstring (value)); }
            public static implicit operator OneOrManyYield (string[] values) { return new OneOrManyYield (values.Select(v => (IYield) new Yieldstring (v))); }
            public static implicit operator OneOrManyYield (List<string> values) { return new OneOrManyYield (values.Select(v => (IYield) new Yieldstring (v))); }
        }
        public struct YieldQuantitativeValue : IYield<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public YieldQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator YieldQuantitativeValue (QuantitativeValue value) { return new YieldQuantitativeValue (value); }
        }
        public struct Yieldstring : IYield<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Yieldstring (string value) { Value = value; }
            public static implicit operator Yieldstring (string value) { return new Yieldstring (value); }
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
        public OneOrManyEstimatedCost EstimatedCost { get; set; }

        /// <summary>
        /// The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "performTime", Order = 207)]
        public OneOrManyPerformTime PerformTime { get; set; }

        /// <summary>
        /// The length of time it takes to prepare the items to be used in instructions or a direction, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "prepTime", Order = 208)]
        public OneOrManyPrepTime PrepTime { get; set; }

        /// <summary>
        /// A single step item (as HowToStep, text, document, video, etc.) or a HowToSection.
        /// </summary>
        [DataMember(Name = "step", Order = 209)]
        public OneOrManyStep Step { get; set; }

        /// <summary>
        /// A sub-property of instrument. A supply consumed when performing instructions or a direction.
        /// </summary>
        [DataMember(Name = "supply", Order = 210)]
        public OneOrManySupply Supply { get; set; }

        /// <summary>
        /// A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.
        /// </summary>
        [DataMember(Name = "tool", Order = 211)]
        public OneOrManyTool Tool { get; set; }

        /// <summary>
        /// The total time required to perform instructions or a direction (including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "totalTime", Order = 212)]
        public OneOrManyTotalTime TotalTime { get; set; }

        /// <summary>
        /// The quantity that results by performing instructions. For example, a paper airplane, 10 personalized candles.
        /// </summary>
        [DataMember(Name = "yield", Order = 213)]
        public OneOrManyYield Yield { get; set; }
    }
}

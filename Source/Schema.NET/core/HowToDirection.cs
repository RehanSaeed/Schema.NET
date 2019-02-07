namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// </summary>
    [DataContract]
    public partial class HowToDirection : CreativeWorkAndListItem
    {
        public interface IAfterMedia : IValue {}
        public interface IAfterMedia<T> : IAfterMedia { new T Value { get; } }
        public class OneOrManyAfterMedia : OneOrMany<IAfterMedia>
        {
            public OneOrManyAfterMedia(IAfterMedia item) : base(item) { }
            public OneOrManyAfterMedia(IEnumerable<IAfterMedia> items) : base(items) { }
            public static implicit operator OneOrManyAfterMedia (MediaObject value) { return new OneOrManyAfterMedia (new AfterMediaMediaObject (value)); }
            public static implicit operator OneOrManyAfterMedia (MediaObject[] values) { return new OneOrManyAfterMedia (values.Select(v => (IAfterMedia) new AfterMediaMediaObject (v))); }
            public static implicit operator OneOrManyAfterMedia (List<MediaObject> values) { return new OneOrManyAfterMedia (values.Select(v => (IAfterMedia) new AfterMediaMediaObject (v))); }
            public static implicit operator OneOrManyAfterMedia (Uri value) { return new OneOrManyAfterMedia (new AfterMediaUri (value)); }
            public static implicit operator OneOrManyAfterMedia (Uri[] values) { return new OneOrManyAfterMedia (values.Select(v => (IAfterMedia) new AfterMediaUri (v))); }
            public static implicit operator OneOrManyAfterMedia (List<Uri> values) { return new OneOrManyAfterMedia (values.Select(v => (IAfterMedia) new AfterMediaUri (v))); }
        }
        public struct AfterMediaMediaObject : IAfterMedia<MediaObject>
        {
            object IValue.Value => this.Value;
            public MediaObject Value { get; }
            public AfterMediaMediaObject (MediaObject value) { Value = value; }
            public static implicit operator AfterMediaMediaObject (MediaObject value) { return new AfterMediaMediaObject (value); }
        }
        public struct AfterMediaUri : IAfterMedia<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public AfterMediaUri (Uri value) { Value = value; }
            public static implicit operator AfterMediaUri (Uri value) { return new AfterMediaUri (value); }
        }

        public interface IBeforeMedia : IValue {}
        public interface IBeforeMedia<T> : IBeforeMedia { new T Value { get; } }
        public class OneOrManyBeforeMedia : OneOrMany<IBeforeMedia>
        {
            public OneOrManyBeforeMedia(IBeforeMedia item) : base(item) { }
            public OneOrManyBeforeMedia(IEnumerable<IBeforeMedia> items) : base(items) { }
            public static implicit operator OneOrManyBeforeMedia (MediaObject value) { return new OneOrManyBeforeMedia (new BeforeMediaMediaObject (value)); }
            public static implicit operator OneOrManyBeforeMedia (MediaObject[] values) { return new OneOrManyBeforeMedia (values.Select(v => (IBeforeMedia) new BeforeMediaMediaObject (v))); }
            public static implicit operator OneOrManyBeforeMedia (List<MediaObject> values) { return new OneOrManyBeforeMedia (values.Select(v => (IBeforeMedia) new BeforeMediaMediaObject (v))); }
            public static implicit operator OneOrManyBeforeMedia (Uri value) { return new OneOrManyBeforeMedia (new BeforeMediaUri (value)); }
            public static implicit operator OneOrManyBeforeMedia (Uri[] values) { return new OneOrManyBeforeMedia (values.Select(v => (IBeforeMedia) new BeforeMediaUri (v))); }
            public static implicit operator OneOrManyBeforeMedia (List<Uri> values) { return new OneOrManyBeforeMedia (values.Select(v => (IBeforeMedia) new BeforeMediaUri (v))); }
        }
        public struct BeforeMediaMediaObject : IBeforeMedia<MediaObject>
        {
            object IValue.Value => this.Value;
            public MediaObject Value { get; }
            public BeforeMediaMediaObject (MediaObject value) { Value = value; }
            public static implicit operator BeforeMediaMediaObject (MediaObject value) { return new BeforeMediaMediaObject (value); }
        }
        public struct BeforeMediaUri : IBeforeMedia<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public BeforeMediaUri (Uri value) { Value = value; }
            public static implicit operator BeforeMediaUri (Uri value) { return new BeforeMediaUri (value); }
        }

        public interface IDuringMedia : IValue {}
        public interface IDuringMedia<T> : IDuringMedia { new T Value { get; } }
        public class OneOrManyDuringMedia : OneOrMany<IDuringMedia>
        {
            public OneOrManyDuringMedia(IDuringMedia item) : base(item) { }
            public OneOrManyDuringMedia(IEnumerable<IDuringMedia> items) : base(items) { }
            public static implicit operator OneOrManyDuringMedia (MediaObject value) { return new OneOrManyDuringMedia (new DuringMediaMediaObject (value)); }
            public static implicit operator OneOrManyDuringMedia (MediaObject[] values) { return new OneOrManyDuringMedia (values.Select(v => (IDuringMedia) new DuringMediaMediaObject (v))); }
            public static implicit operator OneOrManyDuringMedia (List<MediaObject> values) { return new OneOrManyDuringMedia (values.Select(v => (IDuringMedia) new DuringMediaMediaObject (v))); }
            public static implicit operator OneOrManyDuringMedia (Uri value) { return new OneOrManyDuringMedia (new DuringMediaUri (value)); }
            public static implicit operator OneOrManyDuringMedia (Uri[] values) { return new OneOrManyDuringMedia (values.Select(v => (IDuringMedia) new DuringMediaUri (v))); }
            public static implicit operator OneOrManyDuringMedia (List<Uri> values) { return new OneOrManyDuringMedia (values.Select(v => (IDuringMedia) new DuringMediaUri (v))); }
        }
        public struct DuringMediaMediaObject : IDuringMedia<MediaObject>
        {
            object IValue.Value => this.Value;
            public MediaObject Value { get; }
            public DuringMediaMediaObject (MediaObject value) { Value = value; }
            public static implicit operator DuringMediaMediaObject (MediaObject value) { return new DuringMediaMediaObject (value); }
        }
        public struct DuringMediaUri : IDuringMedia<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public DuringMediaUri (Uri value) { Value = value; }
            public static implicit operator DuringMediaUri (Uri value) { return new DuringMediaUri (value); }
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

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToDirection";

        /// <summary>
        /// A media object representing the circumstances after performing this direction.
        /// </summary>
        [DataMember(Name = "afterMedia", Order = 306)]
        public OneOrManyAfterMedia AfterMedia { get; set; }

        /// <summary>
        /// A media object representing the circumstances before performing this direction.
        /// </summary>
        [DataMember(Name = "beforeMedia", Order = 307)]
        public OneOrManyBeforeMedia BeforeMedia { get; set; }

        /// <summary>
        /// A media object representing the circumstances while performing this direction.
        /// </summary>
        [DataMember(Name = "duringMedia", Order = 308)]
        public OneOrManyDuringMedia DuringMedia { get; set; }

        /// <summary>
        /// The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "performTime", Order = 309)]
        public OneOrManyPerformTime PerformTime { get; set; }

        /// <summary>
        /// The length of time it takes to prepare the items to be used in instructions or a direction, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "prepTime", Order = 310)]
        public OneOrManyPrepTime PrepTime { get; set; }

        /// <summary>
        /// A sub-property of instrument. A supply consumed when performing instructions or a direction.
        /// </summary>
        [DataMember(Name = "supply", Order = 311)]
        public OneOrManySupply Supply { get; set; }

        /// <summary>
        /// A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.
        /// </summary>
        [DataMember(Name = "tool", Order = 312)]
        public OneOrManyTool Tool { get; set; }

        /// <summary>
        /// The total time required to perform instructions or a direction (including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "totalTime", Order = 313)]
        public OneOrManyTotalTime TotalTime { get; set; }
    }
}

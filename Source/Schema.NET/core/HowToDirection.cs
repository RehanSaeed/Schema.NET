using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A direction indicating a single action to do in the instructions for how to achieve a result.
    /// </summary>
    [DataContract]
    public partial class HowToDirection : ListItem
    {
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


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HowToDirection";

        /// <summary>
        /// A media object representing the circumstances after performing this direction.
        /// </summary>
        [DataMember(Name = "afterMedia", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MediaObject>? AfterMedia { get; set; } 

        /// <summary>
        /// A media object representing the circumstances before performing this direction.
        /// </summary>
        [DataMember(Name = "beforeMedia", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MediaObject>? BeforeMedia { get; set; } 

        /// <summary>
        /// A media object representing the circumstances while performing this direction.
        /// </summary>
        [DataMember(Name = "duringMedia", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<MediaObject>? DuringMedia { get; set; } 

        /// <summary>
        /// The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "performTime", Order = 309)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan>? PerformTime { get; set; } 

        /// <summary>
        /// The length of time it takes to prepare the items to be used in instructions or a direction, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "prepTime", Order = 310)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan>? PrepTime { get; set; } 

        /// <summary>
        /// A sub-property of instrument. A supply consumed when performing instructions or a direction.
        /// </summary>
        [DataMember(Name = "supply", Order = 311)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISupply>? Supply { get; set; } //HowToSupply, string

        /// <summary>
        /// A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.
        /// </summary>
        [DataMember(Name = "tool", Order = 312)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ITool>? Tool { get; set; } //HowToTool, string

        /// <summary>
        /// The total time required to perform instructions or a direction (including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "totalTime", Order = 313)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan>? TotalTime { get; set; } 
    }
}

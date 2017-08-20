namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Instructions that explain how to achieve a result by performing a sequence of steps.
    /// </summary>
    [DataContract]
    public partial class HowTo : CreativeWork
    {
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
        public Values<MonetaryAmount, string>? EstimatedCost { get; set; }

        /// <summary>
        /// The length of time it takes to perform instructions or a direction (not including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "performTime", Order = 207)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan?>? PerformTime { get; set; }

        /// <summary>
        /// The length of time it takes to prepare the items to be used in instructions or a direction, in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "prepTime", Order = 208)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan?>? PrepTime { get; set; }

        /// <summary>
        /// The steps in the form of a single item (text, document, video, etc.) or an ordered list with HowToStep and/or HowToSection items.
        /// </summary>
        [DataMember(Name = "steps", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork, ItemList, string>? Steps { get; set; }

        /// <summary>
        /// A sub-property of instrument. A supply consumed when performing instructions or a direction.
        /// </summary>
        [DataMember(Name = "supply", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<HowToSupply, string>? Supply { get; set; }

        /// <summary>
        /// A sub property of instrument. An object used (but not consumed) when performing instructions or a direction.
        /// </summary>
        [DataMember(Name = "tool", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<HowToTool, string>? Tool { get; set; }

        /// <summary>
        /// The total time required to perform instructions or a direction (including time to prepare the supplies), in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 duration format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "totalTime", Order = 212)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesConverter))]
        public Values<TimeSpan?>? TotalTime { get; set; }

        /// <summary>
        /// The quantity that results by performing instructions. For example, a paper airplane, 10 personalized candles.
        /// </summary>
        [DataMember(Name = "yield", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue, string>? Yield { get; set; }
    }
}

﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A statistical distribution of values.
    /// </summary>
    public partial interface IQuantitativeValueDistribution : IStructuredValue
    {
        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// The median value.
        /// </summary>
        OneOrMany<double?> Median { get; set; }

        /// <summary>
        /// The 10th percentile value.
        /// </summary>
        OneOrMany<double?> Percentile10 { get; set; }

        /// <summary>
        /// The 25th percentile value.
        /// </summary>
        OneOrMany<double?> Percentile25 { get; set; }

        /// <summary>
        /// The 75th percentile value.
        /// </summary>
        OneOrMany<double?> Percentile75 { get; set; }

        /// <summary>
        /// The 90th percentile value.
        /// </summary>
        OneOrMany<double?> Percentile90 { get; set; }
    }

    /// <summary>
    /// A statistical distribution of values.
    /// </summary>
    [DataContract]
    public partial class QuantitativeValueDistribution : StructuredValue, IQuantitativeValueDistribution, IEquatable<QuantitativeValueDistribution>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "QuantitativeValueDistribution";

        /// <summary>
        /// The duration of the item (movie, audio recording, event, etc.) in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "duration", Order = 306)]
        [JsonConverter(typeof(TimeSpanToISO8601DurationValuesJsonConverter))]
        public OneOrMany<TimeSpan?> Duration { get; set; }

        /// <summary>
        /// The median value.
        /// </summary>
        [DataMember(Name = "median", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> Median { get; set; }

        /// <summary>
        /// The 10th percentile value.
        /// </summary>
        [DataMember(Name = "percentile10", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> Percentile10 { get; set; }

        /// <summary>
        /// The 25th percentile value.
        /// </summary>
        [DataMember(Name = "percentile25", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> Percentile25 { get; set; }

        /// <summary>
        /// The 75th percentile value.
        /// </summary>
        [DataMember(Name = "percentile75", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> Percentile75 { get; set; }

        /// <summary>
        /// The 90th percentile value.
        /// </summary>
        [DataMember(Name = "percentile90", Order = 311)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<double?> Percentile90 { get; set; }

        /// <inheritdoc/>
        public bool Equals(QuantitativeValueDistribution other)
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
                this.Duration == other.Duration &&
                this.Median == other.Median &&
                this.Percentile10 == other.Percentile10 &&
                this.Percentile25 == other.Percentile25 &&
                this.Percentile75 == other.Percentile75 &&
                this.Percentile90 == other.Percentile90 &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as QuantitativeValueDistribution);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Duration)
            .And(this.Median)
            .And(this.Percentile10)
            .And(this.Percentile25)
            .And(this.Percentile75)
            .And(this.Percentile90)
            .And(base.GetHashCode());
    }
}

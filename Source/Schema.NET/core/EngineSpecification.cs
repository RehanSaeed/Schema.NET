namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// </summary>
    public partial interface IEngineSpecification : IStructuredValue
    {
        /// <summary>
        /// The volume swept by all of the pistons inside the cylinders of an internal combustion engine in a single movement. &lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): CMQ for cubic centimeter, LTR for liters, INQ for cubic inches
        /// * Note 1: You can link to information about how the given value has been determined using the &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt; property.
        /// * Note 2: You can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.
        /// </summary>
        OneOrMany<IQuantitativeValue> EngineDisplacement { get; set; }

        /// <summary>
        /// The power of the vehicle's engine.
        ///     Typical unit code(s): KWT for kilowatt, BHP for brake horsepower, N12 for metric horsepower (PS, with 1 PS = 735,49875 W)&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: There are many different ways of measuring an engine's power. For an overview, see  &lt;a href="http://en.wikipedia.org/wiki/Horsepower#Engine_power_test_codes"&gt;http://en.wikipedia.org/wiki/Horsepower#Engine&lt;em&gt;power&lt;/em&gt;test_codes&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You can link to information about how the given value has been determined using the &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt; property.&lt;/li&gt;
        /// &lt;li&gt;Note 3: You can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        OneOrMany<IQuantitativeValue> EnginePower { get; set; }

        /// <summary>
        /// The type of engine or engines powering the vehicle.
        /// </summary>
        Values<string, Uri> EngineType { get; set; }

        /// <summary>
        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        Values<string, Uri> FuelType { get; set; }

        /// <summary>
        /// The torque (turning force) of the vehicle's engine.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): NU for newton metre (N m), F17 for pound-force per foot, or F48 for pound-force per inch&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can link to information about how the given value has been determined (e.g. reference RPM) using the &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt; property.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        OneOrMany<IQuantitativeValue> Torque { get; set; }
    }

    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// </summary>
    [DataContract]
    public partial class EngineSpecification : StructuredValue, IEngineSpecification, IEquatable<EngineSpecification>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EngineSpecification";

        /// <summary>
        /// The volume swept by all of the pistons inside the cylinders of an internal combustion engine in a single movement. &lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): CMQ for cubic centimeter, LTR for liters, INQ for cubic inches
        /// * Note 1: You can link to information about how the given value has been determined using the &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt; property.
        /// * Note 2: You can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.
        /// </summary>
        [DataMember(Name = "engineDisplacement", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> EngineDisplacement { get; set; }

        /// <summary>
        /// The power of the vehicle's engine.
        ///     Typical unit code(s): KWT for kilowatt, BHP for brake horsepower, N12 for metric horsepower (PS, with 1 PS = 735,49875 W)&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: There are many different ways of measuring an engine's power. For an overview, see  &lt;a href="http://en.wikipedia.org/wiki/Horsepower#Engine_power_test_codes"&gt;http://en.wikipedia.org/wiki/Horsepower#Engine&lt;em&gt;power&lt;/em&gt;test_codes&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You can link to information about how the given value has been determined using the &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt; property.&lt;/li&gt;
        /// &lt;li&gt;Note 3: You can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "enginePower", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> EnginePower { get; set; }

        /// <summary>
        /// The type of engine or engines powering the vehicle.
        /// </summary>
        [DataMember(Name = "engineType", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> EngineType { get; set; }

        /// <summary>
        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        [DataMember(Name = "fuelType", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> FuelType { get; set; }

        /// <summary>
        /// The torque (turning force) of the vehicle's engine.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): NU for newton metre (N m), F17 for pound-force per foot, or F48 for pound-force per inch&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can link to information about how the given value has been determined (e.g. reference RPM) using the &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt; property.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "torque", Order = 310)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> Torque { get; set; }

        /// <inheritdoc/>
        public bool Equals(EngineSpecification other)
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
                this.EngineDisplacement == other.EngineDisplacement &&
                this.EnginePower == other.EnginePower &&
                this.EngineType == other.EngineType &&
                this.FuelType == other.FuelType &&
                this.Torque == other.Torque &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as EngineSpecification);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.EngineDisplacement)
            .And(this.EnginePower)
            .And(this.EngineType)
            .And(this.FuelType)
            .And(this.Torque)
            .And(base.GetHashCode());
    }
}

namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Information about the engine of the vehicle. A vehicle can have multiple engines represented by multiple engine specification entities.
    /// </summary>
    [DataContract]
    public partial class EngineSpecification : StructuredValue
    {
        public interface IEngineDisplacement : IValue {}
        public interface IEngineDisplacement<T> : IEngineDisplacement { new T Value { get; } }
        public class OneOrManyEngineDisplacement : OneOrMany<IEngineDisplacement>
        {
            public OneOrManyEngineDisplacement(IEngineDisplacement item) : base(item) { }
            public OneOrManyEngineDisplacement(IEnumerable<IEngineDisplacement> items) : base(items) { }
            public static implicit operator OneOrManyEngineDisplacement (QuantitativeValue value) { return new OneOrManyEngineDisplacement (new EngineDisplacementQuantitativeValue (value)); }
            public static implicit operator OneOrManyEngineDisplacement (QuantitativeValue[] values) { return new OneOrManyEngineDisplacement (values.Select(v => (IEngineDisplacement) new EngineDisplacementQuantitativeValue (v))); }
            public static implicit operator OneOrManyEngineDisplacement (List<QuantitativeValue> values) { return new OneOrManyEngineDisplacement (values.Select(v => (IEngineDisplacement) new EngineDisplacementQuantitativeValue (v))); }
        }
        public struct EngineDisplacementQuantitativeValue : IEngineDisplacement<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public EngineDisplacementQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator EngineDisplacementQuantitativeValue (QuantitativeValue value) { return new EngineDisplacementQuantitativeValue (value); }
        }

        public interface IEnginePower : IValue {}
        public interface IEnginePower<T> : IEnginePower { new T Value { get; } }
        public class OneOrManyEnginePower : OneOrMany<IEnginePower>
        {
            public OneOrManyEnginePower(IEnginePower item) : base(item) { }
            public OneOrManyEnginePower(IEnumerable<IEnginePower> items) : base(items) { }
            public static implicit operator OneOrManyEnginePower (QuantitativeValue value) { return new OneOrManyEnginePower (new EnginePowerQuantitativeValue (value)); }
            public static implicit operator OneOrManyEnginePower (QuantitativeValue[] values) { return new OneOrManyEnginePower (values.Select(v => (IEnginePower) new EnginePowerQuantitativeValue (v))); }
            public static implicit operator OneOrManyEnginePower (List<QuantitativeValue> values) { return new OneOrManyEnginePower (values.Select(v => (IEnginePower) new EnginePowerQuantitativeValue (v))); }
        }
        public struct EnginePowerQuantitativeValue : IEnginePower<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public EnginePowerQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator EnginePowerQuantitativeValue (QuantitativeValue value) { return new EnginePowerQuantitativeValue (value); }
        }

        public interface IEngineType : IValue {}
        public interface IEngineType<T> : IEngineType { new T Value { get; } }
        public class OneOrManyEngineType : OneOrMany<IEngineType>
        {
            public OneOrManyEngineType(IEngineType item) : base(item) { }
            public OneOrManyEngineType(IEnumerable<IEngineType> items) : base(items) { }
            public static implicit operator OneOrManyEngineType (string value) { return new OneOrManyEngineType (new EngineTypestring (value)); }
            public static implicit operator OneOrManyEngineType (string[] values) { return new OneOrManyEngineType (values.Select(v => (IEngineType) new EngineTypestring (v))); }
            public static implicit operator OneOrManyEngineType (List<string> values) { return new OneOrManyEngineType (values.Select(v => (IEngineType) new EngineTypestring (v))); }
            public static implicit operator OneOrManyEngineType (Uri value) { return new OneOrManyEngineType (new EngineTypeUri (value)); }
            public static implicit operator OneOrManyEngineType (Uri[] values) { return new OneOrManyEngineType (values.Select(v => (IEngineType) new EngineTypeUri (v))); }
            public static implicit operator OneOrManyEngineType (List<Uri> values) { return new OneOrManyEngineType (values.Select(v => (IEngineType) new EngineTypeUri (v))); }
        }
        public struct EngineTypestring : IEngineType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EngineTypestring (string value) { Value = value; }
            public static implicit operator EngineTypestring (string value) { return new EngineTypestring (value); }
        }
        public struct EngineTypeUri : IEngineType<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public EngineTypeUri (Uri value) { Value = value; }
            public static implicit operator EngineTypeUri (Uri value) { return new EngineTypeUri (value); }
        }

        public interface IFuelType : IValue {}
        public interface IFuelType<T> : IFuelType { new T Value { get; } }
        public class OneOrManyFuelType : OneOrMany<IFuelType>
        {
            public OneOrManyFuelType(IFuelType item) : base(item) { }
            public OneOrManyFuelType(IEnumerable<IFuelType> items) : base(items) { }
            public static implicit operator OneOrManyFuelType (string value) { return new OneOrManyFuelType (new FuelTypestring (value)); }
            public static implicit operator OneOrManyFuelType (string[] values) { return new OneOrManyFuelType (values.Select(v => (IFuelType) new FuelTypestring (v))); }
            public static implicit operator OneOrManyFuelType (List<string> values) { return new OneOrManyFuelType (values.Select(v => (IFuelType) new FuelTypestring (v))); }
            public static implicit operator OneOrManyFuelType (Uri value) { return new OneOrManyFuelType (new FuelTypeUri (value)); }
            public static implicit operator OneOrManyFuelType (Uri[] values) { return new OneOrManyFuelType (values.Select(v => (IFuelType) new FuelTypeUri (v))); }
            public static implicit operator OneOrManyFuelType (List<Uri> values) { return new OneOrManyFuelType (values.Select(v => (IFuelType) new FuelTypeUri (v))); }
        }
        public struct FuelTypestring : IFuelType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public FuelTypestring (string value) { Value = value; }
            public static implicit operator FuelTypestring (string value) { return new FuelTypestring (value); }
        }
        public struct FuelTypeUri : IFuelType<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public FuelTypeUri (Uri value) { Value = value; }
            public static implicit operator FuelTypeUri (Uri value) { return new FuelTypeUri (value); }
        }

        public interface ITorque : IValue {}
        public interface ITorque<T> : ITorque { new T Value { get; } }
        public class OneOrManyTorque : OneOrMany<ITorque>
        {
            public OneOrManyTorque(ITorque item) : base(item) { }
            public OneOrManyTorque(IEnumerable<ITorque> items) : base(items) { }
            public static implicit operator OneOrManyTorque (QuantitativeValue value) { return new OneOrManyTorque (new TorqueQuantitativeValue (value)); }
            public static implicit operator OneOrManyTorque (QuantitativeValue[] values) { return new OneOrManyTorque (values.Select(v => (ITorque) new TorqueQuantitativeValue (v))); }
            public static implicit operator OneOrManyTorque (List<QuantitativeValue> values) { return new OneOrManyTorque (values.Select(v => (ITorque) new TorqueQuantitativeValue (v))); }
        }
        public struct TorqueQuantitativeValue : ITorque<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public TorqueQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator TorqueQuantitativeValue (QuantitativeValue value) { return new TorqueQuantitativeValue (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EngineSpecification";

        /// <summary>
        /// The volume swept by all of the pistons inside the cylinders of an internal combustion engine in a single movement. &lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): CMQ for cubic centimeter, LTR for liters, INQ for cubic inches
        /// * Note 1: You can link to information about how the given value has been determined using the &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; property.
        /// * Note 2: You can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.
        /// </summary>
        [DataMember(Name = "engineDisplacement", Order = 306)]
        public OneOrManyEngineDisplacement EngineDisplacement { get; set; }

        /// <summary>
        /// The power of the vehicle's engine.
        ///     Typical unit code(s): KWT for kilowatt, BHP for brake horsepower, N12 for metric horsepower (PS, with 1 PS = 735,49875 W)&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: There are many different ways of measuring an engine's power. For an overview, see  &lt;a href="http://en.wikipedia.org/wiki/Horsepower#Engine_power_test_codes"&gt;http://en.wikipedia.org/wiki/Horsepower#Engine&lt;em&gt;power&lt;/em&gt;test_codes&lt;/a&gt;.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You can link to information about how the given value has been determined using the &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; property.&lt;/li&gt;
        /// &lt;li&gt;Note 3: You can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "enginePower", Order = 307)]
        public OneOrManyEnginePower EnginePower { get; set; }

        /// <summary>
        /// The type of engine or engines powering the vehicle.
        /// </summary>
        [DataMember(Name = "engineType", Order = 308)]
        public OneOrManyEngineType EngineType { get; set; }

        /// <summary>
        /// The type of fuel suitable for the engine or engines of the vehicle. If the vehicle has only one engine, this property can be attached directly to the vehicle.
        /// </summary>
        [DataMember(Name = "fuelType", Order = 309)]
        public OneOrManyFuelType FuelType { get; set; }

        /// <summary>
        /// The torque (turning force) of the vehicle's engine.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): NU for newton metre (N m), F17 for pound-force per foot, or F48 for pound-force per inch&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can link to information about how the given value has been determined (e.g. reference RPM) using the &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt; property.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "torque", Order = 310)]
        public OneOrManyTorque Torque { get; set; }
    }
}

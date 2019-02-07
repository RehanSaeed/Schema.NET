namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A specific dosing schedule for a drug or supplement.
    /// </summary>
    [DataContract]
    public partial class DoseSchedule : MedicalIntangible
    {
        public interface IDoseUnit : IValue {}
        public interface IDoseUnit<T> : IDoseUnit { new T Value { get; } }
        public class OneOrManyDoseUnit : OneOrMany<IDoseUnit>
        {
            public OneOrManyDoseUnit(IDoseUnit item) : base(item) { }
            public OneOrManyDoseUnit(IEnumerable<IDoseUnit> items) : base(items) { }
            public static implicit operator OneOrManyDoseUnit (string value) { return new OneOrManyDoseUnit (new DoseUnitstring (value)); }
            public static implicit operator OneOrManyDoseUnit (string[] values) { return new OneOrManyDoseUnit (values.Select(v => (IDoseUnit) new DoseUnitstring (v))); }
            public static implicit operator OneOrManyDoseUnit (List<string> values) { return new OneOrManyDoseUnit (values.Select(v => (IDoseUnit) new DoseUnitstring (v))); }
        }
        public struct DoseUnitstring : IDoseUnit<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public DoseUnitstring (string value) { Value = value; }
            public static implicit operator DoseUnitstring (string value) { return new DoseUnitstring (value); }
        }

        public interface IDoseValue : IValue {}
        public interface IDoseValue<T> : IDoseValue { new T Value { get; } }
        public class OneOrManyDoseValue : OneOrMany<IDoseValue>
        {
            public OneOrManyDoseValue(IDoseValue item) : base(item) { }
            public OneOrManyDoseValue(IEnumerable<IDoseValue> items) : base(items) { }
            public static implicit operator OneOrManyDoseValue (double value) { return new OneOrManyDoseValue (new DoseValuedouble (value)); }
            public static implicit operator OneOrManyDoseValue (double[] values) { return new OneOrManyDoseValue (values.Select(v => (IDoseValue) new DoseValuedouble (v))); }
            public static implicit operator OneOrManyDoseValue (List<double> values) { return new OneOrManyDoseValue (values.Select(v => (IDoseValue) new DoseValuedouble (v))); }
        }
        public struct DoseValuedouble : IDoseValue<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public DoseValuedouble (double value) { Value = value; }
            public static implicit operator DoseValuedouble (double value) { return new DoseValuedouble (value); }
        }

        public interface IFrequency : IValue {}
        public interface IFrequency<T> : IFrequency { new T Value { get; } }
        public class OneOrManyFrequency : OneOrMany<IFrequency>
        {
            public OneOrManyFrequency(IFrequency item) : base(item) { }
            public OneOrManyFrequency(IEnumerable<IFrequency> items) : base(items) { }
            public static implicit operator OneOrManyFrequency (string value) { return new OneOrManyFrequency (new Frequencystring (value)); }
            public static implicit operator OneOrManyFrequency (string[] values) { return new OneOrManyFrequency (values.Select(v => (IFrequency) new Frequencystring (v))); }
            public static implicit operator OneOrManyFrequency (List<string> values) { return new OneOrManyFrequency (values.Select(v => (IFrequency) new Frequencystring (v))); }
        }
        public struct Frequencystring : IFrequency<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Frequencystring (string value) { Value = value; }
            public static implicit operator Frequencystring (string value) { return new Frequencystring (value); }
        }

        public interface ITargetPopulation : IValue {}
        public interface ITargetPopulation<T> : ITargetPopulation { new T Value { get; } }
        public class OneOrManyTargetPopulation : OneOrMany<ITargetPopulation>
        {
            public OneOrManyTargetPopulation(ITargetPopulation item) : base(item) { }
            public OneOrManyTargetPopulation(IEnumerable<ITargetPopulation> items) : base(items) { }
            public static implicit operator OneOrManyTargetPopulation (string value) { return new OneOrManyTargetPopulation (new TargetPopulationstring (value)); }
            public static implicit operator OneOrManyTargetPopulation (string[] values) { return new OneOrManyTargetPopulation (values.Select(v => (ITargetPopulation) new TargetPopulationstring (v))); }
            public static implicit operator OneOrManyTargetPopulation (List<string> values) { return new OneOrManyTargetPopulation (values.Select(v => (ITargetPopulation) new TargetPopulationstring (v))); }
        }
        public struct TargetPopulationstring : ITargetPopulation<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TargetPopulationstring (string value) { Value = value; }
            public static implicit operator TargetPopulationstring (string value) { return new TargetPopulationstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DoseSchedule";

        /// <summary>
        /// The unit of the dose, e.g. 'mg'.
        /// </summary>
        [DataMember(Name = "doseUnit", Order = 306)]
        public OneOrManyDoseUnit DoseUnit { get; set; }

        /// <summary>
        /// The value of the dose, e.g. 500.
        /// </summary>
        [DataMember(Name = "doseValue", Order = 307)]
        public OneOrManyDoseValue DoseValue { get; set; }

        /// <summary>
        /// How often the dose is taken, e.g. 'daily'.
        /// </summary>
        [DataMember(Name = "frequency", Order = 308)]
        public OneOrManyFrequency Frequency { get; set; }

        /// <summary>
        /// Characteristics of the population for which this is intended, or which typically uses it, e.g. 'adults'.
        /// </summary>
        [DataMember(Name = "targetPopulation", Order = 309)]
        public OneOrManyTargetPopulation TargetPopulation { get; set; }
    }
}

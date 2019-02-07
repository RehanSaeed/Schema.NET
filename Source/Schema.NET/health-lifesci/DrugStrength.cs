namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A specific strength in which a medical drug is available in a specific country.
    /// </summary>
    [DataContract]
    public partial class DrugStrength : MedicalIntangible
    {
        public interface IActiveIngredient : IValue {}
        public interface IActiveIngredient<T> : IActiveIngredient { new T Value { get; } }
        public class OneOrManyActiveIngredient : OneOrMany<IActiveIngredient>
        {
            public OneOrManyActiveIngredient(IActiveIngredient item) : base(item) { }
            public OneOrManyActiveIngredient(IEnumerable<IActiveIngredient> items) : base(items) { }
            public static implicit operator OneOrManyActiveIngredient (string value) { return new OneOrManyActiveIngredient (new ActiveIngredientstring (value)); }
            public static implicit operator OneOrManyActiveIngredient (string[] values) { return new OneOrManyActiveIngredient (values.Select(v => (IActiveIngredient) new ActiveIngredientstring (v))); }
            public static implicit operator OneOrManyActiveIngredient (List<string> values) { return new OneOrManyActiveIngredient (values.Select(v => (IActiveIngredient) new ActiveIngredientstring (v))); }
        }
        public struct ActiveIngredientstring : IActiveIngredient<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ActiveIngredientstring (string value) { Value = value; }
            public static implicit operator ActiveIngredientstring (string value) { return new ActiveIngredientstring (value); }
        }

        public interface IAvailableIn : IValue {}
        public interface IAvailableIn<T> : IAvailableIn { new T Value { get; } }
        public class OneOrManyAvailableIn : OneOrMany<IAvailableIn>
        {
            public OneOrManyAvailableIn(IAvailableIn item) : base(item) { }
            public OneOrManyAvailableIn(IEnumerable<IAvailableIn> items) : base(items) { }
            public static implicit operator OneOrManyAvailableIn (AdministrativeArea value) { return new OneOrManyAvailableIn (new AvailableInAdministrativeArea (value)); }
            public static implicit operator OneOrManyAvailableIn (AdministrativeArea[] values) { return new OneOrManyAvailableIn (values.Select(v => (IAvailableIn) new AvailableInAdministrativeArea (v))); }
            public static implicit operator OneOrManyAvailableIn (List<AdministrativeArea> values) { return new OneOrManyAvailableIn (values.Select(v => (IAvailableIn) new AvailableInAdministrativeArea (v))); }
        }
        public struct AvailableInAdministrativeArea : IAvailableIn<AdministrativeArea>
        {
            object IValue.Value => this.Value;
            public AdministrativeArea Value { get; }
            public AvailableInAdministrativeArea (AdministrativeArea value) { Value = value; }
            public static implicit operator AvailableInAdministrativeArea (AdministrativeArea value) { return new AvailableInAdministrativeArea (value); }
        }

        public interface IMaximumIntake : IValue {}
        public interface IMaximumIntake<T> : IMaximumIntake { new T Value { get; } }
        public class OneOrManyMaximumIntake : OneOrMany<IMaximumIntake>
        {
            public OneOrManyMaximumIntake(IMaximumIntake item) : base(item) { }
            public OneOrManyMaximumIntake(IEnumerable<IMaximumIntake> items) : base(items) { }
            public static implicit operator OneOrManyMaximumIntake (MaximumDoseSchedule value) { return new OneOrManyMaximumIntake (new MaximumIntakeMaximumDoseSchedule (value)); }
            public static implicit operator OneOrManyMaximumIntake (MaximumDoseSchedule[] values) { return new OneOrManyMaximumIntake (values.Select(v => (IMaximumIntake) new MaximumIntakeMaximumDoseSchedule (v))); }
            public static implicit operator OneOrManyMaximumIntake (List<MaximumDoseSchedule> values) { return new OneOrManyMaximumIntake (values.Select(v => (IMaximumIntake) new MaximumIntakeMaximumDoseSchedule (v))); }
        }
        public struct MaximumIntakeMaximumDoseSchedule : IMaximumIntake<MaximumDoseSchedule>
        {
            object IValue.Value => this.Value;
            public MaximumDoseSchedule Value { get; }
            public MaximumIntakeMaximumDoseSchedule (MaximumDoseSchedule value) { Value = value; }
            public static implicit operator MaximumIntakeMaximumDoseSchedule (MaximumDoseSchedule value) { return new MaximumIntakeMaximumDoseSchedule (value); }
        }

        public interface IStrengthUnit : IValue {}
        public interface IStrengthUnit<T> : IStrengthUnit { new T Value { get; } }
        public class OneOrManyStrengthUnit : OneOrMany<IStrengthUnit>
        {
            public OneOrManyStrengthUnit(IStrengthUnit item) : base(item) { }
            public OneOrManyStrengthUnit(IEnumerable<IStrengthUnit> items) : base(items) { }
            public static implicit operator OneOrManyStrengthUnit (string value) { return new OneOrManyStrengthUnit (new StrengthUnitstring (value)); }
            public static implicit operator OneOrManyStrengthUnit (string[] values) { return new OneOrManyStrengthUnit (values.Select(v => (IStrengthUnit) new StrengthUnitstring (v))); }
            public static implicit operator OneOrManyStrengthUnit (List<string> values) { return new OneOrManyStrengthUnit (values.Select(v => (IStrengthUnit) new StrengthUnitstring (v))); }
        }
        public struct StrengthUnitstring : IStrengthUnit<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public StrengthUnitstring (string value) { Value = value; }
            public static implicit operator StrengthUnitstring (string value) { return new StrengthUnitstring (value); }
        }

        public interface IStrengthValue : IValue {}
        public interface IStrengthValue<T> : IStrengthValue { new T Value { get; } }
        public class OneOrManyStrengthValue : OneOrMany<IStrengthValue>
        {
            public OneOrManyStrengthValue(IStrengthValue item) : base(item) { }
            public OneOrManyStrengthValue(IEnumerable<IStrengthValue> items) : base(items) { }
            public static implicit operator OneOrManyStrengthValue (double value) { return new OneOrManyStrengthValue (new StrengthValuedouble (value)); }
            public static implicit operator OneOrManyStrengthValue (double[] values) { return new OneOrManyStrengthValue (values.Select(v => (IStrengthValue) new StrengthValuedouble (v))); }
            public static implicit operator OneOrManyStrengthValue (List<double> values) { return new OneOrManyStrengthValue (values.Select(v => (IStrengthValue) new StrengthValuedouble (v))); }
        }
        public struct StrengthValuedouble : IStrengthValue<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public StrengthValuedouble (double value) { Value = value; }
            public static implicit operator StrengthValuedouble (double value) { return new StrengthValuedouble (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DrugStrength";

        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        [DataMember(Name = "activeIngredient", Order = 306)]
        public OneOrManyActiveIngredient ActiveIngredient { get; set; }

        /// <summary>
        /// The location in which the strength is available.
        /// </summary>
        [DataMember(Name = "availableIn", Order = 307)]
        public OneOrManyAvailableIn AvailableIn { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [DataMember(Name = "maximumIntake", Order = 308)]
        public OneOrManyMaximumIntake MaximumIntake { get; set; }

        /// <summary>
        /// The units of an active ingredient's strength, e.g. mg.
        /// </summary>
        [DataMember(Name = "strengthUnit", Order = 309)]
        public OneOrManyStrengthUnit StrengthUnit { get; set; }

        /// <summary>
        /// The value of an active ingredient's strength, e.g. 325.
        /// </summary>
        [DataMember(Name = "strengthValue", Order = 310)]
        public OneOrManyStrengthValue StrengthValue { get; set; }
    }
}

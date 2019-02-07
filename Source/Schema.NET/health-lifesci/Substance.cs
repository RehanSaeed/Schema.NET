namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any matter of defined composition that has discrete existence, whose origin may be biological, mineral or chemical.
    /// </summary>
    [DataContract]
    public partial class Substance : MedicalEntity
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

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Substance";

        /// <summary>
        /// An active ingredient, typically chemical compounds and/or biologic substances.
        /// </summary>
        [DataMember(Name = "activeIngredient", Order = 206)]
        public virtual OneOrManyActiveIngredient ActiveIngredient { get; set; }

        /// <summary>
        /// Recommended intake of this supplement for a given population as defined by a specific recommending authority.
        /// </summary>
        [DataMember(Name = "maximumIntake", Order = 207)]
        public virtual OneOrManyMaximumIntake MaximumIntake { get; set; }
    }
}

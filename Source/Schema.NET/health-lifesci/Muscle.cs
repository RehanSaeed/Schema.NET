namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A muscle is an anatomical structure consisting of a contractile form of tissue that animals use to effect movement.
    /// </summary>
    [DataContract]
    public partial class Muscle : AnatomicalStructure
    {
        public interface IAction : IValue {}
        public interface IAction<T> : IAction { new T Value { get; } }
        public class OneOrManyAction : OneOrMany<IAction>
        {
            public OneOrManyAction(IAction item) : base(item) { }
            public OneOrManyAction(IEnumerable<IAction> items) : base(items) { }
            public static implicit operator OneOrManyAction (string value) { return new OneOrManyAction (new Actionstring (value)); }
            public static implicit operator OneOrManyAction (string[] values) { return new OneOrManyAction (values.Select(v => (IAction) new Actionstring (v))); }
            public static implicit operator OneOrManyAction (List<string> values) { return new OneOrManyAction (values.Select(v => (IAction) new Actionstring (v))); }
        }
        public struct Actionstring : IAction<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Actionstring (string value) { Value = value; }
            public static implicit operator Actionstring (string value) { return new Actionstring (value); }
        }

        public interface IAntagonist : IValue {}
        public interface IAntagonist<T> : IAntagonist { new T Value { get; } }
        public class OneOrManyAntagonist : OneOrMany<IAntagonist>
        {
            public OneOrManyAntagonist(IAntagonist item) : base(item) { }
            public OneOrManyAntagonist(IEnumerable<IAntagonist> items) : base(items) { }
            public static implicit operator OneOrManyAntagonist (Muscle value) { return new OneOrManyAntagonist (new AntagonistMuscle (value)); }
            public static implicit operator OneOrManyAntagonist (Muscle[] values) { return new OneOrManyAntagonist (values.Select(v => (IAntagonist) new AntagonistMuscle (v))); }
            public static implicit operator OneOrManyAntagonist (List<Muscle> values) { return new OneOrManyAntagonist (values.Select(v => (IAntagonist) new AntagonistMuscle (v))); }
        }
        public struct AntagonistMuscle : IAntagonist<Muscle>
        {
            object IValue.Value => this.Value;
            public Muscle Value { get; }
            public AntagonistMuscle (Muscle value) { Value = value; }
            public static implicit operator AntagonistMuscle (Muscle value) { return new AntagonistMuscle (value); }
        }

        public interface IBloodSupply : IValue {}
        public interface IBloodSupply<T> : IBloodSupply { new T Value { get; } }
        public class OneOrManyBloodSupply : OneOrMany<IBloodSupply>
        {
            public OneOrManyBloodSupply(IBloodSupply item) : base(item) { }
            public OneOrManyBloodSupply(IEnumerable<IBloodSupply> items) : base(items) { }
            public static implicit operator OneOrManyBloodSupply (Vessel value) { return new OneOrManyBloodSupply (new BloodSupplyVessel (value)); }
            public static implicit operator OneOrManyBloodSupply (Vessel[] values) { return new OneOrManyBloodSupply (values.Select(v => (IBloodSupply) new BloodSupplyVessel (v))); }
            public static implicit operator OneOrManyBloodSupply (List<Vessel> values) { return new OneOrManyBloodSupply (values.Select(v => (IBloodSupply) new BloodSupplyVessel (v))); }
        }
        public struct BloodSupplyVessel : IBloodSupply<Vessel>
        {
            object IValue.Value => this.Value;
            public Vessel Value { get; }
            public BloodSupplyVessel (Vessel value) { Value = value; }
            public static implicit operator BloodSupplyVessel (Vessel value) { return new BloodSupplyVessel (value); }
        }

        public interface IInsertion : IValue {}
        public interface IInsertion<T> : IInsertion { new T Value { get; } }
        public class OneOrManyInsertion : OneOrMany<IInsertion>
        {
            public OneOrManyInsertion(IInsertion item) : base(item) { }
            public OneOrManyInsertion(IEnumerable<IInsertion> items) : base(items) { }
            public static implicit operator OneOrManyInsertion (AnatomicalStructure value) { return new OneOrManyInsertion (new InsertionAnatomicalStructure (value)); }
            public static implicit operator OneOrManyInsertion (AnatomicalStructure[] values) { return new OneOrManyInsertion (values.Select(v => (IInsertion) new InsertionAnatomicalStructure (v))); }
            public static implicit operator OneOrManyInsertion (List<AnatomicalStructure> values) { return new OneOrManyInsertion (values.Select(v => (IInsertion) new InsertionAnatomicalStructure (v))); }
        }
        public struct InsertionAnatomicalStructure : IInsertion<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public InsertionAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator InsertionAnatomicalStructure (AnatomicalStructure value) { return new InsertionAnatomicalStructure (value); }
        }

        public interface IMuscleAction : IValue {}
        public interface IMuscleAction<T> : IMuscleAction { new T Value { get; } }
        public class OneOrManyMuscleAction : OneOrMany<IMuscleAction>
        {
            public OneOrManyMuscleAction(IMuscleAction item) : base(item) { }
            public OneOrManyMuscleAction(IEnumerable<IMuscleAction> items) : base(items) { }
            public static implicit operator OneOrManyMuscleAction (string value) { return new OneOrManyMuscleAction (new MuscleActionstring (value)); }
            public static implicit operator OneOrManyMuscleAction (string[] values) { return new OneOrManyMuscleAction (values.Select(v => (IMuscleAction) new MuscleActionstring (v))); }
            public static implicit operator OneOrManyMuscleAction (List<string> values) { return new OneOrManyMuscleAction (values.Select(v => (IMuscleAction) new MuscleActionstring (v))); }
        }
        public struct MuscleActionstring : IMuscleAction<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public MuscleActionstring (string value) { Value = value; }
            public static implicit operator MuscleActionstring (string value) { return new MuscleActionstring (value); }
        }

        public interface INerve : IValue {}
        public interface INerve<T> : INerve { new T Value { get; } }
        public class OneOrManyNerve : OneOrMany<INerve>
        {
            public OneOrManyNerve(INerve item) : base(item) { }
            public OneOrManyNerve(IEnumerable<INerve> items) : base(items) { }
            public static implicit operator OneOrManyNerve (Nerve value) { return new OneOrManyNerve (new NerveNerve (value)); }
            public static implicit operator OneOrManyNerve (Nerve[] values) { return new OneOrManyNerve (values.Select(v => (INerve) new NerveNerve (v))); }
            public static implicit operator OneOrManyNerve (List<Nerve> values) { return new OneOrManyNerve (values.Select(v => (INerve) new NerveNerve (v))); }
        }
        public struct NerveNerve : INerve<Nerve>
        {
            object IValue.Value => this.Value;
            public Nerve Value { get; }
            public NerveNerve (Nerve value) { Value = value; }
            public static implicit operator NerveNerve (Nerve value) { return new NerveNerve (value); }
        }

        public interface IOrigin : IValue {}
        public interface IOrigin<T> : IOrigin { new T Value { get; } }
        public class OneOrManyOrigin : OneOrMany<IOrigin>
        {
            public OneOrManyOrigin(IOrigin item) : base(item) { }
            public OneOrManyOrigin(IEnumerable<IOrigin> items) : base(items) { }
            public static implicit operator OneOrManyOrigin (AnatomicalStructure value) { return new OneOrManyOrigin (new OriginAnatomicalStructure (value)); }
            public static implicit operator OneOrManyOrigin (AnatomicalStructure[] values) { return new OneOrManyOrigin (values.Select(v => (IOrigin) new OriginAnatomicalStructure (v))); }
            public static implicit operator OneOrManyOrigin (List<AnatomicalStructure> values) { return new OneOrManyOrigin (values.Select(v => (IOrigin) new OriginAnatomicalStructure (v))); }
        }
        public struct OriginAnatomicalStructure : IOrigin<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public OriginAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator OriginAnatomicalStructure (AnatomicalStructure value) { return new OriginAnatomicalStructure (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Muscle";

        /// <summary>
        /// Obsolete term for &lt;a class="localLink" href="http://schema.org/muscleAction"&gt;muscleAction&lt;/a&gt;. Not to be confused with &lt;a class="localLink" href="http://schema.org/potentialAction"&gt;potentialAction&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "action", Order = 306)]
        public OneOrManyAction Action { get; set; }

        /// <summary>
        /// The muscle whose action counteracts the specified muscle.
        /// </summary>
        [DataMember(Name = "antagonist", Order = 307)]
        public OneOrManyAntagonist Antagonist { get; set; }

        /// <summary>
        /// The blood vessel that carries blood from the heart to the muscle.
        /// </summary>
        [DataMember(Name = "bloodSupply", Order = 308)]
        public OneOrManyBloodSupply BloodSupply { get; set; }

        /// <summary>
        /// The place of attachment of a muscle, or what the muscle moves.
        /// </summary>
        [DataMember(Name = "insertion", Order = 309)]
        public OneOrManyInsertion Insertion { get; set; }

        /// <summary>
        /// The movement the muscle generates.
        /// </summary>
        [DataMember(Name = "muscleAction", Order = 310)]
        public OneOrManyMuscleAction MuscleAction { get; set; }

        /// <summary>
        /// The underlying innervation associated with the muscle.
        /// </summary>
        [DataMember(Name = "nerve", Order = 311)]
        public OneOrManyNerve Nerve { get; set; }

        /// <summary>
        /// The place or point where a muscle arises.
        /// </summary>
        [DataMember(Name = "origin", Order = 312)]
        public OneOrManyOrigin Origin { get; set; }
    }
}

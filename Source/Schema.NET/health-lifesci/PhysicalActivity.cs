namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any bodily activity that enhances or maintains physical fitness and overall health and wellness. Includes activity that is part of daily living and routine, structured exercise, and exercise prescribed as part of a medical treatment or recovery plan.
    /// </summary>
    [DataContract]
    public partial class PhysicalActivity : LifestyleModification
    {
        public interface IAssociatedAnatomy : IValue {}
        public interface IAssociatedAnatomy<T> : IAssociatedAnatomy { new T Value { get; } }
        public class OneOrManyAssociatedAnatomy : OneOrMany<IAssociatedAnatomy>
        {
            public OneOrManyAssociatedAnatomy(IAssociatedAnatomy item) : base(item) { }
            public OneOrManyAssociatedAnatomy(IEnumerable<IAssociatedAnatomy> items) : base(items) { }
            public static implicit operator OneOrManyAssociatedAnatomy (AnatomicalStructure value) { return new OneOrManyAssociatedAnatomy (new AssociatedAnatomyAnatomicalStructure (value)); }
            public static implicit operator OneOrManyAssociatedAnatomy (AnatomicalStructure[] values) { return new OneOrManyAssociatedAnatomy (values.Select(v => (IAssociatedAnatomy) new AssociatedAnatomyAnatomicalStructure (v))); }
            public static implicit operator OneOrManyAssociatedAnatomy (List<AnatomicalStructure> values) { return new OneOrManyAssociatedAnatomy (values.Select(v => (IAssociatedAnatomy) new AssociatedAnatomyAnatomicalStructure (v))); }
            public static implicit operator OneOrManyAssociatedAnatomy (AnatomicalSystem value) { return new OneOrManyAssociatedAnatomy (new AssociatedAnatomyAnatomicalSystem (value)); }
            public static implicit operator OneOrManyAssociatedAnatomy (AnatomicalSystem[] values) { return new OneOrManyAssociatedAnatomy (values.Select(v => (IAssociatedAnatomy) new AssociatedAnatomyAnatomicalSystem (v))); }
            public static implicit operator OneOrManyAssociatedAnatomy (List<AnatomicalSystem> values) { return new OneOrManyAssociatedAnatomy (values.Select(v => (IAssociatedAnatomy) new AssociatedAnatomyAnatomicalSystem (v))); }
            public static implicit operator OneOrManyAssociatedAnatomy (SuperficialAnatomy value) { return new OneOrManyAssociatedAnatomy (new AssociatedAnatomySuperficialAnatomy (value)); }
            public static implicit operator OneOrManyAssociatedAnatomy (SuperficialAnatomy[] values) { return new OneOrManyAssociatedAnatomy (values.Select(v => (IAssociatedAnatomy) new AssociatedAnatomySuperficialAnatomy (v))); }
            public static implicit operator OneOrManyAssociatedAnatomy (List<SuperficialAnatomy> values) { return new OneOrManyAssociatedAnatomy (values.Select(v => (IAssociatedAnatomy) new AssociatedAnatomySuperficialAnatomy (v))); }
        }
        public struct AssociatedAnatomyAnatomicalStructure : IAssociatedAnatomy<AnatomicalStructure>
        {
            object IValue.Value => this.Value;
            public AnatomicalStructure Value { get; }
            public AssociatedAnatomyAnatomicalStructure (AnatomicalStructure value) { Value = value; }
            public static implicit operator AssociatedAnatomyAnatomicalStructure (AnatomicalStructure value) { return new AssociatedAnatomyAnatomicalStructure (value); }
        }
        public struct AssociatedAnatomyAnatomicalSystem : IAssociatedAnatomy<AnatomicalSystem>
        {
            object IValue.Value => this.Value;
            public AnatomicalSystem Value { get; }
            public AssociatedAnatomyAnatomicalSystem (AnatomicalSystem value) { Value = value; }
            public static implicit operator AssociatedAnatomyAnatomicalSystem (AnatomicalSystem value) { return new AssociatedAnatomyAnatomicalSystem (value); }
        }
        public struct AssociatedAnatomySuperficialAnatomy : IAssociatedAnatomy<SuperficialAnatomy>
        {
            object IValue.Value => this.Value;
            public SuperficialAnatomy Value { get; }
            public AssociatedAnatomySuperficialAnatomy (SuperficialAnatomy value) { Value = value; }
            public static implicit operator AssociatedAnatomySuperficialAnatomy (SuperficialAnatomy value) { return new AssociatedAnatomySuperficialAnatomy (value); }
        }

        public interface IEpidemiology : IValue {}
        public interface IEpidemiology<T> : IEpidemiology { new T Value { get; } }
        public class OneOrManyEpidemiology : OneOrMany<IEpidemiology>
        {
            public OneOrManyEpidemiology(IEpidemiology item) : base(item) { }
            public OneOrManyEpidemiology(IEnumerable<IEpidemiology> items) : base(items) { }
            public static implicit operator OneOrManyEpidemiology (string value) { return new OneOrManyEpidemiology (new Epidemiologystring (value)); }
            public static implicit operator OneOrManyEpidemiology (string[] values) { return new OneOrManyEpidemiology (values.Select(v => (IEpidemiology) new Epidemiologystring (v))); }
            public static implicit operator OneOrManyEpidemiology (List<string> values) { return new OneOrManyEpidemiology (values.Select(v => (IEpidemiology) new Epidemiologystring (v))); }
        }
        public struct Epidemiologystring : IEpidemiology<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Epidemiologystring (string value) { Value = value; }
            public static implicit operator Epidemiologystring (string value) { return new Epidemiologystring (value); }
        }

        public interface IPathophysiology : IValue {}
        public interface IPathophysiology<T> : IPathophysiology { new T Value { get; } }
        public class OneOrManyPathophysiology : OneOrMany<IPathophysiology>
        {
            public OneOrManyPathophysiology(IPathophysiology item) : base(item) { }
            public OneOrManyPathophysiology(IEnumerable<IPathophysiology> items) : base(items) { }
            public static implicit operator OneOrManyPathophysiology (string value) { return new OneOrManyPathophysiology (new Pathophysiologystring (value)); }
            public static implicit operator OneOrManyPathophysiology (string[] values) { return new OneOrManyPathophysiology (values.Select(v => (IPathophysiology) new Pathophysiologystring (v))); }
            public static implicit operator OneOrManyPathophysiology (List<string> values) { return new OneOrManyPathophysiology (values.Select(v => (IPathophysiology) new Pathophysiologystring (v))); }
        }
        public struct Pathophysiologystring : IPathophysiology<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Pathophysiologystring (string value) { Value = value; }
            public static implicit operator Pathophysiologystring (string value) { return new Pathophysiologystring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PhysicalActivity";

        /// <summary>
        /// The anatomy of the underlying organ system or structures associated with this entity.
        /// </summary>
        [DataMember(Name = "associatedAnatomy", Order = 306)]
        public OneOrManyAssociatedAnatomy AssociatedAnatomy { get; set; }

        /// <summary>
        /// The characteristics of associated patients, such as age, gender, race etc.
        /// </summary>
        [DataMember(Name = "epidemiology", Order = 307)]
        public OneOrManyEpidemiology Epidemiology { get; set; }

        /// <summary>
        /// Changes in the normal mechanical, physical, and biochemical functions that are associated with this activity or condition.
        /// </summary>
        [DataMember(Name = "pathophysiology", Order = 308)]
        public OneOrManyPathophysiology Pathophysiology { get; set; }
    }
}

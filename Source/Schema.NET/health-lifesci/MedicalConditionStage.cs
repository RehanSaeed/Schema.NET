namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A stage of a medical condition, such as 'Stage IIIa'.
    /// </summary>
    [DataContract]
    public partial class MedicalConditionStage : MedicalIntangible
    {
        public interface IStageAsNumber : IValue {}
        public interface IStageAsNumber<T> : IStageAsNumber { new T Value { get; } }
        public class OneOrManyStageAsNumber : OneOrMany<IStageAsNumber>
        {
            public OneOrManyStageAsNumber(IStageAsNumber item) : base(item) { }
            public OneOrManyStageAsNumber(IEnumerable<IStageAsNumber> items) : base(items) { }
            public static implicit operator OneOrManyStageAsNumber (double value) { return new OneOrManyStageAsNumber (new StageAsNumberdouble (value)); }
            public static implicit operator OneOrManyStageAsNumber (double[] values) { return new OneOrManyStageAsNumber (values.Select(v => (IStageAsNumber) new StageAsNumberdouble (v))); }
            public static implicit operator OneOrManyStageAsNumber (List<double> values) { return new OneOrManyStageAsNumber (values.Select(v => (IStageAsNumber) new StageAsNumberdouble (v))); }
        }
        public struct StageAsNumberdouble : IStageAsNumber<double>
        {
            object IValue.Value => this.Value;
            public double Value { get; }
            public StageAsNumberdouble (double value) { Value = value; }
            public static implicit operator StageAsNumberdouble (double value) { return new StageAsNumberdouble (value); }
        }

        public interface ISubStageSuffix : IValue {}
        public interface ISubStageSuffix<T> : ISubStageSuffix { new T Value { get; } }
        public class OneOrManySubStageSuffix : OneOrMany<ISubStageSuffix>
        {
            public OneOrManySubStageSuffix(ISubStageSuffix item) : base(item) { }
            public OneOrManySubStageSuffix(IEnumerable<ISubStageSuffix> items) : base(items) { }
            public static implicit operator OneOrManySubStageSuffix (string value) { return new OneOrManySubStageSuffix (new SubStageSuffixstring (value)); }
            public static implicit operator OneOrManySubStageSuffix (string[] values) { return new OneOrManySubStageSuffix (values.Select(v => (ISubStageSuffix) new SubStageSuffixstring (v))); }
            public static implicit operator OneOrManySubStageSuffix (List<string> values) { return new OneOrManySubStageSuffix (values.Select(v => (ISubStageSuffix) new SubStageSuffixstring (v))); }
        }
        public struct SubStageSuffixstring : ISubStageSuffix<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SubStageSuffixstring (string value) { Value = value; }
            public static implicit operator SubStageSuffixstring (string value) { return new SubStageSuffixstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalConditionStage";

        /// <summary>
        /// The stage represented as a number, e.g. 3.
        /// </summary>
        [DataMember(Name = "stageAsNumber", Order = 306)]
        public OneOrManyStageAsNumber StageAsNumber { get; set; }

        /// <summary>
        /// The substage, e.g. 'a' for Stage IIIa.
        /// </summary>
        [DataMember(Name = "subStageSuffix", Order = 307)]
        public OneOrManySubStageSuffix SubStageSuffix { get; set; }
    }
}

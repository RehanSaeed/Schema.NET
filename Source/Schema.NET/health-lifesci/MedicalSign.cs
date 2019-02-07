namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any physical manifestation of a person's medical condition discoverable by objective diagnostic tests or physical examination.
    /// </summary>
    [DataContract]
    public partial class MedicalSign : MedicalSignOrSymptom
    {
        public interface IIdentifyingExam : IValue {}
        public interface IIdentifyingExam<T> : IIdentifyingExam { new T Value { get; } }
        public class OneOrManyIdentifyingExam : OneOrMany<IIdentifyingExam>
        {
            public OneOrManyIdentifyingExam(IIdentifyingExam item) : base(item) { }
            public OneOrManyIdentifyingExam(IEnumerable<IIdentifyingExam> items) : base(items) { }
            public static implicit operator OneOrManyIdentifyingExam (PhysicalExam value) { return new OneOrManyIdentifyingExam (new IdentifyingExamPhysicalExam (value)); }
            public static implicit operator OneOrManyIdentifyingExam (PhysicalExam[] values) { return new OneOrManyIdentifyingExam (values.Select(v => (IIdentifyingExam) new IdentifyingExamPhysicalExam (v))); }
            public static implicit operator OneOrManyIdentifyingExam (List<PhysicalExam> values) { return new OneOrManyIdentifyingExam (values.Select(v => (IIdentifyingExam) new IdentifyingExamPhysicalExam (v))); }
        }
        public struct IdentifyingExamPhysicalExam : IIdentifyingExam<PhysicalExam>
        {
            object IValue.Value => this.Value;
            public PhysicalExam Value { get; }
            public IdentifyingExamPhysicalExam (PhysicalExam value) { Value = value; }
            public static implicit operator IdentifyingExamPhysicalExam (PhysicalExam value) { return new IdentifyingExamPhysicalExam (value); }
        }

        public interface IIdentifyingTest : IValue {}
        public interface IIdentifyingTest<T> : IIdentifyingTest { new T Value { get; } }
        public class OneOrManyIdentifyingTest : OneOrMany<IIdentifyingTest>
        {
            public OneOrManyIdentifyingTest(IIdentifyingTest item) : base(item) { }
            public OneOrManyIdentifyingTest(IEnumerable<IIdentifyingTest> items) : base(items) { }
            public static implicit operator OneOrManyIdentifyingTest (MedicalTest value) { return new OneOrManyIdentifyingTest (new IdentifyingTestMedicalTest (value)); }
            public static implicit operator OneOrManyIdentifyingTest (MedicalTest[] values) { return new OneOrManyIdentifyingTest (values.Select(v => (IIdentifyingTest) new IdentifyingTestMedicalTest (v))); }
            public static implicit operator OneOrManyIdentifyingTest (List<MedicalTest> values) { return new OneOrManyIdentifyingTest (values.Select(v => (IIdentifyingTest) new IdentifyingTestMedicalTest (v))); }
        }
        public struct IdentifyingTestMedicalTest : IIdentifyingTest<MedicalTest>
        {
            object IValue.Value => this.Value;
            public MedicalTest Value { get; }
            public IdentifyingTestMedicalTest (MedicalTest value) { Value = value; }
            public static implicit operator IdentifyingTestMedicalTest (MedicalTest value) { return new IdentifyingTestMedicalTest (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalSign";

        /// <summary>
        /// A physical examination that can identify this sign.
        /// </summary>
        [DataMember(Name = "identifyingExam", Order = 406)]
        public OneOrManyIdentifyingExam IdentifyingExam { get; set; }

        /// <summary>
        /// A diagnostic test that can identify this sign.
        /// </summary>
        [DataMember(Name = "identifyingTest", Order = 407)]
        public OneOrManyIdentifyingTest IdentifyingTest { get; set; }
    }
}

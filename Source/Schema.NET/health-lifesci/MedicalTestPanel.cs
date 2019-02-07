namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Any collection of tests commonly ordered together.
    /// </summary>
    [DataContract]
    public partial class MedicalTestPanel : MedicalTest
    {
        public interface ISubTest : IValue {}
        public interface ISubTest<T> : ISubTest { new T Value { get; } }
        public class OneOrManySubTest : OneOrMany<ISubTest>
        {
            public OneOrManySubTest(ISubTest item) : base(item) { }
            public OneOrManySubTest(IEnumerable<ISubTest> items) : base(items) { }
            public static implicit operator OneOrManySubTest (MedicalTest value) { return new OneOrManySubTest (new SubTestMedicalTest (value)); }
            public static implicit operator OneOrManySubTest (MedicalTest[] values) { return new OneOrManySubTest (values.Select(v => (ISubTest) new SubTestMedicalTest (v))); }
            public static implicit operator OneOrManySubTest (List<MedicalTest> values) { return new OneOrManySubTest (values.Select(v => (ISubTest) new SubTestMedicalTest (v))); }
        }
        public struct SubTestMedicalTest : ISubTest<MedicalTest>
        {
            object IValue.Value => this.Value;
            public MedicalTest Value { get; }
            public SubTestMedicalTest (MedicalTest value) { Value = value; }
            public static implicit operator SubTestMedicalTest (MedicalTest value) { return new SubTestMedicalTest (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalTestPanel";

        /// <summary>
        /// A component test of the panel.
        /// </summary>
        [DataMember(Name = "subTest", Order = 306)]
        public OneOrManySubTest SubTest { get; set; }
    }
}

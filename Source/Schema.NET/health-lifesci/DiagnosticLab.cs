namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical laboratory that offers on-site or off-site diagnostic services.
    /// </summary>
    [DataContract]
    public partial class DiagnosticLab : MedicalOrganization
    {
        public interface IAvailableTest : IValue {}
        public interface IAvailableTest<T> : IAvailableTest { new T Value { get; } }
        public class OneOrManyAvailableTest : OneOrMany<IAvailableTest>
        {
            public OneOrManyAvailableTest(IAvailableTest item) : base(item) { }
            public OneOrManyAvailableTest(IEnumerable<IAvailableTest> items) : base(items) { }
            public static implicit operator OneOrManyAvailableTest (MedicalTest value) { return new OneOrManyAvailableTest (new AvailableTestMedicalTest (value)); }
            public static implicit operator OneOrManyAvailableTest (MedicalTest[] values) { return new OneOrManyAvailableTest (values.Select(v => (IAvailableTest) new AvailableTestMedicalTest (v))); }
            public static implicit operator OneOrManyAvailableTest (List<MedicalTest> values) { return new OneOrManyAvailableTest (values.Select(v => (IAvailableTest) new AvailableTestMedicalTest (v))); }
        }
        public struct AvailableTestMedicalTest : IAvailableTest<MedicalTest>
        {
            object IValue.Value => this.Value;
            public MedicalTest Value { get; }
            public AvailableTestMedicalTest (MedicalTest value) { Value = value; }
            public static implicit operator AvailableTestMedicalTest (MedicalTest value) { return new AvailableTestMedicalTest (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DiagnosticLab";

        /// <summary>
        /// A diagnostic test or procedure offered by this lab.
        /// </summary>
        [DataMember(Name = "availableTest", Order = 306)]
        public OneOrManyAvailableTest AvailableTest { get; set; }
    }
}

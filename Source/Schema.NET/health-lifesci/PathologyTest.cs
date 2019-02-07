namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical test performed by a laboratory that typically involves examination of a tissue sample by a pathologist.
    /// </summary>
    [DataContract]
    public partial class PathologyTest : MedicalTest
    {
        public interface ITissueSample : IValue {}
        public interface ITissueSample<T> : ITissueSample { new T Value { get; } }
        public class OneOrManyTissueSample : OneOrMany<ITissueSample>
        {
            public OneOrManyTissueSample(ITissueSample item) : base(item) { }
            public OneOrManyTissueSample(IEnumerable<ITissueSample> items) : base(items) { }
            public static implicit operator OneOrManyTissueSample (string value) { return new OneOrManyTissueSample (new TissueSamplestring (value)); }
            public static implicit operator OneOrManyTissueSample (string[] values) { return new OneOrManyTissueSample (values.Select(v => (ITissueSample) new TissueSamplestring (v))); }
            public static implicit operator OneOrManyTissueSample (List<string> values) { return new OneOrManyTissueSample (values.Select(v => (ITissueSample) new TissueSamplestring (v))); }
        }
        public struct TissueSamplestring : ITissueSample<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TissueSamplestring (string value) { Value = value; }
            public static implicit operator TissueSamplestring (string value) { return new TissueSamplestring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PathologyTest";

        /// <summary>
        /// The type of tissue sample required for the test.
        /// </summary>
        [DataMember(Name = "tissueSample", Order = 306)]
        public OneOrManyTissueSample TissueSample { get; set; }
    }
}

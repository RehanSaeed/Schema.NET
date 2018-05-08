namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A medical test performed by a laboratory that typically involves examination of a tissue sample by a pathologist.
    /// </summary>
    public partial interface IPathologyTest : IMedicalTest
    {
        /// <summary>
        /// The type of tissue sample required for the test.
        /// </summary>
        OneOrMany<string>? TissueSample { get; set; }
    }

    /// <summary>
    /// A medical test performed by a laboratory that typically involves examination of a tissue sample by a pathologist.
    /// </summary>
    [DataContract]
    public partial class PathologyTest : MedicalTest, IPathologyTest
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PathologyTest";

        /// <summary>
        /// The type of tissue sample required for the test.
        /// </summary>
        [DataMember(Name = "tissueSample", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? TissueSample { get; set; }
    }
}

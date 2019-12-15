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
        OneOrMany<string> TissueSample { get; set; }
    }

    /// <summary>
    /// A medical test performed by a laboratory that typically involves examination of a tissue sample by a pathologist.
    /// </summary>
    [DataContract]
    public partial class PathologyTest : MedicalTest, IPathologyTest, IEquatable<PathologyTest>
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
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TissueSample { get; set; }

        /// <inheritdoc/>
        public bool Equals(PathologyTest other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.TissueSample == other.TissueSample &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as PathologyTest);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.TissueSample)
            .And(base.GetHashCode());
    }
}

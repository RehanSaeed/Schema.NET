namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any collection of tests commonly ordered together.
    /// </summary>
    public partial interface IMedicalTestPanel : IMedicalTest
    {
        /// <summary>
        /// A component test of the panel.
        /// </summary>
        OneOrMany<IMedicalTest> SubTest { get; set; }
    }

    /// <summary>
    /// Any collection of tests commonly ordered together.
    /// </summary>
    [DataContract]
    public partial class MedicalTestPanel : MedicalTest, IMedicalTestPanel, IEquatable<MedicalTestPanel>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalTestPanel";

        /// <summary>
        /// A component test of the panel.
        /// </summary>
        [DataMember(Name = "subTest", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IMedicalTest> SubTest { get; set; }

        /// <inheritdoc/>
        public bool Equals(MedicalTestPanel other)
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
                this.SubTest == other.SubTest &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalTestPanel);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.SubTest)
            .And(base.GetHashCode());
    }
}

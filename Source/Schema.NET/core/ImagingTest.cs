namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Any medical imaging modality typically used for diagnostic purposes.
    /// </summary>
    public partial interface IImagingTest : IMedicalTest
    {
        /// <summary>
        /// Imaging technique used.
        /// </summary>
        OneOrMany<MedicalImagingTechnique?> ImagingTechnique { get; set; }
    }

    /// <summary>
    /// Any medical imaging modality typically used for diagnostic purposes.
    /// </summary>
    [DataContract]
    public partial class ImagingTest : MedicalTest, IImagingTest, IEquatable<ImagingTest>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ImagingTest";

        /// <summary>
        /// Imaging technique used.
        /// </summary>
        [DataMember(Name = "imagingTechnique", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<MedicalImagingTechnique?> ImagingTechnique { get; set; }

        /// <inheritdoc/>
        public bool Equals(ImagingTest other)
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
                this.ImagingTechnique == other.ImagingTechnique &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as ImagingTest);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ImagingTechnique)
            .And(base.GetHashCode());
    }
}

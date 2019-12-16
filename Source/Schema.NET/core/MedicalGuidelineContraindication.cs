namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A guideline contraindication that designates a process as harmful and where quality of the data supporting the contraindication is sound.
    /// </summary>
    public partial interface IMedicalGuidelineContraindication : IMedicalGuideline
    {
    }

    /// <summary>
    /// A guideline contraindication that designates a process as harmful and where quality of the data supporting the contraindication is sound.
    /// </summary>
    [DataContract]
    public partial class MedicalGuidelineContraindication : MedicalGuideline, IMedicalGuidelineContraindication, IEquatable<MedicalGuidelineContraindication>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalGuidelineContraindication";

        /// <inheritdoc/>
        public bool Equals(MedicalGuidelineContraindication other)
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
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalGuidelineContraindication);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

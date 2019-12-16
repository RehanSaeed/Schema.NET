namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A utility class that serves as the umbrella for a number of 'intangible' things in the medical space.
    /// </summary>
    public partial interface IMedicalIntangible : IMedicalEntity
    {
    }

    /// <summary>
    /// A utility class that serves as the umbrella for a number of 'intangible' things in the medical space.
    /// </summary>
    [DataContract]
    public partial class MedicalIntangible : MedicalEntity, IMedicalIntangible, IEquatable<MedicalIntangible>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalIntangible";

        /// <inheritdoc/>
        public bool Equals(MedicalIntangible other)
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
        public override bool Equals(object obj) => this.Equals(obj as MedicalIntangible);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

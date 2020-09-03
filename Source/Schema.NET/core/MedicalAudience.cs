namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Target audiences for medical web pages.
    /// </summary>
    public partial interface IMedicalAudience : IPeopleAudience
    {
    }

    /// <summary>
    /// Target audiences for medical web pages.
    /// </summary>
    [DataContract]
    public partial class MedicalAudience : PeopleAudience, IMedicalAudience, IEquatable<MedicalAudience>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalAudience";

        /// <inheritdoc/>
        public bool Equals(MedicalAudience other)
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
        public override bool Equals(object obj) => this.Equals(obj as MedicalAudience);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

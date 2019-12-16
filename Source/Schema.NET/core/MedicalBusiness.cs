namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A particular physical or virtual business of an organization for medical purposes. Examples of MedicalBusiness include differents business run by health professionals.
    /// </summary>
    public partial interface IMedicalBusiness : ILocalBusiness
    {
    }

    /// <summary>
    /// A particular physical or virtual business of an organization for medical purposes. Examples of MedicalBusiness include differents business run by health professionals.
    /// </summary>
    [DataContract]
    public partial class MedicalBusiness : LocalBusiness, IMedicalBusiness, IEquatable<MedicalBusiness>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalBusiness";

        /// <inheritdoc/>
        public bool Equals(MedicalBusiness other)
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
        public override bool Equals(object obj) => this.Equals(obj as MedicalBusiness);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A vet's office.
    /// </summary>
    public partial interface IVeterinaryCare : IMedicalOrganization
    {
    }

    /// <summary>
    /// A vet's office.
    /// </summary>
    [DataContract]
    public partial class VeterinaryCare : MedicalOrganization, IVeterinaryCare, IEquatable<VeterinaryCare>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VeterinaryCare";

        /// <inheritdoc/>
        public bool Equals(VeterinaryCare other)
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
        public override bool Equals(object obj) => this.Equals(obj as VeterinaryCare);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

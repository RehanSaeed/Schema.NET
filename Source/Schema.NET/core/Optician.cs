namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A store that sells reading glasses and similar devices for improving vision.
    /// </summary>
    public partial interface IOptician : IMedicalBusiness
    {
    }

    /// <summary>
    /// A store that sells reading glasses and similar devices for improving vision.
    /// </summary>
    [DataContract]
    public partial class Optician : MedicalBusiness, IOptician, IEquatable<Optician>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Optician";

        /// <inheritdoc/>
        public bool Equals(Optician other)
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
        public override bool Equals(object obj) => this.Equals(obj as Optician);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

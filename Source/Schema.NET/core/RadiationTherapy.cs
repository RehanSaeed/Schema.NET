namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A process of care using radiation aimed at improving a health condition.
    /// </summary>
    public partial interface IRadiationTherapy : IMedicalTherapy
    {
    }

    /// <summary>
    /// A process of care using radiation aimed at improving a health condition.
    /// </summary>
    [DataContract]
    public partial class RadiationTherapy : MedicalTherapy, IRadiationTherapy, IEquatable<RadiationTherapy>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RadiationTherapy";

        /// <inheritdoc/>
        public bool Equals(RadiationTherapy other)
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
        public override bool Equals(object obj) => this.Equals(obj as RadiationTherapy);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A nail salon.
    /// </summary>
    public partial interface INailSalon : IHealthAndBeautyBusiness
    {
    }

    /// <summary>
    /// A nail salon.
    /// </summary>
    [DataContract]
    public partial class NailSalon : HealthAndBeautyBusiness, INailSalon, IEquatable<NailSalon>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NailSalon";

        /// <inheritdoc/>
        public bool Equals(NailSalon other)
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
        public override bool Equals(object obj) => this.Equals(obj as NailSalon);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

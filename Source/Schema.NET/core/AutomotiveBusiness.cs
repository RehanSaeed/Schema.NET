namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Car repair, sales, or parts.
    /// </summary>
    public partial interface IAutomotiveBusiness : ILocalBusiness
    {
    }

    /// <summary>
    /// Car repair, sales, or parts.
    /// </summary>
    [DataContract]
    public partial class AutomotiveBusiness : LocalBusiness, IAutomotiveBusiness, IEquatable<AutomotiveBusiness>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutomotiveBusiness";

        /// <inheritdoc/>
        public bool Equals(AutomotiveBusiness other)
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
        public override bool Equals(object obj) => this.Equals(obj as AutomotiveBusiness);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

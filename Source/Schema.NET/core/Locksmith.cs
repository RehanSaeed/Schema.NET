namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A locksmith.
    /// </summary>
    public partial interface ILocksmith : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A locksmith.
    /// </summary>
    [DataContract]
    public partial class Locksmith : HomeAndConstructionBusiness, ILocksmith, IEquatable<Locksmith>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Locksmith";

        /// <inheritdoc/>
        public bool Equals(Locksmith other)
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
        public override bool Equals(object obj) => this.Equals(obj as Locksmith);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

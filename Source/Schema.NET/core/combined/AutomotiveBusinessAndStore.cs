namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See AutomotiveBusiness, Store for more information.
    /// </summary>
    public partial interface IAutomotiveBusinessAndStore : IAutomotiveBusiness, IStore
    {
    }

    /// <summary>
    /// See AutomotiveBusiness, Store for more information.
    /// </summary>
    [DataContract]
    public abstract partial class AutomotiveBusinessAndStore : LocalBusiness, IAutomotiveBusinessAndStore, IEquatable<AutomotiveBusinessAndStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutomotiveBusinessAndStore";

        /// <inheritdoc/>
        public bool Equals(AutomotiveBusinessAndStore other)
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
        public override bool Equals(object obj) => this.Equals(obj as AutomotiveBusinessAndStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

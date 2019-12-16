namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A hardware store.
    /// </summary>
    public partial interface IHardwareStore : IStore
    {
    }

    /// <summary>
    /// A hardware store.
    /// </summary>
    [DataContract]
    public partial class HardwareStore : Store, IHardwareStore, IEquatable<HardwareStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HardwareStore";

        /// <inheritdoc/>
        public bool Equals(HardwareStore other)
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
        public override bool Equals(object obj) => this.Equals(obj as HardwareStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

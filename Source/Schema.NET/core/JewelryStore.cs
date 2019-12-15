namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A jewelry store.
    /// </summary>
    public partial interface IJewelryStore : IStore
    {
    }

    /// <summary>
    /// A jewelry store.
    /// </summary>
    [DataContract]
    public partial class JewelryStore : Store, IJewelryStore, IEquatable<JewelryStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "JewelryStore";

        /// <inheritdoc/>
        public bool Equals(JewelryStore other)
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
        public override bool Equals(object obj) => this.Equals(obj as JewelryStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

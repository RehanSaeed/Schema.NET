namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An auto parts store.
    /// </summary>
    public partial interface IAutoPartsStore : IAutomotiveBusinessAndStore
    {
    }

    /// <summary>
    /// An auto parts store.
    /// </summary>
    [DataContract]
    public partial class AutoPartsStore : AutomotiveBusinessAndStore, IAutoPartsStore, IEquatable<AutoPartsStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutoPartsStore";

        /// <inheritdoc/>
        public bool Equals(AutoPartsStore other)
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
        public override bool Equals(object obj) => this.Equals(obj as AutoPartsStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

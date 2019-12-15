namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An electronics store.
    /// </summary>
    public partial interface IElectronicsStore : IStore
    {
    }

    /// <summary>
    /// An electronics store.
    /// </summary>
    [DataContract]
    public partial class ElectronicsStore : Store, IElectronicsStore, IEquatable<ElectronicsStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ElectronicsStore";

        /// <inheritdoc/>
        public bool Equals(ElectronicsStore other)
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
        public override bool Equals(object obj) => this.Equals(obj as ElectronicsStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

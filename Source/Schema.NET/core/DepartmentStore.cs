namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A department store.
    /// </summary>
    public partial interface IDepartmentStore : IStore
    {
    }

    /// <summary>
    /// A department store.
    /// </summary>
    [DataContract]
    public partial class DepartmentStore : Store, IDepartmentStore, IEquatable<DepartmentStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DepartmentStore";

        /// <inheritdoc/>
        public bool Equals(DepartmentStore other)
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
        public override bool Equals(object obj) => this.Equals(obj as DepartmentStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

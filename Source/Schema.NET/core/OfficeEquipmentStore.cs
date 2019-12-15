namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An office equipment store.
    /// </summary>
    public partial interface IOfficeEquipmentStore : IStore
    {
    }

    /// <summary>
    /// An office equipment store.
    /// </summary>
    [DataContract]
    public partial class OfficeEquipmentStore : Store, IOfficeEquipmentStore, IEquatable<OfficeEquipmentStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OfficeEquipmentStore";

        /// <inheritdoc/>
        public bool Equals(OfficeEquipmentStore other)
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
        public override bool Equals(object obj) => this.Equals(obj as OfficeEquipmentStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

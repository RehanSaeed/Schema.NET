namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A store that sells mobile phones and related accessories.
    /// </summary>
    public partial interface IMobilePhoneStore : IStore
    {
    }

    /// <summary>
    /// A store that sells mobile phones and related accessories.
    /// </summary>
    [DataContract]
    public partial class MobilePhoneStore : Store, IMobilePhoneStore, IEquatable<MobilePhoneStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MobilePhoneStore";

        /// <inheritdoc/>
        public bool Equals(MobilePhoneStore other)
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
        public override bool Equals(object obj) => this.Equals(obj as MobilePhoneStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

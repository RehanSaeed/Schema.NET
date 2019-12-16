namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A store that sells materials useful or necessary for various hobbies.
    /// </summary>
    public partial interface IHobbyShop : IStore
    {
    }

    /// <summary>
    /// A store that sells materials useful or necessary for various hobbies.
    /// </summary>
    [DataContract]
    public partial class HobbyShop : Store, IHobbyShop, IEquatable<HobbyShop>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HobbyShop";

        /// <inheritdoc/>
        public bool Equals(HobbyShop other)
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
        public override bool Equals(object obj) => this.Equals(obj as HobbyShop);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

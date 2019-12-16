namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A shop that sells alcoholic drinks such as wine, beer, whisky and other spirits.
    /// </summary>
    public partial interface ILiquorStore : IStore
    {
    }

    /// <summary>
    /// A shop that sells alcoholic drinks such as wine, beer, whisky and other spirits.
    /// </summary>
    [DataContract]
    public partial class LiquorStore : Store, ILiquorStore, IEquatable<LiquorStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LiquorStore";

        /// <inheritdoc/>
        public bool Equals(LiquorStore other)
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
        public override bool Equals(object obj) => this.Equals(obj as LiquorStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

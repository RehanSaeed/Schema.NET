﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A wholesale store.
    /// </summary>
    public partial interface IWholesaleStore : IStore
    {
    }

    /// <summary>
    /// A wholesale store.
    /// </summary>
    [DataContract]
    public partial class WholesaleStore : Store, IWholesaleStore, IEquatable<WholesaleStore>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WholesaleStore";

        /// <inheritdoc/>
        public bool Equals(WholesaleStore other)
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
        public override bool Equals(object obj) => this.Equals(obj as WholesaleStore);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

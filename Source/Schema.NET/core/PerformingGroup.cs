﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A performance group, such as a band, an orchestra, or a circus.
    /// </summary>
    public partial interface IPerformingGroup : IOrganization
    {
    }

    /// <summary>
    /// A performance group, such as a band, an orchestra, or a circus.
    /// </summary>
    [DataContract]
    public partial class PerformingGroup : Organization, IPerformingGroup, IEquatable<PerformingGroup>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PerformingGroup";

        /// <inheritdoc/>
        public bool Equals(PerformingGroup other)
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
        public override bool Equals(object obj) => this.Equals(obj as PerformingGroup);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

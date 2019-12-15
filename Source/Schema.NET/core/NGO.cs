﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Organization: Non-governmental Organization.
    /// </summary>
    public partial interface INGO : IOrganization
    {
    }

    /// <summary>
    /// Organization: Non-governmental Organization.
    /// </summary>
    [DataContract]
    public partial class NGO : Organization, INGO, IEquatable<NGO>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NGO";

        /// <inheritdoc/>
        public bool Equals(NGO other)
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
        public override bool Equals(object obj) => this.Equals(obj as NGO);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

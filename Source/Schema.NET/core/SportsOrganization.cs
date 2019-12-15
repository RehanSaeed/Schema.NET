﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// </summary>
    public partial interface ISportsOrganization : IOrganization
    {
        /// <summary>
        /// A type of sport (e.g. Baseball).
        /// </summary>
        Values<string, Uri> Sport { get; set; }
    }

    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// </summary>
    [DataContract]
    public partial class SportsOrganization : Organization, ISportsOrganization, IEquatable<SportsOrganization>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsOrganization";

        /// <summary>
        /// A type of sport (e.g. Baseball).
        /// </summary>
        [DataMember(Name = "sport", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> Sport { get; set; }

        /// <inheritdoc/>
        public bool Equals(SportsOrganization other)
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
                this.Sport == other.Sport &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as SportsOrganization);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Sport)
            .And(base.GetHashCode());
    }
}

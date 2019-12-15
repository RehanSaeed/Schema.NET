namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A sports club.
    /// </summary>
    public partial interface ISportsClub : ISportsActivityLocation
    {
    }

    /// <summary>
    /// A sports club.
    /// </summary>
    [DataContract]
    public partial class SportsClub : SportsActivityLocation, ISportsClub, IEquatable<SportsClub>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsClub";

        /// <inheritdoc/>
        public bool Equals(SportsClub other)
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
        public override bool Equals(object obj) => this.Equals(obj as SportsClub);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

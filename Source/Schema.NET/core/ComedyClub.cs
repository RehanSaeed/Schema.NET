namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A comedy club.
    /// </summary>
    public partial interface IComedyClub : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// A comedy club.
    /// </summary>
    [DataContract]
    public partial class ComedyClub : EntertainmentBusiness, IComedyClub, IEquatable<ComedyClub>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ComedyClub";

        /// <inheritdoc/>
        public bool Equals(ComedyClub other)
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
        public override bool Equals(object obj) => this.Equals(obj as ComedyClub);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

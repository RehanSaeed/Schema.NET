namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A casino.
    /// </summary>
    public partial interface ICasino : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// A casino.
    /// </summary>
    [DataContract]
    public partial class Casino : EntertainmentBusiness, ICasino, IEquatable<Casino>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Casino";

        /// <inheritdoc/>
        public bool Equals(Casino other)
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
        public override bool Equals(object obj) => this.Equals(obj as Casino);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An amusement park.
    /// </summary>
    public partial interface IAmusementPark : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// An amusement park.
    /// </summary>
    [DataContract]
    public partial class AmusementPark : EntertainmentBusiness, IAmusementPark, IEquatable<AmusementPark>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AmusementPark";

        /// <inheritdoc/>
        public bool Equals(AmusementPark other)
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
        public override bool Equals(object obj) => this.Equals(obj as AmusementPark);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

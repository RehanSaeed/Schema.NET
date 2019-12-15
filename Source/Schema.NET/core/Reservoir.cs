namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A reservoir of water, typically an artificially created lake, like the Lake Kariba reservoir.
    /// </summary>
    public partial interface IReservoir : IBodyOfWater
    {
    }

    /// <summary>
    /// A reservoir of water, typically an artificially created lake, like the Lake Kariba reservoir.
    /// </summary>
    [DataContract]
    public partial class Reservoir : BodyOfWater, IReservoir, IEquatable<Reservoir>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Reservoir";

        /// <inheritdoc/>
        public bool Equals(Reservoir other)
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
        public override bool Equals(object obj) => this.Equals(obj as Reservoir);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

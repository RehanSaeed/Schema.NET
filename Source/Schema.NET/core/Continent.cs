namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// One of the continents (for example, Europe or Africa).
    /// </summary>
    public partial interface IContinent : ILandform
    {
    }

    /// <summary>
    /// One of the continents (for example, Europe or Africa).
    /// </summary>
    [DataContract]
    public partial class Continent : Landform, IContinent, IEquatable<Continent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Continent";

        /// <inheritdoc/>
        public bool Equals(Continent other)
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
        public override bool Equals(object obj) => this.Equals(obj as Continent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

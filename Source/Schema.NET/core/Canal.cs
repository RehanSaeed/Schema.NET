namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A canal, like the Panama Canal.
    /// </summary>
    public partial interface ICanal : IBodyOfWater
    {
    }

    /// <summary>
    /// A canal, like the Panama Canal.
    /// </summary>
    [DataContract]
    public partial class Canal : BodyOfWater, ICanal, IEquatable<Canal>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Canal";

        /// <inheritdoc/>
        public bool Equals(Canal other)
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
        public override bool Equals(object obj) => this.Equals(obj as Canal);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

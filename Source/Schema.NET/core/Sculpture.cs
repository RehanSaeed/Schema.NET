namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A piece of sculpture.
    /// </summary>
    public partial interface ISculpture : ICreativeWork
    {
    }

    /// <summary>
    /// A piece of sculpture.
    /// </summary>
    [DataContract]
    public partial class Sculpture : CreativeWork, ISculpture, IEquatable<Sculpture>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Sculpture";

        /// <inheritdoc/>
        public bool Equals(Sculpture other)
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
        public override bool Equals(object obj) => this.Equals(obj as Sculpture);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

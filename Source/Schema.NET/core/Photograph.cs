namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A photograph.
    /// </summary>
    public partial interface IPhotograph : ICreativeWork
    {
    }

    /// <summary>
    /// A photograph.
    /// </summary>
    [DataContract]
    public partial class Photograph : CreativeWork, IPhotograph, IEquatable<Photograph>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Photograph";

        /// <inheritdoc/>
        public bool Equals(Photograph other)
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
        public override bool Equals(object obj) => this.Equals(obj as Photograph);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

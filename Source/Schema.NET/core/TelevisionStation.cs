namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A television station.
    /// </summary>
    public partial interface ITelevisionStation : ILocalBusiness
    {
    }

    /// <summary>
    /// A television station.
    /// </summary>
    [DataContract]
    public partial class TelevisionStation : LocalBusiness, ITelevisionStation, IEquatable<TelevisionStation>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TelevisionStation";

        /// <inheritdoc/>
        public bool Equals(TelevisionStation other)
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
        public override bool Equals(object obj) => this.Equals(obj as TelevisionStation);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

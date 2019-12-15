namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An electrician.
    /// </summary>
    public partial interface IElectrician : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// An electrician.
    /// </summary>
    [DataContract]
    public partial class Electrician : HomeAndConstructionBusiness, IElectrician, IEquatable<Electrician>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Electrician";

        /// <inheritdoc/>
        public bool Equals(Electrician other)
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
        public override bool Equals(object obj) => this.Equals(obj as Electrician);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

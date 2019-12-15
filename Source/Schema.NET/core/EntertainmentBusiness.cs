namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A business providing entertainment.
    /// </summary>
    public partial interface IEntertainmentBusiness : ILocalBusiness
    {
    }

    /// <summary>
    /// A business providing entertainment.
    /// </summary>
    [DataContract]
    public partial class EntertainmentBusiness : LocalBusiness, IEntertainmentBusiness, IEquatable<EntertainmentBusiness>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EntertainmentBusiness";

        /// <inheritdoc/>
        public bool Equals(EntertainmentBusiness other)
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
        public override bool Equals(object obj) => this.Equals(obj as EntertainmentBusiness);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

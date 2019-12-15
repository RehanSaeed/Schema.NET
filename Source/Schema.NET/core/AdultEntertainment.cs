namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An adult entertainment establishment.
    /// </summary>
    public partial interface IAdultEntertainment : IEntertainmentBusiness
    {
    }

    /// <summary>
    /// An adult entertainment establishment.
    /// </summary>
    [DataContract]
    public partial class AdultEntertainment : EntertainmentBusiness, IAdultEntertainment, IEquatable<AdultEntertainment>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AdultEntertainment";

        /// <inheritdoc/>
        public bool Equals(AdultEntertainment other)
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
        public override bool Equals(object obj) => this.Equals(obj as AdultEntertainment);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

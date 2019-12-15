namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An internet cafe.
    /// </summary>
    public partial interface IInternetCafe : ILocalBusiness
    {
    }

    /// <summary>
    /// An internet cafe.
    /// </summary>
    [DataContract]
    public partial class InternetCafe : LocalBusiness, IInternetCafe, IEquatable<InternetCafe>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InternetCafe";

        /// <inheritdoc/>
        public bool Equals(InternetCafe other)
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
        public override bool Equals(object obj) => this.Equals(obj as InternetCafe);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

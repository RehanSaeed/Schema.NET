namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A self-storage facility.
    /// </summary>
    public partial interface ISelfStorage : ILocalBusiness
    {
    }

    /// <summary>
    /// A self-storage facility.
    /// </summary>
    [DataContract]
    public partial class SelfStorage : LocalBusiness, ISelfStorage, IEquatable<SelfStorage>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SelfStorage";

        /// <inheritdoc/>
        public bool Equals(SelfStorage other)
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
        public override bool Equals(object obj) => this.Equals(obj as SelfStorage);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

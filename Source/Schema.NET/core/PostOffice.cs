namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A post office.
    /// </summary>
    public partial interface IPostOffice : IGovernmentOffice
    {
    }

    /// <summary>
    /// A post office.
    /// </summary>
    [DataContract]
    public partial class PostOffice : GovernmentOffice, IPostOffice, IEquatable<PostOffice>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PostOffice";

        /// <inheritdoc/>
        public bool Equals(PostOffice other)
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
        public override bool Equals(object obj) => this.Equals(obj as PostOffice);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

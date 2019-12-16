namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of discovering/finding an object.
    /// </summary>
    public partial interface IDiscoverAction : IFindAction
    {
    }

    /// <summary>
    /// The act of discovering/finding an object.
    /// </summary>
    [DataContract]
    public partial class DiscoverAction : FindAction, IDiscoverAction, IEquatable<DiscoverAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DiscoverAction";

        /// <inheritdoc/>
        public bool Equals(DiscoverAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as DiscoverAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

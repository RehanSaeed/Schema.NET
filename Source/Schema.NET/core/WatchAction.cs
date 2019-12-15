namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of consuming dynamic/moving visual content.
    /// </summary>
    public partial interface IWatchAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of consuming dynamic/moving visual content.
    /// </summary>
    [DataContract]
    public partial class WatchAction : ConsumeAction, IWatchAction, IEquatable<WatchAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WatchAction";

        /// <inheritdoc/>
        public bool Equals(WatchAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as WatchAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

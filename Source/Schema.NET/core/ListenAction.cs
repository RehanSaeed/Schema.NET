namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of consuming audio content.
    /// </summary>
    public partial interface IListenAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of consuming audio content.
    /// </summary>
    [DataContract]
    public partial class ListenAction : ConsumeAction, IListenAction, IEquatable<ListenAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ListenAction";

        /// <inheritdoc/>
        public bool Equals(ListenAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as ListenAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

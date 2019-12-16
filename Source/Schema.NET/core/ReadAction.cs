namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of consuming written content.
    /// </summary>
    public partial interface IReadAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of consuming written content.
    /// </summary>
    [DataContract]
    public partial class ReadAction : ConsumeAction, IReadAction, IEquatable<ReadAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReadAction";

        /// <inheritdoc/>
        public bool Equals(ReadAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as ReadAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

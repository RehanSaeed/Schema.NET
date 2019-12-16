namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of applying an object to its intended purpose.
    /// </summary>
    public partial interface IUseAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of applying an object to its intended purpose.
    /// </summary>
    [DataContract]
    public partial class UseAction : ConsumeAction, IUseAction, IEquatable<UseAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "UseAction";

        /// <inheritdoc/>
        public bool Equals(UseAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as UseAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

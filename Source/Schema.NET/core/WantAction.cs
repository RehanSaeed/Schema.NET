namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of expressing a desire about the object. An agent wants an object.
    /// </summary>
    public partial interface IWantAction : IReactAction
    {
    }

    /// <summary>
    /// The act of expressing a desire about the object. An agent wants an object.
    /// </summary>
    [DataContract]
    public partial class WantAction : ReactAction, IWantAction, IEquatable<WantAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WantAction";

        /// <inheritdoc/>
        public bool Equals(WantAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as WantAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

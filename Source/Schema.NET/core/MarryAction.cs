namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of marrying a person.
    /// </summary>
    public partial interface IMarryAction : IInteractAction
    {
    }

    /// <summary>
    /// The act of marrying a person.
    /// </summary>
    [DataContract]
    public partial class MarryAction : InteractAction, IMarryAction, IEquatable<MarryAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MarryAction";

        /// <inheritdoc/>
        public bool Equals(MarryAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as MarryAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

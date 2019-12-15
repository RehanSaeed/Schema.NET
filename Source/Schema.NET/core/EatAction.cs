namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of swallowing solid objects.
    /// </summary>
    public partial interface IEatAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of swallowing solid objects.
    /// </summary>
    [DataContract]
    public partial class EatAction : ConsumeAction, IEatAction, IEquatable<EatAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EatAction";

        /// <inheritdoc/>
        public bool Equals(EatAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as EatAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of responding instinctively and emotionally to an object, expressing a sentiment.
    /// </summary>
    public partial interface IReactAction : IAssessAction
    {
    }

    /// <summary>
    /// The act of responding instinctively and emotionally to an object, expressing a sentiment.
    /// </summary>
    [DataContract]
    public partial class ReactAction : AssessAction, IReactAction, IEquatable<ReactAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReactAction";

        /// <inheritdoc/>
        public bool Equals(ReactAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as ReactAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

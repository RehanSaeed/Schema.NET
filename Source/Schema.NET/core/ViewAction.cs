namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of consuming static visual content.
    /// </summary>
    public partial interface IViewAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of consuming static visual content.
    /// </summary>
    [DataContract]
    public partial class ViewAction : ConsumeAction, IViewAction, IEquatable<ViewAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ViewAction";

        /// <inheritdoc/>
        public bool Equals(ViewAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as ViewAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

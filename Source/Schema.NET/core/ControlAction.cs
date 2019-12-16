namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent controls a device or application.
    /// </summary>
    public partial interface IControlAction : IAction
    {
    }

    /// <summary>
    /// An agent controls a device or application.
    /// </summary>
    [DataContract]
    public partial class ControlAction : Action, IControlAction, IEquatable<ControlAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ControlAction";

        /// <inheritdoc/>
        public bool Equals(ControlAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as ControlAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

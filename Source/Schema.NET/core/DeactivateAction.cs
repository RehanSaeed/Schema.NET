namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of stopping or deactivating a device or application (e.g. stopping a timer or turning off a flashlight).
    /// </summary>
    public partial interface IDeactivateAction : IControlAction
    {
    }

    /// <summary>
    /// The act of stopping or deactivating a device or application (e.g. stopping a timer or turning off a flashlight).
    /// </summary>
    [DataContract]
    public partial class DeactivateAction : ControlAction, IDeactivateAction, IEquatable<DeactivateAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DeactivateAction";

        /// <inheritdoc/>
        public bool Equals(DeactivateAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as DeactivateAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

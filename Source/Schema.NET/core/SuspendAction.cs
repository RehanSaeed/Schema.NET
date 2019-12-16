namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of momentarily pausing a device or application (e.g. pause music playback or pause a timer).
    /// </summary>
    public partial interface ISuspendAction : IControlAction
    {
    }

    /// <summary>
    /// The act of momentarily pausing a device or application (e.g. pause music playback or pause a timer).
    /// </summary>
    [DataContract]
    public partial class SuspendAction : ControlAction, ISuspendAction, IEquatable<SuspendAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SuspendAction";

        /// <inheritdoc/>
        public bool Equals(SuspendAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as SuspendAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

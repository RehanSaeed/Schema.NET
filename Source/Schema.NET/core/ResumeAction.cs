namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of resuming a device or application which was formerly paused (e.g. resume music playback or resume a timer).
    /// </summary>
    public partial interface IResumeAction : IControlAction
    {
    }

    /// <summary>
    /// The act of resuming a device or application which was formerly paused (e.g. resume music playback or resume a timer).
    /// </summary>
    [DataContract]
    public partial class ResumeAction : ControlAction, IResumeAction, IEquatable<ResumeAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ResumeAction";

        /// <inheritdoc/>
        public bool Equals(ResumeAction other)
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
        public override bool Equals(object obj) => this.Equals(obj as ResumeAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

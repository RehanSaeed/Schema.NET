namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of asking someone to attend an event. Reciprocal of RsvpAction.
    /// </summary>
    public partial interface IInviteAction : ICommunicateAction
    {
        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        OneOrMany<IEvent> Events { get; set; }
    }

    /// <summary>
    /// The act of asking someone to attend an event. Reciprocal of RsvpAction.
    /// </summary>
    [DataContract]
    public partial class InviteAction : CommunicateAction, IInviteAction, IEquatable<InviteAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InviteAction";

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> Events { get; set; }

        /// <inheritdoc/>
        public bool Equals(InviteAction other)
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
                this.Events == other.Events &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as InviteAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Events)
            .And(base.GetHashCode());
    }
}

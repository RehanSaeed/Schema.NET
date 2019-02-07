namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of asking someone to attend an event. Reciprocal of RsvpAction.
    /// </summary>
    [DataContract]
    public partial class InviteAction : CommunicateAction
    {
        public interface IEvent : IValue {}
        public interface IEvent<T> : IEvent { new T Value { get; } }
        public class OneOrManyEvent : OneOrMany<IEvent>
        {
            public OneOrManyEvent(IEvent item) : base(item) { }
            public OneOrManyEvent(IEnumerable<IEvent> items) : base(items) { }
            public static implicit operator OneOrManyEvent (Event value) { return new OneOrManyEvent (new EventEvent (value)); }
            public static implicit operator OneOrManyEvent (Event[] values) { return new OneOrManyEvent (values.Select(v => (IEvent) new EventEvent (v))); }
            public static implicit operator OneOrManyEvent (List<Event> values) { return new OneOrManyEvent (values.Select(v => (IEvent) new EventEvent (v))); }
        }
        public struct EventEvent : IEvent<Event>
        {
            object IValue.Value => this.Value;
            public Event Value { get; }
            public EventEvent (Event value) { Value = value; }
            public static implicit operator EventEvent (Event value) { return new EventEvent (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InviteAction";

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 406)]
        public OneOrManyEvent Event { get; set; }
    }
}

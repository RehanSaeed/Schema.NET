namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An agent leaves an event / group with participants/friends at a location.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: The antonym of LeaveAction.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/UnRegisterAction"&gt;UnRegisterAction&lt;/a&gt;: Unlike UnRegisterAction, LeaveAction implies leaving a group/team of people rather than a service.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class LeaveAction : InteractAction
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
        public override string Type => "LeaveAction";

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 306)]
        public OneOrManyEvent Event { get; set; }
    }
}

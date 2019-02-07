namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of playing/exercising/training/performing for enjoyment, leisure, recreation, Competition or exercise.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ListenAction"&gt;ListenAction&lt;/a&gt;: Unlike ListenAction (which is under ConsumeAction), PlayAction refers to performing for an audience or at an event, rather than consuming music.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/WatchAction"&gt;WatchAction&lt;/a&gt;: Unlike WatchAction (which is under ConsumeAction), PlayAction refers to showing/displaying for an audience or at an event, rather than consuming visual content.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class PlayAction : Action
    {
        public interface IAudience : IValue {}
        public interface IAudience<T> : IAudience { new T Value { get; } }
        public class OneOrManyAudience : OneOrMany<IAudience>
        {
            public OneOrManyAudience(IAudience item) : base(item) { }
            public OneOrManyAudience(IEnumerable<IAudience> items) : base(items) { }
            public static implicit operator OneOrManyAudience (Audience value) { return new OneOrManyAudience (new AudienceAudience (value)); }
            public static implicit operator OneOrManyAudience (Audience[] values) { return new OneOrManyAudience (values.Select(v => (IAudience) new AudienceAudience (v))); }
            public static implicit operator OneOrManyAudience (List<Audience> values) { return new OneOrManyAudience (values.Select(v => (IAudience) new AudienceAudience (v))); }
        }
        public struct AudienceAudience : IAudience<Audience>
        {
            object IValue.Value => this.Value;
            public Audience Value { get; }
            public AudienceAudience (Audience value) { Value = value; }
            public static implicit operator AudienceAudience (Audience value) { return new AudienceAudience (value); }
        }

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
        public override string Type => "PlayAction";

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 206)]
        public OneOrManyAudience Audience { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 207)]
        public OneOrManyEvent Event { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of planning the execution of an event/task/action/reservation/plan to a future date.
    /// </summary>
    [DataContract]
    public partial class PlanAction : OrganizeAction
    {
        public interface IScheduledTime : IValue {}
        public interface IScheduledTime<T> : IScheduledTime { new T Value { get; } }
        public class OneOrManyScheduledTime : OneOrMany<IScheduledTime>
        {
            public OneOrManyScheduledTime(IScheduledTime item) : base(item) { }
            public OneOrManyScheduledTime(IEnumerable<IScheduledTime> items) : base(items) { }
            public static implicit operator OneOrManyScheduledTime (DateTimeOffset value) { return new OneOrManyScheduledTime (new ScheduledTimeDateTimeOffset (value)); }
            public static implicit operator OneOrManyScheduledTime (DateTimeOffset[] values) { return new OneOrManyScheduledTime (values.Select(v => (IScheduledTime) new ScheduledTimeDateTimeOffset (v))); }
            public static implicit operator OneOrManyScheduledTime (List<DateTimeOffset> values) { return new OneOrManyScheduledTime (values.Select(v => (IScheduledTime) new ScheduledTimeDateTimeOffset (v))); }
        }
        public struct ScheduledTimeDateTimeOffset : IScheduledTime<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ScheduledTimeDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ScheduledTimeDateTimeOffset (DateTimeOffset value) { return new ScheduledTimeDateTimeOffset (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PlanAction";

        /// <summary>
        /// The time the object is scheduled to.
        /// </summary>
        [DataMember(Name = "scheduledTime", Order = 306)]
        public OneOrManyScheduledTime ScheduledTime { get; set; }
    }
}

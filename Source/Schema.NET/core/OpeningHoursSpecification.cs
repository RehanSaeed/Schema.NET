namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A structured value providing information about the opening hours of a place or a certain service inside a place.&lt;br/&gt;&lt;br/&gt;
    /// The place is &lt;strong&gt;open&lt;/strong&gt; if the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property is specified, and &lt;strong&gt;closed&lt;/strong&gt; otherwise.&lt;br/&gt;&lt;br/&gt;
    /// If the value for the &lt;a class="localLink" href="http://schema.org/closes"&gt;closes&lt;/a&gt; property is less than the value for the &lt;a class="localLink" href="http://schema.org/opens"&gt;opens&lt;/a&gt; property then the hour range is assumed to span over the next day.
    /// </summary>
    [DataContract]
    public partial class OpeningHoursSpecification : StructuredValue
    {
        public interface ICloses : IValue {}
        public interface ICloses<T> : ICloses { new T Value { get; } }
        public class OneOrManyCloses : OneOrMany<ICloses>
        {
            public OneOrManyCloses(ICloses item) : base(item) { }
            public OneOrManyCloses(IEnumerable<ICloses> items) : base(items) { }
            public static implicit operator OneOrManyCloses (TimeSpan value) { return new OneOrManyCloses (new ClosesTimeSpan (value)); }
            public static implicit operator OneOrManyCloses (TimeSpan[] values) { return new OneOrManyCloses (values.Select(v => (ICloses) new ClosesTimeSpan (v))); }
            public static implicit operator OneOrManyCloses (List<TimeSpan> values) { return new OneOrManyCloses (values.Select(v => (ICloses) new ClosesTimeSpan (v))); }
        }
        public struct ClosesTimeSpan : ICloses<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public ClosesTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator ClosesTimeSpan (TimeSpan value) { return new ClosesTimeSpan (value); }
        }

        public interface IDayOfWeek : IValue {}
        public interface IDayOfWeek<T> : IDayOfWeek { new T Value { get; } }
        public class OneOrManyDayOfWeek : OneOrMany<IDayOfWeek>
        {
            public OneOrManyDayOfWeek(IDayOfWeek item) : base(item) { }
            public OneOrManyDayOfWeek(IEnumerable<IDayOfWeek> items) : base(items) { }
            public static implicit operator OneOrManyDayOfWeek (DayOfWeek value) { return new OneOrManyDayOfWeek (new DayOfWeekDayOfWeek (value)); }
            public static implicit operator OneOrManyDayOfWeek (DayOfWeek[] values) { return new OneOrManyDayOfWeek (values.Select(v => (IDayOfWeek) new DayOfWeekDayOfWeek (v))); }
            public static implicit operator OneOrManyDayOfWeek (List<DayOfWeek> values) { return new OneOrManyDayOfWeek (values.Select(v => (IDayOfWeek) new DayOfWeekDayOfWeek (v))); }
        }
        public struct DayOfWeekDayOfWeek : IDayOfWeek<DayOfWeek>
        {
            object IValue.Value => this.Value;
            public DayOfWeek Value { get; }
            public DayOfWeekDayOfWeek (DayOfWeek value) { Value = value; }
            public static implicit operator DayOfWeekDayOfWeek (DayOfWeek value) { return new DayOfWeekDayOfWeek (value); }
        }

        public interface IOpens : IValue {}
        public interface IOpens<T> : IOpens { new T Value { get; } }
        public class OneOrManyOpens : OneOrMany<IOpens>
        {
            public OneOrManyOpens(IOpens item) : base(item) { }
            public OneOrManyOpens(IEnumerable<IOpens> items) : base(items) { }
            public static implicit operator OneOrManyOpens (TimeSpan value) { return new OneOrManyOpens (new OpensTimeSpan (value)); }
            public static implicit operator OneOrManyOpens (TimeSpan[] values) { return new OneOrManyOpens (values.Select(v => (IOpens) new OpensTimeSpan (v))); }
            public static implicit operator OneOrManyOpens (List<TimeSpan> values) { return new OneOrManyOpens (values.Select(v => (IOpens) new OpensTimeSpan (v))); }
        }
        public struct OpensTimeSpan : IOpens<TimeSpan>
        {
            object IValue.Value => this.Value;
            public TimeSpan Value { get; }
            public OpensTimeSpan (TimeSpan value) { Value = value; }
            public static implicit operator OpensTimeSpan (TimeSpan value) { return new OpensTimeSpan (value); }
        }

        public interface IValidFrom : IValue {}
        public interface IValidFrom<T> : IValidFrom { new T Value { get; } }
        public class OneOrManyValidFrom : OneOrMany<IValidFrom>
        {
            public OneOrManyValidFrom(IValidFrom item) : base(item) { }
            public OneOrManyValidFrom(IEnumerable<IValidFrom> items) : base(items) { }
            public static implicit operator OneOrManyValidFrom (DateTimeOffset value) { return new OneOrManyValidFrom (new ValidFromDateTimeOffset (value)); }
            public static implicit operator OneOrManyValidFrom (DateTimeOffset[] values) { return new OneOrManyValidFrom (values.Select(v => (IValidFrom) new ValidFromDateTimeOffset (v))); }
            public static implicit operator OneOrManyValidFrom (List<DateTimeOffset> values) { return new OneOrManyValidFrom (values.Select(v => (IValidFrom) new ValidFromDateTimeOffset (v))); }
        }
        public struct ValidFromDateTimeOffset : IValidFrom<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ValidFromDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ValidFromDateTimeOffset (DateTimeOffset value) { return new ValidFromDateTimeOffset (value); }
        }

        public interface IValidThrough : IValue {}
        public interface IValidThrough<T> : IValidThrough { new T Value { get; } }
        public class OneOrManyValidThrough : OneOrMany<IValidThrough>
        {
            public OneOrManyValidThrough(IValidThrough item) : base(item) { }
            public OneOrManyValidThrough(IEnumerable<IValidThrough> items) : base(items) { }
            public static implicit operator OneOrManyValidThrough (DateTimeOffset value) { return new OneOrManyValidThrough (new ValidThroughDateTimeOffset (value)); }
            public static implicit operator OneOrManyValidThrough (DateTimeOffset[] values) { return new OneOrManyValidThrough (values.Select(v => (IValidThrough) new ValidThroughDateTimeOffset (v))); }
            public static implicit operator OneOrManyValidThrough (List<DateTimeOffset> values) { return new OneOrManyValidThrough (values.Select(v => (IValidThrough) new ValidThroughDateTimeOffset (v))); }
        }
        public struct ValidThroughDateTimeOffset : IValidThrough<DateTimeOffset>
        {
            object IValue.Value => this.Value;
            public DateTimeOffset Value { get; }
            public ValidThroughDateTimeOffset (DateTimeOffset value) { Value = value; }
            public static implicit operator ValidThroughDateTimeOffset (DateTimeOffset value) { return new ValidThroughDateTimeOffset (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OpeningHoursSpecification";

        /// <summary>
        /// The closing hour of the place or service on the given day(s) of the week.
        /// </summary>
        [DataMember(Name = "closes", Order = 306)]
        public OneOrManyCloses Closes { get; set; }

        /// <summary>
        /// The day of the week for which these opening hours are valid.
        /// </summary>
        [DataMember(Name = "dayOfWeek", Order = 307)]
        public OneOrManyDayOfWeek DayOfWeek { get; set; }

        /// <summary>
        /// The opening hour of the place or service on the given day(s) of the week.
        /// </summary>
        [DataMember(Name = "opens", Order = 308)]
        public OneOrManyOpens Opens { get; set; }

        /// <summary>
        /// The date when the item becomes valid.
        /// </summary>
        [DataMember(Name = "validFrom", Order = 309)]
        public OneOrManyValidFrom ValidFrom { get; set; }

        /// <summary>
        /// The date after when the item is not valid. For example the end of an offer, salary period, or a period of opening hours.
        /// </summary>
        [DataMember(Name = "validThrough", Order = 310)]
        public OneOrManyValidThrough ValidThrough { get; set; }
    }
}

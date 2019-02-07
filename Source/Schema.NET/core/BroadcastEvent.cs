namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An over the air or online broadcast event.
    /// </summary>
    [DataContract]
    public partial class BroadcastEvent : PublicationEvent
    {
        public interface IBroadcastOfEvent : IValue {}
        public interface IBroadcastOfEvent<T> : IBroadcastOfEvent { new T Value { get; } }
        public class OneOrManyBroadcastOfEvent : OneOrMany<IBroadcastOfEvent>
        {
            public OneOrManyBroadcastOfEvent(IBroadcastOfEvent item) : base(item) { }
            public OneOrManyBroadcastOfEvent(IEnumerable<IBroadcastOfEvent> items) : base(items) { }
            public static implicit operator OneOrManyBroadcastOfEvent (Event value) { return new OneOrManyBroadcastOfEvent (new BroadcastOfEventEvent (value)); }
            public static implicit operator OneOrManyBroadcastOfEvent (Event[] values) { return new OneOrManyBroadcastOfEvent (values.Select(v => (IBroadcastOfEvent) new BroadcastOfEventEvent (v))); }
            public static implicit operator OneOrManyBroadcastOfEvent (List<Event> values) { return new OneOrManyBroadcastOfEvent (values.Select(v => (IBroadcastOfEvent) new BroadcastOfEventEvent (v))); }
        }
        public struct BroadcastOfEventEvent : IBroadcastOfEvent<Event>
        {
            object IValue.Value => this.Value;
            public Event Value { get; }
            public BroadcastOfEventEvent (Event value) { Value = value; }
            public static implicit operator BroadcastOfEventEvent (Event value) { return new BroadcastOfEventEvent (value); }
        }

        public interface IIsLiveBroadcast : IValue {}
        public interface IIsLiveBroadcast<T> : IIsLiveBroadcast { new T Value { get; } }
        public class OneOrManyIsLiveBroadcast : OneOrMany<IIsLiveBroadcast>
        {
            public OneOrManyIsLiveBroadcast(IIsLiveBroadcast item) : base(item) { }
            public OneOrManyIsLiveBroadcast(IEnumerable<IIsLiveBroadcast> items) : base(items) { }
            public static implicit operator OneOrManyIsLiveBroadcast (bool value) { return new OneOrManyIsLiveBroadcast (new IsLiveBroadcastbool (value)); }
            public static implicit operator OneOrManyIsLiveBroadcast (bool[] values) { return new OneOrManyIsLiveBroadcast (values.Select(v => (IIsLiveBroadcast) new IsLiveBroadcastbool (v))); }
            public static implicit operator OneOrManyIsLiveBroadcast (List<bool> values) { return new OneOrManyIsLiveBroadcast (values.Select(v => (IIsLiveBroadcast) new IsLiveBroadcastbool (v))); }
        }
        public struct IsLiveBroadcastbool : IIsLiveBroadcast<bool>
        {
            object IValue.Value => this.Value;
            public bool Value { get; }
            public IsLiveBroadcastbool (bool value) { Value = value; }
            public static implicit operator IsLiveBroadcastbool (bool value) { return new IsLiveBroadcastbool (value); }
        }

        public interface IVideoFormat : IValue {}
        public interface IVideoFormat<T> : IVideoFormat { new T Value { get; } }
        public class OneOrManyVideoFormat : OneOrMany<IVideoFormat>
        {
            public OneOrManyVideoFormat(IVideoFormat item) : base(item) { }
            public OneOrManyVideoFormat(IEnumerable<IVideoFormat> items) : base(items) { }
            public static implicit operator OneOrManyVideoFormat (string value) { return new OneOrManyVideoFormat (new VideoFormatstring (value)); }
            public static implicit operator OneOrManyVideoFormat (string[] values) { return new OneOrManyVideoFormat (values.Select(v => (IVideoFormat) new VideoFormatstring (v))); }
            public static implicit operator OneOrManyVideoFormat (List<string> values) { return new OneOrManyVideoFormat (values.Select(v => (IVideoFormat) new VideoFormatstring (v))); }
        }
        public struct VideoFormatstring : IVideoFormat<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VideoFormatstring (string value) { Value = value; }
            public static implicit operator VideoFormatstring (string value) { return new VideoFormatstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastEvent";

        /// <summary>
        /// The event being broadcast such as a sporting event or awards ceremony.
        /// </summary>
        [DataMember(Name = "broadcastOfEvent", Order = 306)]
        public OneOrManyBroadcastOfEvent BroadcastOfEvent { get; set; }

        /// <summary>
        /// True is the broadcast is of a live event.
        /// </summary>
        [DataMember(Name = "isLiveBroadcast", Order = 307)]
        public OneOrManyIsLiveBroadcast IsLiveBroadcast { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [DataMember(Name = "videoFormat", Order = 308)]
        public OneOrManyVideoFormat VideoFormat { get; set; }
    }
}

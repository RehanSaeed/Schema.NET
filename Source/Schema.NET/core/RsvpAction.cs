namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of notifying an event organizer as to whether you expect to attend the event.
    /// </summary>
    [DataContract]
    public partial class RsvpAction : InformAction
    {
        public interface IAdditionalNumberOfGuests : IValue {}
        public interface IAdditionalNumberOfGuests<T> : IAdditionalNumberOfGuests { new T Value { get; } }
        public class OneOrManyAdditionalNumberOfGuests : OneOrMany<IAdditionalNumberOfGuests>
        {
            public OneOrManyAdditionalNumberOfGuests(IAdditionalNumberOfGuests item) : base(item) { }
            public OneOrManyAdditionalNumberOfGuests(IEnumerable<IAdditionalNumberOfGuests> items) : base(items) { }
            public static implicit operator OneOrManyAdditionalNumberOfGuests (int value) { return new OneOrManyAdditionalNumberOfGuests (new AdditionalNumberOfGuestsint (value)); }
            public static implicit operator OneOrManyAdditionalNumberOfGuests (int[] values) { return new OneOrManyAdditionalNumberOfGuests (values.Select(v => (IAdditionalNumberOfGuests) new AdditionalNumberOfGuestsint (v))); }
            public static implicit operator OneOrManyAdditionalNumberOfGuests (List<int> values) { return new OneOrManyAdditionalNumberOfGuests (values.Select(v => (IAdditionalNumberOfGuests) new AdditionalNumberOfGuestsint (v))); }
        }
        public struct AdditionalNumberOfGuestsint : IAdditionalNumberOfGuests<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public AdditionalNumberOfGuestsint (int value) { Value = value; }
            public static implicit operator AdditionalNumberOfGuestsint (int value) { return new AdditionalNumberOfGuestsint (value); }
        }

        public interface IComment : IValue {}
        public interface IComment<T> : IComment { new T Value { get; } }
        public class OneOrManyComment : OneOrMany<IComment>
        {
            public OneOrManyComment(IComment item) : base(item) { }
            public OneOrManyComment(IEnumerable<IComment> items) : base(items) { }
            public static implicit operator OneOrManyComment (Comment value) { return new OneOrManyComment (new CommentComment (value)); }
            public static implicit operator OneOrManyComment (Comment[] values) { return new OneOrManyComment (values.Select(v => (IComment) new CommentComment (v))); }
            public static implicit operator OneOrManyComment (List<Comment> values) { return new OneOrManyComment (values.Select(v => (IComment) new CommentComment (v))); }
        }
        public struct CommentComment : IComment<Comment>
        {
            object IValue.Value => this.Value;
            public Comment Value { get; }
            public CommentComment (Comment value) { Value = value; }
            public static implicit operator CommentComment (Comment value) { return new CommentComment (value); }
        }

        public interface IRsvpResponse : IValue {}
        public interface IRsvpResponse<T> : IRsvpResponse { new T Value { get; } }
        public class OneOrManyRsvpResponse : OneOrMany<IRsvpResponse>
        {
            public OneOrManyRsvpResponse(IRsvpResponse item) : base(item) { }
            public OneOrManyRsvpResponse(IEnumerable<IRsvpResponse> items) : base(items) { }
            public static implicit operator OneOrManyRsvpResponse (RsvpResponseType value) { return new OneOrManyRsvpResponse (new RsvpResponseRsvpResponseType (value)); }
            public static implicit operator OneOrManyRsvpResponse (RsvpResponseType[] values) { return new OneOrManyRsvpResponse (values.Select(v => (IRsvpResponse) new RsvpResponseRsvpResponseType (v))); }
            public static implicit operator OneOrManyRsvpResponse (List<RsvpResponseType> values) { return new OneOrManyRsvpResponse (values.Select(v => (IRsvpResponse) new RsvpResponseRsvpResponseType (v))); }
        }
        public struct RsvpResponseRsvpResponseType : IRsvpResponse<RsvpResponseType>
        {
            object IValue.Value => this.Value;
            public RsvpResponseType Value { get; }
            public RsvpResponseRsvpResponseType (RsvpResponseType value) { Value = value; }
            public static implicit operator RsvpResponseRsvpResponseType (RsvpResponseType value) { return new RsvpResponseRsvpResponseType (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RsvpAction";

        /// <summary>
        /// If responding yes, the number of guests who will attend in addition to the invitee.
        /// </summary>
        [DataMember(Name = "additionalNumberOfGuests", Order = 506)]
        public OneOrManyAdditionalNumberOfGuests AdditionalNumberOfGuests { get; set; }

        /// <summary>
        /// Comments, typically from users.
        /// </summary>
        [DataMember(Name = "comment", Order = 507)]
        public OneOrManyComment Comment { get; set; }

        /// <summary>
        /// The response (yes, no, maybe) to the RSVP.
        /// </summary>
        [DataMember(Name = "rsvpResponse", Order = 508)]
        public OneOrManyRsvpResponse RsvpResponse { get; set; }
    }
}

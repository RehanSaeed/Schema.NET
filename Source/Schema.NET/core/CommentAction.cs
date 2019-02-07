namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of generating a comment about a subject.
    /// </summary>
    [DataContract]
    public partial class CommentAction : CommunicateAction
    {
        public interface IResultComment : IValue {}
        public interface IResultComment<T> : IResultComment { new T Value { get; } }
        public class OneOrManyResultComment : OneOrMany<IResultComment>
        {
            public OneOrManyResultComment(IResultComment item) : base(item) { }
            public OneOrManyResultComment(IEnumerable<IResultComment> items) : base(items) { }
            public static implicit operator OneOrManyResultComment (Comment value) { return new OneOrManyResultComment (new ResultCommentComment (value)); }
            public static implicit operator OneOrManyResultComment (Comment[] values) { return new OneOrManyResultComment (values.Select(v => (IResultComment) new ResultCommentComment (v))); }
            public static implicit operator OneOrManyResultComment (List<Comment> values) { return new OneOrManyResultComment (values.Select(v => (IResultComment) new ResultCommentComment (v))); }
        }
        public struct ResultCommentComment : IResultComment<Comment>
        {
            object IValue.Value => this.Value;
            public Comment Value { get; }
            public ResultCommentComment (Comment value) { Value = value; }
            public static implicit operator ResultCommentComment (Comment value) { return new ResultCommentComment (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CommentAction";

        /// <summary>
        /// A sub property of result. The Comment created or sent as a result of this action.
        /// </summary>
        [DataMember(Name = "resultComment", Order = 406)]
        public OneOrManyResultComment ResultComment { get; set; }
    }
}

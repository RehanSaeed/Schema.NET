namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of responding to a question/message asked/sent by the object. Related to &lt;a class="localLink" href="http://schema.org/AskAction"&gt;AskAction&lt;/a&gt;&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/AskAction"&gt;AskAction&lt;/a&gt;: Appears generally as an origin of a ReplyAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class ReplyAction : CommunicateAction
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
        public override string Type => "ReplyAction";

        /// <summary>
        /// A sub property of result. The Comment created or sent as a result of this action.
        /// </summary>
        [DataMember(Name = "resultComment", Order = 406)]
        public OneOrManyResultComment ResultComment { get; set; }
    }
}

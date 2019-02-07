namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of posing a question / favor to someone.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/ReplyAction"&gt;ReplyAction&lt;/a&gt;: Appears generally as a response to AskAction.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class AskAction : CommunicateAction
    {
        public interface IQuestion : IValue {}
        public interface IQuestion<T> : IQuestion { new T Value { get; } }
        public class OneOrManyQuestion : OneOrMany<IQuestion>
        {
            public OneOrManyQuestion(IQuestion item) : base(item) { }
            public OneOrManyQuestion(IEnumerable<IQuestion> items) : base(items) { }
            public static implicit operator OneOrManyQuestion (Question value) { return new OneOrManyQuestion (new QuestionQuestion (value)); }
            public static implicit operator OneOrManyQuestion (Question[] values) { return new OneOrManyQuestion (values.Select(v => (IQuestion) new QuestionQuestion (v))); }
            public static implicit operator OneOrManyQuestion (List<Question> values) { return new OneOrManyQuestion (values.Select(v => (IQuestion) new QuestionQuestion (v))); }
        }
        public struct QuestionQuestion : IQuestion<Question>
        {
            object IValue.Value => this.Value;
            public Question Value { get; }
            public QuestionQuestion (Question value) { Value = value; }
            public static implicit operator QuestionQuestion (Question value) { return new QuestionQuestion (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AskAction";

        /// <summary>
        /// A sub property of object. A question.
        /// </summary>
        [DataMember(Name = "question", Order = 406)]
        public OneOrManyQuestion Question { get; set; }
    }
}

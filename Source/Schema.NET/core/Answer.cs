namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An answer offered to a question; perhaps correct, perhaps opinionated or wrong.
    /// </summary>
    public partial interface IAnswer : IComment
    {
    }

    /// <summary>
    /// An answer offered to a question; perhaps correct, perhaps opinionated or wrong.
    /// </summary>
    [DataContract]
    public partial class Answer : Comment, IAnswer
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Answer";
    }
}

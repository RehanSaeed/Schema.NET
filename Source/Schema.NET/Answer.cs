namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An answer offered to a question; perhaps correct, perhaps opinionated or wrong.
    /// </summary>
    [DataContract]
    public class Answer : Comment
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Answer";
    }
}

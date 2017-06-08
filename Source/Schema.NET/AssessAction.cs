namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of forming one's opinion, reaction or sentiment.
    /// </summary>
    [DataContract]
    public class AssessAction : Action
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "AssessAction";
    }
}

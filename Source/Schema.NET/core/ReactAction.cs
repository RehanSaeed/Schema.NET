namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of responding instinctively and emotionally to an object, expressing a sentiment.
    /// </summary>
    [DataContract]
    public class ReactAction : AssessAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReactAction";
    }
}

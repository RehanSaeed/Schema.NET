namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of committing to/adopting an object.
    /// Related actions:
    ///
    /// RejectAction: The antonym of AcceptAction.
    /// </summary>
    [DataContract]
    public class AcceptAction : AllocateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "AcceptAction";
    }
}

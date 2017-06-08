namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of asserting that a future event/action is no longer going to happen...
    /// </summary>
    [DataContract]
    public class CancelAction : PlanAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "CancelAction";
    }
}

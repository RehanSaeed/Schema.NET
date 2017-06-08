namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of notifying someone that a future event/action is going to happen as expected...
    /// </summary>
    [DataContract]
    public class ConfirmAction : InformAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ConfirmAction";
    }
}

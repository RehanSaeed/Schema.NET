namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An agent controls a device or application.
    /// </summary>
    [DataContract]
    public class ControlAction : Action
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ControlAction";
    }
}

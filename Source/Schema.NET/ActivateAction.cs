namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of starting or activating a device or application (e.g...
    /// </summary>
    [DataContract]
    public class ActivateAction : ControlAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ActivateAction";
    }
}

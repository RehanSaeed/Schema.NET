namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of momentarily pausing a device or application (e.g. pause music playback or pause a timer).
    /// </summary>
    [DataContract]
    public class SuspendAction : ControlAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "SuspendAction";
    }
}

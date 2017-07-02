namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of resuming a device or application which was formerly paused (e.g. resume music playback or resume a timer).
    /// </summary>
    [DataContract]
    public partial class ResumeAction : ControlAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ResumeAction";
    }
}

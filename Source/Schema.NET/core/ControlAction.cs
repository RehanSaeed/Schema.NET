namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent controls a device or application.
    /// </summary>
    public partial interface IControlAction : IAction
    {
    }

    /// <summary>
    /// An agent controls a device or application.
    /// </summary>
    [DataContract]
    public partial class ControlAction : Action, IControlAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ControlAction";
    }
}

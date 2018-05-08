namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of accomplishing something via previous efforts. It is an instantaneous action rather than an ongoing process.
    /// </summary>
    public partial interface IAchieveAction : IAction
    {
    }

    /// <summary>
    /// The act of accomplishing something via previous efforts. It is an instantaneous action rather than an ongoing process.
    /// </summary>
    [DataContract]
    public partial class AchieveAction : Action, IAchieveAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AchieveAction";
    }
}

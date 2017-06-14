namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Reserving a concrete object.
    /// Related actions:
    ///
    /// ScheduleAction: Unlike ScheduleAction, ReserveAction reserves concrete objects (e...
    /// </summary>
    [DataContract]
    public partial class ReserveAction : PlanAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ReserveAction";
    }
}

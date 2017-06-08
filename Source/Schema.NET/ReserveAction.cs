namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Reserving a concrete object.
    /// Related actions:
    ///
    /// ScheduleAction: Unlike ScheduleAction, ReserveAction reserves concrete objects (e...
    /// </summary>
    [DataContract]
    public class ReserveAction : PlanAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ReserveAction";
    }
}

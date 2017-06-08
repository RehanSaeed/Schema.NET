namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Scheduling future actions, events, or tasks.
    /// Related actions:
    ///
    /// ReserveAction: Unlike ReserveAction, ScheduleAction allocates future actions (e...
    /// </summary>
    [DataContract]
    public class ScheduleAction : PlanAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "ScheduleAction";
    }
}

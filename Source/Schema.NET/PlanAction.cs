namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of planning the execution of an event/task/action/reservation/plan to a future date.
    /// </summary>
    [DataContract]
    public class PlanAction : OrganizeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PlanAction";

        /// <summary>
        /// The time the object is scheduled to.
        /// </summary>
        [DataMember(Name = "scheduledTime")]
        public DateTimeOffset ScheduledTime { get; set; }
    }
}

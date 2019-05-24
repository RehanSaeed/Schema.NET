namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of planning the execution of an event/task/action/reservation/plan to a future date.
    /// </summary>
    public partial interface IPlanAction : IOrganizeAction
    {
        /// <summary>
        /// The time the object is scheduled to.
        /// </summary>
        OneOrMany<DateTimeOffset?> ScheduledTime { get; set; }
    }

    /// <summary>
    /// The act of planning the execution of an event/task/action/reservation/plan to a future date.
    /// </summary>
    [DataContract]
    public partial class PlanAction : OrganizeAction, IPlanAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PlanAction";

        /// <summary>
        /// The time the object is scheduled to.
        /// </summary>
        [DataMember(Name = "scheduledTime", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DateTimeOffset?> ScheduledTime { get; set; }
    }
}

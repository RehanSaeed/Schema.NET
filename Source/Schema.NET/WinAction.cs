namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of achieving victory in a competitive activity.
    /// </summary>
    [DataContract]
    public class WinAction : AchieveAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "WinAction";

        /// <summary>
        /// A sub property of participant. The loser of the action.
        /// </summary>
        [DataMember(Name = "loser")]
        public Person Loser { get; set; }
    }
}

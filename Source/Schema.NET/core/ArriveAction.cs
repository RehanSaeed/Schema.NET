namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of arriving at a place. An agent arrives at a destination from a fromLocation, optionally with participants.
    /// </summary>
    [DataContract]
    public partial class ArriveAction : MoveAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ArriveAction";
    }
}

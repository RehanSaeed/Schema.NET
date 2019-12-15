namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of arriving at a place. An agent arrives at a destination from a fromLocation, optionally with participants.
    /// </summary>
    public partial interface IArriveAction : IMoveAction
    {
    }

    /// <summary>
    /// The act of arriving at a place. An agent arrives at a destination from a fromLocation, optionally with participants.
    /// </summary>
    [DataContract]
    public partial class ArriveAction : MoveAction, IArriveAction, IEquatable<ArriveAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ArriveAction";
    }
}

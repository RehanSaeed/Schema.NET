namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of  departing from a place. An agent departs from an fromLocation for a destination, optionally with participants.
    /// </summary>
    public partial interface IDepartAction : IMoveAction
    {
    }

    /// <summary>
    /// The act of  departing from a place. An agent departs from an fromLocation for a destination, optionally with participants.
    /// </summary>
    [DataContract]
    public partial class DepartAction : MoveAction, IDepartAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DepartAction";
    }
}

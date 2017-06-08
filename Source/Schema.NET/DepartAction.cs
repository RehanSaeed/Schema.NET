namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of  departing from a place. An agent departs from an fromLocation for a destination, optionally with participants.
    /// </summary>
    [DataContract]
    public class DepartAction : MoveAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DepartAction";
    }
}

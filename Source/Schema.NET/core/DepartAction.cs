namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of  departing from a place. An agent departs from an fromLocation for a destination, optionally with participants.
    /// </summary>
    [DataContract]
    public partial class DepartAction : MoveAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DepartAction";
    }
}

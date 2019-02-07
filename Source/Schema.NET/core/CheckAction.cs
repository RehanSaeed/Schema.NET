namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An agent inspects, determines, investigates, inquires, or examines an object's accuracy, quality, condition, or state.
    /// </summary>
    [DataContract]
    public partial class CheckAction : FindAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CheckAction";
    }
}

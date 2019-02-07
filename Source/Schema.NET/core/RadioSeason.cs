namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Season dedicated to radio broadcast and associated online delivery.
    /// </summary>
    [DataContract]
    public partial class RadioSeason : CreativeWorkSeason
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RadioSeason";
    }
}

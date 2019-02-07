namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A publication event e.g. catch-up TV or radio podcast, during which a program is available on-demand.
    /// </summary>
    [DataContract]
    public partial class OnDemandEvent : PublicationEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OnDemandEvent";
    }
}

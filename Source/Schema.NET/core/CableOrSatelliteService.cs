namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A service which provides access to media programming like TV or radio. Access may be via cable or satellite.
    /// </summary>
    [DataContract]
    public partial class CableOrSatelliteService : Service
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CableOrSatelliteService";
    }
}

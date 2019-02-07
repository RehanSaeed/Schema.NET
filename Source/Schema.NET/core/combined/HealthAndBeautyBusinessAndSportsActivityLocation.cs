namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// See HealthAndBeautyBusiness, SportsActivityLocation for more information.
    /// </summary>
    [DataContract]
    public abstract partial class HealthAndBeautyBusinessAndSportsActivityLocation : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HealthAndBeautyBusinessAndSportsActivityLocation";
    }
}

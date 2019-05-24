namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A day spa.
    /// </summary>
    public partial interface IDaySpa : IHealthAndBeautyBusiness
    {
    }

    /// <summary>
    /// A day spa.
    /// </summary>
    [DataContract]
    public partial class DaySpa : HealthAndBeautyBusiness, IDaySpa
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DaySpa";
    }
}

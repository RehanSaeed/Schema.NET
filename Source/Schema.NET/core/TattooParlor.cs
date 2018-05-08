namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A tattoo parlor.
    /// </summary>
    public partial interface ITattooParlor : IHealthAndBeautyBusiness
    {
    }

    /// <summary>
    /// A tattoo parlor.
    /// </summary>
    [DataContract]
    public partial class TattooParlor : HealthAndBeautyBusiness, ITattooParlor
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TattooParlor";
    }
}

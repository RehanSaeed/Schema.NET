namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A hair salon.
    /// </summary>
    public partial interface IHairSalon : IHealthAndBeautyBusiness
    {
    }

    /// <summary>
    /// A hair salon.
    /// </summary>
    [DataContract]
    public partial class HairSalon : HealthAndBeautyBusiness, IHairSalon
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "HairSalon";
    }
}

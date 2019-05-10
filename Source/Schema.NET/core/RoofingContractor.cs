namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A roofing contractor.
    /// </summary>
    public partial interface IRoofingContractor : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A roofing contractor.
    /// </summary>
    [DataContract]
    public partial class RoofingContractor : HomeAndConstructionBusiness, IRoofingContractor
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RoofingContractor";
    }
}

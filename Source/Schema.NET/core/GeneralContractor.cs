namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A general contractor.
    /// </summary>
    public partial interface IGeneralContractor : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A general contractor.
    /// </summary>
    [DataContract]
    public partial class GeneralContractor : HomeAndConstructionBusiness, IGeneralContractor
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GeneralContractor";
    }
}

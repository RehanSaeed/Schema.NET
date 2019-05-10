namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A plumbing service.
    /// </summary>
    public partial interface IPlumber : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A plumbing service.
    /// </summary>
    [DataContract]
    public partial class Plumber : HomeAndConstructionBusiness, IPlumber
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Plumber";
    }
}

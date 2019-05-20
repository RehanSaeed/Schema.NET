namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A moving company.
    /// </summary>
    public partial interface IMovingCompany : IHomeAndConstructionBusiness
    {
    }

    /// <summary>
    /// A moving company.
    /// </summary>
    [DataContract]
    public partial class MovingCompany : HomeAndConstructionBusiness, IMovingCompany
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MovingCompany";
    }
}

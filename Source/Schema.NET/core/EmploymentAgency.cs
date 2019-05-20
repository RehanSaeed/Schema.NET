namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An employment agency.
    /// </summary>
    public partial interface IEmploymentAgency : ILocalBusiness
    {
    }

    /// <summary>
    /// An employment agency.
    /// </summary>
    [DataContract]
    public partial class EmploymentAgency : LocalBusiness, IEmploymentAgency
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EmploymentAgency";
    }
}

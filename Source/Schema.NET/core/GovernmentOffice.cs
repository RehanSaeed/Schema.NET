namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A government office&amp;#x2014;for example, an IRS or DMV office.
    /// </summary>
    public partial interface IGovernmentOffice : ILocalBusiness
    {
    }

    /// <summary>
    /// A government office&amp;#x2014;for example, an IRS or DMV office.
    /// </summary>
    [DataContract]
    public partial class GovernmentOffice : LocalBusiness, IGovernmentOffice
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GovernmentOffice";
    }
}

using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A government office&amp;#x2014;for example, an IRS or DMV office.
    /// </summary>
    [DataContract]
    public partial class GovernmentOffice : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GovernmentOffice";
    }
}

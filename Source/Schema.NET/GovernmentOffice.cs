namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A government office&amp;#x2014;for example, an IRS or DMV office.
    /// </summary>
    [DataContract]
    public class GovernmentOffice : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "GovernmentOffice";
    }
}

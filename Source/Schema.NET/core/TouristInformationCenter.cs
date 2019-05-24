namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A tourist information center.
    /// </summary>
    public partial interface ITouristInformationCenter : ILocalBusiness
    {
    }

    /// <summary>
    /// A tourist information center.
    /// </summary>
    [DataContract]
    public partial class TouristInformationCenter : LocalBusiness, ITouristInformationCenter
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TouristInformationCenter";
    }
}

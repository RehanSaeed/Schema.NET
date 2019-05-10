namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An emergency service, such as a fire station or ER.
    /// </summary>
    public partial interface IEmergencyService : ILocalBusiness
    {
    }

    /// <summary>
    /// An emergency service, such as a fire station or ER.
    /// </summary>
    [DataContract]
    public partial class EmergencyService : LocalBusiness, IEmergencyService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EmergencyService";
    }
}

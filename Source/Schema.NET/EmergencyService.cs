namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An emergency service, such as a fire station or ER.
    /// </summary>
    [DataContract]
    public class EmergencyService : LocalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "EmergencyService";
    }
}

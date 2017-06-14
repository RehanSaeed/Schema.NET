namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of an agent communicating (service provider, social media, etc) their arrival by registering/confirming for a previously reserved service (e...
    /// </summary>
    [DataContract]
    public partial class CheckInAction : CommunicateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CheckInAction";
    }
}

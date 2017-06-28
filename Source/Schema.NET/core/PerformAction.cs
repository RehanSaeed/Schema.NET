namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of participating in performance arts.
    /// </summary>
    [DataContract]
    public partial class PerformAction : PlayAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PerformAction";

        /// <summary>
        /// A sub property of location. The entertainment business where the action occurred.
        /// </summary>
        [DataMember(Name = "entertainmentBusiness", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<EntertainmentBusiness>? EntertainmentBusiness { get; set; }
    }
}

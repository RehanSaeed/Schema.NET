namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates polled from...
    /// </summary>
    [DataContract]
    public partial class FollowAction : InteractAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FollowAction";

        /// <summary>
        /// A sub property of object. The person or organization being followed.
        /// </summary>
        [DataMember(Name = "followee", Order = 2)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization, Person>? Followee { get; set; }
    }
}

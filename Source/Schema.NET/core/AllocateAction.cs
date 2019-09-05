namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// </summary>
    public partial interface IAllocateAction : IOrganizeAction
    {
        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        Values<MedicalDevicePurpose?, IThing> Purpose { get; set; }
    }

    /// <summary>
    /// The act of organizing tasks/objects/events by associating resources to it.
    /// </summary>
    [DataContract]
    public partial class AllocateAction : OrganizeAction, IAllocateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AllocateAction";

        /// <summary>
        /// A goal towards an action is taken. Can be concrete or abstract.
        /// </summary>
        [DataMember(Name = "purpose", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<MedicalDevicePurpose?, IThing> Purpose { get; set; }
    }
}

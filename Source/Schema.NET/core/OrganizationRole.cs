namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A subclass of Role used to describe roles within organizations.
    /// </summary>
    [DataContract]
    public partial class OrganizationRole : Role
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "OrganizationRole";

        /// <summary>
        /// A number associated with a role in an organization, for example, the number on an athlete's jersey.
        /// </summary>
        [DataMember(Name = "numberedPosition", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<double?>? NumberedPosition { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A PerformanceRole is a Role that some entity places with regard to a theatrical performance, e...
    /// </summary>
    [DataContract]
    public class PerformanceRole : Role
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PerformanceRole";

        /// <summary>
        /// The name of a character played in some acting or performing role, i.e. in a PerformanceRole.
        /// </summary>
        [DataMember(Name = "characterName")]
        public string CharacterName { get; set; }
    }
}

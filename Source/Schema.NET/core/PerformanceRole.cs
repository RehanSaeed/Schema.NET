namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A PerformanceRole is a Role that some entity places with regard to a theatrical performance, e.g. in a Movie, TVSeries etc.
    /// </summary>
    public partial interface IPerformanceRole : IRole
    {
        /// <summary>
        /// The name of a character played in some acting or performing role, i.e. in a PerformanceRole.
        /// </summary>
        OneOrMany<string>? CharacterName { get; set; }
    }

    /// <summary>
    /// A PerformanceRole is a Role that some entity places with regard to a theatrical performance, e.g. in a Movie, TVSeries etc.
    /// </summary>
    [DataContract]
    public partial class PerformanceRole : Role, IPerformanceRole
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PerformanceRole";

        /// <summary>
        /// The name of a character played in some acting or performing role, i.e. in a PerformanceRole.
        /// </summary>
        [DataMember(Name = "characterName", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? CharacterName { get; set; }
    }
}

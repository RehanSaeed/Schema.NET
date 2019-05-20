namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A thesis or dissertation document submitted in support of candidature for an academic degree or professional qualification.
    /// </summary>
    public partial interface IThesis : ICreativeWork
    {
        /// <summary>
        /// Qualification, candidature, degree, application that Thesis supports.
        /// </summary>
        OneOrMany<string>? InSupportOf { get; set; }
    }

    /// <summary>
    /// A thesis or dissertation document submitted in support of candidature for an academic degree or professional qualification.
    /// </summary>
    [DataContract]
    public partial class Thesis : CreativeWork, IThesis
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Thesis";

        /// <summary>
        /// Qualification, candidature, degree, application that Thesis supports.
        /// </summary>
        [DataMember(Name = "inSupportOf", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? InSupportOf { get; set; }
    }
}

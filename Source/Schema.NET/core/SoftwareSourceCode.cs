namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
    public partial interface ISoftwareSourceCode : ICreativeWork
    {
        /// <summary>
        /// Link to the repository where the un-compiled, human readable code and related code is located (SVN, github, CodePlex).
        /// </summary>
        OneOrMany<Uri> CodeRepository { get; set; }

        /// <summary>
        /// What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.
        /// </summary>
        OneOrMany<string> CodeSampleType { get; set; }

        /// <summary>
        /// The computer programming language.
        /// </summary>
        Values<IComputerLanguage, string>? ProgrammingLanguage { get; set; }

        /// <summary>
        /// Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).
        /// </summary>
        OneOrMany<string> RuntimePlatform { get; set; }

        /// <summary>
        /// Target Operating System / Product to which the code applies.  If applies to several versions, just the product name can be used.
        /// </summary>
        OneOrMany<ISoftwareApplication> TargetProduct { get; set; }
    }

    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
    [DataContract]
    public partial class SoftwareSourceCode : CreativeWork, ISoftwareSourceCode
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SoftwareSourceCode";

        /// <summary>
        /// Link to the repository where the un-compiled, human readable code and related code is located (SVN, github, CodePlex).
        /// </summary>
        [DataMember(Name = "codeRepository", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> CodeRepository { get; set; }

        /// <summary>
        /// What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.
        /// </summary>
        [DataMember(Name = "codeSampleType", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CodeSampleType { get; set; }

        /// <summary>
        /// The computer programming language.
        /// </summary>
        [DataMember(Name = "programmingLanguage", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IComputerLanguage, string>? ProgrammingLanguage { get; set; }

        /// <summary>
        /// Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).
        /// </summary>
        [DataMember(Name = "runtimePlatform", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> RuntimePlatform { get; set; }

        /// <summary>
        /// Target Operating System / Product to which the code applies.  If applies to several versions, just the product name can be used.
        /// </summary>
        [DataMember(Name = "targetProduct", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ISoftwareApplication> TargetProduct { get; set; }
    }
}

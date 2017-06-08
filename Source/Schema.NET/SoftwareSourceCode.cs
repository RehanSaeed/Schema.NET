namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
    [DataContract]
    public class SoftwareSourceCode : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "SoftwareSourceCode";

        /// <summary>
        /// Target Operating System / Product to which the code applies.  If applies to several versions, just the product name can be used.
        /// </summary>
        [DataMember(Name = "targetProduct")]
        public SoftwareApplication TargetProduct { get; set; }

        /// <summary>
        /// Link to the repository where the un-compiled, human readable code and related code is located (SVN, github, CodePlex).
        /// </summary>
        [DataMember(Name = "codeRepository")]
        public Uri CodeRepository { get; set; }

        /// <summary>
        /// The computer programming language.
        /// </summary>
        [DataMember(Name = "programmingLanguage")]
        public object ProgrammingLanguage { get; protected set; }

        /// <summary>
        /// The computer programming language.
        /// </summary>
        [IgnoreDataMember]
        public ComputerLanguage ProgrammingLanguageComputerLanguage
        {
            get => this.ProgrammingLanguage as ComputerLanguage;
            set => this.ProgrammingLanguage = value;
        }

        /// <summary>
        /// The computer programming language.
        /// </summary>
        [IgnoreDataMember]
        public string ProgrammingLanguageText
        {
            get => this.ProgrammingLanguage as string;
            set => this.ProgrammingLanguage = value;
        }

        /// <summary>
        /// What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.
        /// </summary>
        [DataMember(Name = "codeSampleType")]
        public string CodeSampleType { get; set; }

        /// <summary>
        /// Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).
        /// </summary>
        [DataMember(Name = "runtimePlatform")]
        public string RuntimePlatform { get; set; }
    }
}

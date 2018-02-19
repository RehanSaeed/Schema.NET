using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
    [DataContract]
    public partial class SoftwareSourceCode : CreativeWork
    {
        public interface IProgrammingLanguage : IWrapper { }
        public interface IProgrammingLanguage<T> : IProgrammingLanguage { new T Data { get; set; } }
        public class ProgrammingLanguageComputerLanguage : IProgrammingLanguage<ComputerLanguage>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ComputerLanguage) value; } }
            public virtual ComputerLanguage Data { get; set; }
            public ProgrammingLanguageComputerLanguage () { }
            public ProgrammingLanguageComputerLanguage (ComputerLanguage data) { Data = data; }
            public static implicit operator ProgrammingLanguageComputerLanguage (ComputerLanguage data) { return new ProgrammingLanguageComputerLanguage (data); }
        }

        public class ProgrammingLanguagestring : IProgrammingLanguage<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public ProgrammingLanguagestring () { }
            public ProgrammingLanguagestring (string data) { Data = data; }
            public static implicit operator ProgrammingLanguagestring (string data) { return new ProgrammingLanguagestring (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SoftwareSourceCode";

        /// <summary>
        /// Link to the repository where the un-compiled, human readable code and related code is located (SVN, github, CodePlex).
        /// </summary>
        [DataMember(Name = "codeRepository", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? CodeRepository { get; set; } 

        /// <summary>
        /// What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.
        /// </summary>
        [DataMember(Name = "codeSampleType", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? CodeSampleType { get; set; } 

        /// <summary>
        /// The computer programming language.
        /// </summary>
        [DataMember(Name = "programmingLanguage", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IProgrammingLanguage>? ProgrammingLanguage { get; set; } //ComputerLanguage, string

        /// <summary>
        /// Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).
        /// </summary>
        [DataMember(Name = "runtimePlatform", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? RuntimePlatform { get; set; } 

        /// <summary>
        /// Target Operating System / Product to which the code applies.  If applies to several versions, just the product name can be used.
        /// </summary>
        [DataMember(Name = "targetProduct", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<SoftwareApplication>? TargetProduct { get; set; } 
    }
}

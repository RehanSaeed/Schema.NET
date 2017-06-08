namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// </summary>
    [DataContract]
    public class APIReference : TechArticle
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "APIReference";

        /// <summary>
        /// Library file name e.g., mscorlib.dll, system.web.dll.
        /// </summary>
        [DataMember(Name = "executableLibraryName")]
        public string ExecutableLibraryName { get; set; }

        /// <summary>
        /// Associated product/technology version. e.g., .NET Framework 4.5.
        /// </summary>
        [DataMember(Name = "assemblyVersion")]
        public string AssemblyVersion { get; set; }

        /// <summary>
        /// Indicates whether API is managed or unmanaged.
        /// </summary>
        [DataMember(Name = "programmingModel")]
        public string ProgrammingModel { get; set; }

        /// <summary>
        /// Type of app development: phone, Metro style, desktop, XBox, etc.
        /// </summary>
        [DataMember(Name = "targetPlatform")]
        public string TargetPlatform { get; set; }
    }
}

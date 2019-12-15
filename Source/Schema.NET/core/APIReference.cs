﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// </summary>
    public partial interface IAPIReference : ITechArticle
    {
        /// <summary>
        /// Associated product/technology version. e.g., .NET Framework 4.5.
        /// </summary>
        OneOrMany<string> AssemblyVersion { get; set; }

        /// <summary>
        /// Library file name e.g., mscorlib.dll, system.web.dll.
        /// </summary>
        OneOrMany<string> ExecutableLibraryName { get; set; }

        /// <summary>
        /// Indicates whether API is managed or unmanaged.
        /// </summary>
        OneOrMany<string> ProgrammingModel { get; set; }

        /// <summary>
        /// Type of app development: phone, Metro style, desktop, XBox, etc.
        /// </summary>
        OneOrMany<string> TargetPlatform { get; set; }
    }

    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// </summary>
    [DataContract]
    public partial class APIReference : TechArticle, IAPIReference, IEquatable<APIReference>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "APIReference";

        /// <summary>
        /// Associated product/technology version. e.g., .NET Framework 4.5.
        /// </summary>
        [DataMember(Name = "assemblyVersion", Order = 406)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AssemblyVersion { get; set; }

        /// <summary>
        /// Library file name e.g., mscorlib.dll, system.web.dll.
        /// </summary>
        [DataMember(Name = "executableLibraryName", Order = 407)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ExecutableLibraryName { get; set; }

        /// <summary>
        /// Indicates whether API is managed or unmanaged.
        /// </summary>
        [DataMember(Name = "programmingModel", Order = 408)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProgrammingModel { get; set; }

        /// <summary>
        /// Type of app development: phone, Metro style, desktop, XBox, etc.
        /// </summary>
        [DataMember(Name = "targetPlatform", Order = 409)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> TargetPlatform { get; set; }

        /// <inheritdoc/>
        public bool Equals(APIReference other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.AssemblyVersion == other.AssemblyVersion &&
                this.ExecutableLibraryName == other.ExecutableLibraryName &&
                this.ProgrammingModel == other.ProgrammingModel &&
                this.TargetPlatform == other.TargetPlatform &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as APIReference);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AssemblyVersion)
            .And(this.ExecutableLibraryName)
            .And(this.ProgrammingModel)
            .And(this.TargetPlatform)
            .And(base.GetHashCode());
    }
}

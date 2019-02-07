namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Reference documentation for application programming interfaces (APIs).
    /// </summary>
    [DataContract]
    public partial class APIReference : TechArticle
    {
        public interface IAssemblyVersion : IValue {}
        public interface IAssemblyVersion<T> : IAssemblyVersion { new T Value { get; } }
        public class OneOrManyAssemblyVersion : OneOrMany<IAssemblyVersion>
        {
            public OneOrManyAssemblyVersion(IAssemblyVersion item) : base(item) { }
            public OneOrManyAssemblyVersion(IEnumerable<IAssemblyVersion> items) : base(items) { }
            public static implicit operator OneOrManyAssemblyVersion (string value) { return new OneOrManyAssemblyVersion (new AssemblyVersionstring (value)); }
            public static implicit operator OneOrManyAssemblyVersion (string[] values) { return new OneOrManyAssemblyVersion (values.Select(v => (IAssemblyVersion) new AssemblyVersionstring (v))); }
            public static implicit operator OneOrManyAssemblyVersion (List<string> values) { return new OneOrManyAssemblyVersion (values.Select(v => (IAssemblyVersion) new AssemblyVersionstring (v))); }
        }
        public struct AssemblyVersionstring : IAssemblyVersion<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AssemblyVersionstring (string value) { Value = value; }
            public static implicit operator AssemblyVersionstring (string value) { return new AssemblyVersionstring (value); }
        }

        public interface IExecutableLibraryName : IValue {}
        public interface IExecutableLibraryName<T> : IExecutableLibraryName { new T Value { get; } }
        public class OneOrManyExecutableLibraryName : OneOrMany<IExecutableLibraryName>
        {
            public OneOrManyExecutableLibraryName(IExecutableLibraryName item) : base(item) { }
            public OneOrManyExecutableLibraryName(IEnumerable<IExecutableLibraryName> items) : base(items) { }
            public static implicit operator OneOrManyExecutableLibraryName (string value) { return new OneOrManyExecutableLibraryName (new ExecutableLibraryNamestring (value)); }
            public static implicit operator OneOrManyExecutableLibraryName (string[] values) { return new OneOrManyExecutableLibraryName (values.Select(v => (IExecutableLibraryName) new ExecutableLibraryNamestring (v))); }
            public static implicit operator OneOrManyExecutableLibraryName (List<string> values) { return new OneOrManyExecutableLibraryName (values.Select(v => (IExecutableLibraryName) new ExecutableLibraryNamestring (v))); }
        }
        public struct ExecutableLibraryNamestring : IExecutableLibraryName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ExecutableLibraryNamestring (string value) { Value = value; }
            public static implicit operator ExecutableLibraryNamestring (string value) { return new ExecutableLibraryNamestring (value); }
        }

        public interface IProgrammingModel : IValue {}
        public interface IProgrammingModel<T> : IProgrammingModel { new T Value { get; } }
        public class OneOrManyProgrammingModel : OneOrMany<IProgrammingModel>
        {
            public OneOrManyProgrammingModel(IProgrammingModel item) : base(item) { }
            public OneOrManyProgrammingModel(IEnumerable<IProgrammingModel> items) : base(items) { }
            public static implicit operator OneOrManyProgrammingModel (string value) { return new OneOrManyProgrammingModel (new ProgrammingModelstring (value)); }
            public static implicit operator OneOrManyProgrammingModel (string[] values) { return new OneOrManyProgrammingModel (values.Select(v => (IProgrammingModel) new ProgrammingModelstring (v))); }
            public static implicit operator OneOrManyProgrammingModel (List<string> values) { return new OneOrManyProgrammingModel (values.Select(v => (IProgrammingModel) new ProgrammingModelstring (v))); }
        }
        public struct ProgrammingModelstring : IProgrammingModel<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ProgrammingModelstring (string value) { Value = value; }
            public static implicit operator ProgrammingModelstring (string value) { return new ProgrammingModelstring (value); }
        }

        public interface ITargetPlatform : IValue {}
        public interface ITargetPlatform<T> : ITargetPlatform { new T Value { get; } }
        public class OneOrManyTargetPlatform : OneOrMany<ITargetPlatform>
        {
            public OneOrManyTargetPlatform(ITargetPlatform item) : base(item) { }
            public OneOrManyTargetPlatform(IEnumerable<ITargetPlatform> items) : base(items) { }
            public static implicit operator OneOrManyTargetPlatform (string value) { return new OneOrManyTargetPlatform (new TargetPlatformstring (value)); }
            public static implicit operator OneOrManyTargetPlatform (string[] values) { return new OneOrManyTargetPlatform (values.Select(v => (ITargetPlatform) new TargetPlatformstring (v))); }
            public static implicit operator OneOrManyTargetPlatform (List<string> values) { return new OneOrManyTargetPlatform (values.Select(v => (ITargetPlatform) new TargetPlatformstring (v))); }
        }
        public struct TargetPlatformstring : ITargetPlatform<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public TargetPlatformstring (string value) { Value = value; }
            public static implicit operator TargetPlatformstring (string value) { return new TargetPlatformstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "APIReference";

        /// <summary>
        /// Associated product/technology version. e.g., .NET Framework 4.5.
        /// </summary>
        [DataMember(Name = "assemblyVersion", Order = 406)]
        public OneOrManyAssemblyVersion AssemblyVersion { get; set; }

        /// <summary>
        /// Library file name e.g., mscorlib.dll, system.web.dll.
        /// </summary>
        [DataMember(Name = "executableLibraryName", Order = 407)]
        public OneOrManyExecutableLibraryName ExecutableLibraryName { get; set; }

        /// <summary>
        /// Indicates whether API is managed or unmanaged.
        /// </summary>
        [DataMember(Name = "programmingModel", Order = 408)]
        public OneOrManyProgrammingModel ProgrammingModel { get; set; }

        /// <summary>
        /// Type of app development: phone, Metro style, desktop, XBox, etc.
        /// </summary>
        [DataMember(Name = "targetPlatform", Order = 409)]
        public OneOrManyTargetPlatform TargetPlatform { get; set; }
    }
}

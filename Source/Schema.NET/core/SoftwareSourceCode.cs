namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Computer programming source code. Example: Full (compile ready) solutions, code snippet samples, scripts, templates.
    /// </summary>
    [DataContract]
    public partial class SoftwareSourceCode : CreativeWork
    {
        public interface ICodeRepository : IValue {}
        public interface ICodeRepository<T> : ICodeRepository { new T Value { get; } }
        public class OneOrManyCodeRepository : OneOrMany<ICodeRepository>
        {
            public OneOrManyCodeRepository(ICodeRepository item) : base(item) { }
            public OneOrManyCodeRepository(IEnumerable<ICodeRepository> items) : base(items) { }
            public static implicit operator OneOrManyCodeRepository (Uri value) { return new OneOrManyCodeRepository (new CodeRepositoryUri (value)); }
            public static implicit operator OneOrManyCodeRepository (Uri[] values) { return new OneOrManyCodeRepository (values.Select(v => (ICodeRepository) new CodeRepositoryUri (v))); }
            public static implicit operator OneOrManyCodeRepository (List<Uri> values) { return new OneOrManyCodeRepository (values.Select(v => (ICodeRepository) new CodeRepositoryUri (v))); }
        }
        public struct CodeRepositoryUri : ICodeRepository<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public CodeRepositoryUri (Uri value) { Value = value; }
            public static implicit operator CodeRepositoryUri (Uri value) { return new CodeRepositoryUri (value); }
        }

        public interface ICodeSampleType : IValue {}
        public interface ICodeSampleType<T> : ICodeSampleType { new T Value { get; } }
        public class OneOrManyCodeSampleType : OneOrMany<ICodeSampleType>
        {
            public OneOrManyCodeSampleType(ICodeSampleType item) : base(item) { }
            public OneOrManyCodeSampleType(IEnumerable<ICodeSampleType> items) : base(items) { }
            public static implicit operator OneOrManyCodeSampleType (string value) { return new OneOrManyCodeSampleType (new CodeSampleTypestring (value)); }
            public static implicit operator OneOrManyCodeSampleType (string[] values) { return new OneOrManyCodeSampleType (values.Select(v => (ICodeSampleType) new CodeSampleTypestring (v))); }
            public static implicit operator OneOrManyCodeSampleType (List<string> values) { return new OneOrManyCodeSampleType (values.Select(v => (ICodeSampleType) new CodeSampleTypestring (v))); }
        }
        public struct CodeSampleTypestring : ICodeSampleType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CodeSampleTypestring (string value) { Value = value; }
            public static implicit operator CodeSampleTypestring (string value) { return new CodeSampleTypestring (value); }
        }

        public interface IProgrammingLanguage : IValue {}
        public interface IProgrammingLanguage<T> : IProgrammingLanguage { new T Value { get; } }
        public class OneOrManyProgrammingLanguage : OneOrMany<IProgrammingLanguage>
        {
            public OneOrManyProgrammingLanguage(IProgrammingLanguage item) : base(item) { }
            public OneOrManyProgrammingLanguage(IEnumerable<IProgrammingLanguage> items) : base(items) { }
            public static implicit operator OneOrManyProgrammingLanguage (ComputerLanguage value) { return new OneOrManyProgrammingLanguage (new ProgrammingLanguageComputerLanguage (value)); }
            public static implicit operator OneOrManyProgrammingLanguage (ComputerLanguage[] values) { return new OneOrManyProgrammingLanguage (values.Select(v => (IProgrammingLanguage) new ProgrammingLanguageComputerLanguage (v))); }
            public static implicit operator OneOrManyProgrammingLanguage (List<ComputerLanguage> values) { return new OneOrManyProgrammingLanguage (values.Select(v => (IProgrammingLanguage) new ProgrammingLanguageComputerLanguage (v))); }
            public static implicit operator OneOrManyProgrammingLanguage (string value) { return new OneOrManyProgrammingLanguage (new ProgrammingLanguagestring (value)); }
            public static implicit operator OneOrManyProgrammingLanguage (string[] values) { return new OneOrManyProgrammingLanguage (values.Select(v => (IProgrammingLanguage) new ProgrammingLanguagestring (v))); }
            public static implicit operator OneOrManyProgrammingLanguage (List<string> values) { return new OneOrManyProgrammingLanguage (values.Select(v => (IProgrammingLanguage) new ProgrammingLanguagestring (v))); }
        }
        public struct ProgrammingLanguageComputerLanguage : IProgrammingLanguage<ComputerLanguage>
        {
            object IValue.Value => this.Value;
            public ComputerLanguage Value { get; }
            public ProgrammingLanguageComputerLanguage (ComputerLanguage value) { Value = value; }
            public static implicit operator ProgrammingLanguageComputerLanguage (ComputerLanguage value) { return new ProgrammingLanguageComputerLanguage (value); }
        }
        public struct ProgrammingLanguagestring : IProgrammingLanguage<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ProgrammingLanguagestring (string value) { Value = value; }
            public static implicit operator ProgrammingLanguagestring (string value) { return new ProgrammingLanguagestring (value); }
        }

        public interface IRuntimePlatform : IValue {}
        public interface IRuntimePlatform<T> : IRuntimePlatform { new T Value { get; } }
        public class OneOrManyRuntimePlatform : OneOrMany<IRuntimePlatform>
        {
            public OneOrManyRuntimePlatform(IRuntimePlatform item) : base(item) { }
            public OneOrManyRuntimePlatform(IEnumerable<IRuntimePlatform> items) : base(items) { }
            public static implicit operator OneOrManyRuntimePlatform (string value) { return new OneOrManyRuntimePlatform (new RuntimePlatformstring (value)); }
            public static implicit operator OneOrManyRuntimePlatform (string[] values) { return new OneOrManyRuntimePlatform (values.Select(v => (IRuntimePlatform) new RuntimePlatformstring (v))); }
            public static implicit operator OneOrManyRuntimePlatform (List<string> values) { return new OneOrManyRuntimePlatform (values.Select(v => (IRuntimePlatform) new RuntimePlatformstring (v))); }
        }
        public struct RuntimePlatformstring : IRuntimePlatform<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public RuntimePlatformstring (string value) { Value = value; }
            public static implicit operator RuntimePlatformstring (string value) { return new RuntimePlatformstring (value); }
        }

        public interface ITargetProduct : IValue {}
        public interface ITargetProduct<T> : ITargetProduct { new T Value { get; } }
        public class OneOrManyTargetProduct : OneOrMany<ITargetProduct>
        {
            public OneOrManyTargetProduct(ITargetProduct item) : base(item) { }
            public OneOrManyTargetProduct(IEnumerable<ITargetProduct> items) : base(items) { }
            public static implicit operator OneOrManyTargetProduct (SoftwareApplication value) { return new OneOrManyTargetProduct (new TargetProductSoftwareApplication (value)); }
            public static implicit operator OneOrManyTargetProduct (SoftwareApplication[] values) { return new OneOrManyTargetProduct (values.Select(v => (ITargetProduct) new TargetProductSoftwareApplication (v))); }
            public static implicit operator OneOrManyTargetProduct (List<SoftwareApplication> values) { return new OneOrManyTargetProduct (values.Select(v => (ITargetProduct) new TargetProductSoftwareApplication (v))); }
        }
        public struct TargetProductSoftwareApplication : ITargetProduct<SoftwareApplication>
        {
            object IValue.Value => this.Value;
            public SoftwareApplication Value { get; }
            public TargetProductSoftwareApplication (SoftwareApplication value) { Value = value; }
            public static implicit operator TargetProductSoftwareApplication (SoftwareApplication value) { return new TargetProductSoftwareApplication (value); }
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
        public OneOrManyCodeRepository CodeRepository { get; set; }

        /// <summary>
        /// What type of code sample: full (compile ready) solution, code snippet, inline code, scripts, template.
        /// </summary>
        [DataMember(Name = "codeSampleType", Order = 207)]
        public OneOrManyCodeSampleType CodeSampleType { get; set; }

        /// <summary>
        /// The computer programming language.
        /// </summary>
        [DataMember(Name = "programmingLanguage", Order = 208)]
        public OneOrManyProgrammingLanguage ProgrammingLanguage { get; set; }

        /// <summary>
        /// Runtime platform or script interpreter dependencies (Example - Java v1, Python2.3, .Net Framework 3.0).
        /// </summary>
        [DataMember(Name = "runtimePlatform", Order = 209)]
        public OneOrManyRuntimePlatform RuntimePlatform { get; set; }

        /// <summary>
        /// Target Operating System / Product to which the code applies.  If applies to several versions, just the product name can be used.
        /// </summary>
        [DataMember(Name = "targetProduct", Order = 210)]
        public OneOrManyTargetProduct TargetProduct { get; set; }
    }
}

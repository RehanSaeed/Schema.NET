namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A software application.
    /// </summary>
    [DataContract]
    public partial class SoftwareApplication : CreativeWork
    {
        public interface IApplicationCategory : IValue {}
        public interface IApplicationCategory<T> : IApplicationCategory { new T Value { get; } }
        public class OneOrManyApplicationCategory : OneOrMany<IApplicationCategory>
        {
            public OneOrManyApplicationCategory(IApplicationCategory item) : base(item) { }
            public OneOrManyApplicationCategory(IEnumerable<IApplicationCategory> items) : base(items) { }
            public static implicit operator OneOrManyApplicationCategory (string value) { return new OneOrManyApplicationCategory (new ApplicationCategorystring (value)); }
            public static implicit operator OneOrManyApplicationCategory (string[] values) { return new OneOrManyApplicationCategory (values.Select(v => (IApplicationCategory) new ApplicationCategorystring (v))); }
            public static implicit operator OneOrManyApplicationCategory (List<string> values) { return new OneOrManyApplicationCategory (values.Select(v => (IApplicationCategory) new ApplicationCategorystring (v))); }
            public static implicit operator OneOrManyApplicationCategory (Uri value) { return new OneOrManyApplicationCategory (new ApplicationCategoryUri (value)); }
            public static implicit operator OneOrManyApplicationCategory (Uri[] values) { return new OneOrManyApplicationCategory (values.Select(v => (IApplicationCategory) new ApplicationCategoryUri (v))); }
            public static implicit operator OneOrManyApplicationCategory (List<Uri> values) { return new OneOrManyApplicationCategory (values.Select(v => (IApplicationCategory) new ApplicationCategoryUri (v))); }
        }
        public struct ApplicationCategorystring : IApplicationCategory<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ApplicationCategorystring (string value) { Value = value; }
            public static implicit operator ApplicationCategorystring (string value) { return new ApplicationCategorystring (value); }
        }
        public struct ApplicationCategoryUri : IApplicationCategory<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public ApplicationCategoryUri (Uri value) { Value = value; }
            public static implicit operator ApplicationCategoryUri (Uri value) { return new ApplicationCategoryUri (value); }
        }

        public interface IApplicationSubCategory : IValue {}
        public interface IApplicationSubCategory<T> : IApplicationSubCategory { new T Value { get; } }
        public class OneOrManyApplicationSubCategory : OneOrMany<IApplicationSubCategory>
        {
            public OneOrManyApplicationSubCategory(IApplicationSubCategory item) : base(item) { }
            public OneOrManyApplicationSubCategory(IEnumerable<IApplicationSubCategory> items) : base(items) { }
            public static implicit operator OneOrManyApplicationSubCategory (string value) { return new OneOrManyApplicationSubCategory (new ApplicationSubCategorystring (value)); }
            public static implicit operator OneOrManyApplicationSubCategory (string[] values) { return new OneOrManyApplicationSubCategory (values.Select(v => (IApplicationSubCategory) new ApplicationSubCategorystring (v))); }
            public static implicit operator OneOrManyApplicationSubCategory (List<string> values) { return new OneOrManyApplicationSubCategory (values.Select(v => (IApplicationSubCategory) new ApplicationSubCategorystring (v))); }
            public static implicit operator OneOrManyApplicationSubCategory (Uri value) { return new OneOrManyApplicationSubCategory (new ApplicationSubCategoryUri (value)); }
            public static implicit operator OneOrManyApplicationSubCategory (Uri[] values) { return new OneOrManyApplicationSubCategory (values.Select(v => (IApplicationSubCategory) new ApplicationSubCategoryUri (v))); }
            public static implicit operator OneOrManyApplicationSubCategory (List<Uri> values) { return new OneOrManyApplicationSubCategory (values.Select(v => (IApplicationSubCategory) new ApplicationSubCategoryUri (v))); }
        }
        public struct ApplicationSubCategorystring : IApplicationSubCategory<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ApplicationSubCategorystring (string value) { Value = value; }
            public static implicit operator ApplicationSubCategorystring (string value) { return new ApplicationSubCategorystring (value); }
        }
        public struct ApplicationSubCategoryUri : IApplicationSubCategory<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public ApplicationSubCategoryUri (Uri value) { Value = value; }
            public static implicit operator ApplicationSubCategoryUri (Uri value) { return new ApplicationSubCategoryUri (value); }
        }

        public interface IApplicationSuite : IValue {}
        public interface IApplicationSuite<T> : IApplicationSuite { new T Value { get; } }
        public class OneOrManyApplicationSuite : OneOrMany<IApplicationSuite>
        {
            public OneOrManyApplicationSuite(IApplicationSuite item) : base(item) { }
            public OneOrManyApplicationSuite(IEnumerable<IApplicationSuite> items) : base(items) { }
            public static implicit operator OneOrManyApplicationSuite (string value) { return new OneOrManyApplicationSuite (new ApplicationSuitestring (value)); }
            public static implicit operator OneOrManyApplicationSuite (string[] values) { return new OneOrManyApplicationSuite (values.Select(v => (IApplicationSuite) new ApplicationSuitestring (v))); }
            public static implicit operator OneOrManyApplicationSuite (List<string> values) { return new OneOrManyApplicationSuite (values.Select(v => (IApplicationSuite) new ApplicationSuitestring (v))); }
        }
        public struct ApplicationSuitestring : IApplicationSuite<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ApplicationSuitestring (string value) { Value = value; }
            public static implicit operator ApplicationSuitestring (string value) { return new ApplicationSuitestring (value); }
        }

        public interface IAvailableOnDevice : IValue {}
        public interface IAvailableOnDevice<T> : IAvailableOnDevice { new T Value { get; } }
        public class OneOrManyAvailableOnDevice : OneOrMany<IAvailableOnDevice>
        {
            public OneOrManyAvailableOnDevice(IAvailableOnDevice item) : base(item) { }
            public OneOrManyAvailableOnDevice(IEnumerable<IAvailableOnDevice> items) : base(items) { }
            public static implicit operator OneOrManyAvailableOnDevice (string value) { return new OneOrManyAvailableOnDevice (new AvailableOnDevicestring (value)); }
            public static implicit operator OneOrManyAvailableOnDevice (string[] values) { return new OneOrManyAvailableOnDevice (values.Select(v => (IAvailableOnDevice) new AvailableOnDevicestring (v))); }
            public static implicit operator OneOrManyAvailableOnDevice (List<string> values) { return new OneOrManyAvailableOnDevice (values.Select(v => (IAvailableOnDevice) new AvailableOnDevicestring (v))); }
        }
        public struct AvailableOnDevicestring : IAvailableOnDevice<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AvailableOnDevicestring (string value) { Value = value; }
            public static implicit operator AvailableOnDevicestring (string value) { return new AvailableOnDevicestring (value); }
        }

        public interface ICountriesNotSupported : IValue {}
        public interface ICountriesNotSupported<T> : ICountriesNotSupported { new T Value { get; } }
        public class OneOrManyCountriesNotSupported : OneOrMany<ICountriesNotSupported>
        {
            public OneOrManyCountriesNotSupported(ICountriesNotSupported item) : base(item) { }
            public OneOrManyCountriesNotSupported(IEnumerable<ICountriesNotSupported> items) : base(items) { }
            public static implicit operator OneOrManyCountriesNotSupported (string value) { return new OneOrManyCountriesNotSupported (new CountriesNotSupportedstring (value)); }
            public static implicit operator OneOrManyCountriesNotSupported (string[] values) { return new OneOrManyCountriesNotSupported (values.Select(v => (ICountriesNotSupported) new CountriesNotSupportedstring (v))); }
            public static implicit operator OneOrManyCountriesNotSupported (List<string> values) { return new OneOrManyCountriesNotSupported (values.Select(v => (ICountriesNotSupported) new CountriesNotSupportedstring (v))); }
        }
        public struct CountriesNotSupportedstring : ICountriesNotSupported<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CountriesNotSupportedstring (string value) { Value = value; }
            public static implicit operator CountriesNotSupportedstring (string value) { return new CountriesNotSupportedstring (value); }
        }

        public interface ICountriesSupported : IValue {}
        public interface ICountriesSupported<T> : ICountriesSupported { new T Value { get; } }
        public class OneOrManyCountriesSupported : OneOrMany<ICountriesSupported>
        {
            public OneOrManyCountriesSupported(ICountriesSupported item) : base(item) { }
            public OneOrManyCountriesSupported(IEnumerable<ICountriesSupported> items) : base(items) { }
            public static implicit operator OneOrManyCountriesSupported (string value) { return new OneOrManyCountriesSupported (new CountriesSupportedstring (value)); }
            public static implicit operator OneOrManyCountriesSupported (string[] values) { return new OneOrManyCountriesSupported (values.Select(v => (ICountriesSupported) new CountriesSupportedstring (v))); }
            public static implicit operator OneOrManyCountriesSupported (List<string> values) { return new OneOrManyCountriesSupported (values.Select(v => (ICountriesSupported) new CountriesSupportedstring (v))); }
        }
        public struct CountriesSupportedstring : ICountriesSupported<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public CountriesSupportedstring (string value) { Value = value; }
            public static implicit operator CountriesSupportedstring (string value) { return new CountriesSupportedstring (value); }
        }

        public interface IDownloadUrl : IValue {}
        public interface IDownloadUrl<T> : IDownloadUrl { new T Value { get; } }
        public class OneOrManyDownloadUrl : OneOrMany<IDownloadUrl>
        {
            public OneOrManyDownloadUrl(IDownloadUrl item) : base(item) { }
            public OneOrManyDownloadUrl(IEnumerable<IDownloadUrl> items) : base(items) { }
            public static implicit operator OneOrManyDownloadUrl (Uri value) { return new OneOrManyDownloadUrl (new DownloadUrlUri (value)); }
            public static implicit operator OneOrManyDownloadUrl (Uri[] values) { return new OneOrManyDownloadUrl (values.Select(v => (IDownloadUrl) new DownloadUrlUri (v))); }
            public static implicit operator OneOrManyDownloadUrl (List<Uri> values) { return new OneOrManyDownloadUrl (values.Select(v => (IDownloadUrl) new DownloadUrlUri (v))); }
        }
        public struct DownloadUrlUri : IDownloadUrl<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public DownloadUrlUri (Uri value) { Value = value; }
            public static implicit operator DownloadUrlUri (Uri value) { return new DownloadUrlUri (value); }
        }

        public interface IFeatureList : IValue {}
        public interface IFeatureList<T> : IFeatureList { new T Value { get; } }
        public class OneOrManyFeatureList : OneOrMany<IFeatureList>
        {
            public OneOrManyFeatureList(IFeatureList item) : base(item) { }
            public OneOrManyFeatureList(IEnumerable<IFeatureList> items) : base(items) { }
            public static implicit operator OneOrManyFeatureList (string value) { return new OneOrManyFeatureList (new FeatureListstring (value)); }
            public static implicit operator OneOrManyFeatureList (string[] values) { return new OneOrManyFeatureList (values.Select(v => (IFeatureList) new FeatureListstring (v))); }
            public static implicit operator OneOrManyFeatureList (List<string> values) { return new OneOrManyFeatureList (values.Select(v => (IFeatureList) new FeatureListstring (v))); }
            public static implicit operator OneOrManyFeatureList (Uri value) { return new OneOrManyFeatureList (new FeatureListUri (value)); }
            public static implicit operator OneOrManyFeatureList (Uri[] values) { return new OneOrManyFeatureList (values.Select(v => (IFeatureList) new FeatureListUri (v))); }
            public static implicit operator OneOrManyFeatureList (List<Uri> values) { return new OneOrManyFeatureList (values.Select(v => (IFeatureList) new FeatureListUri (v))); }
        }
        public struct FeatureListstring : IFeatureList<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public FeatureListstring (string value) { Value = value; }
            public static implicit operator FeatureListstring (string value) { return new FeatureListstring (value); }
        }
        public struct FeatureListUri : IFeatureList<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public FeatureListUri (Uri value) { Value = value; }
            public static implicit operator FeatureListUri (Uri value) { return new FeatureListUri (value); }
        }

        public interface IFileSize : IValue {}
        public interface IFileSize<T> : IFileSize { new T Value { get; } }
        public class OneOrManyFileSize : OneOrMany<IFileSize>
        {
            public OneOrManyFileSize(IFileSize item) : base(item) { }
            public OneOrManyFileSize(IEnumerable<IFileSize> items) : base(items) { }
            public static implicit operator OneOrManyFileSize (string value) { return new OneOrManyFileSize (new FileSizestring (value)); }
            public static implicit operator OneOrManyFileSize (string[] values) { return new OneOrManyFileSize (values.Select(v => (IFileSize) new FileSizestring (v))); }
            public static implicit operator OneOrManyFileSize (List<string> values) { return new OneOrManyFileSize (values.Select(v => (IFileSize) new FileSizestring (v))); }
        }
        public struct FileSizestring : IFileSize<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public FileSizestring (string value) { Value = value; }
            public static implicit operator FileSizestring (string value) { return new FileSizestring (value); }
        }

        public interface IInstallUrl : IValue {}
        public interface IInstallUrl<T> : IInstallUrl { new T Value { get; } }
        public class OneOrManyInstallUrl : OneOrMany<IInstallUrl>
        {
            public OneOrManyInstallUrl(IInstallUrl item) : base(item) { }
            public OneOrManyInstallUrl(IEnumerable<IInstallUrl> items) : base(items) { }
            public static implicit operator OneOrManyInstallUrl (Uri value) { return new OneOrManyInstallUrl (new InstallUrlUri (value)); }
            public static implicit operator OneOrManyInstallUrl (Uri[] values) { return new OneOrManyInstallUrl (values.Select(v => (IInstallUrl) new InstallUrlUri (v))); }
            public static implicit operator OneOrManyInstallUrl (List<Uri> values) { return new OneOrManyInstallUrl (values.Select(v => (IInstallUrl) new InstallUrlUri (v))); }
        }
        public struct InstallUrlUri : IInstallUrl<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public InstallUrlUri (Uri value) { Value = value; }
            public static implicit operator InstallUrlUri (Uri value) { return new InstallUrlUri (value); }
        }

        public interface IMemoryRequirements : IValue {}
        public interface IMemoryRequirements<T> : IMemoryRequirements { new T Value { get; } }
        public class OneOrManyMemoryRequirements : OneOrMany<IMemoryRequirements>
        {
            public OneOrManyMemoryRequirements(IMemoryRequirements item) : base(item) { }
            public OneOrManyMemoryRequirements(IEnumerable<IMemoryRequirements> items) : base(items) { }
            public static implicit operator OneOrManyMemoryRequirements (string value) { return new OneOrManyMemoryRequirements (new MemoryRequirementsstring (value)); }
            public static implicit operator OneOrManyMemoryRequirements (string[] values) { return new OneOrManyMemoryRequirements (values.Select(v => (IMemoryRequirements) new MemoryRequirementsstring (v))); }
            public static implicit operator OneOrManyMemoryRequirements (List<string> values) { return new OneOrManyMemoryRequirements (values.Select(v => (IMemoryRequirements) new MemoryRequirementsstring (v))); }
            public static implicit operator OneOrManyMemoryRequirements (Uri value) { return new OneOrManyMemoryRequirements (new MemoryRequirementsUri (value)); }
            public static implicit operator OneOrManyMemoryRequirements (Uri[] values) { return new OneOrManyMemoryRequirements (values.Select(v => (IMemoryRequirements) new MemoryRequirementsUri (v))); }
            public static implicit operator OneOrManyMemoryRequirements (List<Uri> values) { return new OneOrManyMemoryRequirements (values.Select(v => (IMemoryRequirements) new MemoryRequirementsUri (v))); }
        }
        public struct MemoryRequirementsstring : IMemoryRequirements<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public MemoryRequirementsstring (string value) { Value = value; }
            public static implicit operator MemoryRequirementsstring (string value) { return new MemoryRequirementsstring (value); }
        }
        public struct MemoryRequirementsUri : IMemoryRequirements<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public MemoryRequirementsUri (Uri value) { Value = value; }
            public static implicit operator MemoryRequirementsUri (Uri value) { return new MemoryRequirementsUri (value); }
        }

        public interface IOperatingSystem : IValue {}
        public interface IOperatingSystem<T> : IOperatingSystem { new T Value { get; } }
        public class OneOrManyOperatingSystem : OneOrMany<IOperatingSystem>
        {
            public OneOrManyOperatingSystem(IOperatingSystem item) : base(item) { }
            public OneOrManyOperatingSystem(IEnumerable<IOperatingSystem> items) : base(items) { }
            public static implicit operator OneOrManyOperatingSystem (string value) { return new OneOrManyOperatingSystem (new OperatingSystemstring (value)); }
            public static implicit operator OneOrManyOperatingSystem (string[] values) { return new OneOrManyOperatingSystem (values.Select(v => (IOperatingSystem) new OperatingSystemstring (v))); }
            public static implicit operator OneOrManyOperatingSystem (List<string> values) { return new OneOrManyOperatingSystem (values.Select(v => (IOperatingSystem) new OperatingSystemstring (v))); }
        }
        public struct OperatingSystemstring : IOperatingSystem<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public OperatingSystemstring (string value) { Value = value; }
            public static implicit operator OperatingSystemstring (string value) { return new OperatingSystemstring (value); }
        }

        public interface IPermissions : IValue {}
        public interface IPermissions<T> : IPermissions { new T Value { get; } }
        public class OneOrManyPermissions : OneOrMany<IPermissions>
        {
            public OneOrManyPermissions(IPermissions item) : base(item) { }
            public OneOrManyPermissions(IEnumerable<IPermissions> items) : base(items) { }
            public static implicit operator OneOrManyPermissions (string value) { return new OneOrManyPermissions (new Permissionsstring (value)); }
            public static implicit operator OneOrManyPermissions (string[] values) { return new OneOrManyPermissions (values.Select(v => (IPermissions) new Permissionsstring (v))); }
            public static implicit operator OneOrManyPermissions (List<string> values) { return new OneOrManyPermissions (values.Select(v => (IPermissions) new Permissionsstring (v))); }
        }
        public struct Permissionsstring : IPermissions<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Permissionsstring (string value) { Value = value; }
            public static implicit operator Permissionsstring (string value) { return new Permissionsstring (value); }
        }

        public interface IProcessorRequirements : IValue {}
        public interface IProcessorRequirements<T> : IProcessorRequirements { new T Value { get; } }
        public class OneOrManyProcessorRequirements : OneOrMany<IProcessorRequirements>
        {
            public OneOrManyProcessorRequirements(IProcessorRequirements item) : base(item) { }
            public OneOrManyProcessorRequirements(IEnumerable<IProcessorRequirements> items) : base(items) { }
            public static implicit operator OneOrManyProcessorRequirements (string value) { return new OneOrManyProcessorRequirements (new ProcessorRequirementsstring (value)); }
            public static implicit operator OneOrManyProcessorRequirements (string[] values) { return new OneOrManyProcessorRequirements (values.Select(v => (IProcessorRequirements) new ProcessorRequirementsstring (v))); }
            public static implicit operator OneOrManyProcessorRequirements (List<string> values) { return new OneOrManyProcessorRequirements (values.Select(v => (IProcessorRequirements) new ProcessorRequirementsstring (v))); }
        }
        public struct ProcessorRequirementsstring : IProcessorRequirements<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ProcessorRequirementsstring (string value) { Value = value; }
            public static implicit operator ProcessorRequirementsstring (string value) { return new ProcessorRequirementsstring (value); }
        }

        public interface IReleaseNotes : IValue {}
        public interface IReleaseNotes<T> : IReleaseNotes { new T Value { get; } }
        public class OneOrManyReleaseNotes : OneOrMany<IReleaseNotes>
        {
            public OneOrManyReleaseNotes(IReleaseNotes item) : base(item) { }
            public OneOrManyReleaseNotes(IEnumerable<IReleaseNotes> items) : base(items) { }
            public static implicit operator OneOrManyReleaseNotes (string value) { return new OneOrManyReleaseNotes (new ReleaseNotesstring (value)); }
            public static implicit operator OneOrManyReleaseNotes (string[] values) { return new OneOrManyReleaseNotes (values.Select(v => (IReleaseNotes) new ReleaseNotesstring (v))); }
            public static implicit operator OneOrManyReleaseNotes (List<string> values) { return new OneOrManyReleaseNotes (values.Select(v => (IReleaseNotes) new ReleaseNotesstring (v))); }
            public static implicit operator OneOrManyReleaseNotes (Uri value) { return new OneOrManyReleaseNotes (new ReleaseNotesUri (value)); }
            public static implicit operator OneOrManyReleaseNotes (Uri[] values) { return new OneOrManyReleaseNotes (values.Select(v => (IReleaseNotes) new ReleaseNotesUri (v))); }
            public static implicit operator OneOrManyReleaseNotes (List<Uri> values) { return new OneOrManyReleaseNotes (values.Select(v => (IReleaseNotes) new ReleaseNotesUri (v))); }
        }
        public struct ReleaseNotesstring : IReleaseNotes<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ReleaseNotesstring (string value) { Value = value; }
            public static implicit operator ReleaseNotesstring (string value) { return new ReleaseNotesstring (value); }
        }
        public struct ReleaseNotesUri : IReleaseNotes<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public ReleaseNotesUri (Uri value) { Value = value; }
            public static implicit operator ReleaseNotesUri (Uri value) { return new ReleaseNotesUri (value); }
        }

        public interface IScreenshot : IValue {}
        public interface IScreenshot<T> : IScreenshot { new T Value { get; } }
        public class OneOrManyScreenshot : OneOrMany<IScreenshot>
        {
            public OneOrManyScreenshot(IScreenshot item) : base(item) { }
            public OneOrManyScreenshot(IEnumerable<IScreenshot> items) : base(items) { }
            public static implicit operator OneOrManyScreenshot (ImageObject value) { return new OneOrManyScreenshot (new ScreenshotImageObject (value)); }
            public static implicit operator OneOrManyScreenshot (ImageObject[] values) { return new OneOrManyScreenshot (values.Select(v => (IScreenshot) new ScreenshotImageObject (v))); }
            public static implicit operator OneOrManyScreenshot (List<ImageObject> values) { return new OneOrManyScreenshot (values.Select(v => (IScreenshot) new ScreenshotImageObject (v))); }
            public static implicit operator OneOrManyScreenshot (Uri value) { return new OneOrManyScreenshot (new ScreenshotUri (value)); }
            public static implicit operator OneOrManyScreenshot (Uri[] values) { return new OneOrManyScreenshot (values.Select(v => (IScreenshot) new ScreenshotUri (v))); }
            public static implicit operator OneOrManyScreenshot (List<Uri> values) { return new OneOrManyScreenshot (values.Select(v => (IScreenshot) new ScreenshotUri (v))); }
        }
        public struct ScreenshotImageObject : IScreenshot<ImageObject>
        {
            object IValue.Value => this.Value;
            public ImageObject Value { get; }
            public ScreenshotImageObject (ImageObject value) { Value = value; }
            public static implicit operator ScreenshotImageObject (ImageObject value) { return new ScreenshotImageObject (value); }
        }
        public struct ScreenshotUri : IScreenshot<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public ScreenshotUri (Uri value) { Value = value; }
            public static implicit operator ScreenshotUri (Uri value) { return new ScreenshotUri (value); }
        }

        public interface ISoftwareAddOn : IValue {}
        public interface ISoftwareAddOn<T> : ISoftwareAddOn { new T Value { get; } }
        public class OneOrManySoftwareAddOn : OneOrMany<ISoftwareAddOn>
        {
            public OneOrManySoftwareAddOn(ISoftwareAddOn item) : base(item) { }
            public OneOrManySoftwareAddOn(IEnumerable<ISoftwareAddOn> items) : base(items) { }
            public static implicit operator OneOrManySoftwareAddOn (SoftwareApplication value) { return new OneOrManySoftwareAddOn (new SoftwareAddOnSoftwareApplication (value)); }
            public static implicit operator OneOrManySoftwareAddOn (SoftwareApplication[] values) { return new OneOrManySoftwareAddOn (values.Select(v => (ISoftwareAddOn) new SoftwareAddOnSoftwareApplication (v))); }
            public static implicit operator OneOrManySoftwareAddOn (List<SoftwareApplication> values) { return new OneOrManySoftwareAddOn (values.Select(v => (ISoftwareAddOn) new SoftwareAddOnSoftwareApplication (v))); }
        }
        public struct SoftwareAddOnSoftwareApplication : ISoftwareAddOn<SoftwareApplication>
        {
            object IValue.Value => this.Value;
            public SoftwareApplication Value { get; }
            public SoftwareAddOnSoftwareApplication (SoftwareApplication value) { Value = value; }
            public static implicit operator SoftwareAddOnSoftwareApplication (SoftwareApplication value) { return new SoftwareAddOnSoftwareApplication (value); }
        }

        public interface ISoftwareHelp : IValue {}
        public interface ISoftwareHelp<T> : ISoftwareHelp { new T Value { get; } }
        public class OneOrManySoftwareHelp : OneOrMany<ISoftwareHelp>
        {
            public OneOrManySoftwareHelp(ISoftwareHelp item) : base(item) { }
            public OneOrManySoftwareHelp(IEnumerable<ISoftwareHelp> items) : base(items) { }
            public static implicit operator OneOrManySoftwareHelp (CreativeWork value) { return new OneOrManySoftwareHelp (new SoftwareHelpCreativeWork (value)); }
            public static implicit operator OneOrManySoftwareHelp (CreativeWork[] values) { return new OneOrManySoftwareHelp (values.Select(v => (ISoftwareHelp) new SoftwareHelpCreativeWork (v))); }
            public static implicit operator OneOrManySoftwareHelp (List<CreativeWork> values) { return new OneOrManySoftwareHelp (values.Select(v => (ISoftwareHelp) new SoftwareHelpCreativeWork (v))); }
        }
        public struct SoftwareHelpCreativeWork : ISoftwareHelp<CreativeWork>
        {
            object IValue.Value => this.Value;
            public CreativeWork Value { get; }
            public SoftwareHelpCreativeWork (CreativeWork value) { Value = value; }
            public static implicit operator SoftwareHelpCreativeWork (CreativeWork value) { return new SoftwareHelpCreativeWork (value); }
        }

        public interface ISoftwareRequirements : IValue {}
        public interface ISoftwareRequirements<T> : ISoftwareRequirements { new T Value { get; } }
        public class OneOrManySoftwareRequirements : OneOrMany<ISoftwareRequirements>
        {
            public OneOrManySoftwareRequirements(ISoftwareRequirements item) : base(item) { }
            public OneOrManySoftwareRequirements(IEnumerable<ISoftwareRequirements> items) : base(items) { }
            public static implicit operator OneOrManySoftwareRequirements (string value) { return new OneOrManySoftwareRequirements (new SoftwareRequirementsstring (value)); }
            public static implicit operator OneOrManySoftwareRequirements (string[] values) { return new OneOrManySoftwareRequirements (values.Select(v => (ISoftwareRequirements) new SoftwareRequirementsstring (v))); }
            public static implicit operator OneOrManySoftwareRequirements (List<string> values) { return new OneOrManySoftwareRequirements (values.Select(v => (ISoftwareRequirements) new SoftwareRequirementsstring (v))); }
            public static implicit operator OneOrManySoftwareRequirements (Uri value) { return new OneOrManySoftwareRequirements (new SoftwareRequirementsUri (value)); }
            public static implicit operator OneOrManySoftwareRequirements (Uri[] values) { return new OneOrManySoftwareRequirements (values.Select(v => (ISoftwareRequirements) new SoftwareRequirementsUri (v))); }
            public static implicit operator OneOrManySoftwareRequirements (List<Uri> values) { return new OneOrManySoftwareRequirements (values.Select(v => (ISoftwareRequirements) new SoftwareRequirementsUri (v))); }
        }
        public struct SoftwareRequirementsstring : ISoftwareRequirements<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SoftwareRequirementsstring (string value) { Value = value; }
            public static implicit operator SoftwareRequirementsstring (string value) { return new SoftwareRequirementsstring (value); }
        }
        public struct SoftwareRequirementsUri : ISoftwareRequirements<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public SoftwareRequirementsUri (Uri value) { Value = value; }
            public static implicit operator SoftwareRequirementsUri (Uri value) { return new SoftwareRequirementsUri (value); }
        }

        public interface ISoftwareVersion : IValue {}
        public interface ISoftwareVersion<T> : ISoftwareVersion { new T Value { get; } }
        public class OneOrManySoftwareVersion : OneOrMany<ISoftwareVersion>
        {
            public OneOrManySoftwareVersion(ISoftwareVersion item) : base(item) { }
            public OneOrManySoftwareVersion(IEnumerable<ISoftwareVersion> items) : base(items) { }
            public static implicit operator OneOrManySoftwareVersion (string value) { return new OneOrManySoftwareVersion (new SoftwareVersionstring (value)); }
            public static implicit operator OneOrManySoftwareVersion (string[] values) { return new OneOrManySoftwareVersion (values.Select(v => (ISoftwareVersion) new SoftwareVersionstring (v))); }
            public static implicit operator OneOrManySoftwareVersion (List<string> values) { return new OneOrManySoftwareVersion (values.Select(v => (ISoftwareVersion) new SoftwareVersionstring (v))); }
        }
        public struct SoftwareVersionstring : ISoftwareVersion<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public SoftwareVersionstring (string value) { Value = value; }
            public static implicit operator SoftwareVersionstring (string value) { return new SoftwareVersionstring (value); }
        }

        public interface IStorageRequirements : IValue {}
        public interface IStorageRequirements<T> : IStorageRequirements { new T Value { get; } }
        public class OneOrManyStorageRequirements : OneOrMany<IStorageRequirements>
        {
            public OneOrManyStorageRequirements(IStorageRequirements item) : base(item) { }
            public OneOrManyStorageRequirements(IEnumerable<IStorageRequirements> items) : base(items) { }
            public static implicit operator OneOrManyStorageRequirements (string value) { return new OneOrManyStorageRequirements (new StorageRequirementsstring (value)); }
            public static implicit operator OneOrManyStorageRequirements (string[] values) { return new OneOrManyStorageRequirements (values.Select(v => (IStorageRequirements) new StorageRequirementsstring (v))); }
            public static implicit operator OneOrManyStorageRequirements (List<string> values) { return new OneOrManyStorageRequirements (values.Select(v => (IStorageRequirements) new StorageRequirementsstring (v))); }
            public static implicit operator OneOrManyStorageRequirements (Uri value) { return new OneOrManyStorageRequirements (new StorageRequirementsUri (value)); }
            public static implicit operator OneOrManyStorageRequirements (Uri[] values) { return new OneOrManyStorageRequirements (values.Select(v => (IStorageRequirements) new StorageRequirementsUri (v))); }
            public static implicit operator OneOrManyStorageRequirements (List<Uri> values) { return new OneOrManyStorageRequirements (values.Select(v => (IStorageRequirements) new StorageRequirementsUri (v))); }
        }
        public struct StorageRequirementsstring : IStorageRequirements<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public StorageRequirementsstring (string value) { Value = value; }
            public static implicit operator StorageRequirementsstring (string value) { return new StorageRequirementsstring (value); }
        }
        public struct StorageRequirementsUri : IStorageRequirements<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public StorageRequirementsUri (Uri value) { Value = value; }
            public static implicit operator StorageRequirementsUri (Uri value) { return new StorageRequirementsUri (value); }
        }

        public interface ISupportingData : IValue {}
        public interface ISupportingData<T> : ISupportingData { new T Value { get; } }
        public class OneOrManySupportingData : OneOrMany<ISupportingData>
        {
            public OneOrManySupportingData(ISupportingData item) : base(item) { }
            public OneOrManySupportingData(IEnumerable<ISupportingData> items) : base(items) { }
            public static implicit operator OneOrManySupportingData (DataFeed value) { return new OneOrManySupportingData (new SupportingDataDataFeed (value)); }
            public static implicit operator OneOrManySupportingData (DataFeed[] values) { return new OneOrManySupportingData (values.Select(v => (ISupportingData) new SupportingDataDataFeed (v))); }
            public static implicit operator OneOrManySupportingData (List<DataFeed> values) { return new OneOrManySupportingData (values.Select(v => (ISupportingData) new SupportingDataDataFeed (v))); }
        }
        public struct SupportingDataDataFeed : ISupportingData<DataFeed>
        {
            object IValue.Value => this.Value;
            public DataFeed Value { get; }
            public SupportingDataDataFeed (DataFeed value) { Value = value; }
            public static implicit operator SupportingDataDataFeed (DataFeed value) { return new SupportingDataDataFeed (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SoftwareApplication";

        /// <summary>
        /// Type of software application, e.g. 'Game, Multimedia'.
        /// </summary>
        [DataMember(Name = "applicationCategory", Order = 206)]
        public OneOrManyApplicationCategory ApplicationCategory { get; set; }

        /// <summary>
        /// Subcategory of the application, e.g. 'Arcade Game'.
        /// </summary>
        [DataMember(Name = "applicationSubCategory", Order = 207)]
        public OneOrManyApplicationSubCategory ApplicationSubCategory { get; set; }

        /// <summary>
        /// The name of the application suite to which the application belongs (e.g. Excel belongs to Office).
        /// </summary>
        [DataMember(Name = "applicationSuite", Order = 208)]
        public OneOrManyApplicationSuite ApplicationSuite { get; set; }

        /// <summary>
        /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
        /// </summary>
        [DataMember(Name = "availableOnDevice", Order = 209)]
        public OneOrManyAvailableOnDevice AvailableOnDevice { get; set; }

        /// <summary>
        /// Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [DataMember(Name = "countriesNotSupported", Order = 210)]
        public OneOrManyCountriesNotSupported CountriesNotSupported { get; set; }

        /// <summary>
        /// Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [DataMember(Name = "countriesSupported", Order = 211)]
        public OneOrManyCountriesSupported CountriesSupported { get; set; }

        /// <summary>
        /// If the file can be downloaded, URL to download the binary.
        /// </summary>
        [DataMember(Name = "downloadUrl", Order = 212)]
        public OneOrManyDownloadUrl DownloadUrl { get; set; }

        /// <summary>
        /// Features or modules provided by this application (and possibly required by other applications).
        /// </summary>
        [DataMember(Name = "featureList", Order = 213)]
        public OneOrManyFeatureList FeatureList { get; set; }

        /// <summary>
        /// Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.
        /// </summary>
        [DataMember(Name = "fileSize", Order = 214)]
        public OneOrManyFileSize FileSize { get; set; }

        /// <summary>
        /// URL at which the app may be installed, if different from the URL of the item.
        /// </summary>
        [DataMember(Name = "installUrl", Order = 215)]
        public OneOrManyInstallUrl InstallUrl { get; set; }

        /// <summary>
        /// Minimum memory requirements.
        /// </summary>
        [DataMember(Name = "memoryRequirements", Order = 216)]
        public OneOrManyMemoryRequirements MemoryRequirements { get; set; }

        /// <summary>
        /// Operating systems supported (Windows 7, OSX 10.6, Android 1.6).
        /// </summary>
        [DataMember(Name = "operatingSystem", Order = 217)]
        public OneOrManyOperatingSystem OperatingSystem { get; set; }

        /// <summary>
        /// Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).
        /// </summary>
        [DataMember(Name = "permissions", Order = 218)]
        public OneOrManyPermissions Permissions { get; set; }

        /// <summary>
        /// Processor architecture required to run the application (e.g. IA64).
        /// </summary>
        [DataMember(Name = "processorRequirements", Order = 219)]
        public OneOrManyProcessorRequirements ProcessorRequirements { get; set; }

        /// <summary>
        /// Description of what changed in this version.
        /// </summary>
        [DataMember(Name = "releaseNotes", Order = 220)]
        public OneOrManyReleaseNotes ReleaseNotes { get; set; }

        /// <summary>
        /// A link to a screenshot image of the app.
        /// </summary>
        [DataMember(Name = "screenshot", Order = 221)]
        public OneOrManyScreenshot Screenshot { get; set; }

        /// <summary>
        /// Additional content for a software application.
        /// </summary>
        [DataMember(Name = "softwareAddOn", Order = 222)]
        public OneOrManySoftwareAddOn SoftwareAddOn { get; set; }

        /// <summary>
        /// Software application help.
        /// </summary>
        [DataMember(Name = "softwareHelp", Order = 223)]
        public OneOrManySoftwareHelp SoftwareHelp { get; set; }

        /// <summary>
        /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
        /// </summary>
        [DataMember(Name = "softwareRequirements", Order = 224)]
        public OneOrManySoftwareRequirements SoftwareRequirements { get; set; }

        /// <summary>
        /// Version of the software instance.
        /// </summary>
        [DataMember(Name = "softwareVersion", Order = 225)]
        public OneOrManySoftwareVersion SoftwareVersion { get; set; }

        /// <summary>
        /// Storage requirements (free space required).
        /// </summary>
        [DataMember(Name = "storageRequirements", Order = 226)]
        public OneOrManyStorageRequirements StorageRequirements { get; set; }

        /// <summary>
        /// Supporting data for a SoftwareApplication.
        /// </summary>
        [DataMember(Name = "supportingData", Order = 227)]
        public OneOrManySupportingData SupportingData { get; set; }
    }
}

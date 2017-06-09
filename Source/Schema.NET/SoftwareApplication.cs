namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A software application.
    /// </summary>
    [DataContract]
    public class SoftwareApplication : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SoftwareApplication";

        /// <summary>
        /// Type of software application, e.g. 'Game, Multimedia'.
        /// </summary>
        [DataMember(Name = "applicationCategory", Order = 2)]
        public object ApplicationCategory { get; protected set; }

        /// <summary>
        /// Type of software application, e.g. 'Game, Multimedia'.
        /// </summary>
        [IgnoreDataMember]
        public string ApplicationCategoryText
        {
            get => this.ApplicationCategory as string;
            set => this.ApplicationCategory = value;
        }

        /// <summary>
        /// Type of software application, e.g. 'Game, Multimedia'.
        /// </summary>
        [IgnoreDataMember]
        public Uri ApplicationCategoryURL
        {
            get => this.ApplicationCategory as Uri;
            set => this.ApplicationCategory = value;
        }

        /// <summary>
        /// Subcategory of the application, e.g. 'Arcade Game'.
        /// </summary>
        [DataMember(Name = "applicationSubCategory", Order = 3)]
        public object ApplicationSubCategory { get; protected set; }

        /// <summary>
        /// Subcategory of the application, e.g. 'Arcade Game'.
        /// </summary>
        [IgnoreDataMember]
        public string ApplicationSubCategoryText
        {
            get => this.ApplicationSubCategory as string;
            set => this.ApplicationSubCategory = value;
        }

        /// <summary>
        /// Subcategory of the application, e.g. 'Arcade Game'.
        /// </summary>
        [IgnoreDataMember]
        public Uri ApplicationSubCategoryURL
        {
            get => this.ApplicationSubCategory as Uri;
            set => this.ApplicationSubCategory = value;
        }

        /// <summary>
        /// The name of the application suite to which the application belongs (e.g. Excel belongs to Office).
        /// </summary>
        [DataMember(Name = "applicationSuite", Order = 4)]
        public string ApplicationSuite { get; set; }

        /// <summary>
        /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
        /// </summary>
        [DataMember(Name = "availableOnDevice", Order = 5)]
        public string AvailableOnDevice { get; set; }

        /// <summary>
        /// Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [DataMember(Name = "countriesNotSupported", Order = 6)]
        public string CountriesNotSupported { get; set; }

        /// <summary>
        /// Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [DataMember(Name = "countriesSupported", Order = 7)]
        public string CountriesSupported { get; set; }

        /// <summary>
        /// If the file can be downloaded, URL to download the binary.
        /// </summary>
        [DataMember(Name = "downloadUrl", Order = 8)]
        public Uri DownloadUrl { get; set; }

        /// <summary>
        /// Features or modules provided by this application (and possibly required by other applications).
        /// </summary>
        [DataMember(Name = "featureList", Order = 9)]
        public object FeatureList { get; protected set; }

        /// <summary>
        /// Features or modules provided by this application (and possibly required by other applications).
        /// </summary>
        [IgnoreDataMember]
        public Uri FeatureListURL
        {
            get => this.FeatureList as Uri;
            set => this.FeatureList = value;
        }

        /// <summary>
        /// Features or modules provided by this application (and possibly required by other applications).
        /// </summary>
        [IgnoreDataMember]
        public string FeatureListText
        {
            get => this.FeatureList as string;
            set => this.FeatureList = value;
        }

        /// <summary>
        /// Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.
        /// </summary>
        [DataMember(Name = "fileSize", Order = 10)]
        public string FileSize { get; set; }

        /// <summary>
        /// URL at which the app may be installed, if different from the URL of the item.
        /// </summary>
        [DataMember(Name = "installUrl", Order = 11)]
        public Uri InstallUrl { get; set; }

        /// <summary>
        /// Minimum memory requirements.
        /// </summary>
        [DataMember(Name = "memoryRequirements", Order = 12)]
        public object MemoryRequirements { get; protected set; }

        /// <summary>
        /// Minimum memory requirements.
        /// </summary>
        [IgnoreDataMember]
        public Uri MemoryRequirementsURL
        {
            get => this.MemoryRequirements as Uri;
            set => this.MemoryRequirements = value;
        }

        /// <summary>
        /// Minimum memory requirements.
        /// </summary>
        [IgnoreDataMember]
        public string MemoryRequirementsText
        {
            get => this.MemoryRequirements as string;
            set => this.MemoryRequirements = value;
        }

        /// <summary>
        /// Operating systems supported (Windows 7, OSX 10.6, Android 1.6).
        /// </summary>
        [DataMember(Name = "operatingSystem", Order = 13)]
        public string OperatingSystem { get; set; }

        /// <summary>
        /// Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).
        /// </summary>
        [DataMember(Name = "permissions", Order = 14)]
        public string Permissions { get; set; }

        /// <summary>
        /// Processor architecture required to run the application (e.g. IA64).
        /// </summary>
        [DataMember(Name = "processorRequirements", Order = 15)]
        public string ProcessorRequirements { get; set; }

        /// <summary>
        /// Description of what changed in this version.
        /// </summary>
        [DataMember(Name = "releaseNotes", Order = 16)]
        public object ReleaseNotes { get; protected set; }

        /// <summary>
        /// Description of what changed in this version.
        /// </summary>
        [IgnoreDataMember]
        public Uri ReleaseNotesURL
        {
            get => this.ReleaseNotes as Uri;
            set => this.ReleaseNotes = value;
        }

        /// <summary>
        /// Description of what changed in this version.
        /// </summary>
        [IgnoreDataMember]
        public string ReleaseNotesText
        {
            get => this.ReleaseNotes as string;
            set => this.ReleaseNotes = value;
        }

        /// <summary>
        /// A link to a screenshot image of the app.
        /// </summary>
        [DataMember(Name = "screenshot", Order = 17)]
        public object Screenshot { get; protected set; }

        /// <summary>
        /// A link to a screenshot image of the app.
        /// </summary>
        [IgnoreDataMember]
        public ImageObject ScreenshotImageObject
        {
            get => this.Screenshot as ImageObject;
            set => this.Screenshot = value;
        }

        /// <summary>
        /// A link to a screenshot image of the app.
        /// </summary>
        [IgnoreDataMember]
        public Uri ScreenshotURL
        {
            get => this.Screenshot as Uri;
            set => this.Screenshot = value;
        }

        /// <summary>
        /// Additional content for a software application.
        /// </summary>
        [DataMember(Name = "softwareAddOn", Order = 18)]
        public SoftwareApplication SoftwareAddOn { get; set; }

        /// <summary>
        /// Software application help.
        /// </summary>
        [DataMember(Name = "softwareHelp", Order = 19)]
        public CreativeWork SoftwareHelp { get; set; }

        /// <summary>
        /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
        /// </summary>
        [DataMember(Name = "softwareRequirements", Order = 20)]
        public object SoftwareRequirements { get; protected set; }

        /// <summary>
        /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
        /// </summary>
        [IgnoreDataMember]
        public string SoftwareRequirementsText
        {
            get => this.SoftwareRequirements as string;
            set => this.SoftwareRequirements = value;
        }

        /// <summary>
        /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
        /// </summary>
        [IgnoreDataMember]
        public Uri SoftwareRequirementsURL
        {
            get => this.SoftwareRequirements as Uri;
            set => this.SoftwareRequirements = value;
        }

        /// <summary>
        /// Version of the software instance.
        /// </summary>
        [DataMember(Name = "softwareVersion", Order = 21)]
        public string SoftwareVersion { get; set; }

        /// <summary>
        /// Storage requirements (free space required).
        /// </summary>
        [DataMember(Name = "storageRequirements", Order = 22)]
        public object StorageRequirements { get; protected set; }

        /// <summary>
        /// Storage requirements (free space required).
        /// </summary>
        [IgnoreDataMember]
        public string StorageRequirementsText
        {
            get => this.StorageRequirements as string;
            set => this.StorageRequirements = value;
        }

        /// <summary>
        /// Storage requirements (free space required).
        /// </summary>
        [IgnoreDataMember]
        public Uri StorageRequirementsURL
        {
            get => this.StorageRequirements as Uri;
            set => this.StorageRequirements = value;
        }

        /// <summary>
        /// Supporting data for a SoftwareApplication.
        /// </summary>
        [DataMember(Name = "supportingData", Order = 23)]
        public DataFeed SupportingData { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A software application.
    /// </summary>
    [DataContract]
    public partial class SoftwareApplication : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SoftwareApplication";

        /// <summary>
        /// Type of software application, e.g. 'Game, Multimedia'.
        /// </summary>
        [DataMember(Name = "applicationCategory", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? ApplicationCategory { get; set; }

        /// <summary>
        /// Subcategory of the application, e.g. 'Arcade Game'.
        /// </summary>
        [DataMember(Name = "applicationSubCategory", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? ApplicationSubCategory { get; set; }

        /// <summary>
        /// The name of the application suite to which the application belongs (e.g. Excel belongs to Office).
        /// </summary>
        [DataMember(Name = "applicationSuite", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? ApplicationSuite { get; set; }

        /// <summary>
        /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
        /// </summary>
        [DataMember(Name = "availableOnDevice", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? AvailableOnDevice { get; set; }

        /// <summary>
        /// Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [DataMember(Name = "countriesNotSupported", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? CountriesNotSupported { get; set; }

        /// <summary>
        /// Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [DataMember(Name = "countriesSupported", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? CountriesSupported { get; set; }

        /// <summary>
        /// If the file can be downloaded, URL to download the binary.
        /// </summary>
        [DataMember(Name = "downloadUrl", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Uri>? DownloadUrl { get; set; }

        /// <summary>
        /// Features or modules provided by this application (and possibly required by other applications).
        /// </summary>
        [DataMember(Name = "featureList", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? FeatureList { get; set; }

        /// <summary>
        /// Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.
        /// </summary>
        [DataMember(Name = "fileSize", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? FileSize { get; set; }

        /// <summary>
        /// URL at which the app may be installed, if different from the URL of the item.
        /// </summary>
        [DataMember(Name = "installUrl", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<Uri>? InstallUrl { get; set; }

        /// <summary>
        /// Minimum memory requirements.
        /// </summary>
        [DataMember(Name = "memoryRequirements", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? MemoryRequirements { get; set; }

        /// <summary>
        /// Operating systems supported (Windows 7, OSX 10.6, Android 1.6).
        /// </summary>
        [DataMember(Name = "operatingSystem", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? OperatingSystem { get; set; }

        /// <summary>
        /// Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).
        /// </summary>
        [DataMember(Name = "permissions", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? Permissions { get; set; }

        /// <summary>
        /// Processor architecture required to run the application (e.g. IA64).
        /// </summary>
        [DataMember(Name = "processorRequirements", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? ProcessorRequirements { get; set; }

        /// <summary>
        /// Description of what changed in this version.
        /// </summary>
        [DataMember(Name = "releaseNotes", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? ReleaseNotes { get; set; }

        /// <summary>
        /// A link to a screenshot image of the app.
        /// </summary>
        [DataMember(Name = "screenshot", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ImageObject, Uri>? Screenshot { get; set; }

        /// <summary>
        /// Additional content for a software application.
        /// </summary>
        [DataMember(Name = "softwareAddOn", Order = 222)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<SoftwareApplication>? SoftwareAddOn { get; set; }

        /// <summary>
        /// Software application help.
        /// </summary>
        [DataMember(Name = "softwareHelp", Order = 223)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<CreativeWork>? SoftwareHelp { get; set; }

        /// <summary>
        /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
        /// </summary>
        [DataMember(Name = "softwareRequirements", Order = 224)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? SoftwareRequirements { get; set; }

        /// <summary>
        /// Version of the software instance.
        /// </summary>
        [DataMember(Name = "softwareVersion", Order = 225)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<string>? SoftwareVersion { get; set; }

        /// <summary>
        /// Storage requirements (free space required).
        /// </summary>
        [DataMember(Name = "storageRequirements", Order = 226)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string, Uri>? StorageRequirements { get; set; }

        /// <summary>
        /// Supporting data for a SoftwareApplication.
        /// </summary>
        [DataMember(Name = "supportingData", Order = 227)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<DataFeed>? SupportingData { get; set; }
    }
}

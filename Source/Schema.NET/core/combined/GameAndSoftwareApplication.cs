namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See Game, SoftwareApplication for more information.
    /// </summary>
    public partial interface IGameAndSoftwareApplication : IGame, ISoftwareApplication
    {
    }

    /// <summary>
    /// See Game, SoftwareApplication for more information.
    /// </summary>
    [DataContract]
    public abstract partial class GameAndSoftwareApplication : CreativeWork, IGameAndSoftwareApplication
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GameAndSoftwareApplication";

        /// <summary>
        /// Type of software application, e.g. 'Game, Multimedia'.
        /// </summary>
        [DataMember(Name = "applicationCategory", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri>? ApplicationCategory { get; set; }

        /// <summary>
        /// Subcategory of the application, e.g. 'Arcade Game'.
        /// </summary>
        [DataMember(Name = "applicationSubCategory", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri>? ApplicationSubCategory { get; set; }

        /// <summary>
        /// The name of the application suite to which the application belongs (e.g. Excel belongs to Office).
        /// </summary>
        [DataMember(Name = "applicationSuite", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ApplicationSuite { get; set; }

        /// <summary>
        /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
        /// </summary>
        [DataMember(Name = "availableOnDevice", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AvailableOnDevice { get; set; }

        /// <summary>
        /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
        /// </summary>
        [DataMember(Name = "characterAttribute", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing, Thing> CharacterAttribute { get; set; }

        /// <summary>
        /// Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [DataMember(Name = "countriesNotSupported", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CountriesNotSupported { get; set; }

        /// <summary>
        /// Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [DataMember(Name = "countriesSupported", Order = 212)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> CountriesSupported { get; set; }

        /// <summary>
        /// If the file can be downloaded, URL to download the binary.
        /// </summary>
        [DataMember(Name = "downloadUrl", Order = 213)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> DownloadUrl { get; set; }

        /// <summary>
        /// Features or modules provided by this application (and possibly required by other applications).
        /// </summary>
        [DataMember(Name = "featureList", Order = 214)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri>? FeatureList { get; set; }

        /// <summary>
        /// Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.
        /// </summary>
        [DataMember(Name = "fileSize", Order = 215)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> FileSize { get; set; }

        /// <summary>
        /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        [DataMember(Name = "gameItem", Order = 216)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing, Thing> GameItem { get; set; }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [DataMember(Name = "gameLocation", Order = 217)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPlace, IPostalAddress, Uri>? GameLocation { get; set; }

        /// <summary>
        /// URL at which the app may be installed, if different from the URL of the item.
        /// </summary>
        [DataMember(Name = "installUrl", Order = 218)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<Uri> InstallUrl { get; set; }

        /// <summary>
        /// Minimum memory requirements.
        /// </summary>
        [DataMember(Name = "memoryRequirements", Order = 219)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri>? MemoryRequirements { get; set; }

        /// <summary>
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [DataMember(Name = "numberOfPlayers", Order = 220)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue, QuantitativeValue> NumberOfPlayers { get; set; }

        /// <summary>
        /// Operating systems supported (Windows 7, OSX 10.6, Android 1.6).
        /// </summary>
        [DataMember(Name = "operatingSystem", Order = 221)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> OperatingSystem { get; set; }

        /// <summary>
        /// Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).
        /// </summary>
        [DataMember(Name = "permissions", Order = 222)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Permissions { get; set; }

        /// <summary>
        /// Processor architecture required to run the application (e.g. IA64).
        /// </summary>
        [DataMember(Name = "processorRequirements", Order = 223)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> ProcessorRequirements { get; set; }

        /// <summary>
        /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        [DataMember(Name = "quest", Order = 224)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IThing, Thing> Quest { get; set; }

        /// <summary>
        /// Description of what changed in this version.
        /// </summary>
        [DataMember(Name = "releaseNotes", Order = 225)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri>? ReleaseNotes { get; set; }

        /// <summary>
        /// A link to a screenshot image of the app.
        /// </summary>
        [DataMember(Name = "screenshot", Order = 226)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IImageObject, Uri>? Screenshot { get; set; }

        /// <summary>
        /// Additional content for a software application.
        /// </summary>
        [DataMember(Name = "softwareAddOn", Order = 227)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ISoftwareApplication, SoftwareApplication> SoftwareAddOn { get; set; }

        /// <summary>
        /// Software application help.
        /// </summary>
        [DataMember(Name = "softwareHelp", Order = 228)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork, CreativeWork> SoftwareHelp { get; set; }

        /// <summary>
        /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
        /// </summary>
        [DataMember(Name = "softwareRequirements", Order = 229)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri>? SoftwareRequirements { get; set; }

        /// <summary>
        /// Version of the software instance.
        /// </summary>
        [DataMember(Name = "softwareVersion", Order = 230)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> SoftwareVersion { get; set; }

        /// <summary>
        /// Storage requirements (free space required).
        /// </summary>
        [DataMember(Name = "storageRequirements", Order = 231)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri>? StorageRequirements { get; set; }

        /// <summary>
        /// Supporting data for a SoftwareApplication.
        /// </summary>
        [DataMember(Name = "supportingData", Order = 232)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDataFeed, DataFeed> SupportingData { get; set; }
    }
}

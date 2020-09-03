namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See Game, SoftwareApplication for more information.
    /// </summary>
    public partial interface IGameAndSoftwareApplication : ISoftwareApplication, IGame
    {
    }

    /// <summary>
    /// See Game, SoftwareApplication for more information.
    /// </summary>
    [DataContract]
    public abstract partial class GameAndSoftwareApplication : CreativeWork, IGameAndSoftwareApplication, IEquatable<GameAndSoftwareApplication>
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
        public Values<string, Uri> ApplicationCategory { get; set; }

        /// <summary>
        /// Subcategory of the application, e.g. 'Arcade Game'.
        /// </summary>
        [DataMember(Name = "applicationSubCategory", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> ApplicationSubCategory { get; set; }

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
        public OneOrMany<IThing> CharacterAttribute { get; set; }

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
        public Values<string, Uri> FeatureList { get; set; }

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
        public OneOrMany<IThing> GameItem { get; set; }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [DataMember(Name = "gameLocation", Order = 217)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPlace, IPostalAddress, Uri> GameLocation { get; set; }

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
        public Values<string, Uri> MemoryRequirements { get; set; }

        /// <summary>
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [DataMember(Name = "numberOfPlayers", Order = 220)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> NumberOfPlayers { get; set; }

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
        public OneOrMany<IThing> Quest { get; set; }

        /// <summary>
        /// Description of what changed in this version.
        /// </summary>
        [DataMember(Name = "releaseNotes", Order = 225)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> ReleaseNotes { get; set; }

        /// <summary>
        /// A link to a screenshot image of the app.
        /// </summary>
        [DataMember(Name = "screenshot", Order = 226)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IImageObject, Uri> Screenshot { get; set; }

        /// <summary>
        /// Additional content for a software application.
        /// </summary>
        [DataMember(Name = "softwareAddOn", Order = 227)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ISoftwareApplication> SoftwareAddOn { get; set; }

        /// <summary>
        /// Software application help.
        /// </summary>
        [DataMember(Name = "softwareHelp", Order = 228)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<ICreativeWork> SoftwareHelp { get; set; }

        /// <summary>
        /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
        /// </summary>
        [DataMember(Name = "softwareRequirements", Order = 229)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> SoftwareRequirements { get; set; }

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
        public Values<string, Uri> StorageRequirements { get; set; }

        /// <summary>
        /// Supporting data for a SoftwareApplication.
        /// </summary>
        [DataMember(Name = "supportingData", Order = 232)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDataFeed> SupportingData { get; set; }

        /// <inheritdoc/>
        public bool Equals(GameAndSoftwareApplication other)
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
                this.ApplicationCategory == other.ApplicationCategory &&
                this.ApplicationSubCategory == other.ApplicationSubCategory &&
                this.ApplicationSuite == other.ApplicationSuite &&
                this.AvailableOnDevice == other.AvailableOnDevice &&
                this.CharacterAttribute == other.CharacterAttribute &&
                this.CountriesNotSupported == other.CountriesNotSupported &&
                this.CountriesSupported == other.CountriesSupported &&
                this.DownloadUrl == other.DownloadUrl &&
                this.FeatureList == other.FeatureList &&
                this.FileSize == other.FileSize &&
                this.GameItem == other.GameItem &&
                this.GameLocation == other.GameLocation &&
                this.InstallUrl == other.InstallUrl &&
                this.MemoryRequirements == other.MemoryRequirements &&
                this.NumberOfPlayers == other.NumberOfPlayers &&
                this.OperatingSystem == other.OperatingSystem &&
                this.Permissions == other.Permissions &&
                this.ProcessorRequirements == other.ProcessorRequirements &&
                this.Quest == other.Quest &&
                this.ReleaseNotes == other.ReleaseNotes &&
                this.Screenshot == other.Screenshot &&
                this.SoftwareAddOn == other.SoftwareAddOn &&
                this.SoftwareHelp == other.SoftwareHelp &&
                this.SoftwareRequirements == other.SoftwareRequirements &&
                this.SoftwareVersion == other.SoftwareVersion &&
                this.StorageRequirements == other.StorageRequirements &&
                this.SupportingData == other.SupportingData &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as GameAndSoftwareApplication);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.ApplicationCategory)
            .And(this.ApplicationSubCategory)
            .And(this.ApplicationSuite)
            .And(this.AvailableOnDevice)
            .And(this.CharacterAttribute)
            .And(this.CountriesNotSupported)
            .And(this.CountriesSupported)
            .And(this.DownloadUrl)
            .And(this.FeatureList)
            .And(this.FileSize)
            .And(this.GameItem)
            .And(this.GameLocation)
            .And(this.InstallUrl)
            .And(this.MemoryRequirements)
            .And(this.NumberOfPlayers)
            .And(this.OperatingSystem)
            .And(this.Permissions)
            .And(this.ProcessorRequirements)
            .And(this.Quest)
            .And(this.ReleaseNotes)
            .And(this.Screenshot)
            .And(this.SoftwareAddOn)
            .And(this.SoftwareHelp)
            .And(this.SoftwareRequirements)
            .And(this.SoftwareVersion)
            .And(this.StorageRequirements)
            .And(this.SupportingData)
            .And(base.GetHashCode());
    }
}

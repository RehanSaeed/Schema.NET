using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// See Game, SoftwareApplication for more information.
    /// </summary>
    [DataContract]
    public abstract partial class GameAndSoftwareApplication : CreativeWork
    {
        public interface IApplicationCategory : IWrapper { }
        public interface IApplicationCategory<T> : IApplicationCategory { new T Data { get; set; } }
        public class ApplicationCategorystring : IApplicationCategory<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public ApplicationCategorystring () { }
            public ApplicationCategorystring (string data) { Data = data; }
            public static implicit operator ApplicationCategorystring (string data) { return new ApplicationCategorystring (data); }
        }

        public class ApplicationCategoryUri : IApplicationCategory<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public ApplicationCategoryUri () { }
            public ApplicationCategoryUri (Uri data) { Data = data; }
            public static implicit operator ApplicationCategoryUri (Uri data) { return new ApplicationCategoryUri (data); }
        }


        public interface IApplicationSubCategory : IWrapper { }
        public interface IApplicationSubCategory<T> : IApplicationSubCategory { new T Data { get; set; } }
        public class ApplicationSubCategorystring : IApplicationSubCategory<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public ApplicationSubCategorystring () { }
            public ApplicationSubCategorystring (string data) { Data = data; }
            public static implicit operator ApplicationSubCategorystring (string data) { return new ApplicationSubCategorystring (data); }
        }

        public class ApplicationSubCategoryUri : IApplicationSubCategory<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public ApplicationSubCategoryUri () { }
            public ApplicationSubCategoryUri (Uri data) { Data = data; }
            public static implicit operator ApplicationSubCategoryUri (Uri data) { return new ApplicationSubCategoryUri (data); }
        }


        public interface IFeatureList : IWrapper { }
        public interface IFeatureList<T> : IFeatureList { new T Data { get; set; } }
        public class FeatureListstring : IFeatureList<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public FeatureListstring () { }
            public FeatureListstring (string data) { Data = data; }
            public static implicit operator FeatureListstring (string data) { return new FeatureListstring (data); }
        }

        public class FeatureListUri : IFeatureList<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public FeatureListUri () { }
            public FeatureListUri (Uri data) { Data = data; }
            public static implicit operator FeatureListUri (Uri data) { return new FeatureListUri (data); }
        }


        public interface IGameLocation : IWrapper { }
        public interface IGameLocation<T> : IGameLocation { new T Data { get; set; } }
        public class GameLocationPlace : IGameLocation<Place>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Place) value; } }
            public virtual Place Data { get; set; }
            public GameLocationPlace () { }
            public GameLocationPlace (Place data) { Data = data; }
            public static implicit operator GameLocationPlace (Place data) { return new GameLocationPlace (data); }
        }

        public class GameLocationPostalAddress : IGameLocation<PostalAddress>
        {
            object IWrapper.Data { get { return Data; } set { Data = (PostalAddress) value; } }
            public virtual PostalAddress Data { get; set; }
            public GameLocationPostalAddress () { }
            public GameLocationPostalAddress (PostalAddress data) { Data = data; }
            public static implicit operator GameLocationPostalAddress (PostalAddress data) { return new GameLocationPostalAddress (data); }
        }

        public class GameLocationUri : IGameLocation<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public GameLocationUri () { }
            public GameLocationUri (Uri data) { Data = data; }
            public static implicit operator GameLocationUri (Uri data) { return new GameLocationUri (data); }
        }


        public interface IMemoryRequirements : IWrapper { }
        public interface IMemoryRequirements<T> : IMemoryRequirements { new T Data { get; set; } }
        public class MemoryRequirementsstring : IMemoryRequirements<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public MemoryRequirementsstring () { }
            public MemoryRequirementsstring (string data) { Data = data; }
            public static implicit operator MemoryRequirementsstring (string data) { return new MemoryRequirementsstring (data); }
        }

        public class MemoryRequirementsUri : IMemoryRequirements<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public MemoryRequirementsUri () { }
            public MemoryRequirementsUri (Uri data) { Data = data; }
            public static implicit operator MemoryRequirementsUri (Uri data) { return new MemoryRequirementsUri (data); }
        }


        public interface IReleaseNotes : IWrapper { }
        public interface IReleaseNotes<T> : IReleaseNotes { new T Data { get; set; } }
        public class ReleaseNotesstring : IReleaseNotes<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public ReleaseNotesstring () { }
            public ReleaseNotesstring (string data) { Data = data; }
            public static implicit operator ReleaseNotesstring (string data) { return new ReleaseNotesstring (data); }
        }

        public class ReleaseNotesUri : IReleaseNotes<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public ReleaseNotesUri () { }
            public ReleaseNotesUri (Uri data) { Data = data; }
            public static implicit operator ReleaseNotesUri (Uri data) { return new ReleaseNotesUri (data); }
        }


        public interface IScreenshot : IWrapper { }
        public interface IScreenshot<T> : IScreenshot { new T Data { get; set; } }
        public class ScreenshotImageObject : IScreenshot<ImageObject>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ImageObject) value; } }
            public virtual ImageObject Data { get; set; }
            public ScreenshotImageObject () { }
            public ScreenshotImageObject (ImageObject data) { Data = data; }
            public static implicit operator ScreenshotImageObject (ImageObject data) { return new ScreenshotImageObject (data); }
        }

        public class ScreenshotUri : IScreenshot<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public ScreenshotUri () { }
            public ScreenshotUri (Uri data) { Data = data; }
            public static implicit operator ScreenshotUri (Uri data) { return new ScreenshotUri (data); }
        }


        public interface ISoftwareRequirements : IWrapper { }
        public interface ISoftwareRequirements<T> : ISoftwareRequirements { new T Data { get; set; } }
        public class SoftwareRequirementsstring : ISoftwareRequirements<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public SoftwareRequirementsstring () { }
            public SoftwareRequirementsstring (string data) { Data = data; }
            public static implicit operator SoftwareRequirementsstring (string data) { return new SoftwareRequirementsstring (data); }
        }

        public class SoftwareRequirementsUri : ISoftwareRequirements<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public SoftwareRequirementsUri () { }
            public SoftwareRequirementsUri (Uri data) { Data = data; }
            public static implicit operator SoftwareRequirementsUri (Uri data) { return new SoftwareRequirementsUri (data); }
        }


        public interface IStorageRequirements : IWrapper { }
        public interface IStorageRequirements<T> : IStorageRequirements { new T Data { get; set; } }
        public class StorageRequirementsstring : IStorageRequirements<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public StorageRequirementsstring () { }
            public StorageRequirementsstring (string data) { Data = data; }
            public static implicit operator StorageRequirementsstring (string data) { return new StorageRequirementsstring (data); }
        }

        public class StorageRequirementsUri : IStorageRequirements<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public StorageRequirementsUri () { }
            public StorageRequirementsUri (Uri data) { Data = data; }
            public static implicit operator StorageRequirementsUri (Uri data) { return new StorageRequirementsUri (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GameAndSoftwareApplication";

        /// <summary>
        /// Type of software application, e.g. 'Game, Multimedia'.
        /// </summary>
        [DataMember(Name = "applicationCategory", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IApplicationCategory>? ApplicationCategory { get; set; } //string, Uri

        /// <summary>
        /// Subcategory of the application, e.g. 'Arcade Game'.
        /// </summary>
        [DataMember(Name = "applicationSubCategory", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IApplicationSubCategory>? ApplicationSubCategory { get; set; } //string, Uri

        /// <summary>
        /// The name of the application suite to which the application belongs (e.g. Excel belongs to Office).
        /// </summary>
        [DataMember(Name = "applicationSuite", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ApplicationSuite { get; set; } 

        /// <summary>
        /// Device required to run the application. Used in cases where a specific make/model is required to run the application.
        /// </summary>
        [DataMember(Name = "availableOnDevice", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AvailableOnDevice { get; set; } 

        /// <summary>
        /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
        /// </summary>
        [DataMember(Name = "characterAttribute", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? CharacterAttribute { get; set; } 

        /// <summary>
        /// Countries for which the application is not supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [DataMember(Name = "countriesNotSupported", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? CountriesNotSupported { get; set; } 

        /// <summary>
        /// Countries for which the application is supported. You can also provide the two-letter ISO 3166-1 alpha-2 country code.
        /// </summary>
        [DataMember(Name = "countriesSupported", Order = 212)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? CountriesSupported { get; set; } 

        /// <summary>
        /// If the file can be downloaded, URL to download the binary.
        /// </summary>
        [DataMember(Name = "downloadUrl", Order = 213)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? DownloadUrl { get; set; } 

        /// <summary>
        /// Features or modules provided by this application (and possibly required by other applications).
        /// </summary>
        [DataMember(Name = "featureList", Order = 214)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IFeatureList>? FeatureList { get; set; } //string, Uri

        /// <summary>
        /// Size of the application / package (e.g. 18MB). In the absence of a unit (MB, KB etc.), KB will be assumed.
        /// </summary>
        [DataMember(Name = "fileSize", Order = 215)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? FileSize { get; set; } 

        /// <summary>
        /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        [DataMember(Name = "gameItem", Order = 216)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? GameItem { get; set; } 

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [DataMember(Name = "gameLocation", Order = 217)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IGameLocation>? GameLocation { get; set; } //Place, PostalAddress, Uri

        /// <summary>
        /// URL at which the app may be installed, if different from the URL of the item.
        /// </summary>
        [DataMember(Name = "installUrl", Order = 218)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Uri>? InstallUrl { get; set; } 

        /// <summary>
        /// Minimum memory requirements.
        /// </summary>
        [DataMember(Name = "memoryRequirements", Order = 219)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IMemoryRequirements>? MemoryRequirements { get; set; } //string, Uri

        /// <summary>
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [DataMember(Name = "numberOfPlayers", Order = 220)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? NumberOfPlayers { get; set; } 

        /// <summary>
        /// Operating systems supported (Windows 7, OSX 10.6, Android 1.6).
        /// </summary>
        [DataMember(Name = "operatingSystem", Order = 221)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? OperatingSystem { get; set; } 

        /// <summary>
        /// Permission(s) required to run the app (for example, a mobile app may require full internet access or may run only on wifi).
        /// </summary>
        [DataMember(Name = "permissions", Order = 222)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? Permissions { get; set; } 

        /// <summary>
        /// Processor architecture required to run the application (e.g. IA64).
        /// </summary>
        [DataMember(Name = "processorRequirements", Order = 223)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ProcessorRequirements { get; set; } 

        /// <summary>
        /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        [DataMember(Name = "quest", Order = 224)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Thing>? Quest { get; set; } 

        /// <summary>
        /// Description of what changed in this version.
        /// </summary>
        [DataMember(Name = "releaseNotes", Order = 225)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IReleaseNotes>? ReleaseNotes { get; set; } //string, Uri

        /// <summary>
        /// A link to a screenshot image of the app.
        /// </summary>
        [DataMember(Name = "screenshot", Order = 226)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IScreenshot>? Screenshot { get; set; } //ImageObject, Uri

        /// <summary>
        /// Additional content for a software application.
        /// </summary>
        [DataMember(Name = "softwareAddOn", Order = 227)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<SoftwareApplication>? SoftwareAddOn { get; set; } 

        /// <summary>
        /// Software application help.
        /// </summary>
        [DataMember(Name = "softwareHelp", Order = 228)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<CreativeWork>? SoftwareHelp { get; set; } 

        /// <summary>
        /// Component dependency requirements for application. This includes runtime environments and shared libraries that are not included in the application distribution package, but required to run the application (Examples: DirectX, Java or .NET runtime).
        /// </summary>
        [DataMember(Name = "softwareRequirements", Order = 229)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISoftwareRequirements>? SoftwareRequirements { get; set; } //string, Uri

        /// <summary>
        /// Version of the software instance.
        /// </summary>
        [DataMember(Name = "softwareVersion", Order = 230)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? SoftwareVersion { get; set; } 

        /// <summary>
        /// Storage requirements (free space required).
        /// </summary>
        [DataMember(Name = "storageRequirements", Order = 231)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IStorageRequirements>? StorageRequirements { get; set; } //string, Uri

        /// <summary>
        /// Supporting data for a SoftwareApplication.
        /// </summary>
        [DataMember(Name = "supportingData", Order = 232)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DataFeed>? SupportingData { get; set; } 
    }
}

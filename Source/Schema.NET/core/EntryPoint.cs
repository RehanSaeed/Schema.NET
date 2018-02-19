using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// </summary>
    [DataContract]
    public partial class EntryPoint : Intangible
    {
        public interface IActionPlatform : IWrapper { }
        public interface IActionPlatform<T> : IActionPlatform { new T Data { get; set; } }
        public class ActionPlatformstring : IActionPlatform<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public ActionPlatformstring () { }
            public ActionPlatformstring (string data) { Data = data; }
            public static implicit operator ActionPlatformstring (string data) { return new ActionPlatformstring (data); }
        }

        public class ActionPlatformUri : IActionPlatform<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public ActionPlatformUri () { }
            public ActionPlatformUri (Uri data) { Data = data; }
            public static implicit operator ActionPlatformUri (Uri data) { return new ActionPlatformUri (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EntryPoint";

        /// <summary>
        /// An application that can complete the request.
        /// </summary>
        [DataMember(Name = "actionApplication", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<SoftwareApplication>? ActionApplication { get; set; } 

        /// <summary>
        /// The high level platform(s) where the Action can be performed for the given URL. To specify a specific application or operating system instance, use actionApplication.
        /// </summary>
        [DataMember(Name = "actionPlatform", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IActionPlatform>? ActionPlatform { get; set; } //string, Uri

        /// <summary>
        /// The supported content type(s) for an EntryPoint response.
        /// </summary>
        [DataMember(Name = "contentType", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? ContentType { get; set; } 

        /// <summary>
        /// The supported encoding type(s) for an EntryPoint request.
        /// </summary>
        [DataMember(Name = "encodingType", Order = 209)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? EncodingType { get; set; } 

        /// <summary>
        /// An HTTP method that specifies the appropriate HTTP method for a request to an HTTP EntryPoint. Values are capitalized strings as used in HTTP.
        /// </summary>
        [DataMember(Name = "httpMethod", Order = 210)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? HttpMethod { get; set; } 

        /// <summary>
        /// An url template (RFC6570) that will be used to construct the target of the execution of the action.
        /// </summary>
        [DataMember(Name = "urlTemplate", Order = 211)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? UrlTemplate { get; set; } 
    }
}

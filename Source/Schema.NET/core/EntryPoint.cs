namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// An entry point, within some Web-based protocol.
    /// </summary>
    [DataContract]
    public partial class EntryPoint : Intangible
    {
        public interface IActionApplication : IValue {}
        public interface IActionApplication<T> : IActionApplication { new T Value { get; } }
        public class OneOrManyActionApplication : OneOrMany<IActionApplication>
        {
            public OneOrManyActionApplication(IActionApplication item) : base(item) { }
            public OneOrManyActionApplication(IEnumerable<IActionApplication> items) : base(items) { }
            public static implicit operator OneOrManyActionApplication (SoftwareApplication value) { return new OneOrManyActionApplication (new ActionApplicationSoftwareApplication (value)); }
            public static implicit operator OneOrManyActionApplication (SoftwareApplication[] values) { return new OneOrManyActionApplication (values.Select(v => (IActionApplication) new ActionApplicationSoftwareApplication (v))); }
            public static implicit operator OneOrManyActionApplication (List<SoftwareApplication> values) { return new OneOrManyActionApplication (values.Select(v => (IActionApplication) new ActionApplicationSoftwareApplication (v))); }
        }
        public struct ActionApplicationSoftwareApplication : IActionApplication<SoftwareApplication>
        {
            object IValue.Value => this.Value;
            public SoftwareApplication Value { get; }
            public ActionApplicationSoftwareApplication (SoftwareApplication value) { Value = value; }
            public static implicit operator ActionApplicationSoftwareApplication (SoftwareApplication value) { return new ActionApplicationSoftwareApplication (value); }
        }

        public interface IActionPlatform : IValue {}
        public interface IActionPlatform<T> : IActionPlatform { new T Value { get; } }
        public class OneOrManyActionPlatform : OneOrMany<IActionPlatform>
        {
            public OneOrManyActionPlatform(IActionPlatform item) : base(item) { }
            public OneOrManyActionPlatform(IEnumerable<IActionPlatform> items) : base(items) { }
            public static implicit operator OneOrManyActionPlatform (string value) { return new OneOrManyActionPlatform (new ActionPlatformstring (value)); }
            public static implicit operator OneOrManyActionPlatform (string[] values) { return new OneOrManyActionPlatform (values.Select(v => (IActionPlatform) new ActionPlatformstring (v))); }
            public static implicit operator OneOrManyActionPlatform (List<string> values) { return new OneOrManyActionPlatform (values.Select(v => (IActionPlatform) new ActionPlatformstring (v))); }
            public static implicit operator OneOrManyActionPlatform (Uri value) { return new OneOrManyActionPlatform (new ActionPlatformUri (value)); }
            public static implicit operator OneOrManyActionPlatform (Uri[] values) { return new OneOrManyActionPlatform (values.Select(v => (IActionPlatform) new ActionPlatformUri (v))); }
            public static implicit operator OneOrManyActionPlatform (List<Uri> values) { return new OneOrManyActionPlatform (values.Select(v => (IActionPlatform) new ActionPlatformUri (v))); }
        }
        public struct ActionPlatformstring : IActionPlatform<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ActionPlatformstring (string value) { Value = value; }
            public static implicit operator ActionPlatformstring (string value) { return new ActionPlatformstring (value); }
        }
        public struct ActionPlatformUri : IActionPlatform<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public ActionPlatformUri (Uri value) { Value = value; }
            public static implicit operator ActionPlatformUri (Uri value) { return new ActionPlatformUri (value); }
        }

        public interface IContentType : IValue {}
        public interface IContentType<T> : IContentType { new T Value { get; } }
        public class OneOrManyContentType : OneOrMany<IContentType>
        {
            public OneOrManyContentType(IContentType item) : base(item) { }
            public OneOrManyContentType(IEnumerable<IContentType> items) : base(items) { }
            public static implicit operator OneOrManyContentType (string value) { return new OneOrManyContentType (new ContentTypestring (value)); }
            public static implicit operator OneOrManyContentType (string[] values) { return new OneOrManyContentType (values.Select(v => (IContentType) new ContentTypestring (v))); }
            public static implicit operator OneOrManyContentType (List<string> values) { return new OneOrManyContentType (values.Select(v => (IContentType) new ContentTypestring (v))); }
        }
        public struct ContentTypestring : IContentType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public ContentTypestring (string value) { Value = value; }
            public static implicit operator ContentTypestring (string value) { return new ContentTypestring (value); }
        }

        public interface IEncodingType : IValue {}
        public interface IEncodingType<T> : IEncodingType { new T Value { get; } }
        public class OneOrManyEncodingType : OneOrMany<IEncodingType>
        {
            public OneOrManyEncodingType(IEncodingType item) : base(item) { }
            public OneOrManyEncodingType(IEnumerable<IEncodingType> items) : base(items) { }
            public static implicit operator OneOrManyEncodingType (string value) { return new OneOrManyEncodingType (new EncodingTypestring (value)); }
            public static implicit operator OneOrManyEncodingType (string[] values) { return new OneOrManyEncodingType (values.Select(v => (IEncodingType) new EncodingTypestring (v))); }
            public static implicit operator OneOrManyEncodingType (List<string> values) { return new OneOrManyEncodingType (values.Select(v => (IEncodingType) new EncodingTypestring (v))); }
        }
        public struct EncodingTypestring : IEncodingType<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public EncodingTypestring (string value) { Value = value; }
            public static implicit operator EncodingTypestring (string value) { return new EncodingTypestring (value); }
        }

        public interface IHttpMethod : IValue {}
        public interface IHttpMethod<T> : IHttpMethod { new T Value { get; } }
        public class OneOrManyHttpMethod : OneOrMany<IHttpMethod>
        {
            public OneOrManyHttpMethod(IHttpMethod item) : base(item) { }
            public OneOrManyHttpMethod(IEnumerable<IHttpMethod> items) : base(items) { }
            public static implicit operator OneOrManyHttpMethod (string value) { return new OneOrManyHttpMethod (new HttpMethodstring (value)); }
            public static implicit operator OneOrManyHttpMethod (string[] values) { return new OneOrManyHttpMethod (values.Select(v => (IHttpMethod) new HttpMethodstring (v))); }
            public static implicit operator OneOrManyHttpMethod (List<string> values) { return new OneOrManyHttpMethod (values.Select(v => (IHttpMethod) new HttpMethodstring (v))); }
        }
        public struct HttpMethodstring : IHttpMethod<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public HttpMethodstring (string value) { Value = value; }
            public static implicit operator HttpMethodstring (string value) { return new HttpMethodstring (value); }
        }

        public interface IUrlTemplate : IValue {}
        public interface IUrlTemplate<T> : IUrlTemplate { new T Value { get; } }
        public class OneOrManyUrlTemplate : OneOrMany<IUrlTemplate>
        {
            public OneOrManyUrlTemplate(IUrlTemplate item) : base(item) { }
            public OneOrManyUrlTemplate(IEnumerable<IUrlTemplate> items) : base(items) { }
            public static implicit operator OneOrManyUrlTemplate (string value) { return new OneOrManyUrlTemplate (new UrlTemplatestring (value)); }
            public static implicit operator OneOrManyUrlTemplate (string[] values) { return new OneOrManyUrlTemplate (values.Select(v => (IUrlTemplate) new UrlTemplatestring (v))); }
            public static implicit operator OneOrManyUrlTemplate (List<string> values) { return new OneOrManyUrlTemplate (values.Select(v => (IUrlTemplate) new UrlTemplatestring (v))); }
        }
        public struct UrlTemplatestring : IUrlTemplate<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public UrlTemplatestring (string value) { Value = value; }
            public static implicit operator UrlTemplatestring (string value) { return new UrlTemplatestring (value); }
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
        public OneOrManyActionApplication ActionApplication { get; set; }

        /// <summary>
        /// The high level platform(s) where the Action can be performed for the given URL. To specify a specific application or operating system instance, use actionApplication.
        /// </summary>
        [DataMember(Name = "actionPlatform", Order = 207)]
        public OneOrManyActionPlatform ActionPlatform { get; set; }

        /// <summary>
        /// The supported content type(s) for an EntryPoint response.
        /// </summary>
        [DataMember(Name = "contentType", Order = 208)]
        public OneOrManyContentType ContentType { get; set; }

        /// <summary>
        /// The supported encoding type(s) for an EntryPoint request.
        /// </summary>
        [DataMember(Name = "encodingType", Order = 209)]
        public OneOrManyEncodingType EncodingType { get; set; }

        /// <summary>
        /// An HTTP method that specifies the appropriate HTTP method for a request to an HTTP EntryPoint. Values are capitalized strings as used in HTTP.
        /// </summary>
        [DataMember(Name = "httpMethod", Order = 210)]
        public OneOrManyHttpMethod HttpMethod { get; set; }

        /// <summary>
        /// An url template (RFC6570) that will be used to construct the target of the execution of the action.
        /// </summary>
        [DataMember(Name = "urlTemplate", Order = 211)]
        public OneOrManyUrlTemplate UrlTemplate { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// Web applications.
    /// </summary>
    [DataContract]
    public partial class WebApplication : SoftwareApplication
    {
        public interface IBrowserRequirements : IValue {}
        public interface IBrowserRequirements<T> : IBrowserRequirements { new T Value { get; } }
        public class OneOrManyBrowserRequirements : OneOrMany<IBrowserRequirements>
        {
            public OneOrManyBrowserRequirements(IBrowserRequirements item) : base(item) { }
            public OneOrManyBrowserRequirements(IEnumerable<IBrowserRequirements> items) : base(items) { }
            public static implicit operator OneOrManyBrowserRequirements (string value) { return new OneOrManyBrowserRequirements (new BrowserRequirementsstring (value)); }
            public static implicit operator OneOrManyBrowserRequirements (string[] values) { return new OneOrManyBrowserRequirements (values.Select(v => (IBrowserRequirements) new BrowserRequirementsstring (v))); }
            public static implicit operator OneOrManyBrowserRequirements (List<string> values) { return new OneOrManyBrowserRequirements (values.Select(v => (IBrowserRequirements) new BrowserRequirementsstring (v))); }
        }
        public struct BrowserRequirementsstring : IBrowserRequirements<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BrowserRequirementsstring (string value) { Value = value; }
            public static implicit operator BrowserRequirementsstring (string value) { return new BrowserRequirementsstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WebApplication";

        /// <summary>
        /// Specifies browser requirements in human-readable text. For example, 'requires HTML5 support'.
        /// </summary>
        [DataMember(Name = "browserRequirements", Order = 306)]
        public OneOrManyBrowserRequirements BrowserRequirements { get; set; }
    }
}

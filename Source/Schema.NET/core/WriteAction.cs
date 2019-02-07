namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of authoring written creative content.
    /// </summary>
    [DataContract]
    public partial class WriteAction : CreateAction
    {
        public interface IInLanguage : IValue {}
        public interface IInLanguage<T> : IInLanguage { new T Value { get; } }
        public class OneOrManyInLanguage : OneOrMany<IInLanguage>
        {
            public OneOrManyInLanguage(IInLanguage item) : base(item) { }
            public OneOrManyInLanguage(IEnumerable<IInLanguage> items) : base(items) { }
            public static implicit operator OneOrManyInLanguage (Language value) { return new OneOrManyInLanguage (new InLanguageLanguage (value)); }
            public static implicit operator OneOrManyInLanguage (Language[] values) { return new OneOrManyInLanguage (values.Select(v => (IInLanguage) new InLanguageLanguage (v))); }
            public static implicit operator OneOrManyInLanguage (List<Language> values) { return new OneOrManyInLanguage (values.Select(v => (IInLanguage) new InLanguageLanguage (v))); }
            public static implicit operator OneOrManyInLanguage (string value) { return new OneOrManyInLanguage (new InLanguagestring (value)); }
            public static implicit operator OneOrManyInLanguage (string[] values) { return new OneOrManyInLanguage (values.Select(v => (IInLanguage) new InLanguagestring (v))); }
            public static implicit operator OneOrManyInLanguage (List<string> values) { return new OneOrManyInLanguage (values.Select(v => (IInLanguage) new InLanguagestring (v))); }
        }
        public struct InLanguageLanguage : IInLanguage<Language>
        {
            object IValue.Value => this.Value;
            public Language Value { get; }
            public InLanguageLanguage (Language value) { Value = value; }
            public static implicit operator InLanguageLanguage (Language value) { return new InLanguageLanguage (value); }
        }
        public struct InLanguagestring : IInLanguage<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public InLanguagestring (string value) { Value = value; }
            public static implicit operator InLanguagestring (string value) { return new InLanguagestring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WriteAction";

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="http://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage", Order = 306)]
        public OneOrManyInLanguage InLanguage { get; set; }
    }
}

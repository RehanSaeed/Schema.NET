namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of authoring written creative content.
    /// </summary>
    public partial interface IWriteAction : ICreateAction
    {
        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="https://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        Values<ILanguage, string> InLanguage { get; set; }
    }

    /// <summary>
    /// The act of authoring written creative content.
    /// </summary>
    [DataContract]
    public partial class WriteAction : CreateAction, IWriteAction, IEquatable<WriteAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WriteAction";

        /// <summary>
        /// The language of the content or performance or used in an action. Please use one of the language codes from the &lt;a href="http://tools.ietf.org/html/bcp47"&gt;IETF BCP 47 standard&lt;/a&gt;. See also &lt;a class="localLink" href="https://schema.org/availableLanguage"&gt;availableLanguage&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "inLanguage", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<ILanguage, string> InLanguage { get; set; }

        /// <inheritdoc/>
        public bool Equals(WriteAction other)
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
                this.InLanguage == other.InLanguage &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as WriteAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.InLanguage)
            .And(base.GetHashCode());
    }
}

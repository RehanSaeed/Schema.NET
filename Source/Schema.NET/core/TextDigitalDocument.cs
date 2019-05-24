namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A file composed primarily of text.
    /// </summary>
    public partial interface ITextDigitalDocument : IDigitalDocument
    {
    }

    /// <summary>
    /// A file composed primarily of text.
    /// </summary>
    [DataContract]
    public partial class TextDigitalDocument : DigitalDocument, ITextDigitalDocument
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TextDigitalDocument";
    }
}

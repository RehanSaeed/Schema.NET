namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A file containing a note, primarily for the author.
    /// </summary>
    public partial interface INoteDigitalDocument : IDigitalDocument
    {
    }

    /// <summary>
    /// A file containing a note, primarily for the author.
    /// </summary>
    [DataContract]
    public partial class NoteDigitalDocument : DigitalDocument, INoteDigitalDocument
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "NoteDigitalDocument";
    }
}

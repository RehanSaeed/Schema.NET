namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A file containing slides or used for a presentation.
    /// </summary>
    public partial interface IPresentationDigitalDocument : IDigitalDocument
    {
    }

    /// <summary>
    /// A file containing slides or used for a presentation.
    /// </summary>
    [DataContract]
    public partial class PresentationDigitalDocument : DigitalDocument, IPresentationDigitalDocument, IEquatable<PresentationDigitalDocument>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PresentationDigitalDocument";
    }
}

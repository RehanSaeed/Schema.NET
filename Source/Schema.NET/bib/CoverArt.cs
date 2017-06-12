namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The artwork on the outer surface of a CreativeWork.
    /// </summary>
    [DataContract]
    public partial class CoverArt : VisualArtwork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CoverArt";
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The artwork on the outer surface of a CreativeWork.
    /// </summary>
    public partial interface ICoverArt : IVisualArtwork
    {
    }

    /// <summary>
    /// The artwork on the outer surface of a CreativeWork.
    /// </summary>
    [DataContract]
    public partial class CoverArt : VisualArtwork, ICoverArt, IEquatable<CoverArt>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CoverArt";
    }
}

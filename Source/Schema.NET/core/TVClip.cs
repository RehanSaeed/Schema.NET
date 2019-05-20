namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A short TV program or a segment/part of a TV program.
    /// </summary>
    public partial interface ITVClip : IClip
    {
    }

    /// <summary>
    /// A short TV program or a segment/part of a TV program.
    /// </summary>
    [DataContract]
    public partial class TVClip : Clip, ITVClip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TVClip";
    }
}

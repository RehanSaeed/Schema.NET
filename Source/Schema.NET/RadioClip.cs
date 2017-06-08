namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A short radio program or a segment/part of a radio program.
    /// </summary>
    [DataContract]
    public class RadioClip : Clip
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "RadioClip";
    }
}

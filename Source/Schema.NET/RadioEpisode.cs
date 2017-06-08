namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A radio episode which can be part of a series or season.
    /// </summary>
    [DataContract]
    public class RadioEpisode : Episode
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "RadioEpisode";
    }
}

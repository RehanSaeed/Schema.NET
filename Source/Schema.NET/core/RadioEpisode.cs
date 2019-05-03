namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A radio episode which can be part of a series or season.
    /// </summary>
    [DataContract]
    public partial class RadioEpisode : Episode
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RadioEpisode";
    }
}

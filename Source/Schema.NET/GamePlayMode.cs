namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Indicates whether this game is multi-player, co-op or single-player.
    /// </summary>
    [DataContract]
    public class GamePlayMode : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GamePlayMode";
    }
}

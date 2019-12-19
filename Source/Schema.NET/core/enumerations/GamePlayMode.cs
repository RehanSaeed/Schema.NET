namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// Indicates whether this game is multi-player, co-op or single-player.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GamePlayMode
    {
        /// <summary>
        /// Play mode: CoOp. Co-operative games, where you play on the same team with friends.
        /// </summary>
        [EnumMember(Value = "https://schema.org/CoOp")]
        CoOp,

        /// <summary>
        /// Play mode: MultiPlayer. Requiring or allowing multiple human players to play simultaneously.
        /// </summary>
        [EnumMember(Value = "https://schema.org/MultiPlayer")]
        MultiPlayer,

        /// <summary>
        /// Play mode: SinglePlayer. Which is played by a lone player.
        /// </summary>
        [EnumMember(Value = "https://schema.org/SinglePlayer")]
        SinglePlayer,
    }
}

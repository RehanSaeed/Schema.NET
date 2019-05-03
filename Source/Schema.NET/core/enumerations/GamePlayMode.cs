namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Indicates whether this game is multi-player, co-op or single-player.
    /// </summary>
    public enum GamePlayMode
    {
        /// <summary>
        /// Play mode: CoOp. Co-operative games, where you play on the same team with friends.
        /// </summary>
        [EnumMember(Value = "http://schema.org/CoOp")]
        CoOp,

        /// <summary>
        /// Play mode: MultiPlayer. Requiring or allowing multiple human players to play simultaneously.
        /// </summary>
        [EnumMember(Value = "http://schema.org/MultiPlayer")]
        MultiPlayer,

        /// <summary>
        /// Play mode: SinglePlayer. Which is played by a lone player.
        /// </summary>
        [EnumMember(Value = "http://schema.org/SinglePlayer")]
        SinglePlayer
    }
}

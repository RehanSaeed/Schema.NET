namespace Schema.NET
{
    /// <summary>
    /// Status of a game server.
    /// </summary>
    public enum GameServerStatus
    {
        /// <summary>
        /// Game server status: OfflinePermanently. Server is offline and not available.
        /// </summary>
        OfflinePermanently,

        /// <summary>
        /// Game server status: OfflineTemporarily. Server is offline now but it can be online soon.
        /// </summary>
        OfflineTemporarily,

        /// <summary>
        /// Game server status: Online. Server is available.
        /// </summary>
        Online,

        /// <summary>
        /// Game server status: OnlineFull. Server is online but unavailable. The maximum number of players has reached.
        /// </summary>
        OnlineFull
    }
}

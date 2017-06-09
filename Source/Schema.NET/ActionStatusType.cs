namespace Schema.NET
{
    /// <summary>
    /// The status of an Action.
    /// </summary>
    public enum ActionStatusType
    {
        /// <summary>
        /// An in-progress action (e.g, while watching the movie, or driving to a location).
        /// </summary>
        ActiveActionStatus,

        /// <summary>
        /// An action that has already taken place.
        /// </summary>
        CompletedActionStatus,

        /// <summary>
        /// An action that failed to complete. The action's error property and the HTTP return code contain more information about the failure.
        /// </summary>
        FailedActionStatus,

        /// <summary>
        /// A description of an action that is supported.
        /// </summary>
        PotentialActionStatus
    }
}

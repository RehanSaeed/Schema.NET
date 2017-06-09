namespace Schema.NET
{
    /// <summary>
    /// A type of permission which can be granted for accessing a digital document.
    /// </summary>
    public enum DigitalDocumentPermissionType
    {
        /// <summary>
        /// Permission to add comments to the document.
        /// </summary>
        CommentPermission,

        /// <summary>
        /// Permission to read or view the document.
        /// </summary>
        ReadPermission,

        /// <summary>
        /// Permission to write or edit the document.
        /// </summary>
        WritePermission
    }
}

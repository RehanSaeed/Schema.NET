namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A type of permission which can be granted for accessing a digital document.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DigitalDocumentPermissionType
    {
        /// <summary>
        /// Permission to add comments to the document.
        /// </summary>
        [EnumMember(Value = "http://schema.org/CommentPermission")]
        CommentPermission,

        /// <summary>
        /// Permission to read or view the document.
        /// </summary>
        [EnumMember(Value = "http://schema.org/ReadPermission")]
        ReadPermission,

        /// <summary>
        /// Permission to write or edit the document.
        /// </summary>
        [EnumMember(Value = "http://schema.org/WritePermission")]
        WritePermission
    }
}

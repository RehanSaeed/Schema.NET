namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Categories of medical devices, organized by the purpose or intended use of the device.
    /// </summary>
    public enum MedicalDevicePurpose
    {
        /// <summary>
        /// A medical device used for diagnostic purposes.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Diagnostic")]
        Diagnostic,

        /// <summary>
        /// A medical device used for therapeutic purposes.
        /// </summary>
        [EnumMember(Value = "http://schema.org/Therapeutic")]
        Therapeutic
    }
}

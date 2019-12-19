namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A specific payment status. For example, PaymentDue, PaymentComplete, etc.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentStatusType
    {
        /// <summary>
        /// An automatic payment system is in place and will be used.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PaymentAutomaticallyApplied")]
        PaymentAutomaticallyApplied,

        /// <summary>
        /// The payment has been received and processed.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PaymentComplete")]
        PaymentComplete,

        /// <summary>
        /// The payee received the payment, but it was declined for some reason.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PaymentDeclined")]
        PaymentDeclined,

        /// <summary>
        /// The payment is due, but still within an acceptable time to be received.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PaymentDue")]
        PaymentDue,

        /// <summary>
        /// The payment is due and considered late.
        /// </summary>
        [EnumMember(Value = "https://schema.org/PaymentPastDue")]
        PaymentPastDue,
    }
}

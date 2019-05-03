namespace Schema.NET
{
    using System.Runtime.Serialization;

    /// <summary>
    /// A specific payment status. For example, PaymentDue, PaymentComplete, etc.
    /// </summary>
    public enum PaymentStatusType
    {
        /// <summary>
        /// An automatic payment system is in place and will be used.
        /// </summary>
        [EnumMember(Value = "http://schema.org/PaymentAutomaticallyApplied")]
        PaymentAutomaticallyApplied,

        /// <summary>
        /// The payment has been received and processed.
        /// </summary>
        [EnumMember(Value = "http://schema.org/PaymentComplete")]
        PaymentComplete,

        /// <summary>
        /// The payee received the payment, but it was declined for some reason.
        /// </summary>
        [EnumMember(Value = "http://schema.org/PaymentDeclined")]
        PaymentDeclined,

        /// <summary>
        /// The payment is due, but still within an acceptable time to be received.
        /// </summary>
        [EnumMember(Value = "http://schema.org/PaymentDue")]
        PaymentDue,

        /// <summary>
        /// The payment is due and considered late.
        /// </summary>
        [EnumMember(Value = "http://schema.org/PaymentPastDue")]
        PaymentPastDue
    }
}

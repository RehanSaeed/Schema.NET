namespace Schema.NET
{
    /// <summary>
    /// A specific payment status. For example, PaymentDue, PaymentComplete, etc.
    /// </summary>
    public enum PaymentStatusType
    {
        /// <summary>
        /// An automatic payment system is in place and will be used.
        /// </summary>
        PaymentAutomaticallyApplied,

        /// <summary>
        /// The payment has been received and processed.
        /// </summary>
        PaymentComplete,

        /// <summary>
        /// The payee received the payment, but it was declined for some reason.
        /// </summary>
        PaymentDeclined,

        /// <summary>
        /// The payment is due, but still within an acceptable time to be received.
        /// </summary>
        PaymentDue,

        /// <summary>
        /// The payment is due and considered late.
        /// </summary>
        PaymentPastDue
    }
}

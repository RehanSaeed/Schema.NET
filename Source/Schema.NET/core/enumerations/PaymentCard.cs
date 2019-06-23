namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// A payment method using a credit, debit, store or other card to associate the payment with an account.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentCard
    {
    }
}

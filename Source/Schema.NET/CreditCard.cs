namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A card payment method of a particular brand or name.  Used to mark up a particular payment method and/or the financial product/service that supplies the card account...
    /// </summary>
    [DataContract]
    public class CreditCard : PaymentCard
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CreditCard";
    }
}

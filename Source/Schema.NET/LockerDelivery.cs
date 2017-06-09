namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A DeliveryMethod in which an item is made available via locker.
    /// </summary>
    [DataContract]
    public class LockerDelivery : DeliveryMethod
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LockerDelivery";
    }
}

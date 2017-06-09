namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A private parcel service as the delivery mode available for a certain offer...
    /// </summary>
    [DataContract]
    public class ParcelService : DeliveryMethod
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ParcelService";
    }
}

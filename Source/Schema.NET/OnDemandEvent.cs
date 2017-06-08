namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A publication event e.g. catch-up TV or radio podcast, during which a program is available on-demand.
    /// </summary>
    [DataContract]
    public class OnDemandEvent : PublicationEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "OnDemandEvent";
    }
}

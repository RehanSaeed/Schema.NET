namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An agent tracks an object for updates.
    /// Related actions:
    ///
    /// FollowAction: Unlike FollowAction, TrackAction refers to the interest on the location of innanimates objects...
    /// </summary>
    [DataContract]
    public class TrackAction : FindAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "TrackAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod")]
        public DeliveryMethod DeliveryMethod { get; set; }
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Season dedicated to radio broadcast and associated online delivery.
    /// </summary>
    [DataContract]
    public class RadioSeason : CreativeWorkSeason
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "RadioSeason";
    }
}

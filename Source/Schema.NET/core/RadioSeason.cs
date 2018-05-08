namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Season dedicated to radio broadcast and associated online delivery.
    /// </summary>
    public partial interface IRadioSeason : ICreativeWorkSeason
    {
    }

    /// <summary>
    /// Season dedicated to radio broadcast and associated online delivery.
    /// </summary>
    [DataContract]
    public partial class RadioSeason : CreativeWorkSeason, IRadioSeason
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RadioSeason";
    }
}

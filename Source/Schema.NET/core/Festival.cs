namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Festival.
    /// </summary>
    public partial interface IFestival : IEvent
    {
    }

    /// <summary>
    /// Event type: Festival.
    /// </summary>
    [DataContract]
    public partial class Festival : Event, IFestival
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Festival";
    }
}

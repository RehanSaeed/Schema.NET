namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Children's event.
    /// </summary>
    public partial interface IChildrensEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Children's event.
    /// </summary>
    [DataContract]
    public partial class ChildrensEvent : Event, IChildrensEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ChildrensEvent";
    }
}

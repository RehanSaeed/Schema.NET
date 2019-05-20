namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Food event.
    /// </summary>
    public partial interface IFoodEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Food event.
    /// </summary>
    [DataContract]
    public partial class FoodEvent : Event, IFoodEvent
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FoodEvent";
    }
}

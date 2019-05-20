namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A food service, like breakfast, lunch, or dinner.
    /// </summary>
    public partial interface IFoodService : IService
    {
    }

    /// <summary>
    /// A food service, like breakfast, lunch, or dinner.
    /// </summary>
    [DataContract]
    public partial class FoodService : Service, IFoodService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FoodService";
    }
}

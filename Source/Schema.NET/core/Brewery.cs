namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Brewery.
    /// </summary>
    public partial interface IBrewery : IFoodEstablishment
    {
    }

    /// <summary>
    /// Brewery.
    /// </summary>
    [DataContract]
    public partial class Brewery : FoodEstablishment, IBrewery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Brewery";
    }
}

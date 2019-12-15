namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A winery.
    /// </summary>
    public partial interface IWinery : IFoodEstablishment
    {
    }

    /// <summary>
    /// A winery.
    /// </summary>
    [DataContract]
    public partial class Winery : FoodEstablishment, IWinery, IEquatable<Winery>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Winery";
    }
}

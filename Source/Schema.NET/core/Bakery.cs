namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A bakery.
    /// </summary>
    public partial interface IBakery : IFoodEstablishment
    {
    }

    /// <summary>
    /// A bakery.
    /// </summary>
    [DataContract]
    public partial class Bakery : FoodEstablishment, IBakery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Bakery";
    }
}

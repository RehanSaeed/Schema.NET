namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A distillery.
    /// </summary>
    public partial interface IDistillery : IFoodEstablishment
    {
    }

    /// <summary>
    /// A distillery.
    /// </summary>
    [DataContract]
    public partial class Distillery : FoodEstablishment, IDistillery
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Distillery";
    }
}

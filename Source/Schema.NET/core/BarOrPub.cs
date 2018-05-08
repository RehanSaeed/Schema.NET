namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A bar or pub.
    /// </summary>
    public partial interface IBarOrPub : IFoodEstablishment
    {
    }

    /// <summary>
    /// A bar or pub.
    /// </summary>
    [DataContract]
    public partial class BarOrPub : FoodEstablishment, IBarOrPub
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BarOrPub";
    }
}

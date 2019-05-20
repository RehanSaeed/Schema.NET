namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A motorcycle dealer.
    /// </summary>
    public partial interface IMotorcycleDealer : IAutomotiveBusiness
    {
    }

    /// <summary>
    /// A motorcycle dealer.
    /// </summary>
    [DataContract]
    public partial class MotorcycleDealer : AutomotiveBusiness, IMotorcycleDealer
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MotorcycleDealer";
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of swallowing liquids.
    /// </summary>
    public partial interface IDrinkAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of swallowing liquids.
    /// </summary>
    [DataContract]
    public partial class DrinkAction : ConsumeAction, IDrinkAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DrinkAction";
    }
}

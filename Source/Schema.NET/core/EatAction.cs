namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of swallowing solid objects.
    /// </summary>
    public partial interface IEatAction : IConsumeAction
    {
    }

    /// <summary>
    /// The act of swallowing solid objects.
    /// </summary>
    [DataContract]
    public partial class EatAction : ConsumeAction, IEatAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EatAction";
    }
}

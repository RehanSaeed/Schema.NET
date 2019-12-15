namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent orders a (not yet released) object/product/service to be delivered/sent.
    /// </summary>
    public partial interface IPreOrderAction : ITradeAction
    {
    }

    /// <summary>
    /// An agent orders a (not yet released) object/product/service to be delivered/sent.
    /// </summary>
    [DataContract]
    public partial class PreOrderAction : TradeAction, IPreOrderAction, IEquatable<PreOrderAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PreOrderAction";
    }
}

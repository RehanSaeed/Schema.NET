namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An agent orders a (not yet released) object/product/service to be delivered/sent.
    /// </summary>
    [DataContract]
    public class PreOrderAction : TradeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PreOrderAction";
    }
}

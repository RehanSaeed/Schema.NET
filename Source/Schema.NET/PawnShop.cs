namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A shop that will buy, or lend money against the security of, personal possessions.
    /// </summary>
    [DataContract]
    public class PawnShop : Store
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PawnShop";
    }
}

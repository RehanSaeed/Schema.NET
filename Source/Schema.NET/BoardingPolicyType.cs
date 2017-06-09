namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A type of boarding policy used by an airline.
    /// </summary>
    [DataContract]
    public class BoardingPolicyType : Enumeration
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BoardingPolicyType";
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// ATM/cash machine.
    /// </summary>
    [DataContract]
    public class AutomatedTeller : FinancialService
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "AutomatedTeller";
    }
}

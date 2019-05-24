namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// ATM/cash machine.
    /// </summary>
    public partial interface IAutomatedTeller : IFinancialService
    {
    }

    /// <summary>
    /// ATM/cash machine.
    /// </summary>
    [DataContract]
    public partial class AutomatedTeller : FinancialService, IAutomatedTeller
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutomatedTeller";
    }
}

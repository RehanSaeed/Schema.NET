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
    public partial class AutomatedTeller : FinancialService, IAutomatedTeller, IEquatable<AutomatedTeller>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AutomatedTeller";

        /// <inheritdoc/>
        public bool Equals(AutomatedTeller other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as AutomatedTeller);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

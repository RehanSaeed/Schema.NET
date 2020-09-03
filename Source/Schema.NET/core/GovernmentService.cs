namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    /// </summary>
    public partial interface IGovernmentService : IService
    {
        /// <summary>
        /// Indicates a legal jurisdiction, e.g. of some legislation, or where some government service is based.
        /// </summary>
        Values<IAdministrativeArea, string> Jurisdiction { get; set; }

        /// <summary>
        /// The operating organization, if different from the provider.  This enables the representation of services that are provided by an organization, but operated by another organization like a subcontractor.
        /// </summary>
        OneOrMany<IOrganization> ServiceOperator { get; set; }
    }

    /// <summary>
    /// A service provided by a government organization, e.g. food stamps, veterans benefits, etc.
    /// </summary>
    [DataContract]
    public partial class GovernmentService : Service, IGovernmentService, IEquatable<GovernmentService>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "GovernmentService";

        /// <summary>
        /// Indicates a legal jurisdiction, e.g. of some legislation, or where some government service is based.
        /// </summary>
        [DataMember(Name = "jurisdiction", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IAdministrativeArea, string> Jurisdiction { get; set; }

        /// <summary>
        /// The operating organization, if different from the provider.  This enables the representation of services that are provided by an organization, but operated by another organization like a subcontractor.
        /// </summary>
        [DataMember(Name = "serviceOperator", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IOrganization> ServiceOperator { get; set; }

        /// <inheritdoc/>
        public bool Equals(GovernmentService other)
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
                this.Jurisdiction == other.Jurisdiction &&
                this.ServiceOperator == other.ServiceOperator &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as GovernmentService);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Jurisdiction)
            .And(this.ServiceOperator)
            .And(base.GetHashCode());
    }
}

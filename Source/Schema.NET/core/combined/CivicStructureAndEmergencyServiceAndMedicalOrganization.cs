namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// See CivicStructure, EmergencyService, MedicalOrganization for more information.
    /// </summary>
    public partial interface ICivicStructureAndEmergencyServiceAndMedicalOrganization : ICivicStructure, IEmergencyService, IMedicalOrganization
    {
    }

    /// <summary>
    /// See CivicStructure, EmergencyService, MedicalOrganization for more information.
    /// </summary>
    [DataContract]
    public abstract partial class CivicStructureAndEmergencyServiceAndMedicalOrganization : LocalBusinessAndOrganizationAndPlace, ICivicStructureAndEmergencyServiceAndMedicalOrganization, IEquatable<CivicStructureAndEmergencyServiceAndMedicalOrganization>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CivicStructureAndEmergencyServiceAndMedicalOrganization";

        /// <summary>
        /// Name or unique ID of network. (Networks are often reused across different insurance plans).
        /// </summary>
        [DataMember(Name = "healthPlanNetworkId", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> HealthPlanNetworkId { get; set; }

        /// <summary>
        /// Whether the provider is accepting new patients.
        /// </summary>
        [DataMember(Name = "isAcceptingNewPatients", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<bool?> IsAcceptingNewPatients { get; set; }

        /// <summary>
        /// A medical specialty of the provider.
        /// </summary>
        [DataMember(Name = "medicalSpecialty", Order = 308)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public virtual OneOrMany<MedicalSpecialty?> MedicalSpecialty { get; set; }

        /// <summary>
        /// The general opening hours for a business. Opening hours can be specified as a weekly time range, starting with days, then times per day. Multiple days can be listed with commas ',' separating each day. Day or time ranges are specified using a hyphen '-'.&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Days are specified using the following two-letter combinations: &lt;code&gt;Mo&lt;/code&gt;, &lt;code&gt;Tu&lt;/code&gt;, &lt;code&gt;We&lt;/code&gt;, &lt;code&gt;Th&lt;/code&gt;, &lt;code&gt;Fr&lt;/code&gt;, &lt;code&gt;Sa&lt;/code&gt;, &lt;code&gt;Su&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;Times are specified using 24:00 time. For example, 3pm is specified as &lt;code&gt;15:00&lt;/code&gt;. &lt;/li&gt;
        /// &lt;li&gt;Here is an example: &lt;code&gt;&amp;lt;time itemprop="openingHours" datetime=&amp;quot;Tu,Th 16:00-20:00&amp;quot;&amp;gt;Tuesdays and Thursdays 4-8pm&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;li&gt;If a business is open 7 days a week, then it can be specified as &lt;code&gt;&amp;lt;time itemprop=&amp;quot;openingHours&amp;quot; datetime=&amp;quot;Mo-Su&amp;quot;&amp;gt;Monday through Sunday, all day&amp;lt;/time&amp;gt;&lt;/code&gt;.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "openingHours", Order = 309)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public override OneOrMany<string> OpeningHours { get; set; }

        /// <inheritdoc/>
        public bool Equals(CivicStructureAndEmergencyServiceAndMedicalOrganization other)
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
                this.HealthPlanNetworkId == other.HealthPlanNetworkId &&
                this.IsAcceptingNewPatients == other.IsAcceptingNewPatients &&
                this.MedicalSpecialty == other.MedicalSpecialty &&
                this.OpeningHours == other.OpeningHours &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as CivicStructureAndEmergencyServiceAndMedicalOrganization);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.HealthPlanNetworkId)
            .And(this.IsAcceptingNewPatients)
            .And(this.MedicalSpecialty)
            .And(this.OpeningHours)
            .And(base.GetHashCode());
    }
}

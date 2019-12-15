﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Original definition: "provider of professional services."&lt;br/&gt;&lt;br/&gt;
    /// The general &lt;a class="localLink" href="http://schema.org/ProfessionalService"&gt;ProfessionalService&lt;/a&gt; type for local businesses was deprecated due to confusion with &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;. For reference, the types that it included were: &lt;a class="localLink" href="http://schema.org/Dentist"&gt;Dentist&lt;/a&gt;,
    ///         &lt;a class="localLink" href="http://schema.org/AccountingService"&gt;AccountingService&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Attorney"&gt;Attorney&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Notary"&gt;Notary&lt;/a&gt;, as well as types for several kinds of &lt;a class="localLink" href="http://schema.org/HomeAndConstructionBusiness"&gt;HomeAndConstructionBusiness&lt;/a&gt;: &lt;a class="localLink" href="http://schema.org/Electrician"&gt;Electrician&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/GeneralContractor"&gt;GeneralContractor&lt;/a&gt;,
    ///         &lt;a class="localLink" href="http://schema.org/HousePainter"&gt;HousePainter&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Locksmith"&gt;Locksmith&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Plumber"&gt;Plumber&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/RoofingContractor"&gt;RoofingContractor&lt;/a&gt;. &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; was introduced as a more inclusive supertype of &lt;a class="localLink" href="http://schema.org/Attorney"&gt;Attorney&lt;/a&gt;.
    /// </summary>
    public partial interface IProfessionalService : ILocalBusiness
    {
    }

    /// <summary>
    /// Original definition: "provider of professional services."&lt;br/&gt;&lt;br/&gt;
    /// The general &lt;a class="localLink" href="http://schema.org/ProfessionalService"&gt;ProfessionalService&lt;/a&gt; type for local businesses was deprecated due to confusion with &lt;a class="localLink" href="http://schema.org/Service"&gt;Service&lt;/a&gt;. For reference, the types that it included were: &lt;a class="localLink" href="http://schema.org/Dentist"&gt;Dentist&lt;/a&gt;,
    ///         &lt;a class="localLink" href="http://schema.org/AccountingService"&gt;AccountingService&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Attorney"&gt;Attorney&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Notary"&gt;Notary&lt;/a&gt;, as well as types for several kinds of &lt;a class="localLink" href="http://schema.org/HomeAndConstructionBusiness"&gt;HomeAndConstructionBusiness&lt;/a&gt;: &lt;a class="localLink" href="http://schema.org/Electrician"&gt;Electrician&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/GeneralContractor"&gt;GeneralContractor&lt;/a&gt;,
    ///         &lt;a class="localLink" href="http://schema.org/HousePainter"&gt;HousePainter&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Locksmith"&gt;Locksmith&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/Plumber"&gt;Plumber&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/RoofingContractor"&gt;RoofingContractor&lt;/a&gt;. &lt;a class="localLink" href="http://schema.org/LegalService"&gt;LegalService&lt;/a&gt; was introduced as a more inclusive supertype of &lt;a class="localLink" href="http://schema.org/Attorney"&gt;Attorney&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class ProfessionalService : LocalBusiness, IProfessionalService, IEquatable<ProfessionalService>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ProfessionalService";

        /// <inheritdoc/>
        public bool Equals(ProfessionalService other)
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
        public override bool Equals(object obj) => this.Equals(obj as ProfessionalService);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A bus (also omnibus or autobus) is a road vehicle designed to carry passengers. Coaches are luxury busses, usually in service for long distance travel.
    /// </summary>
    public partial interface IBusOrCoach : IVehicle
    {
        /// <summary>
        /// The ACRISS Car Classification Code is a code used by many car rental companies, for classifying vehicles. ACRISS stands for Association of Car Rental Industry Systems and Standards.
        /// </summary>
        OneOrMany<string> AcrissCode { get; set; }

        /// <summary>
        /// The permitted total weight of cargo and installations (e.g. a roof rack) on top of the vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can indicate additional information in the &lt;a class="localLink" href="https://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You may also link to a &lt;a class="localLink" href="https://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt;&lt;/li&gt;
        /// &lt;li&gt;Note 3: Note that you can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        OneOrMany<IQuantitativeValue> RoofLoad { get; set; }
    }

    /// <summary>
    /// A bus (also omnibus or autobus) is a road vehicle designed to carry passengers. Coaches are luxury busses, usually in service for long distance travel.
    /// </summary>
    [DataContract]
    public partial class BusOrCoach : Vehicle, IBusOrCoach, IEquatable<BusOrCoach>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusOrCoach";

        /// <summary>
        /// The ACRISS Car Classification Code is a code used by many car rental companies, for classifying vehicles. ACRISS stands for Association of Car Rental Industry Systems and Standards.
        /// </summary>
        [DataMember(Name = "acrissCode", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> AcrissCode { get; set; }

        /// <summary>
        /// The permitted total weight of cargo and installations (e.g. a roof rack) on top of the vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can indicate additional information in the &lt;a class="localLink" href="https://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="https://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You may also link to a &lt;a class="localLink" href="https://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="https://schema.org/valueReference"&gt;valueReference&lt;/a&gt;&lt;/li&gt;
        /// &lt;li&gt;Note 3: Note that you can use &lt;a class="localLink" href="https://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="https://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "roofLoad", Order = 307)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IQuantitativeValue> RoofLoad { get; set; }

        /// <inheritdoc/>
        public bool Equals(BusOrCoach other)
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
                this.AcrissCode == other.AcrissCode &&
                this.RoofLoad == other.RoofLoad &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as BusOrCoach);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.AcrissCode)
            .And(this.RoofLoad)
            .And(base.GetHashCode());
    }
}

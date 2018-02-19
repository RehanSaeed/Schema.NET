using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A bus (also omnibus or autobus) is a road vehicle designed to carry passengers. Coaches are luxury busses, usually in service for long distance travel.
    /// </summary>
    [DataContract]
    public partial class BusOrCoach : Vehicle
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
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? AcrissCode { get; set; } 

        /// <summary>
        /// &lt;p&gt;The permitted total weight of cargo and installations (e.g. a roof rack) on top of the vehicle.&lt;/p&gt;
        /// &lt;p&gt;Typical unit code(s): KGM for kilogram, LBR for pound&lt;/p&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can indicate additional information in the &lt;a class="localLink" href="http://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You may also link to a &lt;a class="localLink" href="http://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt;&lt;/li&gt;
        /// &lt;li&gt;Note 3: Note that you can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "roofLoad", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<QuantitativeValue>? RoofLoad { get; set; } 
    }
}

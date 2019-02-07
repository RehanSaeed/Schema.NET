namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A bus (also omnibus or autobus) is a road vehicle designed to carry passengers. Coaches are luxury busses, usually in service for long distance travel.
    /// </summary>
    [DataContract]
    public partial class BusOrCoach : Vehicle
    {
        public interface IAcrissCode : IValue {}
        public interface IAcrissCode<T> : IAcrissCode { new T Value { get; } }
        public class OneOrManyAcrissCode : OneOrMany<IAcrissCode>
        {
            public OneOrManyAcrissCode(IAcrissCode item) : base(item) { }
            public OneOrManyAcrissCode(IEnumerable<IAcrissCode> items) : base(items) { }
            public static implicit operator OneOrManyAcrissCode (string value) { return new OneOrManyAcrissCode (new AcrissCodestring (value)); }
            public static implicit operator OneOrManyAcrissCode (string[] values) { return new OneOrManyAcrissCode (values.Select(v => (IAcrissCode) new AcrissCodestring (v))); }
            public static implicit operator OneOrManyAcrissCode (List<string> values) { return new OneOrManyAcrissCode (values.Select(v => (IAcrissCode) new AcrissCodestring (v))); }
        }
        public struct AcrissCodestring : IAcrissCode<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public AcrissCodestring (string value) { Value = value; }
            public static implicit operator AcrissCodestring (string value) { return new AcrissCodestring (value); }
        }

        public interface IRoofLoad : IValue {}
        public interface IRoofLoad<T> : IRoofLoad { new T Value { get; } }
        public class OneOrManyRoofLoad : OneOrMany<IRoofLoad>
        {
            public OneOrManyRoofLoad(IRoofLoad item) : base(item) { }
            public OneOrManyRoofLoad(IEnumerable<IRoofLoad> items) : base(items) { }
            public static implicit operator OneOrManyRoofLoad (QuantitativeValue value) { return new OneOrManyRoofLoad (new RoofLoadQuantitativeValue (value)); }
            public static implicit operator OneOrManyRoofLoad (QuantitativeValue[] values) { return new OneOrManyRoofLoad (values.Select(v => (IRoofLoad) new RoofLoadQuantitativeValue (v))); }
            public static implicit operator OneOrManyRoofLoad (List<QuantitativeValue> values) { return new OneOrManyRoofLoad (values.Select(v => (IRoofLoad) new RoofLoadQuantitativeValue (v))); }
        }
        public struct RoofLoadQuantitativeValue : IRoofLoad<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public RoofLoadQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator RoofLoadQuantitativeValue (QuantitativeValue value) { return new RoofLoadQuantitativeValue (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusOrCoach";

        /// <summary>
        /// The ACRISS Car Classification Code is a code used by many car rental companies, for classifying vehicles. ACRISS stands for Association of Car Rental Industry Systems and Standards.
        /// </summary>
        [DataMember(Name = "acrissCode", Order = 306)]
        public OneOrManyAcrissCode AcrissCode { get; set; }

        /// <summary>
        /// The permitted total weight of cargo and installations (e.g. a roof rack) on top of the vehicle.&lt;br/&gt;&lt;br/&gt;
        /// Typical unit code(s): KGM for kilogram, LBR for pound&lt;br/&gt;&lt;br/&gt;
        /// &lt;ul&gt;
        /// &lt;li&gt;Note 1: You can indicate additional information in the &lt;a class="localLink" href="http://schema.org/name"&gt;name&lt;/a&gt; of the &lt;a class="localLink" href="http://schema.org/QuantitativeValue"&gt;QuantitativeValue&lt;/a&gt; node.&lt;/li&gt;
        /// &lt;li&gt;Note 2: You may also link to a &lt;a class="localLink" href="http://schema.org/QualitativeValue"&gt;QualitativeValue&lt;/a&gt; node that provides additional information using &lt;a class="localLink" href="http://schema.org/valueReference"&gt;valueReference&lt;/a&gt;&lt;/li&gt;
        /// &lt;li&gt;Note 3: Note that you can use &lt;a class="localLink" href="http://schema.org/minValue"&gt;minValue&lt;/a&gt; and &lt;a class="localLink" href="http://schema.org/maxValue"&gt;maxValue&lt;/a&gt; to indicate ranges.&lt;/li&gt;
        /// &lt;/ul&gt;
        /// </summary>
        [DataMember(Name = "roofLoad", Order = 307)]
        public OneOrManyRoofLoad RoofLoad { get; set; }
    }
}

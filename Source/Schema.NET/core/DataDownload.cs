namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A dataset in downloadable form.
    /// </summary>
    [DataContract]
    public partial class DataDownload : MediaObject
    {
        public interface IMeasurementTechnique : IValue {}
        public interface IMeasurementTechnique<T> : IMeasurementTechnique { new T Value { get; } }
        public class OneOrManyMeasurementTechnique : OneOrMany<IMeasurementTechnique>
        {
            public OneOrManyMeasurementTechnique(IMeasurementTechnique item) : base(item) { }
            public OneOrManyMeasurementTechnique(IEnumerable<IMeasurementTechnique> items) : base(items) { }
            public static implicit operator OneOrManyMeasurementTechnique (string value) { return new OneOrManyMeasurementTechnique (new MeasurementTechniquestring (value)); }
            public static implicit operator OneOrManyMeasurementTechnique (string[] values) { return new OneOrManyMeasurementTechnique (values.Select(v => (IMeasurementTechnique) new MeasurementTechniquestring (v))); }
            public static implicit operator OneOrManyMeasurementTechnique (List<string> values) { return new OneOrManyMeasurementTechnique (values.Select(v => (IMeasurementTechnique) new MeasurementTechniquestring (v))); }
            public static implicit operator OneOrManyMeasurementTechnique (Uri value) { return new OneOrManyMeasurementTechnique (new MeasurementTechniqueUri (value)); }
            public static implicit operator OneOrManyMeasurementTechnique (Uri[] values) { return new OneOrManyMeasurementTechnique (values.Select(v => (IMeasurementTechnique) new MeasurementTechniqueUri (v))); }
            public static implicit operator OneOrManyMeasurementTechnique (List<Uri> values) { return new OneOrManyMeasurementTechnique (values.Select(v => (IMeasurementTechnique) new MeasurementTechniqueUri (v))); }
        }
        public struct MeasurementTechniquestring : IMeasurementTechnique<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public MeasurementTechniquestring (string value) { Value = value; }
            public static implicit operator MeasurementTechniquestring (string value) { return new MeasurementTechniquestring (value); }
        }
        public struct MeasurementTechniqueUri : IMeasurementTechnique<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public MeasurementTechniqueUri (Uri value) { Value = value; }
            public static implicit operator MeasurementTechniqueUri (Uri value) { return new MeasurementTechniqueUri (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataDownload";

        /// <summary>
        /// A technique or technology used in a &lt;a class="localLink" href="http://schema.org/Dataset"&gt;Dataset&lt;/a&gt; (or &lt;a class="localLink" href="http://schema.org/DataDownload"&gt;DataDownload&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/DataCatalog"&gt;DataCatalog&lt;/a&gt;),
        /// corresponding to the method used for measuring the corresponding variable(s) (described using &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt;). This is oriented towards scientific and scholarly dataset publication but may have broader applicability; it is not intended as a full representation of measurement, but rather as a high level summary for dataset discovery.&lt;br/&gt;&lt;br/&gt;
        /// For example, if &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is: molecule concentration, &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be: "mass spectrometry" or "nmr spectroscopy" or "colorimetry" or "immunofluorescence".&lt;br/&gt;&lt;br/&gt;
        /// If the &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is "depression rating", the &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be "Zung Scale" or "HAM-D" or "Beck Depression Inventory".&lt;br/&gt;&lt;br/&gt;
        /// If there are several &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; properties recorded for some given data object, use a &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt; for each &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; and attach the corresponding &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "measurementTechnique", Order = 306)]
        public OneOrManyMeasurementTechnique MeasurementTechnique { get; set; }
    }
}

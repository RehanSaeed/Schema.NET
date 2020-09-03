namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A collection of datasets.
    /// </summary>
    public partial interface IDataCatalog : ICreativeWork
    {
        /// <summary>
        /// A dataset contained in this catalog.
        /// </summary>
        OneOrMany<IDataset> Dataset { get; set; }

        /// <summary>
        /// A technique or technology used in a &lt;a class="localLink" href="https://schema.org/Dataset"&gt;Dataset&lt;/a&gt; (or &lt;a class="localLink" href="https://schema.org/DataDownload"&gt;DataDownload&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/DataCatalog"&gt;DataCatalog&lt;/a&gt;),
        /// corresponding to the method used for measuring the corresponding variable(s) (described using &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt;). This is oriented towards scientific and scholarly dataset publication but may have broader applicability; it is not intended as a full representation of measurement, but rather as a high level summary for dataset discovery.&lt;br/&gt;&lt;br/&gt;
        /// For example, if &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is: molecule concentration, &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be: "mass spectrometry" or "nmr spectroscopy" or "colorimetry" or "immunofluorescence".&lt;br/&gt;&lt;br/&gt;
        /// If the &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is "depression rating", the &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be "Zung Scale" or "HAM-D" or "Beck Depression Inventory".&lt;br/&gt;&lt;br/&gt;
        /// If there are several &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; properties recorded for some given data object, use a &lt;a class="localLink" href="https://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt; for each &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; and attach the corresponding &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt;.
        /// </summary>
        Values<string, Uri> MeasurementTechnique { get; set; }
    }

    /// <summary>
    /// A collection of datasets.
    /// </summary>
    [DataContract]
    public partial class DataCatalog : CreativeWork, IDataCatalog, IEquatable<DataCatalog>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DataCatalog";

        /// <summary>
        /// A dataset contained in this catalog.
        /// </summary>
        [DataMember(Name = "dataset", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDataset> Dataset { get; set; }

        /// <summary>
        /// A technique or technology used in a &lt;a class="localLink" href="https://schema.org/Dataset"&gt;Dataset&lt;/a&gt; (or &lt;a class="localLink" href="https://schema.org/DataDownload"&gt;DataDownload&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/DataCatalog"&gt;DataCatalog&lt;/a&gt;),
        /// corresponding to the method used for measuring the corresponding variable(s) (described using &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt;). This is oriented towards scientific and scholarly dataset publication but may have broader applicability; it is not intended as a full representation of measurement, but rather as a high level summary for dataset discovery.&lt;br/&gt;&lt;br/&gt;
        /// For example, if &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is: molecule concentration, &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be: "mass spectrometry" or "nmr spectroscopy" or "colorimetry" or "immunofluorescence".&lt;br/&gt;&lt;br/&gt;
        /// If the &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is "depression rating", the &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be "Zung Scale" or "HAM-D" or "Beck Depression Inventory".&lt;br/&gt;&lt;br/&gt;
        /// If there are several &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; properties recorded for some given data object, use a &lt;a class="localLink" href="https://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt; for each &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; and attach the corresponding &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "measurementTechnique", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> MeasurementTechnique { get; set; }

        /// <inheritdoc/>
        public bool Equals(DataCatalog other)
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
                this.Dataset == other.Dataset &&
                this.MeasurementTechnique == other.MeasurementTechnique &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as DataCatalog);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Dataset)
            .And(this.MeasurementTechnique)
            .And(base.GetHashCode());
    }
}

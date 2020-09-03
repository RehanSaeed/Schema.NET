namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
    public partial interface IDataset : ICreativeWork
    {
        /// <summary>
        /// A downloadable form of this dataset, at a specific location, in a specific format.
        /// </summary>
        OneOrMany<IDataDownload> Distribution { get; set; }

        /// <summary>
        /// A data catalog which contains this dataset.
        /// </summary>
        OneOrMany<IDataCatalog> IncludedInDataCatalog { get; set; }

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        OneOrMany<string> Issn { get; set; }

        /// <summary>
        /// A technique or technology used in a &lt;a class="localLink" href="https://schema.org/Dataset"&gt;Dataset&lt;/a&gt; (or &lt;a class="localLink" href="https://schema.org/DataDownload"&gt;DataDownload&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/DataCatalog"&gt;DataCatalog&lt;/a&gt;),
        /// corresponding to the method used for measuring the corresponding variable(s) (described using &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt;). This is oriented towards scientific and scholarly dataset publication but may have broader applicability; it is not intended as a full representation of measurement, but rather as a high level summary for dataset discovery.&lt;br/&gt;&lt;br/&gt;
        /// For example, if &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is: molecule concentration, &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be: "mass spectrometry" or "nmr spectroscopy" or "colorimetry" or "immunofluorescence".&lt;br/&gt;&lt;br/&gt;
        /// If the &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is "depression rating", the &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be "Zung Scale" or "HAM-D" or "Beck Depression Inventory".&lt;br/&gt;&lt;br/&gt;
        /// If there are several &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; properties recorded for some given data object, use a &lt;a class="localLink" href="https://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt; for each &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; and attach the corresponding &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt;.
        /// </summary>
        Values<string, Uri> MeasurementTechnique { get; set; }

        /// <summary>
        /// The variableMeasured property can indicate (repeated as necessary) the  variables that are measured in some dataset, either described as text or as pairs of identifier and description using PropertyValue.
        /// </summary>
        Values<IPropertyValue, string> VariableMeasured { get; set; }

        /// <summary>
        /// Originally named &lt;a class="localLink" href="https://schema.org/variablesMeasured"&gt;variablesMeasured&lt;/a&gt;, The &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; property can indicate (repeated as necessary) the  variables that are measured in some dataset, either described as text or as pairs of identifier and description using PropertyValue.
        /// </summary>
        Values<IPropertyValue, string> VariablesMeasured { get; set; }
    }

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
    [DataContract]
    public partial class Dataset : CreativeWork, IDataset, IEquatable<Dataset>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Dataset";

        /// <summary>
        /// A downloadable form of this dataset, at a specific location, in a specific format.
        /// </summary>
        [DataMember(Name = "distribution", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDataDownload> Distribution { get; set; }

        /// <summary>
        /// A data catalog which contains this dataset.
        /// </summary>
        [DataMember(Name = "includedInDataCatalog", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IDataCatalog> IncludedInDataCatalog { get; set; }

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        [DataMember(Name = "issn", Order = 208)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<string> Issn { get; set; }

        /// <summary>
        /// A technique or technology used in a &lt;a class="localLink" href="https://schema.org/Dataset"&gt;Dataset&lt;/a&gt; (or &lt;a class="localLink" href="https://schema.org/DataDownload"&gt;DataDownload&lt;/a&gt;, &lt;a class="localLink" href="https://schema.org/DataCatalog"&gt;DataCatalog&lt;/a&gt;),
        /// corresponding to the method used for measuring the corresponding variable(s) (described using &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt;). This is oriented towards scientific and scholarly dataset publication but may have broader applicability; it is not intended as a full representation of measurement, but rather as a high level summary for dataset discovery.&lt;br/&gt;&lt;br/&gt;
        /// For example, if &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is: molecule concentration, &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be: "mass spectrometry" or "nmr spectroscopy" or "colorimetry" or "immunofluorescence".&lt;br/&gt;&lt;br/&gt;
        /// If the &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is "depression rating", the &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be "Zung Scale" or "HAM-D" or "Beck Depression Inventory".&lt;br/&gt;&lt;br/&gt;
        /// If there are several &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; properties recorded for some given data object, use a &lt;a class="localLink" href="https://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt; for each &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; and attach the corresponding &lt;a class="localLink" href="https://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "measurementTechnique", Order = 209)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<string, Uri> MeasurementTechnique { get; set; }

        /// <summary>
        /// The variableMeasured property can indicate (repeated as necessary) the  variables that are measured in some dataset, either described as text or as pairs of identifier and description using PropertyValue.
        /// </summary>
        [DataMember(Name = "variableMeasured", Order = 210)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPropertyValue, string> VariableMeasured { get; set; }

        /// <summary>
        /// Originally named &lt;a class="localLink" href="https://schema.org/variablesMeasured"&gt;variablesMeasured&lt;/a&gt;, The &lt;a class="localLink" href="https://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; property can indicate (repeated as necessary) the  variables that are measured in some dataset, either described as text or as pairs of identifier and description using PropertyValue.
        /// </summary>
        [DataMember(Name = "variablesMeasured", Order = 211)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IPropertyValue, string> VariablesMeasured { get; set; }

        /// <inheritdoc/>
        public bool Equals(Dataset other)
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
                this.Distribution == other.Distribution &&
                this.IncludedInDataCatalog == other.IncludedInDataCatalog &&
                this.Issn == other.Issn &&
                this.MeasurementTechnique == other.MeasurementTechnique &&
                this.VariableMeasured == other.VariableMeasured &&
                this.VariablesMeasured == other.VariablesMeasured &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as Dataset);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Distribution)
            .And(this.IncludedInDataCatalog)
            .And(this.Issn)
            .And(this.MeasurementTechnique)
            .And(this.VariableMeasured)
            .And(this.VariablesMeasured)
            .And(base.GetHashCode());
    }
}

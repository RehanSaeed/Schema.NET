namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A body of structured information describing some topic(s) of interest.
    /// </summary>
    [DataContract]
    public partial class Dataset : CreativeWork
    {
        public interface IDistribution : IValue {}
        public interface IDistribution<T> : IDistribution { new T Value { get; } }
        public class OneOrManyDistribution : OneOrMany<IDistribution>
        {
            public OneOrManyDistribution(IDistribution item) : base(item) { }
            public OneOrManyDistribution(IEnumerable<IDistribution> items) : base(items) { }
            public static implicit operator OneOrManyDistribution (DataDownload value) { return new OneOrManyDistribution (new DistributionDataDownload (value)); }
            public static implicit operator OneOrManyDistribution (DataDownload[] values) { return new OneOrManyDistribution (values.Select(v => (IDistribution) new DistributionDataDownload (v))); }
            public static implicit operator OneOrManyDistribution (List<DataDownload> values) { return new OneOrManyDistribution (values.Select(v => (IDistribution) new DistributionDataDownload (v))); }
        }
        public struct DistributionDataDownload : IDistribution<DataDownload>
        {
            object IValue.Value => this.Value;
            public DataDownload Value { get; }
            public DistributionDataDownload (DataDownload value) { Value = value; }
            public static implicit operator DistributionDataDownload (DataDownload value) { return new DistributionDataDownload (value); }
        }

        public interface IIncludedInDataCatalog : IValue {}
        public interface IIncludedInDataCatalog<T> : IIncludedInDataCatalog { new T Value { get; } }
        public class OneOrManyIncludedInDataCatalog : OneOrMany<IIncludedInDataCatalog>
        {
            public OneOrManyIncludedInDataCatalog(IIncludedInDataCatalog item) : base(item) { }
            public OneOrManyIncludedInDataCatalog(IEnumerable<IIncludedInDataCatalog> items) : base(items) { }
            public static implicit operator OneOrManyIncludedInDataCatalog (DataCatalog value) { return new OneOrManyIncludedInDataCatalog (new IncludedInDataCatalogDataCatalog (value)); }
            public static implicit operator OneOrManyIncludedInDataCatalog (DataCatalog[] values) { return new OneOrManyIncludedInDataCatalog (values.Select(v => (IIncludedInDataCatalog) new IncludedInDataCatalogDataCatalog (v))); }
            public static implicit operator OneOrManyIncludedInDataCatalog (List<DataCatalog> values) { return new OneOrManyIncludedInDataCatalog (values.Select(v => (IIncludedInDataCatalog) new IncludedInDataCatalogDataCatalog (v))); }
        }
        public struct IncludedInDataCatalogDataCatalog : IIncludedInDataCatalog<DataCatalog>
        {
            object IValue.Value => this.Value;
            public DataCatalog Value { get; }
            public IncludedInDataCatalogDataCatalog (DataCatalog value) { Value = value; }
            public static implicit operator IncludedInDataCatalogDataCatalog (DataCatalog value) { return new IncludedInDataCatalogDataCatalog (value); }
        }

        public interface IIssn : IValue {}
        public interface IIssn<T> : IIssn { new T Value { get; } }
        public class OneOrManyIssn : OneOrMany<IIssn>
        {
            public OneOrManyIssn(IIssn item) : base(item) { }
            public OneOrManyIssn(IEnumerable<IIssn> items) : base(items) { }
            public static implicit operator OneOrManyIssn (string value) { return new OneOrManyIssn (new Issnstring (value)); }
            public static implicit operator OneOrManyIssn (string[] values) { return new OneOrManyIssn (values.Select(v => (IIssn) new Issnstring (v))); }
            public static implicit operator OneOrManyIssn (List<string> values) { return new OneOrManyIssn (values.Select(v => (IIssn) new Issnstring (v))); }
        }
        public struct Issnstring : IIssn<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Issnstring (string value) { Value = value; }
            public static implicit operator Issnstring (string value) { return new Issnstring (value); }
        }

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

        public interface IVariableMeasured : IValue {}
        public interface IVariableMeasured<T> : IVariableMeasured { new T Value { get; } }
        public class OneOrManyVariableMeasured : OneOrMany<IVariableMeasured>
        {
            public OneOrManyVariableMeasured(IVariableMeasured item) : base(item) { }
            public OneOrManyVariableMeasured(IEnumerable<IVariableMeasured> items) : base(items) { }
            public static implicit operator OneOrManyVariableMeasured (PropertyValue value) { return new OneOrManyVariableMeasured (new VariableMeasuredPropertyValue (value)); }
            public static implicit operator OneOrManyVariableMeasured (PropertyValue[] values) { return new OneOrManyVariableMeasured (values.Select(v => (IVariableMeasured) new VariableMeasuredPropertyValue (v))); }
            public static implicit operator OneOrManyVariableMeasured (List<PropertyValue> values) { return new OneOrManyVariableMeasured (values.Select(v => (IVariableMeasured) new VariableMeasuredPropertyValue (v))); }
            public static implicit operator OneOrManyVariableMeasured (string value) { return new OneOrManyVariableMeasured (new VariableMeasuredstring (value)); }
            public static implicit operator OneOrManyVariableMeasured (string[] values) { return new OneOrManyVariableMeasured (values.Select(v => (IVariableMeasured) new VariableMeasuredstring (v))); }
            public static implicit operator OneOrManyVariableMeasured (List<string> values) { return new OneOrManyVariableMeasured (values.Select(v => (IVariableMeasured) new VariableMeasuredstring (v))); }
        }
        public struct VariableMeasuredPropertyValue : IVariableMeasured<PropertyValue>
        {
            object IValue.Value => this.Value;
            public PropertyValue Value { get; }
            public VariableMeasuredPropertyValue (PropertyValue value) { Value = value; }
            public static implicit operator VariableMeasuredPropertyValue (PropertyValue value) { return new VariableMeasuredPropertyValue (value); }
        }
        public struct VariableMeasuredstring : IVariableMeasured<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VariableMeasuredstring (string value) { Value = value; }
            public static implicit operator VariableMeasuredstring (string value) { return new VariableMeasuredstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Dataset";

        /// <summary>
        /// A downloadable form of this dataset, at a specific location, in a specific format.
        /// </summary>
        [DataMember(Name = "distribution", Order = 206)]
        public OneOrManyDistribution Distribution { get; set; }

        /// <summary>
        /// A data catalog which contains this dataset.
        /// </summary>
        [DataMember(Name = "includedInDataCatalog", Order = 207)]
        public OneOrManyIncludedInDataCatalog IncludedInDataCatalog { get; set; }

        /// <summary>
        /// The International Standard Serial Number (ISSN) that identifies this serial publication. You can repeat this property to identify different formats of, or the linking ISSN (ISSN-L) for, this serial publication.
        /// </summary>
        [DataMember(Name = "issn", Order = 208)]
        public OneOrManyIssn Issn { get; set; }

        /// <summary>
        /// A technique or technology used in a &lt;a class="localLink" href="http://schema.org/Dataset"&gt;Dataset&lt;/a&gt; (or &lt;a class="localLink" href="http://schema.org/DataDownload"&gt;DataDownload&lt;/a&gt;, &lt;a class="localLink" href="http://schema.org/DataCatalog"&gt;DataCatalog&lt;/a&gt;),
        /// corresponding to the method used for measuring the corresponding variable(s) (described using &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt;). This is oriented towards scientific and scholarly dataset publication but may have broader applicability; it is not intended as a full representation of measurement, but rather as a high level summary for dataset discovery.&lt;br/&gt;&lt;br/&gt;
        /// For example, if &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is: molecule concentration, &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be: "mass spectrometry" or "nmr spectroscopy" or "colorimetry" or "immunofluorescence".&lt;br/&gt;&lt;br/&gt;
        /// If the &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; is "depression rating", the &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt; could be "Zung Scale" or "HAM-D" or "Beck Depression Inventory".&lt;br/&gt;&lt;br/&gt;
        /// If there are several &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; properties recorded for some given data object, use a &lt;a class="localLink" href="http://schema.org/PropertyValue"&gt;PropertyValue&lt;/a&gt; for each &lt;a class="localLink" href="http://schema.org/variableMeasured"&gt;variableMeasured&lt;/a&gt; and attach the corresponding &lt;a class="localLink" href="http://schema.org/measurementTechnique"&gt;measurementTechnique&lt;/a&gt;.
        /// </summary>
        [DataMember(Name = "measurementTechnique", Order = 209)]
        public OneOrManyMeasurementTechnique MeasurementTechnique { get; set; }

        /// <summary>
        /// The variableMeasured property can indicate (repeated as necessary) the  variables that are measured in some dataset, either described as text or as pairs of identifier and description using PropertyValue.
        /// </summary>
        [DataMember(Name = "variableMeasured", Order = 210)]
        public OneOrManyVariableMeasured VariableMeasured { get; set; }
    }
}

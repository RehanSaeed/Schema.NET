namespace Schema.NET.Benchmarks
{
    using System;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Jobs;
    using Newtonsoft.Json;

    [KeepBenchmarkFiles]
    [MemoryDiagnoser]
    [MinColumn]
    [MaxColumn]
    [HtmlExporter]
    [CsvMeasurementsExporter]
    [RPlotExporter]
    [SimpleJob(RuntimeMoniker.Net472)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    public abstract class SchemaBenchmarkBase
    {
        protected Thing Thing { get; set; }

        private Type ThingType { get; set; }

        private string SerializedThing { get; set; }

        [Benchmark]
        public string Serialize() => this.Thing.ToString();

        [Benchmark]
        public object Deserialize() => JsonConvert.DeserializeObject(this.SerializedThing, this.ThingType);

        protected void ConfigureBenchmark(Thing thing)
        {
            this.Thing = thing ?? throw new ArgumentNullException(nameof(thing));
            this.ThingType = this.Thing.GetType();
            this.SerializedThing = this.Thing.ToString();
        }
    }
}

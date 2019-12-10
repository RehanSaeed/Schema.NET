namespace Schema.NET.Benchmarks
{
    using System;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Jobs;
    using Newtonsoft.Json;

    [SimpleJob(RuntimeMoniker.NetCoreApp30)]
    [MemoryDiagnoser]
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
            this.Thing = thing;
            this.ThingType = this.Thing.GetType();
            this.SerializedThing = this.Thing.ToString();
        }
    }
}

namespace Schema.NET.Benchmarks;

using System;
using System.Text.Json;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[KeepBenchmarkFiles]
[MemoryDiagnoser]
[MinColumn]
[MaxColumn]
[HtmlExporter]
[CsvMeasurementsExporter]
[RPlotExporter]
[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net472)]
public abstract class SchemaBenchmarkBase
{
    public Thing Thing { get; set; } = default!;

    private Type ThingType { get; set; } = default!;

    private string SerializedThing { get; set; } = default!;

    public abstract Thing InitialiseThing();

    [GlobalSetup]
    public virtual void Setup()
    {
        this.Thing = this.InitialiseThing();
        this.ThingType = this.Thing.GetType();
        this.SerializedThing = this.Thing.ToString();
    }

    [Benchmark]
    public string Serialize() => this.Thing.ToString();

    [Benchmark]
    public object? Deserialize() => JsonSerializer.Deserialize(this.SerializedThing, this.ThingType);
}

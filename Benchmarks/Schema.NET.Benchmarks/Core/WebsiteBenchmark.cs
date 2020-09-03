namespace Schema.NET.Benchmarks.Core
{
    using System;
    using BenchmarkDotNet.Attributes;

    public class WebsiteBenchmark : SchemaBenchmarkBase
    {
        [GlobalSetup]
        public void Setup() => this.ConfigureBenchmark(new WebSite()
        {
            PotentialAction = new SearchAction()
            {
                Target = new Uri("https://example.com/search?&q={query}"),
                QueryInput = "required",
            },
            Url = new Uri("https://example.com"),
        });
    }
}

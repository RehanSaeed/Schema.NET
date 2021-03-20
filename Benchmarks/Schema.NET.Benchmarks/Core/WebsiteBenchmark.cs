namespace Schema.NET.Benchmarks.Core
{
    using System;

    public class WebsiteBenchmark : SchemaBenchmarkBase
    {
        public override Thing InitialiseThing() =>
            new WebSite()
            {
                PotentialAction = new SearchAction()
                {
                    Target = new Uri("https://example.com/search?&q={query}"),
                    QueryInput = "required",
                },
                Url = new Uri("https://example.com"),
            };
    }
}

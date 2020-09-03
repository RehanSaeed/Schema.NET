namespace Schema.NET.Benchmarks.Core
{
    using System;
    using System.Collections.Generic;
    using BenchmarkDotNet.Attributes;

    public class BookBenchmark : SchemaBenchmarkBase
    {
        [GlobalSetup]
        public void Setup() => this.ConfigureBenchmark(new Book()
        {
            Id = new Uri("https://example.com/book/1"),
            Name = "The Catcher in the Rye",
            Author = new Person()
            {
                Name = "J.D. Salinger",
            },
            Url = new Uri("https://www.barnesandnoble.com/store/info/offer/JDSalinger"),
            WorkExample = new List<ICreativeWork>()
            {
                new Book()
                {
                    Isbn = "031676948",
                    BookEdition = "2nd Edition",
                    BookFormat = BookFormatType.Hardcover,
                    PotentialAction = new ReadAction()
                    {
                        Target = new EntryPoint()
                        {
                            UrlTemplate = "https://www.barnesandnoble.com/store/info/offer/0316769487?purchase=true",
                            ActionPlatform = new List<Uri>()
                            {
                                new Uri("https://schema.org/DesktopWebPlatform"),
                                new Uri("https://schema.org/IOSPlatform"),
                                new Uri("https://schema.org/AndroidPlatform"),
                            },
                        },
                        ExpectsAcceptanceOf = new Offer()
                        {
                            Price = 6.99M,
                            PriceCurrency = "USD",
                            EligibleRegion = new Country()
                            {
                                Name = "US",
                            },
                            Availability = ItemAvailability.InStock,
                        },
                    },
                },
                new Book()
                {
                    Isbn = "031676947",
                    BookEdition = "1st Edition",
                    BookFormat = BookFormatType.EBook,
                    PotentialAction = new ReadAction()
                    {
                        Target = new EntryPoint()
                        {
                            UrlTemplate = "https://www.barnesandnoble.com/store/info/offer/031676947?purchase=true",
                            ActionPlatform = new List<Uri>()
                            {
                                new Uri("https://schema.org/DesktopWebPlatform"),
                                new Uri("https://schema.org/IOSPlatform"),
                                new Uri("https://schema.org/AndroidPlatform"),
                            },
                        },
                        ExpectsAcceptanceOf = new Offer()
                        {
                            Price = 1.99M,
                            PriceCurrency = "USD",
                            EligibleRegion = new Country()
                            {
                                Name = "UK",
                            },
                            Availability = ItemAvailability.InStock,
                        },
                    },
                },
            },
        });
    }
}

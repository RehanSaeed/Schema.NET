using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Schema.NET.Test.core
{
    public class OfferTest
    {
        [Fact]
        public void Foo()
        {
            var products = new Product();

            var offer = this.CreateOffer();
            var offers = new List<IOffer>() { this.CreateOffer(), this.CreateOffer() };
            products.Offers = offer;
            products.Offers = offers;
        }

        private Offer CreateOffer()
        {
            return new Offer();
        }
    }
}

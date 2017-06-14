namespace Schema.NET.Test
{
    using Xunit;

    public class BreadcrumbListTest
    {
        [Fact]
        public void ToString_BreadcrumbListGoogleStructuredData_ReturnsExpectedJsonLd()
        {
            var breadcrumbList = new BreadcrumbList()
            {
                ItemListElement = new ListItem()
            };
        }
    }
}

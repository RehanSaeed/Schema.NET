namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A BreadcrumbList is an ItemList consisting of a chain of linked Web pages, typically described using at least their URL and their name, and typically ending with the current page.&lt;/p&gt;
    /// &lt;p&gt;The &lt;a class="localLink" href="http://schema.org/position"&gt;position&lt;/a&gt; property is used to reconstruct the order of the items in a BreadcrumbList The convention is that a breadcrumb list has an &lt;a class="localLink" href="http://schema.org/itemListOrder"&gt;itemListOrder&lt;/a&gt; of &lt;a class="localLink" href="http://schema.org/ItemListOrderAscending"&gt;ItemListOrderAscending&lt;/a&gt; (lower values listed first), and that the first items in this list correspond to the "top" or beginning of the breadcrumb trail, e.g. with a site or section homepage. The specific values of 'position' are not assigned meaning for a BreadcrumbList, but they should be integers, e.g. beginning with '1' for the first item in the list.
    /// </summary>
    public partial interface IBreadcrumbList : IItemList
    {
    }

    /// <summary>
    /// A BreadcrumbList is an ItemList consisting of a chain of linked Web pages, typically described using at least their URL and their name, and typically ending with the current page.&lt;/p&gt;
    /// &lt;p&gt;The &lt;a class="localLink" href="http://schema.org/position"&gt;position&lt;/a&gt; property is used to reconstruct the order of the items in a BreadcrumbList The convention is that a breadcrumb list has an &lt;a class="localLink" href="http://schema.org/itemListOrder"&gt;itemListOrder&lt;/a&gt; of &lt;a class="localLink" href="http://schema.org/ItemListOrderAscending"&gt;ItemListOrderAscending&lt;/a&gt; (lower values listed first), and that the first items in this list correspond to the "top" or beginning of the breadcrumb trail, e.g. with a site or section homepage. The specific values of 'position' are not assigned meaning for a BreadcrumbList, but they should be integers, e.g. beginning with '1' for the first item in the list.
    /// </summary>
    [DataContract]
    public partial class BreadcrumbList : ItemList, IBreadcrumbList
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BreadcrumbList";
    }
}

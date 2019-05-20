namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Web page type: Checkout page.
    /// </summary>
    public partial interface ICheckoutPage : IWebPage
    {
    }

    /// <summary>
    /// Web page type: Checkout page.
    /// </summary>
    [DataContract]
    public partial class CheckoutPage : WebPage, ICheckoutPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CheckoutPage";
    }
}

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
    public partial class CheckoutPage : WebPage, ICheckoutPage, IEquatable<CheckoutPage>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "CheckoutPage";

        /// <inheritdoc/>
        public bool Equals(CheckoutPage other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as CheckoutPage);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

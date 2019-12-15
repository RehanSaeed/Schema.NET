﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A sidebar section of the page.
    /// </summary>
    public partial interface IWPSideBar : IWebPageElement
    {
    }

    /// <summary>
    /// A sidebar section of the page.
    /// </summary>
    [DataContract]
    public partial class WPSideBar : WebPageElement, IWPSideBar, IEquatable<WPSideBar>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "WPSideBar";

        /// <inheritdoc/>
        public bool Equals(WPSideBar other)
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
        public override bool Equals(object obj) => this.Equals(obj as WPSideBar);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

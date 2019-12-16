namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A web page that provides medical information.
    /// </summary>
    public partial interface IMedicalWebPage : IWebPage
    {
    }

    /// <summary>
    /// A web page that provides medical information.
    /// </summary>
    [DataContract]
    public partial class MedicalWebPage : WebPage, IMedicalWebPage, IEquatable<MedicalWebPage>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MedicalWebPage";

        /// <inheritdoc/>
        public bool Equals(MedicalWebPage other)
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
        public override bool Equals(object obj) => this.Equals(obj as MedicalWebPage);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}

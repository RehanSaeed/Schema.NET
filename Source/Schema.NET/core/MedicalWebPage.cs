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
        /// <summary>
        /// Medical audience for page.
        /// </summary>
        Values<IMedicalAudience, MedicalAudienceType?> MedicalAudience { get; set; }
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

        /// <summary>
        /// Medical audience for page.
        /// </summary>
        [DataMember(Name = "medicalAudience", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public Values<IMedicalAudience, MedicalAudienceType?> MedicalAudience { get; set; }

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
                this.MedicalAudience == other.MedicalAudience &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MedicalWebPage);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.MedicalAudience)
            .And(base.GetHashCode());
    }
}

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
    }
}

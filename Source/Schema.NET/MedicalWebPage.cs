namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A web page that provides medical information.
    /// </summary>
    [DataContract]
    public class MedicalWebPage : WebPage
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "MedicalWebPage";
    }
}

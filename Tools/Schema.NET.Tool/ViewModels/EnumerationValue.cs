namespace Schema.NET.Tool.ViewModels
{
    using System;
    using System.Diagnostics;

    [DebuggerDisplay("{Name}")]
    public class EnumerationValue
    {
        public string Description { get; set; }

        public string Name { get; set; }

        public Uri Uri { get; set; }

        /// <summary>
        /// Gets the HTTPS variant of the URI for future proofing.
        /// </summary>
        /// <remarks>
        /// See: https://schema.org/docs/faq.html#19
        /// Quote: Over time we will migrate the schema.org site itself towards using HTTPS
        /// as the default version of the site and our preferred form in examples.
        /// </remarks>
        public Uri HttpsUri => new UriBuilder(this.Uri)
        {
            Scheme = Uri.UriSchemeHttps,
            Port = this.Uri.IsDefaultPort ? -1 : this.Uri.Port, // -1 => default port for scheme
        }.Uri;
    }
}

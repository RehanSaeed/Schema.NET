namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Web page type: Profile page.
    /// </summary>
    public partial interface IProfilePage : IWebPage
    {
    }

    /// <summary>
    /// Web page type: Profile page.
    /// </summary>
    [DataContract]
    public partial class ProfilePage : WebPage, IProfilePage, IEquatable<ProfilePage>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "ProfilePage";
    }
}

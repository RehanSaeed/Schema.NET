namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// </summary>
    [DataContract]
    public class SportsOrganization : Organization
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "SportsOrganization";

        /// <summary>
        /// A type of sport (e.g. Baseball).
        /// </summary>
        [DataMember(Name = "sport")]
        public object Sport { get; protected set; }

        /// <summary>
        /// A type of sport (e.g. Baseball).
        /// </summary>
        [IgnoreDataMember]
        public Uri SportURL
        {
            get => this.Sport as Uri;
            set => this.Sport = value;
        }

        /// <summary>
        /// A type of sport (e.g. Baseball).
        /// </summary>
        [IgnoreDataMember]
        public string SportText
        {
            get => this.Sport as string;
            set => this.Sport = value;
        }
    }
}

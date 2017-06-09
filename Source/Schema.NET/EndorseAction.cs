namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// An agent approves/certifies/likes/supports/sanction an object.
    /// </summary>
    [DataContract]
    public class EndorseAction : ReactAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EndorseAction";

        /// <summary>
        /// A sub property of participant. The person/organization being supported.
        /// </summary>
        [DataMember(Name = "endorsee", Order = 2)]
        public object Endorsee { get; protected set; }

        /// <summary>
        /// A sub property of participant. The person/organization being supported.
        /// </summary>
        [IgnoreDataMember]
        public Organization EndorseeOrganization
        {
            get => this.Endorsee as Organization;
            set => this.Endorsee = value;
        }

        /// <summary>
        /// A sub property of participant. The person/organization being supported.
        /// </summary>
        [IgnoreDataMember]
        public Person EndorseePerson
        {
            get => this.Endorsee as Person;
            set => this.Endorsee = value;
        }
    }
}

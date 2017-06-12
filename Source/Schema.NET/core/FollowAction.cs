namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates polled from...
    /// </summary>
    [DataContract]
    public class FollowAction : InteractAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FollowAction";

        /// <summary>
        /// A sub property of object. The person or organization being followed.
        /// </summary>
        [DataMember(Name = "followee", Order = 2)]
        public object Followee { get; protected set; }

        /// <summary>
        /// A sub property of object. The person or organization being followed.
        /// </summary>
        [IgnoreDataMember]
        public Organization FolloweeOrganization
        {
            get => this.Followee as Organization;
            set => this.Followee = value;
        }

        /// <summary>
        /// A sub property of object. The person or organization being followed.
        /// </summary>
        [IgnoreDataMember]
        public Person FolloweePerson
        {
            get => this.Followee as Person;
            set => this.Followee = value;
        }
    }
}

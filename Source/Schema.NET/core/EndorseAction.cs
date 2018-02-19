using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// An agent approves/certifies/likes/supports/sanction an object.
    /// </summary>
    [DataContract]
    public partial class EndorseAction : ReactAction
    {
        public interface IEndorsee : IWrapper { }
        public interface IEndorsee<T> : IEndorsee { new T Data { get; set; } }
        public class EndorseeOrganization : IEndorsee<Organization>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Organization) value; } }
            public virtual Organization Data { get; set; }
            public EndorseeOrganization () { }
            public EndorseeOrganization (Organization data) { Data = data; }
            public static implicit operator EndorseeOrganization (Organization data) { return new EndorseeOrganization (data); }
        }

        public class EndorseePerson : IEndorsee<Person>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Person) value; } }
            public virtual Person Data { get; set; }
            public EndorseePerson () { }
            public EndorseePerson (Person data) { Data = data; }
            public static implicit operator EndorseePerson (Person data) { return new EndorseePerson (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EndorseAction";

        /// <summary>
        /// A sub property of participant. The person/organization being supported.
        /// </summary>
        [DataMember(Name = "endorsee", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IEndorsee>? Endorsee { get; set; } //Organization, Person
    }
}

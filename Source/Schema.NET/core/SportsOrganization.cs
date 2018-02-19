using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Represents the collection of all sports organizations, including sports teams, governing bodies, and sports associations.
    /// </summary>
    [DataContract]
    public partial class SportsOrganization : Organization
    {
        public interface ISport : IWrapper { }
        public interface ISport<T> : ISport { new T Data { get; set; } }
        public class Sportstring : ISport<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public Sportstring () { }
            public Sportstring (string data) { Data = data; }
            public static implicit operator Sportstring (string data) { return new Sportstring (data); }
        }

        public class SportUri : ISport<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public SportUri () { }
            public SportUri (Uri data) { Data = data; }
            public static implicit operator SportUri (Uri data) { return new SportUri (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "SportsOrganization";

        /// <summary>
        /// A type of sport (e.g. Baseball).
        /// </summary>
        [DataMember(Name = "sport", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ISport>? Sport { get; set; } //string, Uri
    }
}

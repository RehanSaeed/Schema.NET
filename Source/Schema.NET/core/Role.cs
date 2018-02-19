using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Represents additional information about a relationship or property. For example a Role can be used to say that a 'member' role linking some SportsTeam to a player occurred during a particular time period. Or that a Person's 'actor' role in a Movie was for some particular characterName. Such properties can be attached to a Role entity, which is then associated with the main entities using ordinary properties like 'member' or 'actor'.&lt;/p&gt;
    /// &lt;p&gt;See also &lt;a href="http://blog.schema.org/2014/06/introducing-role.html"&gt;blog post&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class Role : Intangible
    {
        public interface IRoleName : IWrapper { }
        public interface IRoleName<T> : IRoleName { new T Data { get; set; } }
        public class RoleNamestring : IRoleName<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public RoleNamestring () { }
            public RoleNamestring (string data) { Data = data; }
            public static implicit operator RoleNamestring (string data) { return new RoleNamestring (data); }
        }

        public class RoleNameUri : IRoleName<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public RoleNameUri () { }
            public RoleNameUri (Uri data) { Data = data; }
            public static implicit operator RoleNameUri (Uri data) { return new RoleNameUri (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Role";

        /// <summary>
        /// A role played, performed or filled by a person or organization. For example, the team of creators for a comic book might fill the roles named 'inker', 'penciller', and 'letterer'; or an athlete in a SportsTeam might play in the position named 'Quarterback'.
        /// </summary>
        [DataMember(Name = "roleName", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IRoleName>? RoleName { get; set; } //string, Uri

        /// <summary>
        /// The start date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "startDate", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? StartDate { get; set; } 

        /// <summary>
        /// The end date and time of the item (in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 date format&lt;/a&gt;).
        /// </summary>
        [DataMember(Name = "endDate", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<DateTimeOffset>? EndDate { get; set; } 
    }
}

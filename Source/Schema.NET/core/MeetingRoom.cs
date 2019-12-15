namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A meeting room, conference room, or conference hall is a room provided for singular events such as business conferences and meetings (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Conference_hall"&gt;http://en.wikipedia.org/wiki/Conference_hall&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    public partial interface IMeetingRoom : IRoom
    {
    }

    /// <summary>
    /// A meeting room, conference room, or conference hall is a room provided for singular events such as business conferences and meetings (Source: Wikipedia, the free encyclopedia, see &lt;a href="http://en.wikipedia.org/wiki/Conference_hall"&gt;http://en.wikipedia.org/wiki/Conference_hall&lt;/a&gt;).
    /// &lt;br /&gt;&lt;br /&gt;
    /// See also the &lt;a href="/docs/hotels.html"&gt;dedicated document on the use of schema.org for marking up hotels and other forms of accommodations&lt;/a&gt;.
    /// </summary>
    [DataContract]
    public partial class MeetingRoom : Room, IMeetingRoom, IEquatable<MeetingRoom>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MeetingRoom";
    }
}

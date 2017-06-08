namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A room is a distinguishable space within a structure, usually separated from other spaces by interior walls...
    /// </summary>
    [DataContract]
    public class Room : Accommodation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Room";
    }
}

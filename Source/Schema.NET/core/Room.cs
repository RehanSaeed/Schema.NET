namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A room is a distinguishable space within a structure, usually separated from other spaces by interior walls...
    /// </summary>
    [DataContract]
    public partial class Room : Accommodation
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Room";
    }
}

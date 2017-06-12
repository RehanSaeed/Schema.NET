namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A bus (also omnibus or autobus) is a road vehicle designed to carry passengers...
    /// </summary>
    [DataContract]
    public partial class BusOrCoach : Vehicle
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BusOrCoach";
    }
}

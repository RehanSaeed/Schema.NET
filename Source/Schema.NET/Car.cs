namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A car is a wheeled, self-powered motor vehicle used for transportation.
    /// </summary>
    [DataContract]
    public class Car : Vehicle
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Car";
    }
}

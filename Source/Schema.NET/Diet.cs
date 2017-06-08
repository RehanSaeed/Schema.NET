namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A strategy of regulating the intake of food to achieve or maintain a specific health-related goal.
    /// </summary>
    [DataContract]
    public class Diet : CreativeWork
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "Diet";
    }
}

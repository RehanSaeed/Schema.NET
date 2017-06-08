namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A radio channel that uses FM.
    /// </summary>
    [DataContract]
    public class FMRadioChannel : RadioChannel
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "FMRadioChannel";
    }
}

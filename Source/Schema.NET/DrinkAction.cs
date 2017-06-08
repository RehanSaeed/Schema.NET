namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of swallowing liquids.
    /// </summary>
    [DataContract]
    public class DrinkAction : ConsumeAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "DrinkAction";
    }
}

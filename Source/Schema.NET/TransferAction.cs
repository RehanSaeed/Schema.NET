namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of transferring/moving (abstract or concrete) animate or inanimate objects from one place to another.
    /// </summary>
    [DataContract]
    public class TransferAction : Action
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "TransferAction";

        /// <summary>
        /// A sub property of location. The final location of the object or the agent after the action.
        /// </summary>
        [DataMember(Name = "toLocation")]
        public Place ToLocation { get; set; }

        /// <summary>
        /// A sub property of location. The original location of the object or the agent before the action.
        /// </summary>
        [DataMember(Name = "fromLocation")]
        public Place FromLocation { get; set; }
    }
}

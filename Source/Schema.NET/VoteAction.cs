namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of expressing a preference from a fixed/finite/structured set of choices/options.
    /// </summary>
    [DataContract]
    public class VoteAction : ChooseAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "VoteAction";

        /// <summary>
        /// A sub property of object. The candidate subject of this action.
        /// </summary>
        [DataMember(Name = "candidate")]
        public Person Candidate { get; set; }
    }
}

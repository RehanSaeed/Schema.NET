namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of expressing a preference from a fixed/finite/structured set of choices/options.
    /// </summary>
    public partial interface IVoteAction : IChooseAction
    {
        /// <summary>
        /// A sub property of object. The candidate subject of this action.
        /// </summary>
        OneOrMany<IPerson>? Candidate { get; set; }
    }

    /// <summary>
    /// The act of expressing a preference from a fixed/finite/structured set of choices/options.
    /// </summary>
    [DataContract]
    public partial class VoteAction : ChooseAction, IVoteAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "VoteAction";

        /// <summary>
        /// A sub property of object. The candidate subject of this action.
        /// </summary>
        [DataMember(Name = "candidate", Order = 406)]
        [JsonConverter(typeof(ValuesConverter))]
        public OneOrMany<IPerson>? Candidate { get; set; }
    }
}

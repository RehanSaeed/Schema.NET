namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of gaining ownership of an object from an origin. Reciprocal of GiveAction...
    /// </summary>
    [DataContract]
    public partial class TakeAction : TransferAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TakeAction";
    }
}

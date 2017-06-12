namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// UserInteraction and its subtypes is an old way of talking about users interacting with pages...
    /// </summary>
    [DataContract]
    public partial class UserPlusOnes : UserInteraction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "UserPlusOnes";
    }
}

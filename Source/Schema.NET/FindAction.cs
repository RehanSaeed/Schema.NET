namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of finding an object.
    /// Related actions:
    ///
    /// SearchAction: FindAction is generally lead by a SearchAction, but not necessarily.
    /// </summary>
    [DataContract]
    public class FindAction : Action
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FindAction";
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of editing a recipient by removing one of its objects.
    /// </summary>
    [DataContract]
    public class DeleteAction : UpdateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "DeleteAction";
    }
}

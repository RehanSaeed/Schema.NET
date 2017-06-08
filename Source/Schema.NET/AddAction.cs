namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of editing by adding an object to a collection.
    /// </summary>
    [DataContract]
    public class AddAction : UpdateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "AddAction";
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of capturing still images of objects using a camera.
    /// </summary>
    [DataContract]
    public class PhotographAction : CreateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PhotographAction";
    }
}

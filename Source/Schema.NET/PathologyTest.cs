namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A medical test performed by a laboratory that typically involves examination of a tissue sample by a pathologist.
    /// </summary>
    [DataContract]
    public class PathologyTest : MedicalTest
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "PathologyTest";
    }
}

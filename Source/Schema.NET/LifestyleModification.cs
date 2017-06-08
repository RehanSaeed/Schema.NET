namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A process of care involving exercise, changes to diet, fitness routines, and other lifestyle changes aimed at improving a health condition.
    /// </summary>
    [DataContract]
    public class LifestyleModification : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type")]
        public override string Type => "LifestyleModification";
    }
}

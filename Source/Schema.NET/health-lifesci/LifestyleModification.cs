namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A process of care involving exercise, changes to diet, fitness routines, and other lifestyle changes aimed at improving a health condition.
    /// </summary>
    [DataContract]
    public partial class LifestyleModification : MedicalEntity
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LifestyleModification";
    }
}

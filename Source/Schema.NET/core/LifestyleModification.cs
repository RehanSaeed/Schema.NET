namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A process of care involving exercise, changes to diet, fitness routines, and other lifestyle changes aimed at improving a health condition.
    /// </summary>
    public partial interface ILifestyleModification : IMedicalEntity
    {
    }

    /// <summary>
    /// A process of care involving exercise, changes to diet, fitness routines, and other lifestyle changes aimed at improving a health condition.
    /// </summary>
    [DataContract]
    public partial class LifestyleModification : MedicalEntity, ILifestyleModification
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "LifestyleModification";
    }
}

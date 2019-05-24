namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Animal shelter.
    /// </summary>
    public partial interface IAnimalShelter : ILocalBusiness
    {
    }

    /// <summary>
    /// Animal shelter.
    /// </summary>
    [DataContract]
    public partial class AnimalShelter : LocalBusiness, IAnimalShelter
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "AnimalShelter";
    }
}

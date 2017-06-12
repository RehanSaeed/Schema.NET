namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// A specific branch of medical science that specializes in the care of women during the prenatal and postnatal care and with the delivery of the child.
    /// </summary>
    [DataContract]
    public partial class Obstetric : MedicalBusiness
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Obstetric";
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An aggregate rating of an Organization related to its role as an employer.
    /// </summary>
    public partial interface IEmployerAggregateRating : IAggregateRating
    {
    }

    /// <summary>
    /// An aggregate rating of an Organization related to its role as an employer.
    /// </summary>
    [DataContract]
    public partial class EmployerAggregateRating : AggregateRating, IEmployerAggregateRating
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "EmployerAggregateRating";
    }
}

namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of participating in performance arts.
    /// </summary>
    public partial interface IPerformAction : IPlayAction
    {
        /// <summary>
        /// A sub property of location. The entertainment business where the action occurred.
        /// </summary>
        OneOrMany<IEntertainmentBusiness> EntertainmentBusiness { get; set; }
    }

    /// <summary>
    /// The act of participating in performance arts.
    /// </summary>
    [DataContract]
    public partial class PerformAction : PlayAction, IPerformAction, IEquatable<PerformAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PerformAction";

        /// <summary>
        /// A sub property of location. The entertainment business where the action occurred.
        /// </summary>
        [DataMember(Name = "entertainmentBusiness", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEntertainmentBusiness> EntertainmentBusiness { get; set; }

        /// <inheritdoc/>
        public bool Equals(PerformAction other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                this.EntertainmentBusiness == other.EntertainmentBusiness &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as PerformAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.EntertainmentBusiness)
            .And(base.GetHashCode());
    }
}

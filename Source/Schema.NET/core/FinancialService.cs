using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// Financial services business.
    /// </summary>
    [DataContract]
    public partial class FinancialService : LocalBusiness
    {
        public interface IFeesAndCommissionsSpecification : IWrapper { }
        public interface IFeesAndCommissionsSpecification<T> : IFeesAndCommissionsSpecification { new T Data { get; set; } }
        public class FeesAndCommissionsSpecificationstring : IFeesAndCommissionsSpecification<string>
        {
            object IWrapper.Data { get { return Data; } set { Data = (string) value; } }
            public virtual string Data { get; set; }
            public FeesAndCommissionsSpecificationstring () { }
            public FeesAndCommissionsSpecificationstring (string data) { Data = data; }
            public static implicit operator FeesAndCommissionsSpecificationstring (string data) { return new FeesAndCommissionsSpecificationstring (data); }
        }

        public class FeesAndCommissionsSpecificationUri : IFeesAndCommissionsSpecification<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public FeesAndCommissionsSpecificationUri () { }
            public FeesAndCommissionsSpecificationUri (Uri data) { Data = data; }
            public static implicit operator FeesAndCommissionsSpecificationUri (Uri data) { return new FeesAndCommissionsSpecificationUri (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FinancialService";

        /// <summary>
        /// Description of fees, commissions, and other terms applied either to a class of financial product, or by a financial service organization.
        /// </summary>
        [DataMember(Name = "feesAndCommissionsSpecification", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IFeesAndCommissionsSpecification>? FeesAndCommissionsSpecification { get; set; } //string, Uri
    }
}

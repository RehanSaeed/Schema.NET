using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A brand is a name used by an organization or business person for labeling a product, product group, or similar.
    /// </summary>
    [DataContract]
    public partial class Brand : Intangible
    {
        public interface ILogo : IWrapper { }
        public interface ILogo<T> : ILogo { new T Data { get; set; } }
        public class LogoImageObject : ILogo<ImageObject>
        {
            object IWrapper.Data { get { return Data; } set { Data = (ImageObject) value; } }
            public virtual ImageObject Data { get; set; }
            public LogoImageObject () { }
            public LogoImageObject (ImageObject data) { Data = data; }
            public static implicit operator LogoImageObject (ImageObject data) { return new LogoImageObject (data); }
        }

        public class LogoUri : ILogo<Uri>
        {
            object IWrapper.Data { get { return Data; } set { Data = (Uri) value; } }
            public virtual Uri Data { get; set; }
            public LogoUri () { }
            public LogoUri (Uri data) { Data = data; }
            public static implicit operator LogoUri (Uri data) { return new LogoUri (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Brand";

        /// <summary>
        /// The overall rating, based on a collection of reviews or ratings, of the item.
        /// </summary>
        [DataMember(Name = "aggregateRating", Order = 206)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<AggregateRating>? AggregateRating { get; set; } 

        /// <summary>
        /// An associated logo.
        /// </summary>
        [DataMember(Name = "logo", Order = 207)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<ILogo>? Logo { get; set; } //ImageObject, Uri

        /// <summary>
        /// A review of the item.
        /// </summary>
        [DataMember(Name = "review", Order = 208)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Review>? Review { get; set; } 
    }
}

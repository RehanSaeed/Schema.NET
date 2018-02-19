using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Schema.NET
{
    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// </summary>
    [DataContract]
    public partial class InteractionCounter : StructuredValue
    {
        public interface IInteractionService : IWrapper { }
        public interface IInteractionService<T> : IInteractionService { new T Data { get; set; } }
        public class InteractionServiceSoftwareApplication : IInteractionService<SoftwareApplication>
        {
            object IWrapper.Data { get { return Data; } set { Data = (SoftwareApplication) value; } }
            public virtual SoftwareApplication Data { get; set; }
            public InteractionServiceSoftwareApplication () { }
            public InteractionServiceSoftwareApplication (SoftwareApplication data) { Data = data; }
            public static implicit operator InteractionServiceSoftwareApplication (SoftwareApplication data) { return new InteractionServiceSoftwareApplication (data); }
        }

        public class InteractionServiceWebSite : IInteractionService<WebSite>
        {
            object IWrapper.Data { get { return Data; } set { Data = (WebSite) value; } }
            public virtual WebSite Data { get; set; }
            public InteractionServiceWebSite () { }
            public InteractionServiceWebSite (WebSite data) { Data = data; }
            public static implicit operator InteractionServiceWebSite (WebSite data) { return new InteractionServiceWebSite (data); }
        }


        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "InteractionCounter";

        /// <summary>
        /// The WebSite or SoftwareApplication where the interactions took place.
        /// </summary>
        [DataMember(Name = "interactionService", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<IInteractionService>? InteractionService { get; set; } //SoftwareApplication, WebSite

        /// <summary>
        /// The Action representing the type of interaction. For up votes, +1s, etc. use &lt;a class="localLink" href="http://schema.org/LikeAction"&gt;LikeAction&lt;/a&gt;. For down votes use &lt;a class="localLink" href="http://schema.org/DislikeAction"&gt;DislikeAction&lt;/a&gt;. Otherwise, use the most specific Action.
        /// </summary>
        [DataMember(Name = "interactionType", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Action>? InteractionType { get; set; } 

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.
        /// </summary>
        [DataMember(Name = "userInteractionCount", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<int>? UserInteractionCount { get; set; } 
    }
}

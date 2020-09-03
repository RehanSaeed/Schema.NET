namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// An agent tracks an object for updates.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, TrackAction refers to the interest on the location of innanimates objects.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, TrackAction refers to  the interest on the location of innanimate objects.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface ITrackAction : IFindAction
    {
        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        OneOrMany<DeliveryMethod?> DeliveryMethod { get; set; }
    }

    /// <summary>
    /// An agent tracks an object for updates.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/FollowAction"&gt;FollowAction&lt;/a&gt;: Unlike FollowAction, TrackAction refers to the interest on the location of innanimates objects.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, TrackAction refers to  the interest on the location of innanimate objects.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class TrackAction : FindAction, ITrackAction, IEquatable<TrackAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "TrackAction";

        /// <summary>
        /// A sub property of instrument. The method of delivery.
        /// </summary>
        [DataMember(Name = "deliveryMethod", Order = 306)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<DeliveryMethod?> DeliveryMethod { get; set; }

        /// <inheritdoc/>
        public bool Equals(TrackAction other)
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
                this.DeliveryMethod == other.DeliveryMethod &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as TrackAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.DeliveryMethod)
            .And(base.GetHashCode());
    }
}

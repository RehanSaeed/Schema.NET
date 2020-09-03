namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of playing/exercising/training/performing for enjoyment, leisure, recreation, Competition or exercise.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/ListenAction"&gt;ListenAction&lt;/a&gt;: Unlike ListenAction (which is under ConsumeAction), PlayAction refers to performing for an audience or at an event, rather than consuming music.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/WatchAction"&gt;WatchAction&lt;/a&gt;: Unlike WatchAction (which is under ConsumeAction), PlayAction refers to showing/displaying for an audience or at an event, rather than consuming visual content.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    public partial interface IPlayAction : IAction
    {
        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        OneOrMany<IEvent> Events { get; set; }
    }

    /// <summary>
    /// The act of playing/exercising/training/performing for enjoyment, leisure, recreation, Competition or exercise.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/ListenAction"&gt;ListenAction&lt;/a&gt;: Unlike ListenAction (which is under ConsumeAction), PlayAction refers to performing for an audience or at an event, rather than consuming music.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="https://schema.org/WatchAction"&gt;WatchAction&lt;/a&gt;: Unlike WatchAction (which is under ConsumeAction), PlayAction refers to showing/displaying for an audience or at an event, rather than consuming visual content.&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class PlayAction : Action, IPlayAction, IEquatable<PlayAction>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "PlayAction";

        /// <summary>
        /// An intended audience, i.e. a group for whom something was created.
        /// </summary>
        [DataMember(Name = "audience", Order = 206)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IAudience> Audience { get; set; }

        /// <summary>
        /// Upcoming or past event associated with this place, organization, or action.
        /// </summary>
        [DataMember(Name = "event", Order = 207)]
        [JsonConverter(typeof(ValuesJsonConverter))]
        public OneOrMany<IEvent> Events { get; set; }

        /// <inheritdoc/>
        public bool Equals(PlayAction other)
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
                this.Audience == other.Audience &&
                this.Events == other.Events &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as PlayAction);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(this.Audience)
            .And(this.Events)
            .And(base.GetHashCode());
    }
}

namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The act of forming a personal connection with someone/something (object) unidirectionally/asymmetrically to get updates polled from.&lt;br/&gt;&lt;br/&gt;
    /// Related actions:&lt;br/&gt;&lt;br/&gt;
    /// &lt;ul&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/BefriendAction"&gt;BefriendAction&lt;/a&gt;: Unlike BefriendAction, FollowAction implies that the connection is &lt;em&gt;not&lt;/em&gt; necessarily reciprocal.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/SubscribeAction"&gt;SubscribeAction&lt;/a&gt;: Unlike SubscribeAction, FollowAction implies that the follower acts as an active agent constantly/actively polling for updates.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/RegisterAction"&gt;RegisterAction&lt;/a&gt;: Unlike RegisterAction, FollowAction implies that the agent is interested in continuing receiving updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/JoinAction"&gt;JoinAction&lt;/a&gt;: Unlike JoinAction, FollowAction implies that the agent is interested in getting updates from the object.&lt;/li&gt;
    /// &lt;li&gt;&lt;a class="localLink" href="http://schema.org/TrackAction"&gt;TrackAction&lt;/a&gt;: Unlike TrackAction, FollowAction refers to the polling of updates of all aspects of animate objects rather than the location of inanimate objects (e.g. you track a package, but you don't follow it).&lt;/li&gt;
    /// &lt;/ul&gt;
    /// </summary>
    [DataContract]
    public partial class FollowAction : InteractAction
    {
        public interface IFollowee : IValue {}
        public interface IFollowee<T> : IFollowee { new T Value { get; } }
        public class OneOrManyFollowee : OneOrMany<IFollowee>
        {
            public OneOrManyFollowee(IFollowee item) : base(item) { }
            public OneOrManyFollowee(IEnumerable<IFollowee> items) : base(items) { }
            public static implicit operator OneOrManyFollowee (Organization value) { return new OneOrManyFollowee (new FolloweeOrganization (value)); }
            public static implicit operator OneOrManyFollowee (Organization[] values) { return new OneOrManyFollowee (values.Select(v => (IFollowee) new FolloweeOrganization (v))); }
            public static implicit operator OneOrManyFollowee (List<Organization> values) { return new OneOrManyFollowee (values.Select(v => (IFollowee) new FolloweeOrganization (v))); }
            public static implicit operator OneOrManyFollowee (Person value) { return new OneOrManyFollowee (new FolloweePerson (value)); }
            public static implicit operator OneOrManyFollowee (Person[] values) { return new OneOrManyFollowee (values.Select(v => (IFollowee) new FolloweePerson (v))); }
            public static implicit operator OneOrManyFollowee (List<Person> values) { return new OneOrManyFollowee (values.Select(v => (IFollowee) new FolloweePerson (v))); }
        }
        public struct FolloweeOrganization : IFollowee<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public FolloweeOrganization (Organization value) { Value = value; }
            public static implicit operator FolloweeOrganization (Organization value) { return new FolloweeOrganization (value); }
        }
        public struct FolloweePerson : IFollowee<Person>
        {
            object IValue.Value => this.Value;
            public Person Value { get; }
            public FolloweePerson (Person value) { Value = value; }
            public static implicit operator FolloweePerson (Person value) { return new FolloweePerson (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "FollowAction";

        /// <summary>
        /// A sub property of object. The person or organization being followed.
        /// </summary>
        [DataMember(Name = "followee", Order = 306)]
        public OneOrManyFollowee Followee { get; set; }
    }
}

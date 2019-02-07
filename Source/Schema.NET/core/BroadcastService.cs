namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
    [DataContract]
    public partial class BroadcastService : Service
    {
        public interface IBroadcastAffiliateOf : IValue {}
        public interface IBroadcastAffiliateOf<T> : IBroadcastAffiliateOf { new T Value { get; } }
        public class OneOrManyBroadcastAffiliateOf : OneOrMany<IBroadcastAffiliateOf>
        {
            public OneOrManyBroadcastAffiliateOf(IBroadcastAffiliateOf item) : base(item) { }
            public OneOrManyBroadcastAffiliateOf(IEnumerable<IBroadcastAffiliateOf> items) : base(items) { }
            public static implicit operator OneOrManyBroadcastAffiliateOf (Organization value) { return new OneOrManyBroadcastAffiliateOf (new BroadcastAffiliateOfOrganization (value)); }
            public static implicit operator OneOrManyBroadcastAffiliateOf (Organization[] values) { return new OneOrManyBroadcastAffiliateOf (values.Select(v => (IBroadcastAffiliateOf) new BroadcastAffiliateOfOrganization (v))); }
            public static implicit operator OneOrManyBroadcastAffiliateOf (List<Organization> values) { return new OneOrManyBroadcastAffiliateOf (values.Select(v => (IBroadcastAffiliateOf) new BroadcastAffiliateOfOrganization (v))); }
        }
        public struct BroadcastAffiliateOfOrganization : IBroadcastAffiliateOf<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public BroadcastAffiliateOfOrganization (Organization value) { Value = value; }
            public static implicit operator BroadcastAffiliateOfOrganization (Organization value) { return new BroadcastAffiliateOfOrganization (value); }
        }

        public interface IBroadcastDisplayName : IValue {}
        public interface IBroadcastDisplayName<T> : IBroadcastDisplayName { new T Value { get; } }
        public class OneOrManyBroadcastDisplayName : OneOrMany<IBroadcastDisplayName>
        {
            public OneOrManyBroadcastDisplayName(IBroadcastDisplayName item) : base(item) { }
            public OneOrManyBroadcastDisplayName(IEnumerable<IBroadcastDisplayName> items) : base(items) { }
            public static implicit operator OneOrManyBroadcastDisplayName (string value) { return new OneOrManyBroadcastDisplayName (new BroadcastDisplayNamestring (value)); }
            public static implicit operator OneOrManyBroadcastDisplayName (string[] values) { return new OneOrManyBroadcastDisplayName (values.Select(v => (IBroadcastDisplayName) new BroadcastDisplayNamestring (v))); }
            public static implicit operator OneOrManyBroadcastDisplayName (List<string> values) { return new OneOrManyBroadcastDisplayName (values.Select(v => (IBroadcastDisplayName) new BroadcastDisplayNamestring (v))); }
        }
        public struct BroadcastDisplayNamestring : IBroadcastDisplayName<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BroadcastDisplayNamestring (string value) { Value = value; }
            public static implicit operator BroadcastDisplayNamestring (string value) { return new BroadcastDisplayNamestring (value); }
        }

        public interface IBroadcaster : IValue {}
        public interface IBroadcaster<T> : IBroadcaster { new T Value { get; } }
        public class OneOrManyBroadcaster : OneOrMany<IBroadcaster>
        {
            public OneOrManyBroadcaster(IBroadcaster item) : base(item) { }
            public OneOrManyBroadcaster(IEnumerable<IBroadcaster> items) : base(items) { }
            public static implicit operator OneOrManyBroadcaster (Organization value) { return new OneOrManyBroadcaster (new BroadcasterOrganization (value)); }
            public static implicit operator OneOrManyBroadcaster (Organization[] values) { return new OneOrManyBroadcaster (values.Select(v => (IBroadcaster) new BroadcasterOrganization (v))); }
            public static implicit operator OneOrManyBroadcaster (List<Organization> values) { return new OneOrManyBroadcaster (values.Select(v => (IBroadcaster) new BroadcasterOrganization (v))); }
        }
        public struct BroadcasterOrganization : IBroadcaster<Organization>
        {
            object IValue.Value => this.Value;
            public Organization Value { get; }
            public BroadcasterOrganization (Organization value) { Value = value; }
            public static implicit operator BroadcasterOrganization (Organization value) { return new BroadcasterOrganization (value); }
        }

        public interface IBroadcastFrequency : IValue {}
        public interface IBroadcastFrequency<T> : IBroadcastFrequency { new T Value { get; } }
        public class OneOrManyBroadcastFrequency : OneOrMany<IBroadcastFrequency>
        {
            public OneOrManyBroadcastFrequency(IBroadcastFrequency item) : base(item) { }
            public OneOrManyBroadcastFrequency(IEnumerable<IBroadcastFrequency> items) : base(items) { }
            public static implicit operator OneOrManyBroadcastFrequency (string value) { return new OneOrManyBroadcastFrequency (new BroadcastFrequencystring (value)); }
            public static implicit operator OneOrManyBroadcastFrequency (string[] values) { return new OneOrManyBroadcastFrequency (values.Select(v => (IBroadcastFrequency) new BroadcastFrequencystring (v))); }
            public static implicit operator OneOrManyBroadcastFrequency (List<string> values) { return new OneOrManyBroadcastFrequency (values.Select(v => (IBroadcastFrequency) new BroadcastFrequencystring (v))); }
        }
        public struct BroadcastFrequencystring : IBroadcastFrequency<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BroadcastFrequencystring (string value) { Value = value; }
            public static implicit operator BroadcastFrequencystring (string value) { return new BroadcastFrequencystring (value); }
        }

        public interface IBroadcastTimezone : IValue {}
        public interface IBroadcastTimezone<T> : IBroadcastTimezone { new T Value { get; } }
        public class OneOrManyBroadcastTimezone : OneOrMany<IBroadcastTimezone>
        {
            public OneOrManyBroadcastTimezone(IBroadcastTimezone item) : base(item) { }
            public OneOrManyBroadcastTimezone(IEnumerable<IBroadcastTimezone> items) : base(items) { }
            public static implicit operator OneOrManyBroadcastTimezone (string value) { return new OneOrManyBroadcastTimezone (new BroadcastTimezonestring (value)); }
            public static implicit operator OneOrManyBroadcastTimezone (string[] values) { return new OneOrManyBroadcastTimezone (values.Select(v => (IBroadcastTimezone) new BroadcastTimezonestring (v))); }
            public static implicit operator OneOrManyBroadcastTimezone (List<string> values) { return new OneOrManyBroadcastTimezone (values.Select(v => (IBroadcastTimezone) new BroadcastTimezonestring (v))); }
        }
        public struct BroadcastTimezonestring : IBroadcastTimezone<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BroadcastTimezonestring (string value) { Value = value; }
            public static implicit operator BroadcastTimezonestring (string value) { return new BroadcastTimezonestring (value); }
        }

        public interface IHasBroadcastChannel : IValue {}
        public interface IHasBroadcastChannel<T> : IHasBroadcastChannel { new T Value { get; } }
        public class OneOrManyHasBroadcastChannel : OneOrMany<IHasBroadcastChannel>
        {
            public OneOrManyHasBroadcastChannel(IHasBroadcastChannel item) : base(item) { }
            public OneOrManyHasBroadcastChannel(IEnumerable<IHasBroadcastChannel> items) : base(items) { }
            public static implicit operator OneOrManyHasBroadcastChannel (BroadcastChannel value) { return new OneOrManyHasBroadcastChannel (new HasBroadcastChannelBroadcastChannel (value)); }
            public static implicit operator OneOrManyHasBroadcastChannel (BroadcastChannel[] values) { return new OneOrManyHasBroadcastChannel (values.Select(v => (IHasBroadcastChannel) new HasBroadcastChannelBroadcastChannel (v))); }
            public static implicit operator OneOrManyHasBroadcastChannel (List<BroadcastChannel> values) { return new OneOrManyHasBroadcastChannel (values.Select(v => (IHasBroadcastChannel) new HasBroadcastChannelBroadcastChannel (v))); }
        }
        public struct HasBroadcastChannelBroadcastChannel : IHasBroadcastChannel<BroadcastChannel>
        {
            object IValue.Value => this.Value;
            public BroadcastChannel Value { get; }
            public HasBroadcastChannelBroadcastChannel (BroadcastChannel value) { Value = value; }
            public static implicit operator HasBroadcastChannelBroadcastChannel (BroadcastChannel value) { return new HasBroadcastChannelBroadcastChannel (value); }
        }

        public interface IParentService : IValue {}
        public interface IParentService<T> : IParentService { new T Value { get; } }
        public class OneOrManyParentService : OneOrMany<IParentService>
        {
            public OneOrManyParentService(IParentService item) : base(item) { }
            public OneOrManyParentService(IEnumerable<IParentService> items) : base(items) { }
            public static implicit operator OneOrManyParentService (BroadcastService value) { return new OneOrManyParentService (new ParentServiceBroadcastService (value)); }
            public static implicit operator OneOrManyParentService (BroadcastService[] values) { return new OneOrManyParentService (values.Select(v => (IParentService) new ParentServiceBroadcastService (v))); }
            public static implicit operator OneOrManyParentService (List<BroadcastService> values) { return new OneOrManyParentService (values.Select(v => (IParentService) new ParentServiceBroadcastService (v))); }
        }
        public struct ParentServiceBroadcastService : IParentService<BroadcastService>
        {
            object IValue.Value => this.Value;
            public BroadcastService Value { get; }
            public ParentServiceBroadcastService (BroadcastService value) { Value = value; }
            public static implicit operator ParentServiceBroadcastService (BroadcastService value) { return new ParentServiceBroadcastService (value); }
        }

        public interface IVideoFormat : IValue {}
        public interface IVideoFormat<T> : IVideoFormat { new T Value { get; } }
        public class OneOrManyVideoFormat : OneOrMany<IVideoFormat>
        {
            public OneOrManyVideoFormat(IVideoFormat item) : base(item) { }
            public OneOrManyVideoFormat(IEnumerable<IVideoFormat> items) : base(items) { }
            public static implicit operator OneOrManyVideoFormat (string value) { return new OneOrManyVideoFormat (new VideoFormatstring (value)); }
            public static implicit operator OneOrManyVideoFormat (string[] values) { return new OneOrManyVideoFormat (values.Select(v => (IVideoFormat) new VideoFormatstring (v))); }
            public static implicit operator OneOrManyVideoFormat (List<string> values) { return new OneOrManyVideoFormat (values.Select(v => (IVideoFormat) new VideoFormatstring (v))); }
        }
        public struct VideoFormatstring : IVideoFormat<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public VideoFormatstring (string value) { Value = value; }
            public static implicit operator VideoFormatstring (string value) { return new VideoFormatstring (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastService";

        /// <summary>
        /// The media network(s) whose content is broadcast on this station.
        /// </summary>
        [DataMember(Name = "broadcastAffiliateOf", Order = 306)]
        public OneOrManyBroadcastAffiliateOf BroadcastAffiliateOf { get; set; }

        /// <summary>
        /// The name displayed in the channel guide. For many US affiliates, it is the network name.
        /// </summary>
        [DataMember(Name = "broadcastDisplayName", Order = 307)]
        public OneOrManyBroadcastDisplayName BroadcastDisplayName { get; set; }

        /// <summary>
        /// The organization owning or operating the broadcast service.
        /// </summary>
        [DataMember(Name = "broadcaster", Order = 308)]
        public OneOrManyBroadcaster Broadcaster { get; set; }

        /// <summary>
        /// The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".
        /// </summary>
        [DataMember(Name = "broadcastFrequency", Order = 309)]
        public OneOrManyBroadcastFrequency BroadcastFrequency { get; set; }

        /// <summary>
        /// The timezone in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 format&lt;/a&gt; for which the service bases its broadcasts
        /// </summary>
        [DataMember(Name = "broadcastTimezone", Order = 310)]
        public OneOrManyBroadcastTimezone BroadcastTimezone { get; set; }

        /// <summary>
        /// A broadcast channel of a broadcast service.
        /// </summary>
        [DataMember(Name = "hasBroadcastChannel", Order = 311)]
        public OneOrManyHasBroadcastChannel HasBroadcastChannel { get; set; }

        /// <summary>
        /// A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.
        /// </summary>
        [DataMember(Name = "parentService", Order = 312)]
        public OneOrManyParentService ParentService { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [DataMember(Name = "videoFormat", Order = 313)]
        public OneOrManyVideoFormat VideoFormat { get; set; }
    }
}

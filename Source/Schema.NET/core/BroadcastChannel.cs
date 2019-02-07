namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A unique instance of a BroadcastService on a CableOrSatelliteService lineup.
    /// </summary>
    [DataContract]
    public partial class BroadcastChannel : Intangible
    {
        public interface IBroadcastChannelId : IValue {}
        public interface IBroadcastChannelId<T> : IBroadcastChannelId { new T Value { get; } }
        public class OneOrManyBroadcastChannelId : OneOrMany<IBroadcastChannelId>
        {
            public OneOrManyBroadcastChannelId(IBroadcastChannelId item) : base(item) { }
            public OneOrManyBroadcastChannelId(IEnumerable<IBroadcastChannelId> items) : base(items) { }
            public static implicit operator OneOrManyBroadcastChannelId (string value) { return new OneOrManyBroadcastChannelId (new BroadcastChannelIdstring (value)); }
            public static implicit operator OneOrManyBroadcastChannelId (string[] values) { return new OneOrManyBroadcastChannelId (values.Select(v => (IBroadcastChannelId) new BroadcastChannelIdstring (v))); }
            public static implicit operator OneOrManyBroadcastChannelId (List<string> values) { return new OneOrManyBroadcastChannelId (values.Select(v => (IBroadcastChannelId) new BroadcastChannelIdstring (v))); }
        }
        public struct BroadcastChannelIdstring : IBroadcastChannelId<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BroadcastChannelIdstring (string value) { Value = value; }
            public static implicit operator BroadcastChannelIdstring (string value) { return new BroadcastChannelIdstring (value); }
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

        public interface IBroadcastServiceTier : IValue {}
        public interface IBroadcastServiceTier<T> : IBroadcastServiceTier { new T Value { get; } }
        public class OneOrManyBroadcastServiceTier : OneOrMany<IBroadcastServiceTier>
        {
            public OneOrManyBroadcastServiceTier(IBroadcastServiceTier item) : base(item) { }
            public OneOrManyBroadcastServiceTier(IEnumerable<IBroadcastServiceTier> items) : base(items) { }
            public static implicit operator OneOrManyBroadcastServiceTier (string value) { return new OneOrManyBroadcastServiceTier (new BroadcastServiceTierstring (value)); }
            public static implicit operator OneOrManyBroadcastServiceTier (string[] values) { return new OneOrManyBroadcastServiceTier (values.Select(v => (IBroadcastServiceTier) new BroadcastServiceTierstring (v))); }
            public static implicit operator OneOrManyBroadcastServiceTier (List<string> values) { return new OneOrManyBroadcastServiceTier (values.Select(v => (IBroadcastServiceTier) new BroadcastServiceTierstring (v))); }
        }
        public struct BroadcastServiceTierstring : IBroadcastServiceTier<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public BroadcastServiceTierstring (string value) { Value = value; }
            public static implicit operator BroadcastServiceTierstring (string value) { return new BroadcastServiceTierstring (value); }
        }

        public interface IGenre : IValue {}
        public interface IGenre<T> : IGenre { new T Value { get; } }
        public class OneOrManyGenre : OneOrMany<IGenre>
        {
            public OneOrManyGenre(IGenre item) : base(item) { }
            public OneOrManyGenre(IEnumerable<IGenre> items) : base(items) { }
            public static implicit operator OneOrManyGenre (string value) { return new OneOrManyGenre (new Genrestring (value)); }
            public static implicit operator OneOrManyGenre (string[] values) { return new OneOrManyGenre (values.Select(v => (IGenre) new Genrestring (v))); }
            public static implicit operator OneOrManyGenre (List<string> values) { return new OneOrManyGenre (values.Select(v => (IGenre) new Genrestring (v))); }
            public static implicit operator OneOrManyGenre (Uri value) { return new OneOrManyGenre (new GenreUri (value)); }
            public static implicit operator OneOrManyGenre (Uri[] values) { return new OneOrManyGenre (values.Select(v => (IGenre) new GenreUri (v))); }
            public static implicit operator OneOrManyGenre (List<Uri> values) { return new OneOrManyGenre (values.Select(v => (IGenre) new GenreUri (v))); }
        }
        public struct Genrestring : IGenre<string>
        {
            object IValue.Value => this.Value;
            public string Value { get; }
            public Genrestring (string value) { Value = value; }
            public static implicit operator Genrestring (string value) { return new Genrestring (value); }
        }
        public struct GenreUri : IGenre<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public GenreUri (Uri value) { Value = value; }
            public static implicit operator GenreUri (Uri value) { return new GenreUri (value); }
        }

        public interface IInBroadcastLineup : IValue {}
        public interface IInBroadcastLineup<T> : IInBroadcastLineup { new T Value { get; } }
        public class OneOrManyInBroadcastLineup : OneOrMany<IInBroadcastLineup>
        {
            public OneOrManyInBroadcastLineup(IInBroadcastLineup item) : base(item) { }
            public OneOrManyInBroadcastLineup(IEnumerable<IInBroadcastLineup> items) : base(items) { }
            public static implicit operator OneOrManyInBroadcastLineup (CableOrSatelliteService value) { return new OneOrManyInBroadcastLineup (new InBroadcastLineupCableOrSatelliteService (value)); }
            public static implicit operator OneOrManyInBroadcastLineup (CableOrSatelliteService[] values) { return new OneOrManyInBroadcastLineup (values.Select(v => (IInBroadcastLineup) new InBroadcastLineupCableOrSatelliteService (v))); }
            public static implicit operator OneOrManyInBroadcastLineup (List<CableOrSatelliteService> values) { return new OneOrManyInBroadcastLineup (values.Select(v => (IInBroadcastLineup) new InBroadcastLineupCableOrSatelliteService (v))); }
        }
        public struct InBroadcastLineupCableOrSatelliteService : IInBroadcastLineup<CableOrSatelliteService>
        {
            object IValue.Value => this.Value;
            public CableOrSatelliteService Value { get; }
            public InBroadcastLineupCableOrSatelliteService (CableOrSatelliteService value) { Value = value; }
            public static implicit operator InBroadcastLineupCableOrSatelliteService (CableOrSatelliteService value) { return new InBroadcastLineupCableOrSatelliteService (value); }
        }

        public interface IProvidesBroadcastService : IValue {}
        public interface IProvidesBroadcastService<T> : IProvidesBroadcastService { new T Value { get; } }
        public class OneOrManyProvidesBroadcastService : OneOrMany<IProvidesBroadcastService>
        {
            public OneOrManyProvidesBroadcastService(IProvidesBroadcastService item) : base(item) { }
            public OneOrManyProvidesBroadcastService(IEnumerable<IProvidesBroadcastService> items) : base(items) { }
            public static implicit operator OneOrManyProvidesBroadcastService (BroadcastService value) { return new OneOrManyProvidesBroadcastService (new ProvidesBroadcastServiceBroadcastService (value)); }
            public static implicit operator OneOrManyProvidesBroadcastService (BroadcastService[] values) { return new OneOrManyProvidesBroadcastService (values.Select(v => (IProvidesBroadcastService) new ProvidesBroadcastServiceBroadcastService (v))); }
            public static implicit operator OneOrManyProvidesBroadcastService (List<BroadcastService> values) { return new OneOrManyProvidesBroadcastService (values.Select(v => (IProvidesBroadcastService) new ProvidesBroadcastServiceBroadcastService (v))); }
        }
        public struct ProvidesBroadcastServiceBroadcastService : IProvidesBroadcastService<BroadcastService>
        {
            object IValue.Value => this.Value;
            public BroadcastService Value { get; }
            public ProvidesBroadcastServiceBroadcastService (BroadcastService value) { Value = value; }
            public static implicit operator ProvidesBroadcastServiceBroadcastService (BroadcastService value) { return new ProvidesBroadcastServiceBroadcastService (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastChannel";

        /// <summary>
        /// The unique address by which the BroadcastService can be identified in a provider lineup. In US, this is typically a number.
        /// </summary>
        [DataMember(Name = "broadcastChannelId", Order = 206)]
        public OneOrManyBroadcastChannelId BroadcastChannelId { get; set; }

        /// <summary>
        /// The frequency used for over-the-air broadcasts. Numeric values or simple ranges e.g. 87-99. In addition a shortcut idiom is supported for frequences of AM and FM radio channels, e.g. "87 FM".
        /// </summary>
        [DataMember(Name = "broadcastFrequency", Order = 207)]
        public OneOrManyBroadcastFrequency BroadcastFrequency { get; set; }

        /// <summary>
        /// The type of service required to have access to the channel (e.g. Standard or Premium).
        /// </summary>
        [DataMember(Name = "broadcastServiceTier", Order = 208)]
        public OneOrManyBroadcastServiceTier BroadcastServiceTier { get; set; }

        /// <summary>
        /// Genre of the creative work, broadcast channel or group.
        /// </summary>
        [DataMember(Name = "genre", Order = 209)]
        public OneOrManyGenre Genre { get; set; }

        /// <summary>
        /// The CableOrSatelliteService offering the channel.
        /// </summary>
        [DataMember(Name = "inBroadcastLineup", Order = 210)]
        public OneOrManyInBroadcastLineup InBroadcastLineup { get; set; }

        /// <summary>
        /// The BroadcastService offered on this channel.
        /// </summary>
        [DataMember(Name = "providesBroadcastService", Order = 211)]
        public OneOrManyProvidesBroadcastService ProvidesBroadcastService { get; set; }
    }
}

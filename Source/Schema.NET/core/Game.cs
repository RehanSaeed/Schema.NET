namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// The Game type represents things which are games. These are typically rule-governed recreational activities, e.g. role-playing games in which players assume the role of characters in a fictional setting.
    /// </summary>
    [DataContract]
    public partial class Game : CreativeWork
    {
        public interface ICharacterAttribute : IValue {}
        public interface ICharacterAttribute<T> : ICharacterAttribute { new T Value { get; } }
        public class OneOrManyCharacterAttribute : OneOrMany<ICharacterAttribute>
        {
            public OneOrManyCharacterAttribute(ICharacterAttribute item) : base(item) { }
            public OneOrManyCharacterAttribute(IEnumerable<ICharacterAttribute> items) : base(items) { }
            public static implicit operator OneOrManyCharacterAttribute (Thing value) { return new OneOrManyCharacterAttribute (new CharacterAttributeThing (value)); }
            public static implicit operator OneOrManyCharacterAttribute (Thing[] values) { return new OneOrManyCharacterAttribute (values.Select(v => (ICharacterAttribute) new CharacterAttributeThing (v))); }
            public static implicit operator OneOrManyCharacterAttribute (List<Thing> values) { return new OneOrManyCharacterAttribute (values.Select(v => (ICharacterAttribute) new CharacterAttributeThing (v))); }
        }
        public struct CharacterAttributeThing : ICharacterAttribute<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public CharacterAttributeThing (Thing value) { Value = value; }
            public static implicit operator CharacterAttributeThing (Thing value) { return new CharacterAttributeThing (value); }
        }

        public interface IGameItem : IValue {}
        public interface IGameItem<T> : IGameItem { new T Value { get; } }
        public class OneOrManyGameItem : OneOrMany<IGameItem>
        {
            public OneOrManyGameItem(IGameItem item) : base(item) { }
            public OneOrManyGameItem(IEnumerable<IGameItem> items) : base(items) { }
            public static implicit operator OneOrManyGameItem (Thing value) { return new OneOrManyGameItem (new GameItemThing (value)); }
            public static implicit operator OneOrManyGameItem (Thing[] values) { return new OneOrManyGameItem (values.Select(v => (IGameItem) new GameItemThing (v))); }
            public static implicit operator OneOrManyGameItem (List<Thing> values) { return new OneOrManyGameItem (values.Select(v => (IGameItem) new GameItemThing (v))); }
        }
        public struct GameItemThing : IGameItem<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public GameItemThing (Thing value) { Value = value; }
            public static implicit operator GameItemThing (Thing value) { return new GameItemThing (value); }
        }

        public interface IGameLocation : IValue {}
        public interface IGameLocation<T> : IGameLocation { new T Value { get; } }
        public class OneOrManyGameLocation : OneOrMany<IGameLocation>
        {
            public OneOrManyGameLocation(IGameLocation item) : base(item) { }
            public OneOrManyGameLocation(IEnumerable<IGameLocation> items) : base(items) { }
            public static implicit operator OneOrManyGameLocation (Place value) { return new OneOrManyGameLocation (new GameLocationPlace (value)); }
            public static implicit operator OneOrManyGameLocation (Place[] values) { return new OneOrManyGameLocation (values.Select(v => (IGameLocation) new GameLocationPlace (v))); }
            public static implicit operator OneOrManyGameLocation (List<Place> values) { return new OneOrManyGameLocation (values.Select(v => (IGameLocation) new GameLocationPlace (v))); }
            public static implicit operator OneOrManyGameLocation (PostalAddress value) { return new OneOrManyGameLocation (new GameLocationPostalAddress (value)); }
            public static implicit operator OneOrManyGameLocation (PostalAddress[] values) { return new OneOrManyGameLocation (values.Select(v => (IGameLocation) new GameLocationPostalAddress (v))); }
            public static implicit operator OneOrManyGameLocation (List<PostalAddress> values) { return new OneOrManyGameLocation (values.Select(v => (IGameLocation) new GameLocationPostalAddress (v))); }
            public static implicit operator OneOrManyGameLocation (Uri value) { return new OneOrManyGameLocation (new GameLocationUri (value)); }
            public static implicit operator OneOrManyGameLocation (Uri[] values) { return new OneOrManyGameLocation (values.Select(v => (IGameLocation) new GameLocationUri (v))); }
            public static implicit operator OneOrManyGameLocation (List<Uri> values) { return new OneOrManyGameLocation (values.Select(v => (IGameLocation) new GameLocationUri (v))); }
        }
        public struct GameLocationPlace : IGameLocation<Place>
        {
            object IValue.Value => this.Value;
            public Place Value { get; }
            public GameLocationPlace (Place value) { Value = value; }
            public static implicit operator GameLocationPlace (Place value) { return new GameLocationPlace (value); }
        }
        public struct GameLocationPostalAddress : IGameLocation<PostalAddress>
        {
            object IValue.Value => this.Value;
            public PostalAddress Value { get; }
            public GameLocationPostalAddress (PostalAddress value) { Value = value; }
            public static implicit operator GameLocationPostalAddress (PostalAddress value) { return new GameLocationPostalAddress (value); }
        }
        public struct GameLocationUri : IGameLocation<Uri>
        {
            object IValue.Value => this.Value;
            public Uri Value { get; }
            public GameLocationUri (Uri value) { Value = value; }
            public static implicit operator GameLocationUri (Uri value) { return new GameLocationUri (value); }
        }

        public interface INumberOfPlayers : IValue {}
        public interface INumberOfPlayers<T> : INumberOfPlayers { new T Value { get; } }
        public class OneOrManyNumberOfPlayers : OneOrMany<INumberOfPlayers>
        {
            public OneOrManyNumberOfPlayers(INumberOfPlayers item) : base(item) { }
            public OneOrManyNumberOfPlayers(IEnumerable<INumberOfPlayers> items) : base(items) { }
            public static implicit operator OneOrManyNumberOfPlayers (QuantitativeValue value) { return new OneOrManyNumberOfPlayers (new NumberOfPlayersQuantitativeValue (value)); }
            public static implicit operator OneOrManyNumberOfPlayers (QuantitativeValue[] values) { return new OneOrManyNumberOfPlayers (values.Select(v => (INumberOfPlayers) new NumberOfPlayersQuantitativeValue (v))); }
            public static implicit operator OneOrManyNumberOfPlayers (List<QuantitativeValue> values) { return new OneOrManyNumberOfPlayers (values.Select(v => (INumberOfPlayers) new NumberOfPlayersQuantitativeValue (v))); }
        }
        public struct NumberOfPlayersQuantitativeValue : INumberOfPlayers<QuantitativeValue>
        {
            object IValue.Value => this.Value;
            public QuantitativeValue Value { get; }
            public NumberOfPlayersQuantitativeValue (QuantitativeValue value) { Value = value; }
            public static implicit operator NumberOfPlayersQuantitativeValue (QuantitativeValue value) { return new NumberOfPlayersQuantitativeValue (value); }
        }

        public interface IQuest : IValue {}
        public interface IQuest<T> : IQuest { new T Value { get; } }
        public class OneOrManyQuest : OneOrMany<IQuest>
        {
            public OneOrManyQuest(IQuest item) : base(item) { }
            public OneOrManyQuest(IEnumerable<IQuest> items) : base(items) { }
            public static implicit operator OneOrManyQuest (Thing value) { return new OneOrManyQuest (new QuestThing (value)); }
            public static implicit operator OneOrManyQuest (Thing[] values) { return new OneOrManyQuest (values.Select(v => (IQuest) new QuestThing (v))); }
            public static implicit operator OneOrManyQuest (List<Thing> values) { return new OneOrManyQuest (values.Select(v => (IQuest) new QuestThing (v))); }
        }
        public struct QuestThing : IQuest<Thing>
        {
            object IValue.Value => this.Value;
            public Thing Value { get; }
            public QuestThing (Thing value) { Value = value; }
            public static implicit operator QuestThing (Thing value) { return new QuestThing (value); }
        }

        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "Game";

        /// <summary>
        /// A piece of data that represents a particular aspect of a fictional character (skill, power, character points, advantage, disadvantage).
        /// </summary>
        [DataMember(Name = "characterAttribute", Order = 206)]
        public OneOrManyCharacterAttribute CharacterAttribute { get; set; }

        /// <summary>
        /// An item is an object within the game world that can be collected by a player or, occasionally, a non-player character.
        /// </summary>
        [DataMember(Name = "gameItem", Order = 207)]
        public OneOrManyGameItem GameItem { get; set; }

        /// <summary>
        /// Real or fictional location of the game (or part of game).
        /// </summary>
        [DataMember(Name = "gameLocation", Order = 208)]
        public OneOrManyGameLocation GameLocation { get; set; }

        /// <summary>
        /// Indicate how many people can play this game (minimum, maximum, or range).
        /// </summary>
        [DataMember(Name = "numberOfPlayers", Order = 209)]
        public OneOrManyNumberOfPlayers NumberOfPlayers { get; set; }

        /// <summary>
        /// The task that a player-controlled character, or group of characters may complete in order to gain a reward.
        /// </summary>
        [DataMember(Name = "quest", Order = 210)]
        public OneOrManyQuest Quest { get; set; }
    }
}

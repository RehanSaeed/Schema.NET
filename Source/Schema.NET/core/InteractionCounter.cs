namespace Schema.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    /// <summary>
    /// A summary of how users have interacted with this CreativeWork. In most cases, authors will use a subtype to specify the specific type of interaction.
    /// </summary>
    [DataContract]
    public partial class InteractionCounter : StructuredValue
    {
        public interface IInteractionService : IValue {}
        public interface IInteractionService<T> : IInteractionService { new T Value { get; } }
        public class OneOrManyInteractionService : OneOrMany<IInteractionService>
        {
            public OneOrManyInteractionService(IInteractionService item) : base(item) { }
            public OneOrManyInteractionService(IEnumerable<IInteractionService> items) : base(items) { }
            public static implicit operator OneOrManyInteractionService (SoftwareApplication value) { return new OneOrManyInteractionService (new InteractionServiceSoftwareApplication (value)); }
            public static implicit operator OneOrManyInteractionService (SoftwareApplication[] values) { return new OneOrManyInteractionService (values.Select(v => (IInteractionService) new InteractionServiceSoftwareApplication (v))); }
            public static implicit operator OneOrManyInteractionService (List<SoftwareApplication> values) { return new OneOrManyInteractionService (values.Select(v => (IInteractionService) new InteractionServiceSoftwareApplication (v))); }
            public static implicit operator OneOrManyInteractionService (WebSite value) { return new OneOrManyInteractionService (new InteractionServiceWebSite (value)); }
            public static implicit operator OneOrManyInteractionService (WebSite[] values) { return new OneOrManyInteractionService (values.Select(v => (IInteractionService) new InteractionServiceWebSite (v))); }
            public static implicit operator OneOrManyInteractionService (List<WebSite> values) { return new OneOrManyInteractionService (values.Select(v => (IInteractionService) new InteractionServiceWebSite (v))); }
        }
        public struct InteractionServiceSoftwareApplication : IInteractionService<SoftwareApplication>
        {
            object IValue.Value => this.Value;
            public SoftwareApplication Value { get; }
            public InteractionServiceSoftwareApplication (SoftwareApplication value) { Value = value; }
            public static implicit operator InteractionServiceSoftwareApplication (SoftwareApplication value) { return new InteractionServiceSoftwareApplication (value); }
        }
        public struct InteractionServiceWebSite : IInteractionService<WebSite>
        {
            object IValue.Value => this.Value;
            public WebSite Value { get; }
            public InteractionServiceWebSite (WebSite value) { Value = value; }
            public static implicit operator InteractionServiceWebSite (WebSite value) { return new InteractionServiceWebSite (value); }
        }

        public interface IInteractionType : IValue {}
        public interface IInteractionType<T> : IInteractionType { new T Value { get; } }
        public class OneOrManyInteractionType : OneOrMany<IInteractionType>
        {
            public OneOrManyInteractionType(IInteractionType item) : base(item) { }
            public OneOrManyInteractionType(IEnumerable<IInteractionType> items) : base(items) { }
            public static implicit operator OneOrManyInteractionType (Action value) { return new OneOrManyInteractionType (new InteractionTypeAction (value)); }
            public static implicit operator OneOrManyInteractionType (Action[] values) { return new OneOrManyInteractionType (values.Select(v => (IInteractionType) new InteractionTypeAction (v))); }
            public static implicit operator OneOrManyInteractionType (List<Action> values) { return new OneOrManyInteractionType (values.Select(v => (IInteractionType) new InteractionTypeAction (v))); }
        }
        public struct InteractionTypeAction : IInteractionType<Action>
        {
            object IValue.Value => this.Value;
            public Action Value { get; }
            public InteractionTypeAction (Action value) { Value = value; }
            public static implicit operator InteractionTypeAction (Action value) { return new InteractionTypeAction (value); }
        }

        public interface IUserInteractionCount : IValue {}
        public interface IUserInteractionCount<T> : IUserInteractionCount { new T Value { get; } }
        public class OneOrManyUserInteractionCount : OneOrMany<IUserInteractionCount>
        {
            public OneOrManyUserInteractionCount(IUserInteractionCount item) : base(item) { }
            public OneOrManyUserInteractionCount(IEnumerable<IUserInteractionCount> items) : base(items) { }
            public static implicit operator OneOrManyUserInteractionCount (int value) { return new OneOrManyUserInteractionCount (new UserInteractionCountint (value)); }
            public static implicit operator OneOrManyUserInteractionCount (int[] values) { return new OneOrManyUserInteractionCount (values.Select(v => (IUserInteractionCount) new UserInteractionCountint (v))); }
            public static implicit operator OneOrManyUserInteractionCount (List<int> values) { return new OneOrManyUserInteractionCount (values.Select(v => (IUserInteractionCount) new UserInteractionCountint (v))); }
        }
        public struct UserInteractionCountint : IUserInteractionCount<int>
        {
            object IValue.Value => this.Value;
            public int Value { get; }
            public UserInteractionCountint (int value) { Value = value; }
            public static implicit operator UserInteractionCountint (int value) { return new UserInteractionCountint (value); }
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
        public OneOrManyInteractionService InteractionService { get; set; }

        /// <summary>
        /// The Action representing the type of interaction. For up votes, +1s, etc. use &lt;a class="localLink" href="http://schema.org/LikeAction"&gt;LikeAction&lt;/a&gt;. For down votes use &lt;a class="localLink" href="http://schema.org/DislikeAction"&gt;DislikeAction&lt;/a&gt;. Otherwise, use the most specific Action.
        /// </summary>
        [DataMember(Name = "interactionType", Order = 307)]
        public OneOrManyInteractionType InteractionType { get; set; }

        /// <summary>
        /// The number of interactions for the CreativeWork using the WebSite or SoftwareApplication.
        /// </summary>
        [DataMember(Name = "userInteractionCount", Order = 308)]
        public OneOrManyUserInteractionCount UserInteractionCount { get; set; }
    }
}
